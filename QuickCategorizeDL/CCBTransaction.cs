using System;

namespace QuickCategorizeDL
{
    //class CCBTransaction
    //{
    //    int ID = 0;
    //    DateTime Date = DateTime.MinValue;
    //    double Amount = 0.0;
    //    string Description = string.Empty;
    //    string Category = string.Empty;
    //    string Account = string.Empty;
    //    bool Jived = false;
    //    string CheckNumber = string.Empty;
    //    string Payee = string.Empty;
    //    string Memo = string.Empty;
    //    string User = string.Empty;
    //}

    public class CCBTransaction
    {
        private int _ID = 0;
        private DateTime _Date = DateTime.MinValue;
        private double _Amount = 0.0;
        private string _Description = string.Empty;
        private string _Category = string.Empty;
        private string _Account = string.Empty;
        private bool _Jived = false;
        private string _CheckNumber = string.Empty;
        private string _Payee = string.Empty;
        private string _Memo = string.Empty;
        private string _User = string.Empty;

        public CCBTransaction()
        {
        }

        public CCBTransaction(int p_ID, DateTime p_Date, double p_Amount, string p_Description, string p_Category, string p_Account, bool p_Jived, string p_CheckNumber, string p_Payee, string p_Memo, string p_User)
        {
            this._ID = p_ID;
            this._Date = p_Date;
            this._Amount = p_Amount;
            this._Description = p_Description;
            this._Category = p_Category;
            this._Account = p_Account;
            this._Jived = p_Jived;
            this._CheckNumber = p_CheckNumber;
            this._Payee = p_Payee;
            this._Memo = p_Memo;
            this._User = p_User;
        }

        public CCBTransaction(CCBTransaction p_obj)
        {
            Load(p_obj);
        }

        public CCBTransaction(object[] p_obj)
        {
            this._ID = (int)p_obj[0];
            this._Date = (DateTime)p_obj[1];
            this._Amount = (double)p_obj[2];
            this._Description = (string)p_obj[3];
            this._Category = (string)p_obj[4];
            this._Account = (string)p_obj[5];
            this._Jived = (bool)p_obj[6];
            this._CheckNumber = (string)p_obj[7];
            this._Payee = (string)p_obj[8];
            this._Memo = (string)p_obj[9];
            this._User = (string)p_obj[10];
        }

        public void Load(CCBTransaction p_obj)
        {
            this._ID = p_obj.ID;
            this._Date = p_obj.Date;
            this._Amount = p_obj.Amount;
            this._Description = p_obj.Description;
            this._Category = p_obj.Category;
            this._Account = p_obj.Account;
            this._Jived = p_obj.Jived;
            this._CheckNumber = p_obj.CheckNumber;
            this._Payee = p_obj.Payee;
            this._Memo = p_obj.Memo;
            this._User = p_obj.User;
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        public string Account
        {
            get { return _Account; }
            set { _Account = value; }
        }

        public bool Jived
        {
            get { return _Jived; }
            set { _Jived = value; }
        }

        public string CheckNumber
        {
            get { return _CheckNumber; }
            set { _CheckNumber = value; }
        }

        public string Payee
        {
            get { return _Payee; }
            set { _Payee = value; }
        }

        public string Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
        }

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
    }
}
