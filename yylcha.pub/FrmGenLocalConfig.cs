using ServiceStack.Commands;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yylcha.pub.common;
using yylcha.pub.model.nugetM;

namespace yylcha.pub
{
    public partial class FrmGenLocalConfig : UIForm
    {
        #region 公共属性

        public static List<ExecuteCommandModel> commandList = new List<ExecuteCommandModel>();

        #endregion
        public FrmGenLocalConfig()
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

        /// <summary>
        /// 窗体load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGenLocalConfig_Load(object sender, EventArgs e)
        {
            commandList = tool.GetNugetModel();
            this.uiDgvLocalConfig.DataSource = commandList;
            this.RefreshGridViewStyle();
        }

        /// <summary>
        /// 新增行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ulBtnInsert_Click(object sender, EventArgs e)
        {
            commandList.Add(new ExecuteCommandModel() { ServicePath = string.Empty, Apikey = string.Empty, Command = string.Empty });
            this.uiDgvLocalConfig.DataSource = null;
            this.uiDgvLocalConfig.DataSource = commandList;
            this.RefreshGridViewStyle();
        }

        /// <summary>
        /// 删除行 删除的是聚焦行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnDel_Click(object sender, EventArgs e)
        {
            List<int> delList = new List<int>();
            for (int i = 0; i < this.uiDgvLocalConfig.Rows.Count; i++)
            {
                bool isSel = this.uiDgvLocalConfig.Rows[i].Cells[0].Selected;
                if (!isSel) continue;
                delList.Add(i);
            }
            if (delList.Count > 0)
            {
                List<ExecuteCommandModel> newCommandList = new List<ExecuteCommandModel>();

                foreach (var index in delList)
                {
                    for (int i = 0; i < commandList.Count; i++)
                    {
                        if (!index.Equals(i))
                        {
                            newCommandList.Add(commandList[i]);
                        }
                    }
                }
                commandList = newCommandList;
            }
            this.uiDgvLocalConfig.DataSource = null;
            this.uiDgvLocalConfig.DataSource = commandList;
            this.RefreshGridViewStyle();
        }

        /// <summary>
        /// 刷新列表样式
        /// </summary>
        private void RefreshGridViewStyle()
        {
            this.uiDgvLocalConfig.Columns["ServicePath"].Width = 150;
            this.uiDgvLocalConfig.Columns["ServicePath"].DisplayIndex = 0;

            this.uiDgvLocalConfig.Columns["Apikey"].Width = 120;
            this.uiDgvLocalConfig.Columns["Apikey"].DisplayIndex = 1;

            this.uiDgvLocalConfig.Columns["Command"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.uiDgvLocalConfig.Columns["Command"].DisplayIndex = 2;

            this.uiDgvLocalConfig.Refresh();
        }

        /// <summary>
        /// 移除所有配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnDelAll_Click(object sender, EventArgs e)
        {
            commandList.Clear();
            this.uiDgvLocalConfig.DataSource = null;
            this.uiDgvLocalConfig.DataSource = commandList;
            this.RefreshGridViewStyle();
            commandList = tool.ResetConfig();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateCell())
            {
                UIMessageBox.ShowWarning("数据验证不通过，请按照单元格提示调整！");
                return;
            }
            commandList = tool.SaveNugetConfig(commandList);
            this.uiDgvLocalConfig.DataSource = null;
            this.uiDgvLocalConfig.DataSource = commandList;
            this.RefreshGridViewStyle();

            bool result = UIMessageDialog.ShowAskDialog(this, "保存成功！是否关闭当前窗体？");
            if (result) this.Close();
        }

        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 列表校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool ValidateCell()
        {
            List<ExecuteCommandModel> saveData = this.uiDgvLocalConfig.DataSource as List<ExecuteCommandModel>;
            for (int i = 0; i < saveData.Count; i++)
            {
                var command = saveData[i].Command;
                if (string.IsNullOrEmpty(command))
                {
                    this.uiDgvLocalConfig.Rows[i].Cells["Command"].ErrorText = "Command 为空";
                }
                else if (!string.IsNullOrEmpty(command))
                {
                    if (saveData.Where(d => d.Command.Equals(command)).Count() > 1)
                    {
                        this.uiDgvLocalConfig.Rows[i].Cells["Command"].ErrorText = "Command 有重复";
                    }
                    else
                    {
                        this.uiDgvLocalConfig.Rows[i].Cells["Command"].ErrorText = string.Empty;
                    }
                }


                var servicePath = saveData[i].ServicePath;
                if (string.IsNullOrEmpty(servicePath))
                {
                    this.uiDgvLocalConfig.Rows[i].Cells["ServicePath"].ErrorText = "ServicePath 为空";
                }
                else
                {
                    this.uiDgvLocalConfig.Rows[i].Cells["ServicePath"].ErrorText = string.Empty;
                }

                var apiKey = saveData[i].Apikey;
                if (string.IsNullOrEmpty(apiKey))
                {
                    this.uiDgvLocalConfig.Rows[i].Cells["Apikey"].ErrorText = "Apikey 为空";
                }
                else
                {
                    this.uiDgvLocalConfig.Rows[i].Cells["Apikey"].ErrorText = string.Empty;
                }
            }

            bool isError = true; //默认没有错误
            //循环遍历检测是否有错误
            this.uiDgvLocalConfig.Rows.Cast<DataGridViewRow>()?.ToList()?.ForEach(row =>
            {
                if (!string.IsNullOrEmpty(row.Cells[0].ErrorText))
                {
                    isError = false;
                }
            });

            return isError;
        }

        /// <summary>
        /// 单元格修改后验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiDgvLocalConfig_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            this.ValidateCell();
        }

        /// <summary>
        /// 单元格修改时验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiDgvLocalConfig_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            this.ValidateCell();
        }
    }
}
