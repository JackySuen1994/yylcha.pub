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
            deZipModelBindingSource5 = new BindingSource(components);
            btnDecompression = new Button();
            txtTargetPath = new TextBox();
            lblTarget = new Label();
            btnOk = new Button();
            txtSourcePath = new TextBox();
            lblSource = new Label();
            tpPushNugetPkg = new TabPage();
            dgvFileLoad = new DataGridView();
            tbServerPath = new TextBox();
            lblServerPath = new Label();
            btnSubmit = new Button();
            label4 = new Label();
            tbFilePath = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbCommand = new TextBox();
            label1 = new Label();
            deZipModelBindingSource4 = new BindingSource(components);
            deZipModelBindingSource2 = new BindingSource(components);
            deZipModelBindingSource = new BindingSource(components);
            deZipModelBindingSource1 = new BindingSource(components);
            deZipModelBindingSource3 = new BindingSource(components);
            tbApiKey = new TextBox();
            label5 = new Label();
            plMain.SuspendLayout();
            tcMain.SuspendLayout();
            tpDeZip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource5).BeginInit();
            tpPushNugetPkg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileLoad).BeginInit();
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
            plMain.Location = new Point(2, 4);
            plMain.Margin = new Padding(2, 3, 2, 3);
            plMain.Name = "plMain";
            plMain.Size = new Size(660, 368);
            plMain.TabIndex = 0;
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpDeZip);
            tcMain.Controls.Add(tpPushNugetPkg);
            tcMain.Location = new Point(14, 6);
            tcMain.Margin = new Padding(2, 3, 2, 3);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(644, 360);
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
            tpDeZip.Location = new Point(4, 26);
            tpDeZip.Margin = new Padding(2, 3, 2, 3);
            tpDeZip.Name = "tpDeZip";
            tpDeZip.Padding = new Padding(2, 3, 2, 3);
            tpDeZip.Size = new Size(636, 330);
            tpDeZip.TabIndex = 0;
            tpDeZip.Text = "Zip解压缩";
            tpDeZip.UseVisualStyleBackColor = true;
            // 
            // lblEndTip
            // 
            lblEndTip.AutoSize = true;
            lblEndTip.ForeColor = Color.Red;
            lblEndTip.Location = new Point(408, 65);
            lblEndTip.Margin = new Padding(2, 0, 2, 0);
            lblEndTip.Name = "lblEndTip";
            lblEndTip.Size = new Size(234, 51);
            lblEndTip.TabIndex = 9;
            lblEndTip.Text = "备份 当前文件路径中增加backfile+时间戳\r\n删除 删掉原文件\r\n保留 不作任何操作";
            lblEndTip.Visible = false;
            // 
            // cbxEndType
            // 
            cbxEndType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEndType.FormattingEnabled = true;
            cbxEndType.Items.AddRange(new object[] { "备份", "删除", "保留" });
            cbxEndType.Location = new Point(518, 38);
            cbxEndType.Margin = new Padding(2, 3, 2, 3);
            cbxEndType.Name = "cbxEndType";
            cbxEndType.Size = new Size(118, 25);
            cbxEndType.TabIndex = 8;
            cbxEndType.Visible = false;
            // 
            // dgvFileInfo
            // 
            dgvFileInfo.AutoGenerateColumns = false;
            dgvFileInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileInfo.DataSource = deZipModelBindingSource5;
            dgvFileInfo.Location = new Point(5, 117);
            dgvFileInfo.Margin = new Padding(2, 3, 2, 3);
            dgvFileInfo.Name = "dgvFileInfo";
            dgvFileInfo.RowHeadersWidth = 51;
            dgvFileInfo.RowTemplate.Height = 29;
            dgvFileInfo.Size = new Size(628, 204);
            dgvFileInfo.TabIndex = 7;
            dgvFileInfo.Visible = false;
            // 
            // btnDecompression
            // 
            btnDecompression.Location = new Point(425, 37);
            btnDecompression.Margin = new Padding(2, 3, 2, 3);
            btnDecompression.Name = "btnDecompression";
            btnDecompression.Size = new Size(86, 25);
            btnDecompression.TabIndex = 6;
            btnDecompression.Text = "解压";
            btnDecompression.UseVisualStyleBackColor = true;
            btnDecompression.Visible = false;
            btnDecompression.Click += btnDecompression_Click;
            // 
            // txtTargetPath
            // 
            txtTargetPath.Location = new Point(96, 36);
            txtTargetPath.Margin = new Padding(2, 3, 2, 3);
            txtTargetPath.Name = "txtTargetPath";
            txtTargetPath.Size = new Size(325, 23);
            txtTargetPath.TabIndex = 5;
            txtTargetPath.Visible = false;
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(6, 36);
            lblTarget.Margin = new Padding(2, 0, 2, 0);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(92, 17);
            lblTarget.TabIndex = 4;
            lblTarget.Text = "解压缩文件目录";
            lblTarget.Visible = false;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(548, 8);
            btnOk.Margin = new Padding(2, 3, 2, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 25);
            btnOk.TabIndex = 2;
            btnOk.Text = "解析文件";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtSourcePath
            // 
            txtSourcePath.Location = new Point(96, 8);
            txtSourcePath.Margin = new Padding(2, 3, 2, 3);
            txtSourcePath.Name = "txtSourcePath";
            txtSourcePath.Size = new Size(447, 23);
            txtSourcePath.TabIndex = 1;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(6, 10);
            lblSource.Margin = new Padding(2, 0, 2, 0);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(92, 17);
            lblSource.TabIndex = 0;
            lblSource.Text = "待解压文件目录";
            // 
            // tpPushNugetPkg
            // 
            tpPushNugetPkg.Controls.Add(tbApiKey);
            tpPushNugetPkg.Controls.Add(label5);
            tpPushNugetPkg.Controls.Add(dgvFileLoad);
            tpPushNugetPkg.Controls.Add(tbServerPath);
            tpPushNugetPkg.Controls.Add(lblServerPath);
            tpPushNugetPkg.Controls.Add(btnSubmit);
            tpPushNugetPkg.Controls.Add(label4);
            tpPushNugetPkg.Controls.Add(tbFilePath);
            tpPushNugetPkg.Controls.Add(label3);
            tpPushNugetPkg.Controls.Add(label2);
            tpPushNugetPkg.Controls.Add(tbCommand);
            tpPushNugetPkg.Controls.Add(label1);
            tpPushNugetPkg.Location = new Point(4, 26);
            tpPushNugetPkg.Margin = new Padding(2, 3, 2, 3);
            tpPushNugetPkg.Name = "tpPushNugetPkg";
            tpPushNugetPkg.Padding = new Padding(2, 3, 2, 3);
            tpPushNugetPkg.Size = new Size(636, 330);
            tpPushNugetPkg.TabIndex = 1;
            tpPushNugetPkg.Text = "推送Nuget包到服务器";
            tpPushNugetPkg.UseVisualStyleBackColor = true;
            // 
            // dgvFileLoad
            // 
            dgvFileLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileLoad.Location = new Point(3, 148);
            dgvFileLoad.Name = "dgvFileLoad";
            dgvFileLoad.ReadOnly = true;
            dgvFileLoad.RowTemplate.Height = 25;
            dgvFileLoad.Size = new Size(628, 176);
            dgvFileLoad.TabIndex = 9;
            // 
            // tbServerPath
            // 
            tbServerPath.Location = new Point(75, 119);
            tbServerPath.Name = "tbServerPath";
            tbServerPath.Size = new Size(146, 23);
            tbServerPath.TabIndex = 8;
            // 
            // lblServerPath
            // 
            lblServerPath.AutoSize = true;
            lblServerPath.ForeColor = Color.Black;
            lblServerPath.Location = new Point(3, 122);
            lblServerPath.Name = "lblServerPath";
            lblServerPath.Size = new Size(80, 17);
            lblServerPath.TabIndex = 7;
            lblServerPath.Text = "服务器路径：";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(516, 119);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "上传";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 28);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 5;
            label4.Text = "支持上传包含下级的文件";
            // 
            // tbFilePath
            // 
            tbFilePath.Location = new Point(64, 84);
            tbFilePath.Name = "tbFilePath";
            tbFilePath.Size = new Size(567, 23);
            tbFilePath.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 88);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 3;
            label3.Text = "文件路径";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(17, 6);
            label2.Name = "label2";
            label2.Size = new Size(361, 17);
            label2.TabIndex = 2;
            label2.Text = "命令：输入命令，关键词请使用占位符(只支持文件名+服务器地址)";
            // 
            // tbCommand
            // 
            tbCommand.Location = new Point(64, 53);
            tbCommand.Name = "tbCommand";
            tbCommand.Size = new Size(567, 23);
            tbCommand.TabIndex = 1;
            tbCommand.Text = "dotnet nuget push {0} -k {1} -s {2}";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 56);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "命令：";
            // 
            // tbApiKey
            // 
            tbApiKey.Location = new Point(301, 119);
            tbApiKey.Name = "tbApiKey";
            tbApiKey.Size = new Size(146, 23);
            tbApiKey.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(229, 122);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 10;
            label5.Text = "api key：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 382);
            Controls.Add(plMain);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            plMain.ResumeLayout(false);
            tcMain.ResumeLayout(false);
            tpDeZip.ResumeLayout(false);
            tpDeZip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)deZipModelBindingSource5).EndInit();
            tpPushNugetPkg.ResumeLayout(false);
            tpPushNugetPkg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFileLoad).EndInit();
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
        private TabPage tpPushNugetPkg;
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
        private Label label2;
        private TextBox tbCommand;
        private Label label1;
        private TextBox tbFilePath;
        private Label label3;
        private Button btnSubmit;
        private Label label4;
        private TextBox tbServerPath;
        private Label lblServerPath;
        private DataGridView dgvFileLoad;
        private TextBox tbApiKey;
        private Label label5;
    }
}