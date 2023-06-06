
namespace CCBQuickCategorizerV2
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
			components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickCategorize));
			splitContainer1 = new System.Windows.Forms.SplitContainer();
			chkEditingAnImportFile = new System.Windows.Forms.CheckBox();
			lblAllTimeExportSource = new System.Windows.Forms.Label();
			txtAllTimeExportFilename = new System.Windows.Forms.TextBox();
			btnLoad = new System.Windows.Forms.Button();
			btnSave = new System.Windows.Forms.Button();
			txtImportFilename = new System.Windows.Forms.TextBox();
			splitContainer2 = new System.Windows.Forms.SplitContainer();
			splitContainer4 = new System.Windows.Forms.SplitContainer();
			btnRefresh = new System.Windows.Forms.Button();
			btnSelectedUncategorizedTransactions = new System.Windows.Forms.Button();
			btnApplySelectedCategoryToSelectedTransactions = new System.Windows.Forms.Button();
			btnApplyTransactionFilter = new System.Windows.Forms.Button();
			chkboxHideUncategorized = new System.Windows.Forms.CheckBox();
			chkboxHideCategorized = new System.Windows.Forms.CheckBox();
			btnClearTransactionFilter = new System.Windows.Forms.Button();
			txtTransactionFilter = new System.Windows.Forms.TextBox();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			splitContainer3 = new System.Windows.Forms.SplitContainer();
			btnCatSummary = new System.Windows.Forms.Button();
			btnAddCategory = new System.Windows.Forms.Button();
			lblCategoryList = new System.Windows.Forms.Label();
			btnClearCategoryFilter = new System.Windows.Forms.Button();
			txtCategoryFilter = new System.Windows.Forms.TextBox();
			lstboxCategory = new System.Windows.Forms.ListBox();
			statusStrip1 = new System.Windows.Forms.StatusStrip();
			toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			toolTip1 = new System.Windows.Forms.ToolTip(components);
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
			splitContainer4.Panel1.SuspendLayout();
			splitContainer4.Panel2.SuspendLayout();
			splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.Panel1.SuspendLayout();
			splitContainer3.Panel2.SuspendLayout();
			splitContainer3.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new System.Drawing.Point(5, 1);
			splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(chkEditingAnImportFile);
			splitContainer1.Panel1.Controls.Add(lblAllTimeExportSource);
			splitContainer1.Panel1.Controls.Add(txtAllTimeExportFilename);
			splitContainer1.Panel1.Controls.Add(btnLoad);
			splitContainer1.Panel1.Controls.Add(btnSave);
			splitContainer1.Panel1.Controls.Add(txtImportFilename);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Size = new System.Drawing.Size(1429, 610);
			splitContainer1.SplitterDistance = 76;
			splitContainer1.SplitterWidth = 5;
			splitContainer1.TabIndex = 4;
			// 
			// chkEditingAnImportFile
			// 
			chkEditingAnImportFile.AutoSize = true;
			chkEditingAnImportFile.Location = new System.Drawing.Point(102, 47);
			chkEditingAnImportFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			chkEditingAnImportFile.Name = "chkEditingAnImportFile";
			chkEditingAnImportFile.Size = new System.Drawing.Size(120, 19);
			chkEditingAnImportFile.TabIndex = 12;
			chkEditingAnImportFile.Text = "Edit an import file";
			chkEditingAnImportFile.UseVisualStyleBackColor = true;
			chkEditingAnImportFile.CheckedChanged += chkEditingAnImportFile_CheckedChanged;
			// 
			// lblAllTimeExportSource
			// 
			lblAllTimeExportSource.AutoSize = true;
			lblAllTimeExportSource.Location = new System.Drawing.Point(98, 9);
			lblAllTimeExportSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblAllTimeExportSource.Name = "lblAllTimeExportSource";
			lblAllTimeExportSource.Size = new System.Drawing.Size(136, 15);
			lblAllTimeExportSource.TabIndex = 11;
			lblAllTimeExportSource.Text = "CCB All-Time Export File";
			// 
			// txtAllTimeExportFilename
			// 
			txtAllTimeExportFilename.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			txtAllTimeExportFilename.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			txtAllTimeExportFilename.Location = new System.Drawing.Point(255, 3);
			txtAllTimeExportFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtAllTimeExportFilename.Name = "txtAllTimeExportFilename";
			txtAllTimeExportFilename.Size = new System.Drawing.Size(1035, 23);
			txtAllTimeExportFilename.TabIndex = 8;
			txtAllTimeExportFilename.Text = "{ double click to select the file clearcheckbook.csv }";
			txtAllTimeExportFilename.DoubleClick += txtAllTimeExportFilename_DoubleClick;
			// 
			// btnLoad
			// 
			btnLoad.Location = new System.Drawing.Point(4, 6);
			btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new System.Drawing.Size(88, 67);
			btnLoad.TabIndex = 7;
			btnLoad.Text = "&Load";
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// btnSave
			// 
			btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnSave.Location = new System.Drawing.Point(1298, 6);
			btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnSave.Name = "btnSave";
			btnSave.Size = new System.Drawing.Size(121, 65);
			btnSave.TabIndex = 6;
			btnSave.Text = "&Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// txtImportFilename
			// 
			txtImportFilename.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			txtImportFilename.Enabled = false;
			txtImportFilename.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			txtImportFilename.Location = new System.Drawing.Point(255, 42);
			txtImportFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtImportFilename.Name = "txtImportFilename";
			txtImportFilename.Size = new System.Drawing.Size(1035, 23);
			txtImportFilename.TabIndex = 4;
			txtImportFilename.Text = "{ double click to select your import file }";
			txtImportFilename.DoubleClick += txtImportFilename_DoubleClick;
			// 
			// splitContainer2
			// 
			splitContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			splitContainer2.IsSplitterFixed = true;
			splitContainer2.Location = new System.Drawing.Point(4, 3);
			splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(splitContainer4);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(splitContainer3);
			splitContainer2.Size = new System.Drawing.Size(1422, 502);
			splitContainer2.SplitterDistance = 1075;
			splitContainer2.SplitterWidth = 5;
			splitContainer2.TabIndex = 0;
			// 
			// splitContainer4
			// 
			splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			splitContainer4.IsSplitterFixed = true;
			splitContainer4.Location = new System.Drawing.Point(0, 0);
			splitContainer4.Name = "splitContainer4";
			splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			splitContainer4.Panel1.Controls.Add(btnRefresh);
			splitContainer4.Panel1.Controls.Add(btnSelectedUncategorizedTransactions);
			splitContainer4.Panel1.Controls.Add(btnApplySelectedCategoryToSelectedTransactions);
			splitContainer4.Panel1.Controls.Add(btnApplyTransactionFilter);
			splitContainer4.Panel1.Controls.Add(chkboxHideUncategorized);
			splitContainer4.Panel1.Controls.Add(chkboxHideCategorized);
			splitContainer4.Panel1.Controls.Add(btnClearTransactionFilter);
			splitContainer4.Panel1.Controls.Add(txtTransactionFilter);
			// 
			// splitContainer4.Panel2
			// 
			splitContainer4.Panel2.Controls.Add(dataGridView1);
			splitContainer4.Size = new System.Drawing.Size(1075, 502);
			splitContainer4.SplitterDistance = 62;
			splitContainer4.TabIndex = 11;
			// 
			// btnRefresh
			// 
			btnRefresh.Enabled = false;
			btnRefresh.Location = new System.Drawing.Point(311, 34);
			btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new System.Drawing.Size(97, 27);
			btnRefresh.TabIndex = 18;
			btnRefresh.Text = "&Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnSelectedUncategorizedTransactions
			// 
			btnSelectedUncategorizedTransactions.Enabled = false;
			btnSelectedUncategorizedTransactions.Location = new System.Drawing.Point(414, 34);
			btnSelectedUncategorizedTransactions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnSelectedUncategorizedTransactions.Name = "btnSelectedUncategorizedTransactions";
			btnSelectedUncategorizedTransactions.Size = new System.Drawing.Size(298, 27);
			btnSelectedUncategorizedTransactions.TabIndex = 17;
			btnSelectedUncategorizedTransactions.Text = "Select &Uncategorized Transactions";
			btnSelectedUncategorizedTransactions.UseVisualStyleBackColor = true;
			btnSelectedUncategorizedTransactions.Click += btnSelectedUncategorizedTransactions_Click;
			// 
			// btnApplySelectedCategoryToSelectedTransactions
			// 
			btnApplySelectedCategoryToSelectedTransactions.Enabled = false;
			btnApplySelectedCategoryToSelectedTransactions.Location = new System.Drawing.Point(719, 34);
			btnApplySelectedCategoryToSelectedTransactions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnApplySelectedCategoryToSelectedTransactions.Name = "btnApplySelectedCategoryToSelectedTransactions";
			btnApplySelectedCategoryToSelectedTransactions.Size = new System.Drawing.Size(344, 27);
			btnApplySelectedCategoryToSelectedTransactions.TabIndex = 16;
			btnApplySelectedCategoryToSelectedTransactions.Text = "Apply Selected Category To Selected Transactions";
			btnApplySelectedCategoryToSelectedTransactions.UseVisualStyleBackColor = true;
			btnApplySelectedCategoryToSelectedTransactions.Click += btnApplySelectedCategoryToSelectedTransactions_Click;
			// 
			// btnApplyTransactionFilter
			// 
			btnApplyTransactionFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnApplyTransactionFilter.Enabled = false;
			btnApplyTransactionFilter.Location = new System.Drawing.Point(844, 5);
			btnApplyTransactionFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnApplyTransactionFilter.Name = "btnApplyTransactionFilter";
			btnApplyTransactionFilter.Size = new System.Drawing.Size(106, 23);
			btnApplyTransactionFilter.TabIndex = 15;
			btnApplyTransactionFilter.Text = "Apply Filter";
			btnApplyTransactionFilter.UseVisualStyleBackColor = true;
			btnApplyTransactionFilter.Click += btnApplyTransactionFilter_Click;
			// 
			// chkboxHideUncategorized
			// 
			chkboxHideUncategorized.AutoSize = true;
			chkboxHideUncategorized.Location = new System.Drawing.Point(163, 38);
			chkboxHideUncategorized.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			chkboxHideUncategorized.Name = "chkboxHideUncategorized";
			chkboxHideUncategorized.Size = new System.Drawing.Size(130, 19);
			chkboxHideUncategorized.TabIndex = 14;
			chkboxHideUncategorized.Text = "Hide Uncategorized";
			chkboxHideUncategorized.UseVisualStyleBackColor = true;
			chkboxHideUncategorized.CheckedChanged += chkboxHideUncategorized_CheckedChanged;
			// 
			// chkboxHideCategorized
			// 
			chkboxHideCategorized.AutoSize = true;
			chkboxHideCategorized.Location = new System.Drawing.Point(15, 38);
			chkboxHideCategorized.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			chkboxHideCategorized.Name = "chkboxHideCategorized";
			chkboxHideCategorized.Size = new System.Drawing.Size(117, 19);
			chkboxHideCategorized.TabIndex = 13;
			chkboxHideCategorized.Text = "Hide Categorized";
			chkboxHideCategorized.UseVisualStyleBackColor = true;
			chkboxHideCategorized.CheckedChanged += chkboxHideCategorized_CheckedChanged;
			// 
			// btnClearTransactionFilter
			// 
			btnClearTransactionFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClearTransactionFilter.Enabled = false;
			btnClearTransactionFilter.Location = new System.Drawing.Point(957, 5);
			btnClearTransactionFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnClearTransactionFilter.Name = "btnClearTransactionFilter";
			btnClearTransactionFilter.Size = new System.Drawing.Size(106, 23);
			btnClearTransactionFilter.TabIndex = 12;
			btnClearTransactionFilter.Text = "Clear Filter";
			btnClearTransactionFilter.UseVisualStyleBackColor = true;
			btnClearTransactionFilter.Click += btnClearTransactionFilter_Click;
			// 
			// txtTransactionFilter
			// 
			txtTransactionFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			txtTransactionFilter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			txtTransactionFilter.Location = new System.Drawing.Point(15, 5);
			txtTransactionFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtTransactionFilter.Name = "txtTransactionFilter";
			txtTransactionFilter.Size = new System.Drawing.Size(821, 22);
			txtTransactionFilter.TabIndex = 11;
			txtTransactionFilter.TextChanged += txtTransactionFilter_TextChanged;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowDrop = true;
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			dataGridView1.Location = new System.Drawing.Point(0, 0);
			dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new System.Drawing.Size(1075, 436);
			dataGridView1.TabIndex = 6;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellContentDoubleClick += dataGridView1_CellDoubleClick;
			dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
			// 
			// splitContainer3
			// 
			splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			splitContainer3.IsSplitterFixed = true;
			splitContainer3.Location = new System.Drawing.Point(0, 0);
			splitContainer3.Name = "splitContainer3";
			splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			splitContainer3.Panel1.Controls.Add(btnCatSummary);
			splitContainer3.Panel1.Controls.Add(btnAddCategory);
			splitContainer3.Panel1.Controls.Add(lblCategoryList);
			splitContainer3.Panel1.Controls.Add(btnClearCategoryFilter);
			splitContainer3.Panel1.Controls.Add(txtCategoryFilter);
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.Controls.Add(lstboxCategory);
			splitContainer3.Size = new System.Drawing.Size(342, 502);
			splitContainer3.SplitterDistance = 62;
			splitContainer3.TabIndex = 9;
			// 
			// btnCatSummary
			// 
			btnCatSummary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnCatSummary.Location = new System.Drawing.Point(100, 36);
			btnCatSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnCatSummary.Name = "btnCatSummary";
			btnCatSummary.Size = new System.Drawing.Size(106, 27);
			btnCatSummary.TabIndex = 13;
			btnCatSummary.Text = "Summary";
			btnCatSummary.UseVisualStyleBackColor = true;
			// 
			// btnAddCategory
			// 
			btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnAddCategory.Location = new System.Drawing.Point(226, 36);
			btnAddCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnAddCategory.Name = "btnAddCategory";
			btnAddCategory.Size = new System.Drawing.Size(109, 27);
			btnAddCategory.TabIndex = 12;
			btnAddCategory.Text = "+";
			btnAddCategory.UseVisualStyleBackColor = true;
			btnAddCategory.Click += btnAddCategory_Click;
			// 
			// lblCategoryList
			// 
			lblCategoryList.AutoSize = true;
			lblCategoryList.Location = new System.Drawing.Point(9, 41);
			lblCategoryList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblCategoryList.Name = "lblCategoryList";
			lblCategoryList.Size = new System.Drawing.Size(76, 15);
			lblCategoryList.TabIndex = 11;
			lblCategoryList.Text = "Category List";
			// 
			// btnClearCategoryFilter
			// 
			btnClearCategoryFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			btnClearCategoryFilter.Enabled = false;
			btnClearCategoryFilter.Location = new System.Drawing.Point(226, 5);
			btnClearCategoryFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnClearCategoryFilter.Name = "btnClearCategoryFilter";
			btnClearCategoryFilter.Size = new System.Drawing.Size(109, 27);
			btnClearCategoryFilter.TabIndex = 9;
			btnClearCategoryFilter.Text = "Clear Filter";
			btnClearCategoryFilter.UseVisualStyleBackColor = true;
			btnClearCategoryFilter.Click += btnClearCategoryFilter_Click;
			// 
			// txtCategoryFilter
			// 
			txtCategoryFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			txtCategoryFilter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			txtCategoryFilter.Location = new System.Drawing.Point(9, 5);
			txtCategoryFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			txtCategoryFilter.Name = "txtCategoryFilter";
			txtCategoryFilter.Size = new System.Drawing.Size(197, 22);
			txtCategoryFilter.TabIndex = 10;
			txtCategoryFilter.TextChanged += txtCategoryFilter_TextChanged;
			// 
			// lstboxCategory
			// 
			lstboxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
			lstboxCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			lstboxCategory.FormattingEnabled = true;
			lstboxCategory.ItemHeight = 14;
			lstboxCategory.Location = new System.Drawing.Point(0, 0);
			lstboxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			lstboxCategory.Name = "lstboxCategory";
			lstboxCategory.Size = new System.Drawing.Size(342, 436);
			lstboxCategory.Sorted = true;
			lstboxCategory.TabIndex = 6;
			lstboxCategory.SelectedIndexChanged += lstboxCategory_SelectedIndexChanged;
			lstboxCategory.DoubleClick += lstboxCategory_DoubleClick;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
			statusStrip1.Location = new System.Drawing.Point(0, 618);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			statusStrip1.Size = new System.Drawing.Size(1438, 22);
			statusStrip1.TabIndex = 5;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new System.Drawing.Size(254, 17);
			toolStripStatusLabel1.Text = "Welcome to ClearCheckbook Quick Categorize";
			// 
			// frmQuickCategorize
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1438, 640);
			Controls.Add(statusStrip1);
			Controls.Add(splitContainer1);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MinimumSize = new System.Drawing.Size(1454, 679);
			Name = "frmQuickCategorize";
			Text = "CCB Quick Categorize";
			FormClosing += frmQuickCategorize_FormClosing;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			splitContainer4.Panel1.ResumeLayout(false);
			splitContainer4.Panel1.PerformLayout();
			splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
			splitContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			splitContainer3.Panel1.ResumeLayout(false);
			splitContainer3.Panel1.PerformLayout();
			splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtImportFilename;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TextBox txtAllTimeExportFilename;
		private System.Windows.Forms.Label lblAllTimeExportSource;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox chkEditingAnImportFile;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Button btnCatSummary;
		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.Label lblCategoryList;
		private System.Windows.Forms.Button btnClearCategoryFilter;
		private System.Windows.Forms.TextBox txtCategoryFilter;
		private System.Windows.Forms.ListBox lstboxCategory;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnSelectedUncategorizedTransactions;
		private System.Windows.Forms.Button btnApplySelectedCategoryToSelectedTransactions;
		private System.Windows.Forms.Button btnApplyTransactionFilter;
		private System.Windows.Forms.CheckBox chkboxHideUncategorized;
		private System.Windows.Forms.CheckBox chkboxHideCategorized;
		private System.Windows.Forms.Button btnClearTransactionFilter;
		private System.Windows.Forms.TextBox txtTransactionFilter;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

