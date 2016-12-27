namespace CCBQuickCategorizer
{
    partial class frmQuickCategorize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.chkEditingAnImportFile = new System.Windows.Forms.CheckBox();
			this.lblAllTimeExportSource = new System.Windows.Forms.Label();
			this.txtAllTimeExportFilename = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtImportFilename = new System.Windows.Forms.TextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnSelectedUncategorizedTransactions = new System.Windows.Forms.Button();
			this.btnApplySelectedCategoryToSelectedTransactions = new System.Windows.Forms.Button();
			this.btnApplyTransactionFilter = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.chkboxHideUncategorized = new System.Windows.Forms.CheckBox();
			this.chkboxHideCategorized = new System.Windows.Forms.CheckBox();
			this.btnClearTransactionFilter = new System.Windows.Forms.Button();
			this.txtTransactionFilter = new System.Windows.Forms.TextBox();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.lstboxCategory = new System.Windows.Forms.ListBox();
			this.lblCategoryList = new System.Windows.Forms.Label();
			this.btnClearCategoryFilter = new System.Windows.Forms.Button();
			this.txtCategoryFilter = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(4, 1);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.chkEditingAnImportFile);
			this.splitContainer1.Panel1.Controls.Add(this.lblAllTimeExportSource);
			this.splitContainer1.Panel1.Controls.Add(this.txtAllTimeExportFilename);
			this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
			this.splitContainer1.Panel1.Controls.Add(this.btnSave);
			this.splitContainer1.Panel1.Controls.Add(this.txtImportFilename);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1225, 529);
			this.splitContainer1.SplitterDistance = 66;
			this.splitContainer1.TabIndex = 4;
			// 
			// chkEditingAnImportFile
			// 
			this.chkEditingAnImportFile.AutoSize = true;
			this.chkEditingAnImportFile.Location = new System.Drawing.Point(87, 41);
			this.chkEditingAnImportFile.Name = "chkEditingAnImportFile";
			this.chkEditingAnImportFile.Size = new System.Drawing.Size(106, 17);
			this.chkEditingAnImportFile.TabIndex = 12;
			this.chkEditingAnImportFile.Text = "Edit an import file";
			this.chkEditingAnImportFile.UseVisualStyleBackColor = true;
			this.chkEditingAnImportFile.CheckedChanged += new System.EventHandler(this.chkEditingAnImportFile_CheckedChanged);
			// 
			// lblAllTimeExportSource
			// 
			this.lblAllTimeExportSource.AutoSize = true;
			this.lblAllTimeExportSource.Location = new System.Drawing.Point(84, 8);
			this.lblAllTimeExportSource.Name = "lblAllTimeExportSource";
			this.lblAllTimeExportSource.Size = new System.Drawing.Size(120, 13);
			this.lblAllTimeExportSource.TabIndex = 11;
			this.lblAllTimeExportSource.Text = "CCB All-Time Export File";
			// 
			// txtAllTimeExportFilename
			// 
			this.txtAllTimeExportFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAllTimeExportFilename.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAllTimeExportFilename.Location = new System.Drawing.Point(219, 3);
			this.txtAllTimeExportFilename.Name = "txtAllTimeExportFilename";
			this.txtAllTimeExportFilename.Size = new System.Drawing.Size(888, 23);
			this.txtAllTimeExportFilename.TabIndex = 8;
			this.txtAllTimeExportFilename.Text = "{ double click to select the file clearcheckbook.csv }";
			this.txtAllTimeExportFilename.DoubleClick += new System.EventHandler(this.txtAllTimeExportFilename_DoubleClick);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(3, 5);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 58);
			this.btnLoad.TabIndex = 7;
			this.btnLoad.Text = "&Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(1113, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 56);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtImportFilename
			// 
			this.txtImportFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtImportFilename.Enabled = false;
			this.txtImportFilename.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImportFilename.Location = new System.Drawing.Point(219, 36);
			this.txtImportFilename.Name = "txtImportFilename";
			this.txtImportFilename.Size = new System.Drawing.Size(888, 23);
			this.txtImportFilename.TabIndex = 4;
			this.txtImportFilename.Text = "{ double click to select your import file }";
			this.txtImportFilename.DoubleClick += new System.EventHandler(this.txtImportFilename_DoubleClick);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.btnRefresh);
			this.splitContainer2.Panel1.Controls.Add(this.btnSelectedUncategorizedTransactions);
			this.splitContainer2.Panel1.Controls.Add(this.btnApplySelectedCategoryToSelectedTransactions);
			this.splitContainer2.Panel1.Controls.Add(this.btnApplyTransactionFilter);
			this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
			this.splitContainer2.Panel1.Controls.Add(this.chkboxHideUncategorized);
			this.splitContainer2.Panel1.Controls.Add(this.chkboxHideCategorized);
			this.splitContainer2.Panel1.Controls.Add(this.btnClearTransactionFilter);
			this.splitContainer2.Panel1.Controls.Add(this.txtTransactionFilter);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.btnAddCategory);
			this.splitContainer2.Panel2.Controls.Add(this.lstboxCategory);
			this.splitContainer2.Panel2.Controls.Add(this.lblCategoryList);
			this.splitContainer2.Panel2.Controls.Add(this.btnClearCategoryFilter);
			this.splitContainer2.Panel2.Controls.Add(this.txtCategoryFilter);
			this.splitContainer2.Size = new System.Drawing.Size(1219, 456);
			this.splitContainer2.SplitterDistance = 922;
			this.splitContainer2.TabIndex = 0;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Enabled = false;
			this.btnRefresh.Location = new System.Drawing.Point(267, 31);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(83, 23);
			this.btnRefresh.TabIndex = 10;
			this.btnRefresh.Text = "&Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSelectedUncategorizedTransactions
			// 
			this.btnSelectedUncategorizedTransactions.Enabled = false;
			this.btnSelectedUncategorizedTransactions.Location = new System.Drawing.Point(356, 31);
			this.btnSelectedUncategorizedTransactions.Name = "btnSelectedUncategorizedTransactions";
			this.btnSelectedUncategorizedTransactions.Size = new System.Drawing.Size(255, 23);
			this.btnSelectedUncategorizedTransactions.TabIndex = 9;
			this.btnSelectedUncategorizedTransactions.Text = "Select &Uncategorized Transactions";
			this.btnSelectedUncategorizedTransactions.UseVisualStyleBackColor = true;
			this.btnSelectedUncategorizedTransactions.Click += new System.EventHandler(this.btnSelectedUncategorizedTransactions_Click);
			// 
			// btnApplySelectedCategoryToSelectedTransactions
			// 
			this.btnApplySelectedCategoryToSelectedTransactions.Enabled = false;
			this.btnApplySelectedCategoryToSelectedTransactions.Location = new System.Drawing.Point(617, 31);
			this.btnApplySelectedCategoryToSelectedTransactions.Name = "btnApplySelectedCategoryToSelectedTransactions";
			this.btnApplySelectedCategoryToSelectedTransactions.Size = new System.Drawing.Size(298, 23);
			this.btnApplySelectedCategoryToSelectedTransactions.TabIndex = 8;
			this.btnApplySelectedCategoryToSelectedTransactions.Text = "Apply Selected Category To Selected Transactions";
			this.btnApplySelectedCategoryToSelectedTransactions.UseVisualStyleBackColor = true;
			this.btnApplySelectedCategoryToSelectedTransactions.Click += new System.EventHandler(this.btnApplySelectedCategoryToSelectedTransactions_Click);
			// 
			// btnApplyTransactionFilter
			// 
			this.btnApplyTransactionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApplyTransactionFilter.Enabled = false;
			this.btnApplyTransactionFilter.Location = new System.Drawing.Point(727, 3);
			this.btnApplyTransactionFilter.Name = "btnApplyTransactionFilter";
			this.btnApplyTransactionFilter.Size = new System.Drawing.Size(91, 20);
			this.btnApplyTransactionFilter.TabIndex = 6;
			this.btnApplyTransactionFilter.Text = "Apply Filter";
			this.btnApplyTransactionFilter.UseVisualStyleBackColor = true;
			this.btnApplyTransactionFilter.Click += new System.EventHandler(this.btnApplyTransactionFilter_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 60);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(913, 394);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// chkboxHideUncategorized
			// 
			this.chkboxHideUncategorized.AutoSize = true;
			this.chkboxHideUncategorized.Location = new System.Drawing.Point(141, 35);
			this.chkboxHideUncategorized.Name = "chkboxHideUncategorized";
			this.chkboxHideUncategorized.Size = new System.Drawing.Size(120, 17);
			this.chkboxHideUncategorized.TabIndex = 4;
			this.chkboxHideUncategorized.Text = "Hide Uncategorized";
			this.chkboxHideUncategorized.UseVisualStyleBackColor = true;
			this.chkboxHideUncategorized.CheckedChanged += new System.EventHandler(this.chkboxHideUncategorized_CheckedChanged);
			// 
			// chkboxHideCategorized
			// 
			this.chkboxHideCategorized.AutoSize = true;
			this.chkboxHideCategorized.Location = new System.Drawing.Point(14, 35);
			this.chkboxHideCategorized.Name = "chkboxHideCategorized";
			this.chkboxHideCategorized.Size = new System.Drawing.Size(107, 17);
			this.chkboxHideCategorized.TabIndex = 3;
			this.chkboxHideCategorized.Text = "Hide Categorized";
			this.chkboxHideCategorized.UseVisualStyleBackColor = true;
			this.chkboxHideCategorized.CheckedChanged += new System.EventHandler(this.chkboxHideCategorized_CheckedChanged);
			// 
			// btnClearTransactionFilter
			// 
			this.btnClearTransactionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearTransactionFilter.Enabled = false;
			this.btnClearTransactionFilter.Location = new System.Drawing.Point(824, 3);
			this.btnClearTransactionFilter.Name = "btnClearTransactionFilter";
			this.btnClearTransactionFilter.Size = new System.Drawing.Size(91, 20);
			this.btnClearTransactionFilter.TabIndex = 1;
			this.btnClearTransactionFilter.Text = "Clear Filter";
			this.btnClearTransactionFilter.UseVisualStyleBackColor = true;
			this.btnClearTransactionFilter.Click += new System.EventHandler(this.btnClearTransactionFilter_Click);
			// 
			// txtTransactionFilter
			// 
			this.txtTransactionFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTransactionFilter.Location = new System.Drawing.Point(4, 4);
			this.txtTransactionFilter.Name = "txtTransactionFilter";
			this.txtTransactionFilter.Size = new System.Drawing.Size(717, 20);
			this.txtTransactionFilter.TabIndex = 0;
			this.txtTransactionFilter.TextChanged += new System.EventHandler(this.txtTransactionFilter_TextChanged);
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddCategory.Location = new System.Drawing.Point(202, 27);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(91, 23);
			this.btnAddCategory.TabIndex = 7;
			this.btnAddCategory.Text = "+";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// lstboxCategory
			// 
			this.lstboxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstboxCategory.FormattingEnabled = true;
			this.lstboxCategory.Location = new System.Drawing.Point(3, 60);
			this.lstboxCategory.Name = "lstboxCategory";
			this.lstboxCategory.Size = new System.Drawing.Size(287, 394);
			this.lstboxCategory.Sorted = true;
			this.lstboxCategory.TabIndex = 5;
			this.lstboxCategory.SelectedIndexChanged += new System.EventHandler(this.lstboxCategory_SelectedIndexChanged);
			// 
			// lblCategoryList
			// 
			this.lblCategoryList.AutoSize = true;
			this.lblCategoryList.Location = new System.Drawing.Point(13, 35);
			this.lblCategoryList.Name = "lblCategoryList";
			this.lblCategoryList.Size = new System.Drawing.Size(68, 13);
			this.lblCategoryList.TabIndex = 4;
			this.lblCategoryList.Text = "Category List";
			// 
			// btnClearCategoryFilter
			// 
			this.btnClearCategoryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearCategoryFilter.Enabled = false;
			this.btnClearCategoryFilter.Location = new System.Drawing.Point(202, 2);
			this.btnClearCategoryFilter.Name = "btnClearCategoryFilter";
			this.btnClearCategoryFilter.Size = new System.Drawing.Size(91, 20);
			this.btnClearCategoryFilter.TabIndex = 2;
			this.btnClearCategoryFilter.Text = "Clear Filter";
			this.btnClearCategoryFilter.UseVisualStyleBackColor = true;
			this.btnClearCategoryFilter.Click += new System.EventHandler(this.btnClearCategoryFilter_Click);
			// 
			// txtCategoryFilter
			// 
			this.txtCategoryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCategoryFilter.Location = new System.Drawing.Point(3, 3);
			this.txtCategoryFilter.Name = "txtCategoryFilter";
			this.txtCategoryFilter.Size = new System.Drawing.Size(193, 20);
			this.txtCategoryFilter.TabIndex = 2;
			this.txtCategoryFilter.TextChanged += new System.EventHandler(this.txtCategoryFilter_TextChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 533);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1233, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(254, 17);
			this.toolStripStatusLabel1.Text = "Welcome to ClearCheckbook Quick Categorize";
			// 
			// frmQuickCategorize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1233, 555);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(1249, 594);
			this.Name = "frmQuickCategorize";
			this.Text = "CCB Quick Categorize";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuickCategorize_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtImportFilename;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtTransactionFilter;
        private System.Windows.Forms.Button btnClearTransactionFilter;
        private System.Windows.Forms.TextBox txtCategoryFilter;
        private System.Windows.Forms.Button btnClearCategoryFilter;
        private System.Windows.Forms.CheckBox chkboxHideCategorized;
        private System.Windows.Forms.CheckBox chkboxHideUncategorized;
        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstboxCategory;
        private System.Windows.Forms.Button btnApplyTransactionFilter;
        private System.Windows.Forms.Button btnApplySelectedCategoryToSelectedTransactions;
        private System.Windows.Forms.Button btnSelectedUncategorizedTransactions;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtAllTimeExportFilename;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblAllTimeExportSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkEditingAnImportFile;
    }
}

