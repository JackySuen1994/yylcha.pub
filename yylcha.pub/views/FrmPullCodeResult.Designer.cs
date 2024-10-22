namespace yylcha.pub.views
{
    partial class FrmPullCodeResult
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiDgvResult = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)uiDgvResult).BeginInit();
            SuspendLayout();
            // 
            // uiDgvResult
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDgvResult.BackgroundColor = Color.White;
            uiDgvResult.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDgvResult.DefaultCellStyle = dataGridViewCellStyle8;
            uiDgvResult.Dock = DockStyle.Fill;
            uiDgvResult.EnableHeadersVisualStyles = false;
            uiDgvResult.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvResult.GridColor = Color.FromArgb(80, 160, 255);
            uiDgvResult.Location = new Point(0, 35);
            uiDgvResult.Name = "uiDgvResult";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDgvResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDgvResult.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDgvResult.RowTemplate.Height = 25;
            uiDgvResult.SelectedIndex = -1;
            uiDgvResult.Size = new Size(800, 415);
            uiDgvResult.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDgvResult.TabIndex = 0;
            // 
            // FrmPullCodeResult
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiDgvResult);
            Name = "FrmPullCodeResult";
            Text = "源远流长:yyliucha.com";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)uiDgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView uiDgvResult;
    }
}