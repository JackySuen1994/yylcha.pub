using ServiceStack;
using ServiceStack.Commands;
using ServiceStack.Redis;
using Sunny.UI;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
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
        /// 配置文件集合
        /// </summary>
        public static Dictionary<string, Feed> configDic = new Dictionary<string, Feed>();

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
        static List<string> themeList = new List<string>();

        static UIStyle selectStyle = UIStyle.Blue;
        #endregion

        #region 主窗体事件

        /// <summary>
        /// 主窗体
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.tsslCopyRight.Text = $"Copyright © 2024-{System.DateTime.Now.Year} yyliucha. All rights reserved.";

            //校验是否已经打开一个程序
            bool isOkOpen = true;
            Mutex mutex = new Mutex(true, this.Name, out isOkOpen);
            if (!isOkOpen)
            {
                UIMessageBox.ShowError("只能运行一个程序！");
                Environment.Exit(0);//退出程序
            }

            this.MaximizeBox = false;

            this.wvBlog.Source = new Uri("https://www.yyliucha.com");
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

            this.tiNowTime.Enabled = true;

            #endregion

            #region tabPage1

            this.Page1ControlIsShow(false);

            #endregion

            #region tabPage2

            commandList = tool.GetNugetModel();

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
            if (commandList != null)
            {
                if (commandList.Count > 0)
                {
                    commandList = commandList.Where(d => !string.IsNullOrEmpty(d.Command))?.ToList();
                }

                this.uiCmbCommand.Items.Clear();
                if (commandList.Count == 0)
                {
                    this.uiCmbCommand.Items.Add("dotnet nuget push {0} -k {1} -s {2}");
                }
                else
                {
                    foreach (var item in commandList.Select(d => d.Command).ToList().DistinctBy(d => d))
                    {

                        this.uiCmbCommand.Items.Add(item.ToString());
                    }
                }
                //有配置，控件隐藏
                this.Page2ControlIsShow(commandList.Count == 0);
            }

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
            selectStyle = uiStyle;
        }

        /// <summary>
        /// 跳转到博客
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiyyliucha_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://yyliucha.com/",
                UseShellExecute = true//用当前系统默认浏览器打开
            });
        }

        /// <summary>
        /// 快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int selIndex = this.uiTcMain.SelectedIndex;
            //根据点击的菜单，刷新对应的grid
            if (selIndex == 1)
            {
                if (e.KeyCode.Equals(Keys.F5))
                {
                    this.loadFileInfo();//刷新nuget列表
                }
                if (e.Control && e.KeyCode.Equals(Keys.Delete))
                {
                    this.clearNugetList();//清空nuget列表
                }
                if (e.Control && e.KeyCode.Equals(Keys.S))
                {
                    this.submitNuget();
                }
                if (e.Control && e.KeyCode.Equals(Keys.O))
                {
                    this.uiBtnSelectPath.PerformClick();//模拟点击选择文件路径按钮
                }
            }
        }

        /// <summary>
        /// menu单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tcM = sender as UITabControlMenu;
            int selIndex = tcM.SelectedIndex;
            if (selIndex == 1)//tabIndex为1表示为nuget页签
            {
                UIProcessBar uiProcessBar = new UIProcessBar
                {
                    Maximum = 10,
                    Visible = false
                };

                uiProcessBar.Visible = true;
                Task.Run(() =>
                {
                    getNugetPkgs();//读取服务器packages集合

                    Invoke(new Action(() =>
                    {
                        uiProcessBar.Visible = true;
                        uiProcessBar.Value = 4;
                        uiProcessBar.Text = "准备请求获取服务器包";
                    }));

                    Invoke(new Action(() =>
                    {
                        uiProcessBar.Value = 4;
                        uiProcessBar.Text = "获取服务器包成功";
                    }));
                    Task.Delay(20000).Wait();

                    Invoke(new Action(() => uiProcessBar.Value = 7));//进度条调整到读取配置的位置
                    Task.Delay(20000).Wait();

                    Invoke(new Action(() => uiProcessBar.Value = 10));//进度条调整到读取配置的位置
                    Invoke(new Action(() => uiProcessBar.Visible = false));//关闭进度条

                    Application.DoEvents();//确保UI及时更新
                });
            }
        }

        /// <summary>
        /// 检测粘贴板
        /// 2024-3-1 16:56:30 只适配nuget tab
        /// </summary>
        private bool CheckClipboard()
        {
            bool isClickOk = true;
            int selIndex = this.uiTcMain.SelectedIndex;
            if (Clipboard.ContainsText())
            {
                string filePath = this.uiTxtFilePath.Text;
                string clipboardTxt = Clipboard.GetText();
                if (!string.IsNullOrEmpty(clipboardTxt) && Path.IsPathRooted(clipboardTxt) && !filePath.Equals(clipboardTxt))
                {
                    bool isOk = UIMessageDialog.ShowAskDialog(this, "检测到你有copy文件路径，是否带入？");
                    if (isOk)
                    {
                        this.uiTxtFilePath.Text = clipboardTxt;
                        isClickOk = false;
                    }
                }
            }
            return isClickOk;
        }

        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool result = UIMessageDialog.ShowAskDialog(this, "确定要退出yyliucha吗？");
            if (result) Environment.Exit(0);
            else e.Cancel = true;
        }

        /// <summary>
        /// 页面关闭后,释放浏览器资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.wvBlog.Dispose();
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
                UIMessageBox.ShowWarning("请输入需要解析的文件路径！");
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
                UIMessageBox.ShowWarning("文件夹中没有待解析的文件！");
            }

            this.uiDgvFileInfo.DataSource = deZipList;
            this.Page1ControlIsShow(true);
            this.uiCbxEndType.SelectedIndex = 0;

            this.uiDgvFileInfo.DataSource = pushList;
            this.uiDgvFileInfo.Columns["FileName"].Width = 100;
            this.uiDgvFileInfo.Columns["FileName"].DisplayIndex = 0;

            this.uiDgvFileInfo.Columns["IsDeResult"].Width = 80;
            this.uiDgvFileInfo.Columns["IsDeResult"].DisplayIndex = 1;

            this.uiDgvFileInfo.Columns["Path"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                UIMessageBox.ShowWarning("请输入压缩路径！");
                return;
            }
            if (deZipList.FirstOrDefault().IsDeResult.Equals("解析成功"))
            {
                UIMessageBox.ShowWarning("已经解析过，不可重复解析！");
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
        private void ExecuteCommand(string commandStr, string apiKey, string serverPath, PushNugetModel pItem)
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

            uiDgvFileLoad.Refresh();
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
            bool isOpenDialog = this.CheckClipboard();
            if (!isOpenDialog) return;
            string path = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            string defPath = this.uiTxtFilePath.Text;//如果文件路径有地址，则默认打开文件路径中的地址
            if (!string.IsNullOrEmpty(defPath))
            {
                fbd.SelectedPath = defPath;
            }
            else
            {
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//默认起始路径-桌面
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            this.uiTxtFilePath.Text = path;
        }

        /// <summary>
        /// 上传事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnSubmit_Click(object sender, EventArgs e)
        {
            this.submitNuget();
        }

        /// <summary>
        /// 上传nuget包
        /// </summary>
        private void submitNuget()
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
                    UIMessageBox.ShowWarning("选中项在基础数据源中不存在，请验证是否有正确录入配置(xml/redis)");
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
                UIMessageBox.ShowWarning("请输入必填项！");
                return;
            }

            this.loadFileInfo();
            if (this.pushList.Count() > 0)
            {
                bool result = UIMessageDialog.ShowAskDialog(this, "是否上传？");
                if (result)
                {
                    foreach (var pItem in pushList)
                    {
                        Task.Run(() =>
                        {
                            ExecuteCommand(commandStr, apiKey, serverPath, pItem);
                        });
                    }
                }
            }
        }

        /// <summary>
        /// 加载文件目录
        /// </summary>
        /// <param name="filePath"></param>
        private void loadFileInfo()
        {
            var filePath = this.uiTxtFilePath.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                UIMessageBox.ShowWarning("请填写文件路径！");
                return;
            }

            if (Directory.Exists(filePath))
            {
                pushList.Clear();
                this.uiDgvFileLoad.DataSource = null;
                string[] files = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);

                if (files.Length == 0)
                {
                    UIMessageBox.ShowWarning("文件目录下没有文件！");
                }
                else
                {
                    Dictionary<string, DateTime> fileDic = new Dictionary<string, DateTime>();
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
                                PushResult = "暂未推送",
                                CreateTime = File.GetCreationTime(file)
                            });
                        }
                    }
                }
                if (pushList.Count > 0)
                {
                    PushNugetModel model = pushList.OrderByDescending(d => d.CreateTime)?.FirstOrDefault();
                    pushList.Clear();
                    pushList.Add(model);
                    this.uiDgvFileLoad.DataSource = pushList;
                    this.uiDgvFileLoad.Columns["FileName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    this.uiDgvFileLoad.Columns["FileName"].DisplayIndex = 0;

                    this.uiDgvFileLoad.Columns["PushResult"].Width = 100;
                    this.uiDgvFileLoad.Columns["PushResult"].DisplayIndex = 1;

                    this.uiDgvFileLoad.Columns["FilePath"].Width = 100;
                    this.uiDgvFileLoad.Columns["FilePath"].DisplayIndex = 2;
                }
                else
                {
                    UIMessageBox.ShowError("未找到需要上传的nuget包！");
                }
            }
            else
            {
                UIMessageBox.ShowError("文件路径不存在！");
            }
        }

        /// <summary>
        /// 清空nuget列表
        /// </summary>
        private void clearNugetList()
        {
            if (this.uiDgvFileLoad.DataSource != null)
            {
                this.uiDgvFileLoad.DataSource = new List<PushNugetModel>();
            }
        }

        /// <summary>
        /// 生成本地配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiBtnGenerateLocalConfig_Click(object sender, EventArgs e)
        {
            FrmGenLocalConfig frmGen = new FrmGenLocalConfig();//子窗体沿用父窗体样式
            frmGen.ShowForm(selectStyle);
            this.Form1_Load(sender, e);
        }

        /// <summary>
        /// 通过配置文件，读取对应服务器上的nuget所有版本包
        /// </summary>
        private async void getNugetPkgs()
        {
            List<ExecuteCommandModel> defConfigList = tool.GetNugetModel();

            redisTools.Init();
            isRedis = redisTools.RedisConnectionIsOk();
            if (isRedis)
            {
                List<ExecuteCommandModel> redisList = redisTools.GetCommandModels();
                if (redisList != null && redisList.Count > 0)
                {
                    defConfigList = defConfigList.Union(redisList)?.ToList();//合并去重
                }
            }
            if (defConfigList != null && defConfigList.Count > 0)
            {
                defConfigList = defConfigList.Where(d => !string.IsNullOrEmpty(d.Command))?.ToList();
            }

            if (defConfigList != null && defConfigList.Count > 0)
            {
                foreach (var config in defConfigList)
                {
                    if (string.IsNullOrEmpty(config.ServicePath)) continue;

                    //HttpClient client = new HttpClient();
                    //string response = await client.GetStringAsync(Path.Combine(config.ServicePath, "nuget/Packages"));
                    //if (!string.IsNullOrEmpty(response) && !configDic.ContainsKey(config.ServicePath))
                    //{
                    //    XmlSerializer serializer = new XmlSerializer(typeof(Feed));
                    //    using (StringReader sr = new StringReader(response))
                    //    {
                    //        Feed feed = (Feed)serializer.Deserialize(sr);
                    //        configDic.Add(config.ServicePath, feed);
                    //    }
                    //}
                }
            }
        }

        /// <summary>
        /// 移除选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRemoveSelected_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 清空nuget列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiClearNugetList_Click(object sender, EventArgs e)
        {
            this.clearNugetList();
        }

        /// <summary>
        /// 刷新nuget列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRefreshNugetList_Click(object sender, EventArgs e)
        {
            this.loadFileInfo();
        }

        /// <summary>
        /// 当文件路径发生改变，则自动刷新列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTxtFilePath_TextChanged(object sender, EventArgs e)
        {
            this.loadFileInfo();//刷新nuget列表
        }

        private void uiBtnShowPkgList_Click(object sender, EventArgs e)
        {
            string commandStr = this.uiCmbCommand.Text;
            string servicePath = commandList.Where(d => d.Command.Equals(commandStr))?.SingleOrDefault()?.ServicePath;
            if (string.IsNullOrEmpty(servicePath))
            {
                UIMessageBox.ShowWarning("未读取到正确的服务器地址!请查看配置");
                return;
            }
            FrmNugetList frmNuget = new FrmNugetList(servicePath);
            frmNuget.ShowForm(selectStyle);
        }

        #endregion

    }
}