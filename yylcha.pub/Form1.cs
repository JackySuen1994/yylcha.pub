using ServiceStack;
using Sunny.UI;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Text;
using yylcha.pub.common;
using yylcha.pub.model.nugetM;
using yylcha.pub.model.zip;

namespace yylcha.pub
{
    public partial class Form1 : UIForm
    {
        #region 公共属性

        /// <summary>
        /// 读取本地文件/redis的默认配置集合
        /// </summary>
        public static List<ExecuteCommandModel> commandList = new List<ExecuteCommandModel>();

        /// <summary>
        /// 判定redis是否有配置
        /// </summary>
        bool isRedis = false;

        /// <summary>
        /// cmd进程初始化
        /// </summary>
        static ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            CreateNoWindow = true,
            UseShellExecute = false
        };

        /// <summary>
        /// 主题颜色字典
        /// </summary>
        static List<string> themeList = new List<string> ();

        #endregion

        #region 主窗体事件

        public Form1()
        {
            InitializeComponent();
            commandList = tool.GetNugetModel();
            this.tsslCopyRight.Text = $"Copyright © 2024-{System.DateTime.Now.Year} yyliucha. All rights reserved.";

        }

        /// <summary>
        /// form1 load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            #region main

            themeList.Add("Green");
            themeList.Add("Orange");
            themeList.Add("Red");
            themeList.Add("Purple");
            themeList.Add("Gray");
            themeList.Add("Black");
            themeList.Add("Default");

            this.ChangeTheme();//初始化主题菜单数据源
            #endregion

            #region tabPage1

            this.Page1ControlIsShow(false);

            #endregion

            #region tabPage2

            redisTools.Init();
            isRedis = redisTools.RedisConnectionIsOk();
            if (isRedis)
            {
                List<ExecuteCommandModel> redisList = redisTools.GetCommandModels();
                if (redisList != null && redisList.Count > 0)
                {
                    commandList = commandList.Union(redisList)?.ToList();//合并去重
                }
            }
            if (commandList.Count > 0)
            {
                commandList = commandList.Where(d => !string.IsNullOrEmpty(d.Command))?.ToList();
            }
            if (commandList.Count == 0)
            {
                this.uiCmbCommand.Items.Add("dotnet nuget push {0} -k {1} -s {2}");
            }
            //有配置，控件隐藏
            this.Page2ControlIsShow(commandList.Count == 0);
            if (this.uiCmbCommand.Items.Count > 0)
            {
                this.uiCmbCommand.SelectedIndex = 0;
            }

            #endregion
        }

        /// <summary>
        /// time tick事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tiNowTime_Tick(object sender, EventArgs e)
        {
            this.tsslNowTime.Text = $"当前系统时间：{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
        }

        /// <summary>
        /// 初始化菜单栏 更改主题数据源
        /// </summary>
        private void ChangeTheme()
        {
            foreach (var theme in themeList)
            {
                this.tsmiChangeTheme.DropDownItems.Add(theme);
            }
        }

        #endregion

        #region tabPage1

        /// <summary>
        /// 解析事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnOk_Click(object sender, EventArgs e)
        {
            string sourcePath = this.uiTxtSourcePath.Text;
            if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("请输入需要解析的文件路径！");
                return;
            }

            List<DeZipModel> deZipList = new List<DeZipModel>();
            DirectoryInfo folder = new DirectoryInfo(sourcePath);
            foreach (FileInfo file in folder.GetFiles("*.*", SearchOption.TopDirectoryOnly))
            {
                var fileType = System.IO.Path.GetExtension(file.FullName).ToLower();
                if (fileType.Equals(".zip"))
                {
                    deZipList.Add(new DeZipModel()
                    {
                        FileName = file.Name,
                        Path = file.FullName
                    });
                }
            }

            if (deZipList.Count == 0)
            {
                MessageBox.Show("文件夹中没有待解析的文件");
            }

            this.uiDgvFileInfo.DataSource = deZipList;
            this.Page1ControlIsShow(true);
            this.uiCbxEndType.SelectedIndex = 0;

            this.uiDgvFileInfo.DataSource = pushList;
            this.uiDgvFileInfo.Columns["FileName"].Width = 100;
            this.uiDgvFileInfo.Columns["FileName"].DisplayIndex = 0;

            this.uiDgvFileInfo.Columns["IsDeResult"].Width = 80;
            this.uiDgvFileInfo.Columns["IsDeResult"].DisplayIndex = 1;

            this.uiDgvFileInfo.Columns["Path"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.uiDgvFileInfo.Columns["Path"].DisplayIndex = 2;
        }

        /// <summary>
        /// 解压事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnDecompression_Click(object sender, EventArgs e)
        {
            string sourcePath = this.uiTxtSourcePath.Text;
            string backPath = Path.Combine(sourcePath, "backfile", tool.GetTimeSpan());
            List<DeZipModel> deZipList = (List<DeZipModel>)this.uiDgvFileInfo.DataSource;
            string targetPath = this.uiTxtTargetPath.Text;
            if (string.IsNullOrEmpty(targetPath))
            {
                MessageBox.Show("请输入压缩路径！");
                return;
            }
            if (deZipList.FirstOrDefault().IsDeResult.Equals("解析成功"))
            {
                MessageBox.Show("已经解析过，不可重复解析");
                return;
            }
            //0 备份 1 删除 2 保留
            int endType = this.uiCbxEndType.SelectedIndex;
            foreach (var item in deZipList)
            {
                try
                {
                    using (ZipArchive archive = ZipFile.OpenRead(item.Path))
                    {
                        // 遍历zip文件中的每个文件
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {

                            // 创建文件保存路径
                            string fullPath = Path.Combine(targetPath, entry.FullName);

                            // 创建文件夹
                            if (entry.FullName.EndsWith("/"))
                            {
                                Directory.CreateDirectory(fullPath);
                                continue;
                            }

                            // 创建文件流
                            using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
                            {
                                // 复制zip文件的流到文件流中
                                using (Stream stream = entry.Open())
                                {
                                    stream.CopyTo(fileStream);
                                }
                            }
                        }

                        archive.Dispose();
                    }
                    switch (endType)
                    {
                        case 0:
                            if (!Directory.Exists(backPath))
                            {
                                Directory.CreateDirectory(backPath);
                            }
                            Directory.Move(item.Path, Path.Combine(backPath, item.FileName));
                            break;
                        case 2: break;
                        default: break;
                    }
                    item.IsDeResult = "解析成功";
                }
                catch (Exception ex)
                {
                    item.IsDeResult = "解析失败:" + ex.Message;
                }
            }
            if (endType == 1)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(sourcePath);
                directoryInfo.Delete(true);
            }
            this.uiDgvFileInfo.Refresh();
        }

        /// <summary>
        /// page1控件显示与隐藏
        /// </summary>
        /// <param name="isShow"></param>
        private void Page1ControlIsShow(bool isShow)
        {
            this.uiLblTarget.Visible = isShow;
            this.uiTxtTargetPath.Visible = isShow;
            this.uiBtnDecompression.Visible = isShow;
            this.uiDgvFileInfo.Visible = isShow;
            this.uiCbxEndType.Visible = isShow;
            this.uiLblEndTip.Visible = isShow;
        }
        #endregion

        #region tabPage2

        private List<PushNugetModel> pushList = new List<PushNugetModel>();

        /// <summary>
        /// 异步执行cmd命令
        /// </summary>
        /// <param name="commandStr"></param>
        /// <param name="apiKey"></param>
        /// <param name="serverPath"></param>
        /// <param name="pItem"></param>
        private async void ExecuteCommand(string commandStr, string apiKey, string serverPath, PushNugetModel pItem)
        {
            string command = string.Format(commandStr, pItem.FilePath, apiKey, serverPath);
            using (Process process = new Process { StartInfo = psi })
            {
                process.StartInfo.Arguments = $"/c {command} /n";
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.Start();
                string commandResult = process.StandardOutput.ReadToEnd();
                if (commandResult.IndexOf("已推送包") > -1)
                {
                    pItem.PushResult = "已推送包";
                }
                else
                {
                    pItem.PushResult = commandResult;
                }
            }

            this.uiDgvFileLoad.Refresh();
        }

        /// <summary>
        /// 控制控件显示与隐藏
        /// </summary>
        /// <param name="isShow"></param>
        private void Page2ControlIsShow(bool isShow)
        {

            this.uiLblServerPath.Visible = isShow;
            this.uiTxtServerPath.Visible = isShow;
            this.uiLblApiKey.Visible = isShow;
            this.uiTxtApiKey.Visible = isShow;
        }

        /// <summary>
        /// 选择本地文件 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnSelectPath_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            this.uiTxtFilePath.Text = path;
        }
        private void uiBtnSubmit_Click(object sender, EventArgs e)
        {

            var commandStr = this.uiCmbCommand.SelectedItem.ToString() ?? "";
            var filePath = this.uiTxtFilePath.Text;
            var serverPath = string.Empty;
            var apiKey = string.Empty;
            //如果redis/本地的xml文件中有配置，则读取配置，原本需要录入的控件隐藏
            //如果配置文件中录入的是空，则对应的控件会显示
            if (commandList.Count > 0)
            {
                ExecuteCommandModel commandModel = commandList.Where(d => d.Command.Equals(commandStr))?.SingleOrDefault();
                if (commandModel == null)
                {
                    MessageBox.Show("选中项在基础数据源中不存在，请验证是否有正确录入配置(xml/redis)");
                    return;
                }
                else
                {
                    serverPath = commandModel.ServicePath;
                    apiKey = commandModel.Apikey;
                }
            }
            else
            {
                serverPath = this.uiTxtServerPath.Text;
                apiKey = this.uiTxtApiKey.Text;
            }
            if (string.IsNullOrEmpty(commandStr) || string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(serverPath) || string.IsNullOrEmpty(apiKey))
            {
                this.Page2ControlIsShow(true);
                MessageBox.Show("请输入必填项！");
                return;
            }

            if (Directory.Exists(filePath))
            {
                pushList.Clear();
                this.uiDgvFileLoad.DataSource = null;
                string[] files = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);

                if (files.Length == 0)
                {
                    MessageBox.Show("文件目录下没有文件！");
                }
                else
                {
                    foreach (var file in files)
                    {
                        string fileName = file.Substring(file.LastIndexOf('\\') + 1);

                        string suffix = fileName.Substring(fileName.LastIndexOf('.') + 1);
                        if (string.IsNullOrEmpty(suffix))
                            continue;
                        if (suffix.Equals("nupkg"))
                        {
                            pushList.Add(new PushNugetModel()
                            {
                                FileName = fileName,
                                FilePath = file,
                                PushResult = "暂未推送"
                            });
                        }
                    }

                    if (pushList.Count > 0)
                    {
                        this.uiDgvFileLoad.DataSource = pushList;
                        this.uiDgvFileLoad.Columns["FileName"].Width = 100;
                        this.uiDgvFileLoad.Columns["FileName"].DisplayIndex = 0;

                        this.uiDgvFileLoad.Columns["PushResult"].Width = 80;
                        this.uiDgvFileLoad.Columns["PushResult"].DisplayIndex = 1;

                        this.uiDgvFileLoad.Columns["FilePath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        this.uiDgvFileLoad.Columns["FilePath"].DisplayIndex = 2;


                        DialogResult result = MessageBox.Show("是否上传？", "上传提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result.Equals(DialogResult.Yes))
                        {
                            foreach (var pItem in pushList)
                            {
                                ExecuteCommand(commandStr, apiKey, serverPath, pItem);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到需要上传的nuget包");
                    }
                }
            }
            else
            {
                MessageBox.Show("文件路径不存在");
            }
        }


        #endregion

        /// <summary>
        /// 更改主题 单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiChangeTheme_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var selectTheme = e.ClickedItem.Text;
            UIStyle uiStyle = UIStyle.Blue;
            switch (selectTheme)
            {
                case "Green":
                    uiStyle = UIStyle.Green;
                    break;
                case "Orange":
                    uiStyle = UIStyle.Orange;
                    break;
                case "Red":
                    uiStyle = UIStyle.Red;
                    break;
                case "Purple":
                    uiStyle = UIStyle.Purple;
                    break;
                case "Gray":
                    uiStyle = UIStyle.Gray;
                    break;
                case "Black":
                    uiStyle = UIStyle.Black;
                    break;
                default:
                    uiStyle = UIStyle.Blue;
                    break;
            }
            this.Style = uiStyle;
        }
    }
}