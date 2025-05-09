using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CCBQuickCategorizerV2
{
    public partial class frmSummary : Form
    {
        bool BlockRecalculateTotal = true;

        public frmSummary(Dictionary<string, double> datagridInfo)
        {
            InitializeComponent();

            this.dgvSummary.ReadOnly = true;

            this.dgvSummary.Columns.Add(new DataGridViewTextBoxColumn());
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].Name = "Category";
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].ReadOnly = true;
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].ValueType = typeof(string);

            this.dgvSummary.Columns.Add(new DataGridViewTextBoxColumn());
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].Name = "Amount";
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].ReadOnly = true;
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.Automatic;
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].ValueType = typeof(double);
            this.dgvSummary.Columns[this.dgvSummary.Columns.Count - 1].DefaultCellStyle.Format = "c";

            foreach (var category in datagridInfo.Keys.OrderBy(o => o))
            {
                this.dgvSummary.Rows.Add(new object[] { category, datagridInfo[category] });
            }
            this.dgvSummary.ColumnHeadersVisible = false;
            this.dgvSummary.SelectAll();
            this.dgvSummary.ColumnHeadersVisible = true;
            BlockRecalculateTotal = false;
        }

        private void RecalculateTotal()
        {
            if (BlockRecalculateTotal) return;

            var totalDebit = 0.0d;
            var totalCredit = 0.0d;

            if (this.dgvSummary.SelectedRows.Count == 0)
            {
                foreach (DataGridViewRow thisRow in dgvSummary.Rows)
                {
                    var amount = (double)thisRow.Cells[1].Value;
                    if (amount > 0.0d) totalCredit += amount;
                    else totalDebit += amount;
                }
            }
            else
            {
                foreach (DataGridViewRow thisRow in dgvSummary.SelectedRows)
                {
                    var amount = (double)thisRow.Cells[1].Value;
                    if (amount > 0.0d) totalCredit += amount;
                    else totalDebit += amount;
                }
            }
            this.lblTotalAmount.Text = $"CR: {totalCredit:c}, DB: {totalDebit:c}, TOTAL: {totalDebit + totalCredit:c}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSummary_SelectionChanged(object sender, EventArgs e)
        {
            RecalculateTotal();
        }
    }
}
