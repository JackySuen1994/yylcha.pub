namespace yylcha.pub
{
    partial class FrmNugetList
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
            uiTvNugetPkg = new Sunny.UI.UITreeView();
            uiDgvPkgDetail = new Sunny.UI.UIDataGridView();
            uiPnlLeft = new Sunny.UI.UIPanel();
            uiPnlRight = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)uiDgvPkgDetail).BeginInit();
            uiPnlLeft.SuspendLayout();
            uiPnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // uiTvNugetPkg
            // 
            uiTvNugetPkg.Dock = DockStyle.Fill;
            uiTvNugetPkg.FillColor = Color.White;
            uiTvNugetPkg.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTvNugetPkg.Location = new Point(0, 0);
            uiTvNugetPkg.Margin = new Padding(4, 5, 4, 5);
            uiTvNugetPkg.MinimumSize = new Size(1, 1);
            uiTvNugetPkg.Name = "uiTvNugetPkg";
            uiTvNugetPkg.ScrollBarStyleInherited = false;
            uiTvNugetPkg.ShowText = false;
            uiTvNugetPkg.Size = new Size(300, 454);
            uiTvNugetPkg.TabIndex = 0;
            uiTvNugetPkg.Text = "uiTreeView1";
            uiTvNugetPkg.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiDgvPkgDetail
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDgvPkgDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDgvPkgDetail.BackgroundColor = Color.White;
            uiDgvPkgDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDgvPkgDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDgvPkgDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDgvPkgDetail.DefaultCellStyle = dataGridViewCellStyle3;
            uiDgvPkgDetail.Dock = DockStyle.Fill;
            uiDgvPkgDetail.EnableHeadersVisualStyles = false;
            uiDgvPkgDetail.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvPkgDetail.GridColor = Color.FromArgb(80, 160, 255);
            uiDgvPkgDetail.Location = new Point(0, 0);
            uiDgvPkgDetail.Name = "uiDgvPkgDetail";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDgvPkgDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvPkgDetail.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDgvPkgDetail.RowTemplate.Height = 25;
            uiDgvPkgDetail.SelectedIndex = -1;
            uiDgvPkgDetail.Size = new Size(499, 454);
            uiDgvPkgDetail.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDgvPkgDetail.TabIndex = 1;
            // 
            // uiPnlLeft
            // 
            uiPnlLeft.Controls.Add(uiTvNugetPkg);
            uiPnlLeft.Dock = DockStyle.Left;
            uiPnlLeft.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPnlLeft.Location = new Point(0, 35);
            uiPnlLeft.Margin = new Padding(4, 5, 4, 5);
            uiPnlLeft.MinimumSize = new Size(1, 1);
            uiPnlLeft.Name = "uiPnlLeft";
            uiPnlLeft.Size = new Size(300, 454);
            uiPnlLeft.TabIndex = 4;
            uiPnlLeft.Text = "uiPanel1";
            uiPnlLeft.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPnlRight
            // 
            uiPnlRight.Controls.Add(uiDgvPkgDetail);
            uiPnlRight.Dock = DockStyle.Right;
            uiPnlRight.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPnlRight.Location = new Point(301, 35);
            uiPnlRight.Margin = new Padding(4, 5, 4, 5);
            uiPnlRight.MinimumSize = new Size(1, 1);
            uiPnlRight.Name = "uiPnlRight";
            uiPnlRight.Size = new Size(499, 454);
            uiPnlRight.TabIndex = 5;
            uiPnlRight.Text = "uiPanel2";
            uiPnlRight.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FrmNugetList
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 489);
            Controls.Add(uiPnlRight);
            Controls.Add(uiPnlLeft);
            Name = "FrmNugetList";
            Text = "源远流长:yyliucha.com";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)uiDgvPkgDetail).EndInit();
            uiPnlLeft.ResumeLayout(false);
            uiPnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITreeView uiTvNugetPkg;
        private Sunny.UI.UIDataGridView uiDgvPkgDetail;
        private Sunny.UI.UIPanel uiPnlLeft;
        private Sunny.UI.UIPanel uiPnlRight;
    }
}