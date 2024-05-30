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
            ((System.ComponentModel.ISupportInitialize)uiDgvPkgDetail).BeginInit();
            SuspendLayout();
            // 
            // uiTvNugetPkg
            // 
            uiTvNugetPkg.FillColor = Color.White;
            uiTvNugetPkg.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTvNugetPkg.Location = new Point(4, 40);
            uiTvNugetPkg.Margin = new Padding(4, 5, 4, 5);
            uiTvNugetPkg.MinimumSize = new Size(1, 1);
            uiTvNugetPkg.Name = "uiTvNugetPkg";
            uiTvNugetPkg.ScrollBarStyleInherited = false;
            uiTvNugetPkg.ShowText = false;
            uiTvNugetPkg.Size = new Size(270, 405);
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
            uiDgvPkgDetail.EnableHeadersVisualStyles = false;
            uiDgvPkgDetail.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvPkgDetail.GridColor = Color.FromArgb(80, 160, 255);
            uiDgvPkgDetail.Location = new Point(277, 42);
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
            uiDgvPkgDetail.Size = new Size(520, 403);
            uiDgvPkgDetail.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDgvPkgDetail.TabIndex = 1;
            // 
            // FrmNugetList
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiDgvPkgDetail);
            Controls.Add(uiTvNugetPkg);
            Name = "FrmNugetList";
            Text = "FrmNugetList";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)uiDgvPkgDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITreeView uiTvNugetPkg;
        private Sunny.UI.UIDataGridView uiDgvPkgDetail;
    }
}