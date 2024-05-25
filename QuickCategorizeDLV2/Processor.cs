using System;
using System.Collections.Generic;
using System.IO;
using BOG.SwissArmyKnife;
using BOG.SwissArmyKnife.Extensions;

namespace QuickCategorizeDLV2
{
    public class Processor
    {
        private enum CsvFileType : int
        {
            ExportedFormat = 1,
            ImportFormat = 2
        }
        protected List<CCBTransaction> _TransactionSet = new List<CCBTransaction>();
        protected string _AccountID = string.Empty;
        protected int IDcounter = 0;

        public List<CCBTransaction> TransactionSet { get { return _TransactionSet; } }
        public string AccountID { get { return _AccountID; } set { _AccountID = value; } }

        public Processor()
        {
        }

        public double FinancialDoubleParse(string source)
        {
            bool Negative = false;
            string sourceWork = source;

            sourceWork = sourceWork.Replace("$", string.Empty).Replace(",", string.Empty);
            if (sourceWork.Length > 2 && sourceWork[0] == '(' && sourceWork[sourceWork.Length - 1] == ')')
            {
                sourceWork = sourceWork.Substring(1, sourceWork.Length - 2);
                Negative = true;
            }
            return (Negative ? (double)-1.0 : (double)1.0) * double.Parse(sourceWork);
        }

        protected string[] ParseLine(string rawLine)
        {
            List<string> Parsed = new List<string>();
            bool InQuote = false;
            int StartIndex = 0;
            int Index = 0;
            for (Index = 0; Index < rawLine.Length; Index++)
            {
                if (rawLine[Index] == '\"')
                {
                    InQuote = !InQuote;
                    continue;
                }
                if (rawLine[Index] == ',' && !InQuote)
                {
                    string corePart = rawLine.Substring(StartIndex, Index - StartIndex);
                    string quoteTrimPart = StringEx.QuotedTrim(corePart, new char[] { ' ', '\t' }, '\"');
                    Parsed.Add(quoteTrimPart.Trim());
                    //Parsed.Add(
                    //    StringEx.QuotedTrim(
                    //        rawLine.Substring(StartIndex, Index - StartIndex), new char[] { ' ', '\t' }, '\"').Trim());
                    StartIndex = Index + 1;
                }
            }
            if (StartIndex < rawLine.Length)
            {
                Parsed.Add(
                    StringEx.QuotedTrim(
                        rawLine.Substring(StartIndex, Index - StartIndex), new char[] { ' ', '\t' }, '\"').Trim());
            }
            else
            {
                Parsed.Add(string.Empty);
            }
            return Parsed.ToArray();
        }

        protected double DoubleOrNothing(string source)
        {
            double Result = 0.0;

            try { Result = double.Parse(source); }
            catch
            {
                // Attempt to read a negative number, if surrounded by parenthesis.
                if (source.Length >= 2 && source[0] == '(' && source[source.Length - 1] == ')')
                {
                    try { Result = -double.Parse(source.Substring(1, source.Length - 2)); }
                    catch { }
                }
            }
            return Result;
        }

        public List<CCBTransaction> ParseCSV(string fileLocation, bool useImportFormat)
        {
            List<CCBTransaction> TransactionSet = new List<CCBTransaction>();
            Dictionary<string, int> ColumnMapping = new Dictionary<string, int>();
            if (!File.Exists(fileLocation)) throw new IOException(string.Format("CSV file does not exist: {0}", fileLocation));
            TransactionSet.Clear();
            string FullFile = File.ReadAllText(fileLocation);
            bool HaveHeaders = false;
            string AccountID = string.Empty;
            int LineIndex = 0;
            bool UseLFonly = FullFile.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Length
                < FullFile.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Length;

            IDcounter = 0;

            foreach (string RawLine in FullFile.Split(
                UseLFonly ? new string[] { "\n" } : new string[] { "\r\n" },
                StringSplitOptions.RemoveEmptyEntries))
            {
                LineIndex++;
                if (RawLine.Length == 0) continue;
                if (!HaveHeaders)
                {
                    string[] ColumnNames = ParseLine(RawLine);
                    int Offset = 0;
                    foreach (string ColumnName in ColumnNames)
                    {
                        ColumnMapping.Add(ColumnName.Trim(), Offset++);
                    }
                    HaveHeaders = true;
                }
                else
                {
                    try
                    {
                        string[] ColumnValues = ParseLine(RawLine);
                        if (useImportFormat)
                        {
                            TransactionSet.Add(
                                new CCBTransaction(
                                    IDcounter++,
                                    DateTime.Parse(ColumnValues[ColumnMapping["Date"]]),
                                    DoubleOrNothing(ColumnValues[ColumnMapping["Amount"]]),
                                    ColumnValues[ColumnMapping["Description"]],
                                    ColumnValues[ColumnMapping["Category"]],
                                    ColumnValues[ColumnMapping["Account"]],
                                    ColumnValues[ColumnMapping["Jived"]] == "yes" ? true : false,
                                    ColumnValues[ColumnMapping["Check"]],
                                    ColumnValues[ColumnMapping["Payee"]],
                                    ColumnValues[ColumnMapping["Memo"]],
                                    string.Empty
                                ));
                        }
                        else
                        {
                            TransactionSet.Add(
                                new CCBTransaction(
                                    IDcounter++,
                                    DateTime.Parse(ColumnValues[ColumnMapping["Date(MM/DD/YYYY)"]]),
                                    DoubleOrNothing(ColumnValues[ColumnMapping["Amount"]]),
                                    ColumnValues[ColumnMapping["Description"]],
                                    ColumnValues[ColumnMapping["Category"]],
                                    ColumnValues[ColumnMapping["Account"]],
                                    ColumnValues[ColumnMapping["Cleared"]] == "yes" ? true : false,
                                    ColumnValues[ColumnMapping["Check Number"]],
                                    ColumnValues[ColumnMapping["Payee"]],
                                    ColumnValues[ColumnMapping["Memo"]],
                                    ColumnValues[ColumnMapping["User"]]
                                ));
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine("Error parsing line #{0}:\r\n{1}\r\n\r\n{2}", LineIndex, RawLine,
                            DetailedException.WithEnterpriseContent(ref e1));
                        throw;
                    }
                }
            }
            return TransactionSet;
        }

        public void SaveCSV(List<CCBTransaction> transactions, string fileLocation, bool useImportFormat)
        {
            using (StreamWriter sw = new StreamWriter(fileLocation))
            {
                if (useImportFormat)
                {
                    sw.Write("Date,Amount,Description,Category,Account,Jived,Check,Payee,Memo\r\n");
                }
                else
                {
                    sw.Write("Date(MM/DD/YYYY),Amount,Description,Category,Account,Cleared,Check Number,Payee,Memo,User,\n");
                }

                foreach (var t in transactions)
                {
                    if (useImportFormat)
                    {
                        sw.Write(string.Format("{0:MM/dd/yyyy},", t.Date));
                        sw.Write(string.Format(t.Amount == 0.0 ? "-{0:f}," : "{0:f},", t.Amount));
                        sw.Write(string.Format("\"{0}\",", t.Description));
                        sw.Write(string.Format("\"{0}\",", t.Category));
                        sw.Write(string.Format("{0},", t.Account));
                        sw.Write(string.Format("{0},", t.Cleared ? "yes" : "0"));
                        sw.Write(string.Format("{0},", t.CheckNumber));
                        sw.Write(string.Format("\"{0}\",", t.Payee));
                        sw.Write(string.Format("{0},", t.Memo));
                        sw.Write("\r\n");
                    }
                    else
                    {
                        sw.Write(string.Format("{0:MM/dd/yyyy},", t.Date));
                        sw.Write(string.Format(t.Amount == 0.0 ? "-{0:f}," : "{0:f},", t.Amount));
                        sw.Write(string.Format("\"{0}\",", t.Description));
                        sw.Write(string.Format("\"{0}\",", t.Category));
                        sw.Write(string.Format("\"{0}\",", t.Account));
                        sw.Write(string.Format("{0},", t.Cleared ? "yes" : "0"));
                        sw.Write(string.Format("\"{0}\",", t.CheckNumber));
                        sw.Write(string.Format("\"{0}\",", t.Payee));
                        sw.Write(string.Format("\"{0}\",", t.Memo));
                        sw.Write(string.Format("\"{0}\",", t.User));
                        sw.Write("\n");
                    }
                }
                sw.Close();
            }
        }
    }
}

