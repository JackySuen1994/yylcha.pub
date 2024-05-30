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

namespace yylcha.pub
{
    public partial class FrmNugetList  : UIForm
    {
        /// <summary>
        /// 服务器包的列表展示窗体
        /// </summary>
        public FrmNugetList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        /// <param name="style"></param>
        public void ShowForm(UIStyle style)
        {
            this.Style = style;
            this.ShowDialog();
        }
    }
}
