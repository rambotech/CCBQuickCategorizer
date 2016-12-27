using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using BOG.Framework;
using QuickCategorizeDL;

namespace CCBQuickCategorizer
{
    public partial class frmQuickCategorize : Form
    {
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
        Color OriginalBackgroundColor = Color.White;

        public frmQuickCategorize()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = false;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Date(MM/DD/YYYY)";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Payee";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Memo";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Category";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = false;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Description";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Amount";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Account";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Jived";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "Check Number";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].Name = "User";
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].ReadOnly = true;
            this.dataGridView1.Columns[this.dataGridView1.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
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
            //this

        }

        private void ShowTransactions()
        {
            this.dataGridView1.Rows.Clear();
            int ItemCount = 0;
            foreach (int i in transactions.Keys)
            {
                CCBTransaction t = transactions[i];
                if (this.chkboxHideCategorized.Checked && !string.IsNullOrEmpty(t.Category)) continue;
                if (this.chkboxHideUncategorized.Checked && string.IsNullOrEmpty(t.Category)) continue;
                bool ShowThis = true;
                while (!string.IsNullOrEmpty(this.txtTransactionFilter.Text.Trim()))
                {
                    ShowThis = false;
                    if (t.Description.IndexOf(this.txtTransactionFilter.Text, StringComparison.InvariantCultureIgnoreCase) >= 0)
                    {
                        ShowThis = true;
                        break;
                    }
                    if (t.Memo.IndexOf(this.txtTransactionFilter.Text, StringComparison.InvariantCultureIgnoreCase) >= 0)
                    {
                        ShowThis = true;
                        break;
                    }
                    if (t.Payee.IndexOf(this.txtTransactionFilter.Text, StringComparison.InvariantCultureIgnoreCase) >= 0)
                    {
                        ShowThis = true;
                    }
                    break;
                }
                if (ShowThis)
                {
                    ItemCount++;
                    DataGridViewRow r = new DataGridViewRow();
                    r.Tag = t.ID.ToString();
                    r.CreateCells(this.dataGridView1);
                    r.SetValues(new string[] {
                        t.Date.ToString("d"), t.Payee, t.Memo,
                        t.Category, t.Description, t.Amount.ToString("f"),
                        t.Account, t.Jived.ToString(), t.CheckNumber, t.User});
                    this.dataGridView1.Rows.Add(r);
                }
                this.btnSelectedUncategorizedTransactions.Enabled = this.dataGridView1.Rows.Count > 0;
            }
            this.toolStripStatusLabel1.Text = string.Format("({0} transactions {1} filters)",
                ItemCount,
                this.txtTransactionFilter.Text.Trim().Length > 0 ||
                this.chkboxHideCategorized.Checked ||
                this.chkboxHideUncategorized.Checked ? "with" : "without");
        }

        private void ShowCategories()
        {
            this.lstboxCategory.Items.Clear();
            foreach (string category in categories.Keys)
            {
                if (!string.IsNullOrEmpty(this.txtCategoryFilter.Text.Trim()))
                {
                    if (category.IndexOf(this.txtCategoryFilter.Text, StringComparison.InvariantCultureIgnoreCase) < 0)
                    {
                        continue;
                    }
                }
                this.lstboxCategory.Items.Add(category);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show(BOG.Framework.DetailedException.WithUserContent(ref err, "Failure attempting to load all-time transaction file.", string.Empty));
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
                    MessageBox.Show(BOG.Framework.DetailedException.WithUserContent(ref err, "Failure attempting to load import transaction file.", string.Empty));
                    ObjectEnabling(true);
                    return;
                }
            }
            ShowTransactions();
            this.toolStripStatusLabel1.Text = "CSV file loaded";
            this.btnLoad.Enabled = false;
            this.btnSave.Enabled = false;
            this.txtAllTimeExportFilename.Enabled = false;
            this.txtImportFilename.Enabled = false;
            UnsavedChangesExist = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Saving CSV file...";
            this.statusStrip1.Refresh();
            List<CCBTransaction> trans = new List<CCBTransaction>();
            foreach (int i in transactions.Keys)
            {
                CCBTransaction t = transactions[i];
                trans.Add(t);
            }
            Processor dl = new Processor();
            dl.SaveCSV(trans, this.txtImportFilename.Text, this.chkEditingAnImportFile.Checked);
            this.toolStripStatusLabel1.Text = "CSV file saved";
            this.btnLoad.Enabled = true;
            this.btnSave.Enabled = false;
            UnsavedChangesExist = false;
        }

        private void chkboxHideCategorized_CheckedChanged(object sender, EventArgs e)
        {
            ShowTransactions();
        }

        private void chkboxHideUncategorized_CheckedChanged(object sender, EventArgs e)
        {
            ShowTransactions();
        }

        private void btnApplyTransactionFilter_Click(object sender, EventArgs e)
        {
            ShowTransactions();
            this.btnApplyTransactionFilter.Enabled = false;
        }

        private void btnClearTransactionFilter_Click(object sender, EventArgs e)
        {
            this.txtTransactionFilter.Text = string.Empty;
            ShowTransactions();
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
                int index = int.Parse((string)this.dataGridView1.Rows[i].Tag);
                this.dataGridView1.Rows[i].Selected = transactions[index].Category.Trim().Length == 0;
            }
        }

        private void btnApplySelectedCategoryToSelectedTransactions_Click(object sender, EventArgs e)
        {
            UnsavedChangesExist |= this.dataGridView1.SelectedRows.Count > 0;
            for (int i = 0; i < this.dataGridView1.SelectedRows.Count; i++)
            {
                UnsavedChangesExist = true;
                int ID = int.Parse((string)this.dataGridView1.SelectedRows[i].Tag);
                transactions[ID].Category = (string)this.lstboxCategory.SelectedItem;
            }
            ShowTransactions();
            this.btnSave.Enabled |= UnsavedChangesExist;
            this.btnLoad.Enabled = true;
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
            if (!categories.ContainsKey(this.txtCategoryFilter.Text))
            {
                categories.Add(this.txtCategoryFilter.Text, 0);
                this.lstboxCategory.Items.Add(this.txtCategoryFilter.Text);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && this.lstboxCategory.SelectedIndex >= 0 && !this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].IsInEditMode)
            {
                int ID = int.Parse(this.dataGridView1.Rows[e.RowIndex].Tag.ToString());
                string category = this.lstboxCategory.Items[this.lstboxCategory.SelectedIndex].ToString();
                this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = category;
                transactions[ID].Category = category;
                UnsavedChangesExist = true;
                this.btnSave.Enabled = true;
                this.dataGridView1.Refresh();
                return;
            }
			// launch a Google search on either the Description or Payee column, whichever is clicked.
			if (e.ColumnIndex == 1 || e.ColumnIndex == 4)
            {
                string URLtemplate = "https://www.google.com/search?q={0}";
                string URL = string.Format(
                    URLtemplate,
                    HttpUtility.UrlEncode(((string)this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)));
                System.Diagnostics.Process.Start(URL);
                return;
            }
        }

		private void frmQuickCategorize_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedChangesExist)
            {
                if (DialogResult.Cancel ==
                    MessageBox.Show(
                        "There are unsaved changes to the categories. If you exit now, you will lose these changes.\r\n\r\n" +
                        "Are you sure you don't want to save the changes?",
                        "WHOA... not so fast!", MessageBoxButtons.OKCancel))
                {
                    e.Cancel = true;
                }
            }
            sd.SetSetting("AllTimeExportFilename", this.txtAllTimeExportFilename.Text);
            sd.SetSetting("ImportFilename", this.txtImportFilename.Text);
            sd.SetSetting("EditAnImportFile", this.chkEditingAnImportFile.Checked ? "true" : "false");
            sd.SaveSettings();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                CellOriginalValue = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Empty;
                }
                if (string.Compare(CellOriginalValue, this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), false) != 0)
                {
                    int ID = int.Parse(this.dataGridView1.Rows[e.RowIndex].Tag.ToString());
                    string category = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    transactions[ID].Category = category;
                    UnsavedChangesExist = true;
                    this.btnSave.Enabled = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Refreshing the view...";
            this.Enabled = false;
            this.Refresh();
            ShowTransactions();
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
	}
}
