namespace yylcha.pub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            plMain = new Panel();
            tcMain = new TabControl();
            tpDeZip = new TabPage();
            lblEndTip = new Label();
            cbxEndType = new ComboBox();
            dgvFileInfo = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deZipModelBindingSource5 = new BindingSource(components);
            btnDecompression = new Button();
            txtTargetPath = new TextBox();
            lblTarget = new Label();
            btnOk = new Button();
            txtSourcePath = new TextBox();
            lblSource = new Label();
            tabPage2 = new TabPage();
            deZipModelBindingSource4 = new BindingSource(components);
            deZipModelBindingSource2 = new BindingSource(components);
            deZipModelBindingSource = new BindingSource(components);
            deZipModelBindingSource1 = new BindingSource(components);
            deZipModelBindingSource3 = new BindingSource(components);
            plMain.SuspendLayout();
            tcMain.SuspendLayout();
            tpDeZip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // plMain
            // 
            plMain.Controls.Add(tcMain);
            plMain.Location = new Point(3, 5);
            plMain.Name = "plMain";
            plMain.Size = new Size(849, 433);
            plMain.TabIndex = 0;
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpDeZip);
            tcMain.Controls.Add(tabPage2);
            tcMain.Location = new Point(18, 7);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(828, 423);
            tcMain.TabIndex = 0;
            // 
            // tpDeZip
            // 
            tpDeZip.Controls.Add(lblEndTip);
            tpDeZip.Controls.Add(cbxEndType);
            tpDeZip.Controls.Add(dgvFileInfo);
            tpDeZip.Controls.Add(btnDecompression);
            tpDeZip.Controls.Add(txtTargetPath);
            tpDeZip.Controls.Add(lblTarget);
            tpDeZip.Controls.Add(btnOk);
            tpDeZip.Controls.Add(txtSourcePath);
            tpDeZip.Controls.Add(lblSource);
            tpDeZip.Location = new Point(4, 29);
            tpDeZip.Name = "tpDeZip";
            tpDeZip.Padding = new Padding(3);
            tpDeZip.Size = new Size(820, 390);
            tpDeZip.TabIndex = 0;
            tpDeZip.Text = "Zip解压缩";
            tpDeZip.UseVisualStyleBackColor = true;
            // 
            // lblEndTip
            // 
            lblEndTip.AutoSize = true;
            lblEndTip.ForeColor = Color.Red;
            lblEndTip.Location = new Point(524, 76);
            lblEndTip.Name = "lblEndTip";
            lblEndTip.Size = new Size(290, 60);
            lblEndTip.TabIndex = 9;
            lblEndTip.Text = "备份 当前文件路径中增加backfile+时间戳\r\n删除 删掉原文件\r\n保留 不作任何操作";
            lblEndTip.Visible = false;
            // 
            // cbxEndType
            // 
            cbxEndType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEndType.FormattingEnabled = true;
            cbxEndType.Items.AddRange(new object[] { "备份", "删除", "保留" });
            cbxEndType.Location = new Point(666, 45);
            cbxEndType.Name = "cbxEndType";
            cbxEndType.Size = new Size(151, 28);
            cbxEndType.TabIndex = 8;
            cbxEndType.Visible = false;
            // 
            // dgvFileInfo
            // 
            dgvFileInfo.AutoGenerateColumns = false;
            dgvFileInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileInfo.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, pathDataGridViewTextBoxColumn });
            dgvFileInfo.DataSource = deZipModelBindingSource5;
            dgvFileInfo.Location = new Point(7, 138);
            dgvFileInfo.Name = "dgvFileInfo";
            dgvFileInfo.RowHeadersWidth = 51;
            dgvFileInfo.RowTemplate.Height = 29;
            dgvFileInfo.Size = new Size(807, 240);
            dgvFileInfo.TabIndex = 7;
            dgvFileInfo.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FileName";
            dataGridViewTextBoxColumn1.HeaderText = "文件名称";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "IsDeResult";
            dataGridViewTextBoxColumn2.HeaderText = "结果";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.HeaderText = "路径";
            pathDataGridViewTextBoxColumn.MinimumWidth = 6;
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.Width = 400;
            // 
            // deZipModelBindingSource5
            // 
            deZipModelBindingSource5.DataSource = typeof(model.DeZipModel);
            // 
            // btnDecompression
            // 
            btnDecompression.Location = new Point(547, 44);
            btnDecompression.Name = "btnDecompression";
            btnDecompression.Size = new Size(110, 29);
            btnDecompression.TabIndex = 6;
            btnDecompression.Text = "解压";
            btnDecompression.UseVisualStyleBackColor = true;
            btnDecompression.Visible = false;
            btnDecompression.Click += btnDecompression_Click;
            // 
            // txtTargetPath
            // 
            txtTargetPath.Location = new Point(124, 42);
            txtTargetPath.Name = "txtTargetPath";
            txtTargetPath.Size = new Size(417, 27);
            txtTargetPath.TabIndex = 5;
            txtTargetPath.Visible = false;
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(8, 42);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(114, 20);
            lblTarget.TabIndex = 4;
            lblTarget.Text = "解压缩文件目录";
            lblTarget.Visible = false;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(704, 9);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(110, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "解析文件";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtSourcePath
            // 
            txtSourcePath.Location = new Point(124, 9);
            txtSourcePath.Name = "txtSourcePath";
            txtSourcePath.Size = new Size(574, 27);
            txtSourcePath.TabIndex = 1;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(8, 12);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(114, 20);
            lblSource.TabIndex = 0;
            lblSource.Text = "待解压文件目录";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(820, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(plMain);
            Name = "Form1";
            Text = "Form1";
            plMain.ResumeLayout(false);
            tcMain.ResumeLayout(false);
            tpDeZip.ResumeLayout(false);
            tpDeZip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plMain;
        private TabControl tcMain;
        private TabPage tpDeZip;
        private Label lblSource;
        private TabPage tabPage2;
        private Button btnOk;
        private TextBox txtSourcePath;
        private BindingSource deZipModelBindingSource;
        private Button btnDecompression;
        private TextBox txtTargetPath;
        private Label lblTarget;
        private BindingSource deZipModelBindingSource1;
        private BindingSource deZipModelBindingSource2;
        private DataGridView dgvFileInfo;
        private DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isDeResultDataGridViewTextBoxColumn;
        private BindingSource deZipModelBindingSource4;
        private BindingSource deZipModelBindingSource3;
        private BindingSource deZipModelBindingSource5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private ComboBox cbxEndType;
        private Label lblEndTip;
    }
}