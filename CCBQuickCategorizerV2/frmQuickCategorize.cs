using BOG.SwissArmyKnife;
using QuickCategorizeDLV2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Forms;

namespace CCBQuickCategorizerV2
{
    public partial class frmQuickCategorize : Form
    {
        private enum FieldIndex : int
        {
            ID = 0,
            Date = 1,
            Payee = 2,
            Memo = 3,
            Category = 4,
            Description = 5,
            Amount = 6,
            Account = 7,
            Cleared = 8,
            CheckNumber = 9,
            User = 10,
            Exclude = 11,
        }

        Dictionary<int, CCBTransaction> transactions = new Dictionary<int, CCBTransaction>();
        Dictionary<string, int> categories = new Dictionary<string, int>();
        string LastSettingsConfigurationFile = Path.Combine(
            new string[] {
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Bits of Genius",
                "CCB Quick Categorizer",
                "CCBQuickCategorizer.xml" });
        SettingsDictionary sd = new SettingsDictionary();
        bool UnsavedChangesExist = false;
        string CellOriginalValue = string.Empty;
        Color CellDefaultBackColor = Color.White;
        Color OriginalBackgroundColor = Color.White;

        bool CtrlIsDown = false;

        float dataGridView1OrgFontSize = 0.0f;
        float lstboxCategoryOrgFontSize = 0.0f;

        public frmQuickCategorize()
        {
            InitializeComponent();

            var info = new BOG.SwissArmyKnife.AssemblyVersion();
            this.Text = this.Text + $" ({info.Version}, {info.BuildDate})";

            dataGridView1OrgFontSize = this.dataGridView1.Font.Size;
            lstboxCategoryOrgFontSize = this.lstboxCategory.Font.Size;

            this.dataGridView1.ReadOnly = false;

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "ID";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(int);
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Visible = true;

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Date";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].DefaultCellStyle.Format = "d";

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Payee";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Memo";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Category";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);
            CellDefaultBackColor = this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].DefaultCellStyle.BackColor;

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Description";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Amount";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(decimal);
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].DefaultCellStyle.Format = "c";

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Account";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);

            this.dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Changed";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(bool);

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Check Number";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "User";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(string);

            this.dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Exclude";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = false;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ValueType = typeof(bool);

            this.btnSave.Enabled = false;
            sd.ConfigurationFile = this.LastSettingsConfigurationFile;
            if (File.Exists(LastSettingsConfigurationFile))
            {
                sd.LoadSettings();
                if (sd.HasSetting("AllTimeExportFilename"))
                {
                    this.txtAllTimeExportFilename.Text = (string)sd.GetSetting("AllTimeExportFilename", this.txtAllTimeExportFilename.Text);
                }
                if (sd.HasSetting("ImportFilename"))
                {
                    this.txtImportFilename.Text = (string)sd.GetSetting("ImportFilename", this.txtImportFilename.Text);
                }
                if (sd.HasSetting("EditAnImportFile"))
                {
                    this.chkEditingAnImportFile.Checked = bool.Parse((string)sd.GetSetting("EditAnImportFile", false));
                }
            }
            this.txtImportFilename.Enabled = this.chkEditingAnImportFile.Checked;
            OriginalBackgroundColor = this.txtAllTimeExportFilename.BackColor;
            AdjustFilenameColors();
        }

        private void AdjustFilenameColors()
        {
            this.txtAllTimeExportFilename.BackColor =
                !this.chkEditingAnImportFile.Checked ? Color.LightSalmon : OriginalBackgroundColor;
            this.txtImportFilename.BackColor =
                this.chkEditingAnImportFile.Checked ? Color.LightSalmon : OriginalBackgroundColor;
        }

        private void ObjectEnabling(bool allowUse)
        {
            this.dataGridView1.Enabled = allowUse;
            this.chkEditingAnImportFile.Enabled = allowUse;
            this.txtAllTimeExportFilename.Enabled = allowUse;
            this.btnSave.Enabled = UnsavedChangesExist;
            this.btnLoad.Text = UnsavedChangesExist ? "&Undo Changes" : "&Load";
        }

        private void LoadTransactions()
        {
            foreach (int i in transactions.Keys)
            {
                CCBTransaction t = transactions[i];
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(this.dataGridView1);
                r.Cells[(int)FieldIndex.ID].Value = t.ID;
                r.Cells[(int)FieldIndex.Date].Value = t.Date;
                r.Cells[(int)FieldIndex.Payee].Value = t.Payee;
                r.Cells[(int)FieldIndex.Memo].Value = t.Memo;
                r.Cells[(int)FieldIndex.Category].Value = t.Category;
                r.Cells[(int)FieldIndex.Description].Value = t.Description;
                r.Cells[(int)FieldIndex.Amount].Value = t.Amount;
                r.Cells[(int)FieldIndex.Account].Value = t.Account;
                r.Cells[(int)FieldIndex.Cleared].Value = t.Cleared;
                r.Cells[(int)FieldIndex.CheckNumber].Value = t.CheckNumber;
                r.Cells[(int)FieldIndex.User].Value = t.User;
                r.Cells[(int)FieldIndex.Exclude].Value = false;

                r.Visible = true;
                this.dataGridView1.Rows.Add(r);
                this.btnSelectedUncategorizedTransactions.Enabled = this.dataGridView1.Rows.Count > 0;
            }
        }

        private void ShowTransactions(bool forceReload)
        {
            if (forceReload) this.dataGridView1.Rows.Clear();
            if (this.dataGridView1.Rows.Count == 0 && transactions.Keys.Count > 0)
                LoadTransactions();

            int ItemCount = 0;
            for (var index = 0; index < this.dataGridView1.Rows.Count; index++)
            {
                var thisRow = this.dataGridView1.Rows[index];
                var category = (string)thisRow.Cells[(int)FieldIndex.Category].Value;
                var description = (string)thisRow.Cells[(int)FieldIndex.Description].Value;
                var memo = (string)thisRow.Cells[(int)FieldIndex.Memo].Value;
                var payee = (string)thisRow.Cells[(int)FieldIndex.Payee].Value;

                var ShowThis = true;
                do // trap door sequence
                {
                    if (this.chkboxHideCategorized.Checked && !string.IsNullOrEmpty(category))
                    {
                        ShowThis = false;
                        break;
                    }

                    if (this.chkboxHideUncategorized.Checked && string.IsNullOrEmpty(category))
                    {
                        ShowThis = false;
                        break;
                    }

                    if (!string.IsNullOrEmpty(this.txtTransactionFilter.Text.Trim()))
                    {
                        if (  // no filter text found...
                            (description.IndexOf(this.txtTransactionFilter.Text, StringComparison.InvariantCultureIgnoreCase) < 0) &&
                            (memo.IndexOf(this.txtTransactionFilter.Text, StringComparison.InvariantCultureIgnoreCase) < 0) &&
                            (category.IndexOf(this.txtTransactionFilter.Text, StringComparison.InvariantCultureIgnoreCase) < 0) &&
                            (payee.IndexOf(this.txtTransactionFilter.Text, StringComparison.InvariantCultureIgnoreCase) < 0)
                        )
                        {
                            ShowThis = false;
                            break;
                        }
                    }
                } while (false);

                thisRow.Visible = ShowThis;
                if (ShowThis)
                {
                    ItemCount++;
                }
            }
            this.btnSelectedUncategorizedTransactions.Enabled = this.dataGridView1.Rows.Count > 0;
            this.toolStripStatusLabel1.Text = string.Format("({0} transactions: {1})",
                ItemCount,
                this.txtTransactionFilter.Text.Trim().Length > 0 ||
                this.chkboxHideCategorized.Checked ||
                this.chkboxHideUncategorized.Checked ? "filtered" : "unfiltered");
        }

        private void ShowCategories()
        {
            var matchingItems = new Dictionary<int, string>();
            var filterIsUsed = !string.IsNullOrWhiteSpace(this.txtCategoryFilter.Text);
            foreach (string category in categories.Keys)
            {
                if (filterIsUsed)
                {
                    if (category.IndexOf(this.txtCategoryFilter.Text, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }
                }
                matchingItems.Add(matchingItems.Count, category);
            }
            this.lstboxCategory.Enabled = matchingItems.Count > 0;
            if (this.lstboxCategory.Enabled)
            {
                this.lstboxCategory.Items.Clear();
                for (var index = 0; index < matchingItems.Count; index++)
                {
                    this.lstboxCategory.Items.Add(matchingItems[index]);
                }
            }
        }

        private DialogResult UserChangeAction()
        {
            return
                    MessageBox.Show(
                        "Would you like to save the changes before continuing?\r\n\r\n" +
                        "There are unsaved changes here",
                        "WHOA... not so fast!", MessageBoxButtons.YesNoCancel);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (UnsavedChangesExist)
            {
                // action is Undo Changes
                var userResponse = MessageBox.Show(
                        "This will revert everything to the current file content, losing all changes\r\n\r\n" +
                        "Continue?",
                        "WHOA... not so fast!", MessageBoxButtons.OKCancel);
                if (userResponse == DialogResult.Cancel) return;
            }
            this.toolStripStatusLabel1.Text = "Loading all-time export file ...";
            this.chkboxHideCategorized.Checked = false;
            this.chkboxHideUncategorized.Checked = false;
            this.statusStrip1.Refresh();
            Processor dl = new Processor();
            List<CCBTransaction> trans = new List<CCBTransaction>();
            try
            {
                trans = dl.ParseCSV(this.txtAllTimeExportFilename.Text, false);
                transactions.Clear();
                foreach (CCBTransaction t in trans)
                {
                    transactions.Add(t.ID, t);
                }
                categories = new Dictionary<string, int>();
                foreach (CCBTransaction transaction in trans)
                {
                    if (string.IsNullOrEmpty(transaction.Category)) continue;
                    if (!categories.ContainsKey(transaction.Category))
                    {
                        categories.Add(transaction.Category, 0);
                    }
                    categories[transaction.Category]++;
                }
                ShowCategories();
            }
            catch (Exception err)
            {
                MessageBox.Show(BOG.SwissArmyKnife.DetailedException.WithUserContent(ref err, "Failure attempting to load all-time transaction file.", string.Empty));
                ObjectEnabling(true);
                return;
            }
            if (this.chkEditingAnImportFile.Checked)
            {
                this.toolStripStatusLabel1.Text = "Loading import file...";
                this.statusStrip1.Refresh();
                trans.Clear();
                try
                {
                    trans = dl.ParseCSV(this.txtImportFilename.Text, true);
                    transactions.Clear();
                    foreach (CCBTransaction t in trans)
                    {
                        transactions.Add(t.ID, t);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(BOG.SwissArmyKnife.DetailedException.WithUserContent(ref err, "Failure attempting to load import transaction file.", string.Empty));
                    ObjectEnabling(true);
                    return;
                }
            }
            ShowTransactions(true);
            this.toolStripStatusLabel1.Text = "CSV file loaded";
            this.btnSave.Enabled = false;
            this.txtAllTimeExportFilename.Enabled = false;
            this.txtImportFilename.Enabled = false;
            UnsavedChangesExist = false;
            ObjectEnabling(true);
        }

        private void SaveContent()
        {
            this.toolStripStatusLabel1.Text = "Saving CSV file...";
            this.statusStrip1.Refresh();
            List<CCBTransaction> trans = new List<CCBTransaction>();
            for (var rowIndex = 0; rowIndex < this.dataGridView1.Rows.Count; rowIndex++)
            {
                var thisRow = this.dataGridView1.Rows[rowIndex];
                thisRow.Cells[(int)FieldIndex.Category].Style.BackColor = CellDefaultBackColor;
                if (!(bool)thisRow.Cells[(int)FieldIndex.Exclude].Value)
                {
                    trans.Add(transactions[(int)thisRow.Cells[(int)FieldIndex.ID].Value]);
                }
            }
            Processor dl = new Processor();
            dl.SaveCSV(trans, this.txtImportFilename.Text, this.chkEditingAnImportFile.Checked);
            this.toolStripStatusLabel1.Text = "CSV file saved";
            this.btnSave.Enabled = false;
            UnsavedChangesExist = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveContent();
        }

        private void chkboxHideCategorized_CheckedChanged(object sender, EventArgs e)
        {
            ShowTransactions(false);
        }

        private void chkboxHideUncategorized_CheckedChanged(object sender, EventArgs e)
        {
            ShowTransactions(false);
        }

        private void btnApplyTransactionFilter_Click(object sender, EventArgs e)
        {
            ShowTransactions(false);
            this.btnApplyTransactionFilter.Enabled = false;
        }

        private void btnClearTransactionFilter_Click(object sender, EventArgs e)
        {
            this.txtTransactionFilter.Text = string.Empty;
            ShowTransactions(false);
            this.btnApplyTransactionFilter.Enabled = false;
        }

        private void btnClearCategoryFilter_Click(object sender, EventArgs e)
        {
            this.txtCategoryFilter.Text = string.Empty;
            ShowCategories();
        }

        private void AdjustChangeButton()
        {
            this.btnApplySelectedCategoryToSelectedTransactions.Enabled =
                (this.dataGridView1.Rows.Count > 0 && this.dataGridView1.SelectedRows.Count > 0 && this.lstboxCategory.SelectedItems.Count > 0);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            AdjustChangeButton();
        }

        private void lstboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustChangeButton();
        }

        private void btnSelectedUncategorizedTransactions_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                int index = (int)this.dataGridView1.Rows[i].Cells[(int)FieldIndex.ID].Value;
                this.dataGridView1.Rows[i].Selected = transactions[index].Category.Trim().Length == 0;
            }
        }

        private void btnApplySelectedCategoryToSelectedTransactions_Click(object sender, EventArgs e)
        {
            ApplyCategoryToSelectedTransactions();
        }

        private void txtTransactionFilter_TextChanged(object sender, EventArgs e)
        {
            this.btnApplyTransactionFilter.Enabled = this.txtTransactionFilter.Text.Length > 0;
            this.btnClearTransactionFilter.Enabled = this.txtTransactionFilter.Text.Length > 0;
        }

        private void txtCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            this.btnClearCategoryFilter.Enabled = this.txtCategoryFilter.Text.Length > 0;
            ShowCategories();
            if (this.lstboxCategory.Items.Count == 1)
            {
                this.lstboxCategory.SetSelected(0, true);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtCategoryFilter.Text) && !categories.ContainsKey(this.txtCategoryFilter.Text))
            {
                categories.Add(this.txtCategoryFilter.Text, 0);
                this.lstboxCategory.Items.Add(this.txtCategoryFilter.Text);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int)FieldIndex.Category && this.lstboxCategory.SelectedIndex >= 0)
            {
                int ID = (int)this.dataGridView1.Rows[e.RowIndex].Cells[(int)FieldIndex.ID].Value;
                string category = this.lstboxCategory.Items[this.lstboxCategory.SelectedIndex].ToString();
                this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = category;
                transactions[ID].Category = category;
                UnsavedChangesExist = true;
                this.btnSave.Enabled = true;
                this.dataGridView1.Refresh();
                return;
            }
            // launch a Google search on either the Description or Payee column, whichever is clicked.
            if ((e.ColumnIndex == (int)FieldIndex.Description || e.ColumnIndex == (int)FieldIndex.Payee) && e.RowIndex >= 0)
            {
                string URLtemplate = "https://www.google.com/search?q={0}";
                string URL = string.Format(
                    URLtemplate,
                    HttpUtility.UrlEncode(
                        "credit card charge \"" +
                        (string)this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value +
                        "\""
                    )
                );

                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = URL;
                System.Diagnostics.Process.Start(psi);
                return;
            }
        }

        private void frmQuickCategorize_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedChangesExist)
            {
                switch (UserChangeAction())
                {
                    case DialogResult.Yes:
                        SaveContent();
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
            sd.SetSetting("AllTimeExportFilename", this.txtAllTimeExportFilename.Text);
            sd.SetSetting("ImportFilename", this.txtImportFilename.Text);
            sd.SetSetting("EditAnImportFile", this.chkEditingAnImportFile.Checked ? "true" : "false");
            sd.SaveSettings();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Refreshing the view...";
            this.Enabled = false;
            this.Refresh();
            ShowTransactions(false);
            this.toolStripStatusLabel1.Text = "Refresh complete";
            this.Enabled = true;
        }

        private void txtAllTimeExportFilename_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the file which is the Full (aka All-Time) Export from ClearCheckbook";
            ofd.CheckFileExists = true;
            ofd.DefaultExt = "csv";
            ofd.InitialDirectory = Path.GetDirectoryName(this.txtAllTimeExportFilename.Text);
            ofd.FileName = this.txtAllTimeExportFilename.Text;
            ofd.Multiselect = false;
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.txtAllTimeExportFilename.Text = ofd.FileName;
            }
        }

        private void txtImportFilename_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the file which is the Import for ClearCheckbook";
            ofd.CheckFileExists = true;
            ofd.DefaultExt = "csv";
            ofd.InitialDirectory = Path.GetDirectoryName(this.txtImportFilename.Text);
            ofd.FileName = this.txtImportFilename.Text;
            ofd.Multiselect = false;
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.txtImportFilename.Text = ofd.FileName;
            }
        }

        private void chkEditingAnImportFile_CheckedChanged(object sender, EventArgs e)
        {
            this.txtImportFilename.Enabled = this.chkEditingAnImportFile.Checked;
            AdjustFilenameColors();
        }

        private void btnCatSummary_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> summary = new Dictionary<string, double>();
            this.toolStripStatusLabel1.Text = "Displaying Category Summary...";
            this.statusStrip1.Refresh();
            for (var rowIndex = 0; rowIndex < this.dataGridView1.Rows.Count; rowIndex++)
            {
                var thisRow = this.dataGridView1.Rows[rowIndex];
                if (!(bool)thisRow.Cells[(int)FieldIndex.Exclude].Value)
                {
                    var categoryName = (string)thisRow.Cells[(int)FieldIndex.Category].Value;
                    var amount = (double)thisRow.Cells[(int)FieldIndex.Amount].Value;
                    if (!summary.ContainsKey(categoryName))
                    {
                        summary.Add(categoryName, amount);
                    }
                    else
                    {
                        summary[categoryName] += amount;
                    }
                }
            }

            var s = new frmSummary(summary);
            s.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var isInEdit = e.RowIndex >= 0 && e.ColumnIndex >= 0;
            if (e.ColumnIndex == (int)FieldIndex.Exclude)
            {
                this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    (object)!(bool)this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    (bool)this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?
                        Color.LightYellow :
                        Color.White;
                UnsavedChangesExist = true;
                this.btnSave.Enabled = true;
                this.dataGridView1.Refresh();
                return;
            }
        }

        private void ApplyCategoryToSelectedTransactions()
        {
            if (this.lstboxCategory.SelectedItems.Count == 1 && this.dataGridView1.SelectedRows.Count > 0)
            {
                if (this.dataGridView1.SelectedRows.Count > 1)
                {
                    if (DialogResult.No == MessageBox.Show("Apply this category to multiple transactions?", "Multiple Transactions", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        return;
                    }
                }
                string category = this.lstboxCategory.Items[this.lstboxCategory.SelectedIndex].ToString();
#if FALSE
				for (var rowIndex = 0; rowIndex < this.dataGridView1.Rows.Count; rowIndex++)
				{
					if (!this.dataGridView1.Rows[rowIndex].Selected) continue;
					if (string.Compare((string)this.dataGridView1.Rows[rowIndex].Cells[(int)FieldIndex.Category].Value, category, true) == 0) continue;
					int ID = (int)this.dataGridView1.Rows[rowIndex].Cells[(int)FieldIndex.ID].Value;
					this.dataGridView1.Rows[rowIndex].Cells[(int)FieldIndex.Category].Value = category;
					this.dataGridView1.Rows[rowIndex].Cells[(int)FieldIndex.Category].Style.BackColor = Color.Yellow;
					transactions[ID].Category = category;
					UnsavedChangesExist = true;
				}
#else
                for (var rowIndex = 0; rowIndex < this.dataGridView1.SelectedRows.Count; rowIndex++)
                {
                    if (string.Compare((string)this.dataGridView1.SelectedRows[rowIndex].Cells[(int)FieldIndex.Category].Value, category, true) == 0) continue;
                    int ID = (int)this.dataGridView1.SelectedRows[rowIndex].Cells[(int)FieldIndex.ID].Value;
                    this.dataGridView1.SelectedRows[rowIndex].Cells[(int)FieldIndex.Category].Value = category;
                    this.dataGridView1.SelectedRows[rowIndex].Cells[(int)FieldIndex.Category].Style.BackColor = Color.Yellow;
                    transactions[ID].Category = category;
                    UnsavedChangesExist = true;
                }
#endif
                this.btnSave.Enabled |= UnsavedChangesExist;
                this.dataGridView1.Refresh();
            }
        }

        private void lstboxCategory_DoubleClick(object sender, EventArgs e)
        {
            this.txtCategoryFilter.Text = this.lstboxCategory.Text;
            this.txtCategoryFilter.SelectAll();
        }

        private void lstboxCategory_KeyUp(object sender, KeyEventArgs e)
        {
            CtrlIsDown = e.Control;
        }

        private void lstboxCategory_KeyDown(object sender, KeyEventArgs e)
        {
            CtrlIsDown = e.Control;
        }

        private void lstboxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CtrlIsDown)
            {
                var newSize = 0.0f;

                if (e.KeyChar == '+')
                {
                    newSize = lstboxCategory.Font.Size + 2.0f;
                }
                else if (e.KeyChar == '-')
                {
                    newSize = lstboxCategory.Font.Size - 2.0f;
                }
                else if (e.KeyChar == '\\')
                {
                    newSize = lstboxCategoryOrgFontSize;
                }
                if (newSize > 0)
                {
                    lstboxCategory.Font = new(lstboxCategory.Font.FontFamily, newSize);
                }
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                var newSize = 0.0f;

                if (e.KeyCode == Keys.Oemplus)
                {
                    newSize = dataGridView1.Font.Size + 2.0f;
                }
                else if (e.KeyCode == Keys.OemMinus)
                {
                    newSize = dataGridView1.Font.Size - 2.0f;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    newSize = dataGridView1OrgFontSize;
                }
                if (newSize > 0)
                {
                    dataGridView1.Font = new(dataGridView1.Font.FontFamily, newSize);
                }
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
