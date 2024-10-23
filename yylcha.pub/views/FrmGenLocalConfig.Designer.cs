namespace yylcha.pub.views
{
    partial class FrmGenLocalConfig
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiDgvLocalConfig = new Sunny.UI.UIDataGridView();
            uiPanel1 = new Sunny.UI.UIPanel();
            ulBtnInsert = new Sunny.UI.UIButton();
            uiBtnDel = new Sunny.UI.UIButton();
            uiBtnDelAll = new Sunny.UI.UIButton();
            uiBtnClose = new Sunny.UI.UIButton();
            uiBtnSave = new Sunny.UI.UIButton();
            uiLabel1 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)uiDgvLocalConfig).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiDgvLocalConfig
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDgvLocalConfig.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDgvLocalConfig.BackgroundColor = Color.White;
            uiDgvLocalConfig.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDgvLocalConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDgvLocalConfig.ColumnHeadersHeight = 32;
            uiDgvLocalConfig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDgvLocalConfig.DefaultCellStyle = dataGridViewCellStyle3;
            uiDgvLocalConfig.Dock = DockStyle.Fill;
            uiDgvLocalConfig.EnableHeadersVisualStyles = false;
            uiDgvLocalConfig.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvLocalConfig.GridColor = Color.FromArgb(80, 160, 255);
            uiDgvLocalConfig.Location = new Point(0, 0);
            uiDgvLocalConfig.Name = "uiDgvLocalConfig";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDgvLocalConfig.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvLocalConfig.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDgvLocalConfig.RowTemplate.Height = 25;
            uiDgvLocalConfig.SelectedIndex = -1;
            uiDgvLocalConfig.Size = new Size(705, 308);
            uiDgvLocalConfig.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDgvLocalConfig.TabIndex = 0;
            uiDgvLocalConfig.CellValidated += uiDgvLocalConfig_CellValidated;
            uiDgvLocalConfig.CellValidating += uiDgvLocalConfig_CellValidating;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiDgvLocalConfig);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(3, 79);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(705, 308);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ulBtnInsert
            // 
            ulBtnInsert.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ulBtnInsert.Location = new Point(7, 38);
            ulBtnInsert.MinimumSize = new Size(1, 1);
            ulBtnInsert.Name = "ulBtnInsert";
            ulBtnInsert.Radius = 35;
            ulBtnInsert.Size = new Size(100, 35);
            ulBtnInsert.TabIndex = 2;
            ulBtnInsert.Text = "新增一行";
            ulBtnInsert.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ulBtnInsert.Click += ulBtnInsert_Click;
            // 
            // uiBtnDel
            // 
            uiBtnDel.FillColor = Color.Red;
            uiBtnDel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnDel.Location = new Point(123, 38);
            uiBtnDel.MinimumSize = new Size(1, 1);
            uiBtnDel.Name = "uiBtnDel";
            uiBtnDel.Radius = 35;
            uiBtnDel.Size = new Size(100, 35);
            uiBtnDel.TabIndex = 3;
            uiBtnDel.Text = "删除选中";
            uiBtnDel.Click += uiBtnDel_Click;
            // 
            // uiBtnDelAll
            // 
            uiBtnDelAll.FillColor = Color.Red;
            uiBtnDelAll.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnDelAll.Location = new Point(239, 38);
            uiBtnDelAll.MinimumSize = new Size(1, 1);
            uiBtnDelAll.Name = "uiBtnDelAll";
            uiBtnDelAll.Radius = 35;
            uiBtnDelAll.Size = new Size(100, 35);
            uiBtnDelAll.TabIndex = 4;
            uiBtnDelAll.Text = "移除所有配置";
            uiBtnDelAll.Click += uiBtnDelAll_Click;
            // 
            // uiBtnClose
            // 
            uiBtnClose.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnClose.Location = new Point(358, 395);
            uiBtnClose.MinimumSize = new Size(1, 1);
            uiBtnClose.Name = "uiBtnClose";
            uiBtnClose.Radius = 35;
            uiBtnClose.Size = new Size(100, 35);
            uiBtnClose.TabIndex = 5;
            uiBtnClose.Text = "关闭";
            uiBtnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnClose.Click += uiBtnClose_Click;
            // 
            // uiBtnSave
            // 
            uiBtnSave.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnSave.Location = new Point(225, 395);
            uiBtnSave.MinimumSize = new Size(1, 1);
            uiBtnSave.Name = "uiBtnSave";
            uiBtnSave.Radius = 35;
            uiBtnSave.Size = new Size(100, 35);
            uiBtnSave.TabIndex = 6;
            uiBtnSave.Text = "\u007f保存";
            uiBtnSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiBtnSave.Click += uiBtnSave_Click;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.Red;
            uiLabel1.Location = new Point(516, 398);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(172, 23);
            uiLabel1.TabIndex = 7;
            uiLabel1.Text = "列表默认会有一条数据";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmGenLocalConfig
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(709, 450);
            Controls.Add(uiLabel1);
            Controls.Add(uiBtnSave);
            Controls.Add(uiBtnClose);
            Controls.Add(uiBtnDelAll);
            Controls.Add(uiBtnDel);
            Controls.Add(ulBtnInsert);
            Controls.Add(uiPanel1);
            Name = "FrmGenLocalConfig";
            Text = "源远流长:yyliucha.com";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmGenLocalConfig_Load;
            ((System.ComponentModel.ISupportInitialize)uiDgvLocalConfig).EndInit();
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView uiDgvLocalConfig;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton ulBtnInsert;
        private Sunny.UI.UIButton uiBtnDel;
        private Sunny.UI.UIButton uiBtnDelAll;
        private Sunny.UI.UIButton uiBtnClose;
        private Sunny.UI.UIButton uiBtnSave;
        private Sunny.UI.UILabel uiLabel1;
    }
}