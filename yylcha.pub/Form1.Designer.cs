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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            uiTcMain = new Sunny.UI.UITabControlMenu();
            uiCmsMenu = new Sunny.UI.UIContextMenuStrip();
            tsmiChangeTheme = new ToolStripMenuItem();
            tsmiyyliucha = new ToolStripMenuItem();
            uiTpDeZip = new TabPage();
            uiDgvFileInfo = new Sunny.UI.UIDataGridView();
            uiLblEndTip = new Sunny.UI.UILabel();
            uiCbxEndType = new Sunny.UI.UIComboBox();
            uiBtnDecompression = new Sunny.UI.UIButton();
            uiTxtTargetPath = new Sunny.UI.UITextBox();
            uiBtnOk = new Sunny.UI.UIButton();
            uiTxtSourcePath = new Sunny.UI.UITextBox();
            uiLblTarget = new Sunny.UI.UILabel();
            uiLblSource = new Sunny.UI.UILabel();
            uiTpPushNugetPkg = new TabPage();
            uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            uiLblNugetTip = new Sunny.UI.UILabel();
            uiBtnShowPkgList = new Sunny.UI.UIButton();
            uiLblNugetTip2 = new Sunny.UI.UILabel();
            uiLblPushType = new Sunny.UI.UILabel();
            uiLblCommand = new Sunny.UI.UILabel();
            uiBtnGenerateLocalConfig = new Sunny.UI.UIButton();
            uiLblFilePath = new Sunny.UI.UILabel();
            uiBtnSubmit = new Sunny.UI.UIButton();
            uiLblServerPath = new Sunny.UI.UILabel();
            uiBtnSelectPath = new Sunny.UI.UIButton();
            uiLblApiKey = new Sunny.UI.UILabel();
            uiCmbCommand = new Sunny.UI.UIComboBox();
            uiTxtServerPath = new Sunny.UI.UITextBox();
            uiTxtFilePath = new Sunny.UI.UITextBox();
            uiTxtApiKey = new Sunny.UI.UITextBox();
            uiDgvFileLoad = new Sunny.UI.UIDataGridView();
            uiCmsNugetGrdMenu = new Sunny.UI.UIContextMenuStrip();
            tsmiRemoveSelected = new ToolStripMenuItem();
            tsmiClearNugetList = new ToolStripMenuItem();
            tsmiRefreshNugetList = new ToolStripMenuItem();
            uiTpHelp = new TabPage();
            uiRTxtHelp = new Sunny.UI.UIRichTextBox();
            uiTpLog = new TabPage();
            uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            ssFootStatus = new StatusStrip();
            tsslCopyRight = new ToolStripStatusLabel();
            tsslNowTime = new ToolStripStatusLabel();
            tiNowTime = new System.Windows.Forms.Timer(components);
            uiTcMain.SuspendLayout();
            uiCmsMenu.SuspendLayout();
            uiTpDeZip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDgvFileInfo).BeginInit();
            uiTpPushNugetPkg.SuspendLayout();
            uiSplitContainer1.BeginInit();
            uiSplitContainer1.Panel1.SuspendLayout();
            uiSplitContainer1.Panel2.SuspendLayout();
            uiSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDgvFileLoad).BeginInit();
            uiCmsNugetGrdMenu.SuspendLayout();
            uiTpHelp.SuspendLayout();
            uiTpLog.SuspendLayout();
            ssFootStatus.SuspendLayout();
            SuspendLayout();
            // 
            // uiTcMain
            // 
            uiTcMain.Alignment = TabAlignment.Left;
            uiTcMain.ContextMenuStrip = uiCmsMenu;
            uiTcMain.Controls.Add(uiTpDeZip);
            uiTcMain.Controls.Add(uiTpPushNugetPkg);
            uiTcMain.Controls.Add(uiTpHelp);
            uiTcMain.Controls.Add(uiTpLog);
            uiTcMain.Dock = DockStyle.Fill;
            uiTcMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTcMain.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTcMain.Location = new Point(0, 35);
            uiTcMain.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTcMain.Multiline = true;
            uiTcMain.Name = "uiTcMain";
            uiTcMain.SelectedIndex = 0;
            uiTcMain.Size = new Size(1020, 562);
            uiTcMain.SizeMode = TabSizeMode.Fixed;
            uiTcMain.TabIndex = 2;
            uiTcMain.SelectedIndexChanged += uiTcMain_SelectedIndexChanged;
            // 
            // uiCmsMenu
            // 
            uiCmsMenu.BackColor = Color.FromArgb(243, 249, 255);
            uiCmsMenu.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCmsMenu.Items.AddRange(new ToolStripItem[] { tsmiChangeTheme, tsmiyyliucha });
            uiCmsMenu.Name = "uiCmsChangeTheme";
            uiCmsMenu.Size = new Size(139, 48);
            // 
            // tsmiChangeTheme
            // 
            tsmiChangeTheme.Name = "tsmiChangeTheme";
            tsmiChangeTheme.Size = new Size(138, 22);
            tsmiChangeTheme.Text = "更改主题";
            tsmiChangeTheme.DropDownItemClicked += tsmiChangeTheme_DropDownItemClicked;
            // 
            // tsmiyyliucha
            // 
            tsmiyyliucha.Name = "tsmiyyliucha";
            tsmiyyliucha.Size = new Size(138, 22);
            tsmiyyliucha.Text = "yyliucha";
            tsmiyyliucha.Click += tsmiyyliucha_Click;
            // 
            // uiTpDeZip
            // 
            uiTpDeZip.Controls.Add(uiDgvFileInfo);
            uiTpDeZip.Controls.Add(uiLblEndTip);
            uiTpDeZip.Controls.Add(uiCbxEndType);
            uiTpDeZip.Controls.Add(uiBtnDecompression);
            uiTpDeZip.Controls.Add(uiTxtTargetPath);
            uiTpDeZip.Controls.Add(uiBtnOk);
            uiTpDeZip.Controls.Add(uiTxtSourcePath);
            uiTpDeZip.Controls.Add(uiLblTarget);
            uiTpDeZip.Controls.Add(uiLblSource);
            uiTpDeZip.Location = new Point(201, 0);
            uiTpDeZip.Name = "uiTpDeZip";
            uiTpDeZip.Size = new Size(819, 562);
            uiTpDeZip.TabIndex = 0;
            uiTpDeZip.Text = "Zip解压缩(仅支持Zip)";
            uiTpDeZip.UseVisualStyleBackColor = true;
            // 
            // uiDgvFileInfo
            // 
            uiDgvFileInfo.AllowUserToAddRows = false;
            uiDgvFileInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDgvFileInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDgvFileInfo.BackgroundColor = Color.White;
            uiDgvFileInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDgvFileInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDgvFileInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDgvFileInfo.DefaultCellStyle = dataGridViewCellStyle3;
            uiDgvFileInfo.EnableHeadersVisualStyles = false;
            uiDgvFileInfo.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvFileInfo.GridColor = Color.FromArgb(80, 160, 255);
            uiDgvFileInfo.Location = new Point(5, 143);
            uiDgvFileInfo.Name = "uiDgvFileInfo";
            uiDgvFileInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDgvFileInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvFileInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDgvFileInfo.RowTemplate.Height = 25;
            uiDgvFileInfo.SelectedIndex = -1;
            uiDgvFileInfo.Size = new Size(805, 387);
            uiDgvFileInfo.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDgvFileInfo.TabIndex = 11;
            // 
            // uiLblEndTip
            // 
            uiLblEndTip.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblEndTip.ForeColor = Color.Red;
            uiLblEndTip.Location = new Point(483, 86);
            uiLblEndTip.Name = "uiLblEndTip";
            uiLblEndTip.Size = new Size(314, 54);
            uiLblEndTip.TabIndex = 6;
            uiLblEndTip.Text = "备份 当前文件路径中增加backfile+时间戳\r\n删除 删掉原文件\r\n保留 不作任何操作\r\n\r\n";
            uiLblEndTip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiCbxEndType
            // 
            uiCbxEndType.DataSource = null;
            uiCbxEndType.FillColor = Color.White;
            uiCbxEndType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCbxEndType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiCbxEndType.Items.AddRange(new object[] { "备份", "删除", "保留" });
            uiCbxEndType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiCbxEndType.Location = new Point(483, 43);
            uiCbxEndType.Margin = new Padding(4, 5, 4, 5);
            uiCbxEndType.MinimumSize = new Size(63, 0);
            uiCbxEndType.Name = "uiCbxEndType";
            uiCbxEndType.Padding = new Padding(0, 0, 30, 2);
            uiCbxEndType.Size = new Size(150, 29);
            uiCbxEndType.TabIndex = 5;
            uiCbxEndType.TextAlignment = ContentAlignment.MiddleLeft;
            uiCbxEndType.Watermark = "";
            // 
            // uiBtnDecompression
            // 
            uiBtnDecompression.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnDecompression.Location = new Point(366, 43);
            uiBtnDecompression.MinimumSize = new Size(1, 1);
            uiBtnDecompression.Name = "uiBtnDecompression";
            uiBtnDecompression.Radius = 30;
            uiBtnDecompression.Size = new Size(100, 30);
            uiBtnDecompression.TabIndex = 4;
            uiBtnDecompression.Text = "解压";
            uiBtnDecompression.Click += uiBtnDecompression_Click;
            // 
            // uiTxtTargetPath
            // 
            uiTxtTargetPath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTxtTargetPath.Location = new Point(134, 44);
            uiTxtTargetPath.Margin = new Padding(4, 5, 4, 5);
            uiTxtTargetPath.MinimumSize = new Size(1, 16);
            uiTxtTargetPath.Name = "uiTxtTargetPath";
            uiTxtTargetPath.Padding = new Padding(5);
            uiTxtTargetPath.ShowText = false;
            uiTxtTargetPath.Size = new Size(225, 29);
            uiTxtTargetPath.TabIndex = 3;
            uiTxtTargetPath.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtTargetPath.Watermark = "";
            // 
            // uiBtnOk
            // 
            uiBtnOk.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnOk.Location = new Point(366, 8);
            uiBtnOk.MinimumSize = new Size(1, 1);
            uiBtnOk.Name = "uiBtnOk";
            uiBtnOk.Radius = 30;
            uiBtnOk.Size = new Size(100, 30);
            uiBtnOk.TabIndex = 3;
            uiBtnOk.Text = "解析文件";
            uiBtnOk.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnOk.Click += uiBtnOk_Click;
            // 
            // uiTxtSourcePath
            // 
            uiTxtSourcePath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTxtSourcePath.Location = new Point(134, 9);
            uiTxtSourcePath.Margin = new Padding(4, 5, 4, 5);
            uiTxtSourcePath.MinimumSize = new Size(1, 16);
            uiTxtSourcePath.Name = "uiTxtSourcePath";
            uiTxtSourcePath.Padding = new Padding(5);
            uiTxtSourcePath.ShowText = false;
            uiTxtSourcePath.Size = new Size(225, 29);
            uiTxtSourcePath.TabIndex = 2;
            uiTxtSourcePath.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtSourcePath.Watermark = "";
            // 
            // uiLblTarget
            // 
            uiLblTarget.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblTarget.ForeColor = Color.FromArgb(48, 48, 48);
            uiLblTarget.Location = new Point(3, 47);
            uiLblTarget.Name = "uiLblTarget";
            uiLblTarget.Size = new Size(124, 23);
            uiLblTarget.TabIndex = 1;
            uiLblTarget.Text = "解压缩文件目录";
            uiLblTarget.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLblSource
            // 
            uiLblSource.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblSource.ForeColor = Color.FromArgb(48, 48, 48);
            uiLblSource.Location = new Point(3, 12);
            uiLblSource.Name = "uiLblSource";
            uiLblSource.Size = new Size(124, 23);
            uiLblSource.TabIndex = 0;
            uiLblSource.Text = "待解压文件目录";
            uiLblSource.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiTpPushNugetPkg
            // 
            uiTpPushNugetPkg.Controls.Add(uiSplitContainer1);
            uiTpPushNugetPkg.Location = new Point(201, 0);
            uiTpPushNugetPkg.Name = "uiTpPushNugetPkg";
            uiTpPushNugetPkg.Size = new Size(819, 562);
            uiTpPushNugetPkg.TabIndex = 1;
            uiTpPushNugetPkg.Text = "Nuget";
            uiTpPushNugetPkg.UseVisualStyleBackColor = true;
            // 
            // uiSplitContainer1
            // 
            uiSplitContainer1.Dock = DockStyle.Fill;
            uiSplitContainer1.Location = new Point(0, 0);
            uiSplitContainer1.MinimumSize = new Size(20, 20);
            uiSplitContainer1.Name = "uiSplitContainer1";
            uiSplitContainer1.Orientation = Orientation.Horizontal;
            // 
            // uiSplitContainer1.Panel1
            // 
            uiSplitContainer1.Panel1.Controls.Add(uiLblNugetTip);
            uiSplitContainer1.Panel1.Controls.Add(uiBtnShowPkgList);
            uiSplitContainer1.Panel1.Controls.Add(uiLblNugetTip2);
            uiSplitContainer1.Panel1.Controls.Add(uiLblPushType);
            uiSplitContainer1.Panel1.Controls.Add(uiLblCommand);
            uiSplitContainer1.Panel1.Controls.Add(uiBtnGenerateLocalConfig);
            uiSplitContainer1.Panel1.Controls.Add(uiLblFilePath);
            uiSplitContainer1.Panel1.Controls.Add(uiBtnSubmit);
            uiSplitContainer1.Panel1.Controls.Add(uiLblServerPath);
            uiSplitContainer1.Panel1.Controls.Add(uiBtnSelectPath);
            uiSplitContainer1.Panel1.Controls.Add(uiLblApiKey);
            uiSplitContainer1.Panel1.Controls.Add(uiCmbCommand);
            uiSplitContainer1.Panel1.Controls.Add(uiTxtServerPath);
            uiSplitContainer1.Panel1.Controls.Add(uiTxtFilePath);
            uiSplitContainer1.Panel1.Controls.Add(uiTxtApiKey);
            // 
            // uiSplitContainer1.Panel2
            // 
            uiSplitContainer1.Panel2.Controls.Add(uiDgvFileLoad);
            uiSplitContainer1.Size = new Size(819, 562);
            uiSplitContainer1.SplitterDistance = 172;
            uiSplitContainer1.SplitterWidth = 11;
            uiSplitContainer1.TabIndex = 16;
            // 
            // uiLblNugetTip
            // 
            uiLblNugetTip.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblNugetTip.ForeColor = Color.Red;
            uiLblNugetTip.Location = new Point(11, 7);
            uiLblNugetTip.Name = "uiLblNugetTip";
            uiLblNugetTip.Size = new Size(518, 23);
            uiLblNugetTip.TabIndex = 0;
            uiLblNugetTip.Text = "命令：输入命令，关键词请使用占位符(只支持文件名+服务器地址)";
            uiLblNugetTip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiBtnShowPkgList
            // 
            uiBtnShowPkgList.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnShowPkgList.Location = new Point(651, 83);
            uiBtnShowPkgList.MinimumSize = new Size(1, 1);
            uiBtnShowPkgList.Name = "uiBtnShowPkgList";
            uiBtnShowPkgList.Radius = 29;
            uiBtnShowPkgList.Size = new Size(100, 35);
            uiBtnShowPkgList.TabIndex = 15;
            uiBtnShowPkgList.Text = "查看包列表";
            uiBtnShowPkgList.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnShowPkgList.Click += uiBtnShowPkgList_Click;
            // 
            // uiLblNugetTip2
            // 
            uiLblNugetTip2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblNugetTip2.ForeColor = Color.Black;
            uiLblNugetTip2.Location = new Point(11, 30);
            uiLblNugetTip2.Name = "uiLblNugetTip2";
            uiLblNugetTip2.Size = new Size(518, 23);
            uiLblNugetTip2.TabIndex = 1;
            uiLblNugetTip2.Text = "支持上传包含下级的文件";
            uiLblNugetTip2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLblPushType
            // 
            uiLblPushType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblPushType.ForeColor = Color.FromArgb(48, 48, 48);
            uiLblPushType.Location = new Point(520, 55);
            uiLblPushType.Name = "uiLblPushType";
            uiLblPushType.Size = new Size(87, 23);
            uiLblPushType.TabIndex = 14;
            uiLblPushType.Text = "上传方式：";
            uiLblPushType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLblCommand
            // 
            uiLblCommand.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblCommand.ForeColor = Color.Black;
            uiLblCommand.Location = new Point(14, 55);
            uiLblCommand.Name = "uiLblCommand";
            uiLblCommand.Size = new Size(92, 23);
            uiLblCommand.TabIndex = 2;
            uiLblCommand.Text = "命令:";
            uiLblCommand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiBtnGenerateLocalConfig
            // 
            uiBtnGenerateLocalConfig.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnGenerateLocalConfig.Location = new Point(692, 3);
            uiBtnGenerateLocalConfig.MinimumSize = new Size(1, 1);
            uiBtnGenerateLocalConfig.Name = "uiBtnGenerateLocalConfig";
            uiBtnGenerateLocalConfig.Radius = 35;
            uiBtnGenerateLocalConfig.Size = new Size(100, 35);
            uiBtnGenerateLocalConfig.TabIndex = 12;
            uiBtnGenerateLocalConfig.Text = "生成本地配置";
            uiBtnGenerateLocalConfig.Click += uiBtnGenerateLocalConfig_Click;
            // 
            // uiLblFilePath
            // 
            uiLblFilePath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblFilePath.ForeColor = Color.Black;
            uiLblFilePath.Location = new Point(11, 93);
            uiLblFilePath.Name = "uiLblFilePath";
            uiLblFilePath.Size = new Size(92, 23);
            uiLblFilePath.TabIndex = 3;
            uiLblFilePath.Text = "文件路径:";
            uiLblFilePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiBtnSubmit
            // 
            uiBtnSubmit.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnSubmit.Location = new Point(520, 123);
            uiBtnSubmit.MinimumSize = new Size(1, 1);
            uiBtnSubmit.Name = "uiBtnSubmit";
            uiBtnSubmit.Radius = 29;
            uiBtnSubmit.Size = new Size(123, 29);
            uiBtnSubmit.TabIndex = 10;
            uiBtnSubmit.Text = "上传";
            uiBtnSubmit.Click += uiBtnSubmit_Click;
            // 
            // uiLblServerPath
            // 
            uiLblServerPath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblServerPath.ForeColor = Color.Black;
            uiLblServerPath.Location = new Point(5, 128);
            uiLblServerPath.Name = "uiLblServerPath";
            uiLblServerPath.Size = new Size(98, 23);
            uiLblServerPath.TabIndex = 4;
            uiLblServerPath.Text = "服务器路径:";
            uiLblServerPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiBtnSelectPath
            // 
            uiBtnSelectPath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnSelectPath.Location = new Point(520, 87);
            uiBtnSelectPath.MinimumSize = new Size(1, 1);
            uiBtnSelectPath.Name = "uiBtnSelectPath";
            uiBtnSelectPath.Radius = 29;
            uiBtnSelectPath.Size = new Size(123, 29);
            uiBtnSelectPath.TabIndex = 9;
            uiBtnSelectPath.Text = "选择文件路径";
            uiBtnSelectPath.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnSelectPath.Click += uiBtnSelectPath_Click;
            // 
            // uiLblApiKey
            // 
            uiLblApiKey.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLblApiKey.ForeColor = Color.Black;
            uiLblApiKey.Location = new Point(272, 125);
            uiLblApiKey.Name = "uiLblApiKey";
            uiLblApiKey.Size = new Size(80, 23);
            uiLblApiKey.TabIndex = 5;
            uiLblApiKey.Text = "api Key:";
            uiLblApiKey.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiCmbCommand
            // 
            uiCmbCommand.DataSource = null;
            uiCmbCommand.FillColor = Color.White;
            uiCmbCommand.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCmbCommand.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiCmbCommand.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiCmbCommand.Location = new Point(111, 53);
            uiCmbCommand.Margin = new Padding(4, 5, 4, 5);
            uiCmbCommand.MinimumSize = new Size(63, 0);
            uiCmbCommand.Name = "uiCmbCommand";
            uiCmbCommand.Padding = new Padding(0, 0, 30, 2);
            uiCmbCommand.Size = new Size(394, 29);
            uiCmbCommand.TabIndex = 8;
            uiCmbCommand.TextAlignment = ContentAlignment.MiddleLeft;
            uiCmbCommand.Watermark = "";
            // 
            // uiTxtServerPath
            // 
            uiTxtServerPath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTxtServerPath.Location = new Point(111, 123);
            uiTxtServerPath.Margin = new Padding(4, 5, 4, 5);
            uiTxtServerPath.MinimumSize = new Size(1, 16);
            uiTxtServerPath.Name = "uiTxtServerPath";
            uiTxtServerPath.Padding = new Padding(5);
            uiTxtServerPath.ShowText = false;
            uiTxtServerPath.Size = new Size(150, 29);
            uiTxtServerPath.TabIndex = 6;
            uiTxtServerPath.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtServerPath.Watermark = "";
            // 
            // uiTxtFilePath
            // 
            uiTxtFilePath.Enabled = false;
            uiTxtFilePath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTxtFilePath.Location = new Point(111, 87);
            uiTxtFilePath.Margin = new Padding(4, 5, 4, 5);
            uiTxtFilePath.MinimumSize = new Size(1, 16);
            uiTxtFilePath.Name = "uiTxtFilePath";
            uiTxtFilePath.Padding = new Padding(5);
            uiTxtFilePath.ShowText = false;
            uiTxtFilePath.Size = new Size(396, 29);
            uiTxtFilePath.TabIndex = 7;
            uiTxtFilePath.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtFilePath.Watermark = "";
            uiTxtFilePath.TextChanged += uiTxtFilePath_TextChanged;
            // 
            // uiTxtApiKey
            // 
            uiTxtApiKey.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTxtApiKey.Location = new Point(357, 123);
            uiTxtApiKey.Margin = new Padding(4, 5, 4, 5);
            uiTxtApiKey.MinimumSize = new Size(1, 16);
            uiTxtApiKey.Name = "uiTxtApiKey";
            uiTxtApiKey.Padding = new Padding(5);
            uiTxtApiKey.ShowText = false;
            uiTxtApiKey.Size = new Size(150, 29);
            uiTxtApiKey.TabIndex = 7;
            uiTxtApiKey.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtApiKey.Watermark = "";
            // 
            // uiDgvFileLoad
            // 
            uiDgvFileLoad.AllowUserToAddRows = false;
            uiDgvFileLoad.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDgvFileLoad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDgvFileLoad.BackgroundColor = Color.White;
            uiDgvFileLoad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDgvFileLoad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDgvFileLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uiDgvFileLoad.ContextMenuStrip = uiCmsNugetGrdMenu;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDgvFileLoad.DefaultCellStyle = dataGridViewCellStyle8;
            uiDgvFileLoad.Dock = DockStyle.Fill;
            uiDgvFileLoad.EnableHeadersVisualStyles = false;
            uiDgvFileLoad.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvFileLoad.GridColor = Color.FromArgb(80, 160, 255);
            uiDgvFileLoad.Location = new Point(0, 0);
            uiDgvFileLoad.Name = "uiDgvFileLoad";
            uiDgvFileLoad.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDgvFileLoad.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvFileLoad.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDgvFileLoad.RowTemplate.Height = 25;
            uiDgvFileLoad.SelectedIndex = -1;
            uiDgvFileLoad.Size = new Size(819, 379);
            uiDgvFileLoad.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDgvFileLoad.TabIndex = 11;
            // 
            // uiCmsNugetGrdMenu
            // 
            uiCmsNugetGrdMenu.BackColor = Color.FromArgb(243, 249, 255);
            uiCmsNugetGrdMenu.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCmsNugetGrdMenu.Items.AddRange(new ToolStripItem[] { tsmiRemoveSelected, tsmiClearNugetList, tsmiRefreshNugetList });
            uiCmsNugetGrdMenu.Name = "uiCmsNugetGrdMenu";
            uiCmsNugetGrdMenu.Size = new Size(155, 70);
            // 
            // tsmiRemoveSelected
            // 
            tsmiRemoveSelected.Name = "tsmiRemoveSelected";
            tsmiRemoveSelected.Size = new Size(154, 22);
            tsmiRemoveSelected.Text = "移除选中行";
            tsmiRemoveSelected.Click += tsmiRemoveSelected_Click;
            // 
            // tsmiClearNugetList
            // 
            tsmiClearNugetList.Name = "tsmiClearNugetList";
            tsmiClearNugetList.Size = new Size(154, 22);
            tsmiClearNugetList.Text = "清空列表";
            tsmiClearNugetList.Click += tsmiClearNugetList_Click;
            // 
            // tsmiRefreshNugetList
            // 
            tsmiRefreshNugetList.Name = "tsmiRefreshNugetList";
            tsmiRefreshNugetList.Size = new Size(154, 22);
            tsmiRefreshNugetList.Text = "刷新列表";
            tsmiRefreshNugetList.Click += tsmiRefreshNugetList_Click;
            // 
            // uiTpHelp
            // 
            uiTpHelp.Controls.Add(uiRTxtHelp);
            uiTpHelp.Location = new Point(201, 0);
            uiTpHelp.Name = "uiTpHelp";
            uiTpHelp.Size = new Size(819, 562);
            uiTpHelp.TabIndex = 2;
            uiTpHelp.Text = "帮助";
            uiTpHelp.UseVisualStyleBackColor = true;
            // 
            // uiRTxtHelp
            // 
            uiRTxtHelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiRTxtHelp.Enabled = false;
            uiRTxtHelp.FillColor = Color.White;
            uiRTxtHelp.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiRTxtHelp.Location = new Point(3, 0);
            uiRTxtHelp.Margin = new Padding(4, 5, 4, 5);
            uiRTxtHelp.MinimumSize = new Size(1, 1);
            uiRTxtHelp.Name = "uiRTxtHelp";
            uiRTxtHelp.Padding = new Padding(2);
            uiRTxtHelp.ScrollBarStyleInherited = false;
            uiRTxtHelp.ShowText = false;
            uiRTxtHelp.Size = new Size(816, 561);
            uiRTxtHelp.TabIndex = 0;
            uiRTxtHelp.Text = resources.GetString("uiRTxtHelp.Text");
            uiRTxtHelp.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTpLog
            // 
            uiTpLog.Controls.Add(uiRichTextBox1);
            uiTpLog.Location = new Point(201, 0);
            uiTpLog.Name = "uiTpLog";
            uiTpLog.Size = new Size(819, 562);
            uiTpLog.TabIndex = 3;
            uiTpLog.Text = "日志";
            uiTpLog.UseVisualStyleBackColor = true;
            // 
            // uiRichTextBox1
            // 
            uiRichTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiRichTextBox1.Enabled = false;
            uiRichTextBox1.FillColor = Color.White;
            uiRichTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiRichTextBox1.Location = new Point(1, 0);
            uiRichTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiRichTextBox1.MinimumSize = new Size(1, 1);
            uiRichTextBox1.Name = "uiRichTextBox1";
            uiRichTextBox1.Padding = new Padding(2);
            uiRichTextBox1.ScrollBarStyleInherited = false;
            uiRichTextBox1.ShowText = false;
            uiRichTextBox1.Size = new Size(816, 561);
            uiRichTextBox1.TabIndex = 1;
            uiRichTextBox1.Text = "2024-04-03\n  Nuget=>展示列表只显示并上传最新的nuget文件\n";
            uiRichTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ssFootStatus
            // 
            ssFootStatus.Items.AddRange(new ToolStripItem[] { tsslCopyRight, tsslNowTime });
            ssFootStatus.Location = new Point(0, 575);
            ssFootStatus.Name = "ssFootStatus";
            ssFootStatus.Size = new Size(1020, 22);
            ssFootStatus.TabIndex = 3;
            ssFootStatus.Text = "statusStrip1";
            // 
            // tsslCopyRight
            // 
            tsslCopyRight.Name = "tsslCopyRight";
            tsslCopyRight.Size = new Size(0, 17);
            // 
            // tsslNowTime
            // 
            tsslNowTime.Name = "tsslNowTime";
            tsslNowTime.Size = new Size(0, 17);
            // 
            // tiNowTime
            // 
            tiNowTime.Tick += tiNowTime_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1020, 597);
            Controls.Add(ssFootStatus);
            Controls.Add(uiTcMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Style = Sunny.UI.UIStyle.Custom;
            Text = "源远流长:yyliucha.com v6.25";
            ZoomScaleRect = new Rectangle(15, 15, 672, 382);
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            uiTcMain.ResumeLayout(false);
            uiCmsMenu.ResumeLayout(false);
            uiTpDeZip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDgvFileInfo).EndInit();
            uiTpPushNugetPkg.ResumeLayout(false);
            uiSplitContainer1.Panel1.ResumeLayout(false);
            uiSplitContainer1.Panel2.ResumeLayout(false);
            uiSplitContainer1.EndInit();
            uiSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDgvFileLoad).EndInit();
            uiCmsNugetGrdMenu.ResumeLayout(false);
            uiTpHelp.ResumeLayout(false);
            uiTpLog.ResumeLayout(false);
            ssFootStatus.ResumeLayout(false);
            ssFootStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isDeResultDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private Sunny.UI.UITabControlMenu uiTcMain;
        private TabPage uiTpDeZip;
        private TabPage uiTpPushNugetPkg;
        private Sunny.UI.UIButton uiBtnOk;
        private Sunny.UI.UITextBox uiTxtSourcePath;
        private Sunny.UI.UILabel uiLblTarget;
        private Sunny.UI.UILabel uiLblSource;
        private Sunny.UI.UIDataGridView uiDgvFileInfo;
        private Sunny.UI.UILabel uiLblEndTip;
        private Sunny.UI.UIComboBox uiCbxEndType;
        private Sunny.UI.UIButton uiBtnDecompression;
        private Sunny.UI.UITextBox uiTxtTargetPath;
        private Sunny.UI.UIComboBox uiCmbCommand;
        private Sunny.UI.UITextBox uiTxtFilePath;
        private Sunny.UI.UITextBox uiTxtApiKey;
        private Sunny.UI.UITextBox uiTxtServerPath;
        private Sunny.UI.UILabel uiLblApiKey;
        private Sunny.UI.UILabel uiLblServerPath;
        private Sunny.UI.UILabel uiLblFilePath;
        private Sunny.UI.UILabel uiLblCommand;
        private Sunny.UI.UILabel uiLblNugetTip2;
        private Sunny.UI.UILabel uiLblNugetTip;
        private Sunny.UI.UIButton uiBtnSubmit;
        private Sunny.UI.UIButton uiBtnSelectPath;
        private Sunny.UI.UIDataGridView uiDgvFileLoad;
        private StatusStrip ssFootStatus;
        private ToolStripStatusLabel tsslCopyRight;
        private ToolStripStatusLabel tsslNowTime;
        private System.Windows.Forms.Timer tiNowTime;
        private Sunny.UI.UIContextMenuStrip uiCmsMenu;
        private ToolStripMenuItem tsmiChangeTheme;
        private Sunny.UI.UIButton uiBtnGenerateLocalConfig;
        private ToolStripMenuItem tsmiyyliucha;
        private Sunny.UI.UILabel uiLblPushType;
        private Sunny.UI.UIContextMenuStrip uiCmsNugetGrdMenu;
        private ToolStripMenuItem tsmiRemoveSelected;
        private ToolStripMenuItem tsmiClearNugetList;
        private ToolStripMenuItem tsmiRefreshNugetList;
        private TabPage uiTpHelp;
        private Sunny.UI.UIRichTextBox uiRTxtHelp;
        private TabPage uiTpLog;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UIButton uiBtnShowPkgList;
        private Sunny.UI.UISplitContainer uiSplitContainer1;
    }
}