using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yylcha.pub.model.redis;

namespace yylcha.pub.views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmPullCodeResult : UIForm
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmPullCodeResult(List<RedisPullResult> resultList)
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.uiDgvResult.DataSource = resultList;
            this.uiDgvResult.Columns[this.uiDgvResult.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


    }
}
