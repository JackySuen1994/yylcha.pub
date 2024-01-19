using System.Diagnostics;
using System.IO.Compression;
using System.Text;
using yylcha.pub.common;
using yylcha.pub.model;

namespace yylcha.pub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region tabPage1

        private void btnOk_Click(object sender, EventArgs e)
        {
            string sourcePath = this.txtSourcePath.Text;
            if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("��������Ҫ�������ļ�·����");
                return;
            }

            List<DeZipModel> deZipList = new List<DeZipModel>();
            DirectoryInfo folder = new DirectoryInfo(sourcePath);
            foreach (FileInfo file in folder.GetFiles("*.*", SearchOption.TopDirectoryOnly))
            {
                deZipList.Add(new DeZipModel()
                {
                    FileName = file.Name,
                    Path = file.FullName
                });
            }

            if (deZipList.Count == 0)
            {
                MessageBox.Show("�ļ�����û�д��������ļ�");
            }
            this.dgvFileInfo.DataSource = deZipList;
            this.lblTarget.Visible = true;
            this.txtTargetPath.Visible = true;
            this.btnDecompression.Visible = true;
            this.dgvFileInfo.Visible = true;
            this.cbxEndType.Visible = true;
            this.cbxEndType.SelectedIndex = 0;
            this.lblEndTip.Visible = true;
        }

        private void btnDecompression_Click(object sender, EventArgs e)
        {
            string sourcePath = this.txtSourcePath.Text;
            string backPath = Path.Combine(sourcePath, "backfile", tool.GetTimeSpan());
            List<DeZipModel> deZipList = (List<DeZipModel>)this.dgvFileInfo.DataSource;
            string targetPath = this.txtTargetPath.Text;
            if (string.IsNullOrEmpty(targetPath))
            {
                MessageBox.Show("������ѹ��·����");
                return;
            }
            if (deZipList.FirstOrDefault().IsDeResult.Equals("�����ɹ�"))
            {
                MessageBox.Show("�Ѿ��������������ظ�����");
                return;
            }
            //0 ���� 1 ɾ�� 2 ����
            int endType = this.cbxEndType.SelectedIndex;
            foreach (var item in deZipList)
            {
                try
                {
                    using (ZipArchive archive = ZipFile.OpenRead(item.Path))
                    {
                        // ����zip�ļ��е�ÿ���ļ�
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {

                            // �����ļ�����·��
                            string fullPath = Path.Combine(targetPath, entry.FullName);

                            // �����ļ���
                            if (entry.FullName.EndsWith("/"))
                            {
                                Directory.CreateDirectory(fullPath);
                                continue;
                            }

                            // �����ļ���
                            using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
                            {
                                // ����zip�ļ��������ļ�����
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
                    item.IsDeResult = "�����ɹ�";
                }
                catch (Exception ex)
                {
                    item.IsDeResult = "����ʧ��:" + ex.Message;
                }
            }
            if (endType == 1)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(sourcePath);
                directoryInfo.Delete(true);
            }
            this.dgvFileInfo.Refresh();
        }

        #endregion

        #region tabPage2
        static ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            CreateNoWindow = true,
            UseShellExecute = false
        };

        private List<PushNugetModel> pushList = new List<PushNugetModel>();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var commandStr = this.tbCommand.Text;
            var filePath = this.tbFilePath.Text;
            var serverPath = this.tbServerPath.Text;
            var apiKey = this.tbApiKey.Text;
            if (string.IsNullOrEmpty(commandStr) || string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(serverPath) || string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("����������");
            }

            if (Directory.Exists(filePath))
            {
                pushList.Clear();
                this.dgvFileLoad.DataSource = null;
                string[] files = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);

                if (files.Length == 0)
                {
                    MessageBox.Show("�ļ�Ŀ¼��û���ļ���");
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
                                PushResult = "��δ����"
                            });
                        }
                    }

                    if (pushList.Count > 0)
                    {
                        this.dgvFileLoad.DataSource = pushList;

                        DialogResult result = MessageBox.Show("�Ƿ��ϴ���", "�ϴ���ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result.Equals(DialogResult.Yes))
                        {
                            foreach (var pItem in pushList)
                            {
                               ExecuteCommand(commandStr,apiKey,serverPath,pItem);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("�ļ�·��������");
            }
        }

        /// <summary>
        /// �첽ִ��cmd����
        /// </summary>
        /// <param name="commandStr"></param>
        /// <param name="apiKey"></param>
        /// <param name="serverPath"></param>
        /// <param name="pItem"></param>
        private async void ExecuteCommand(string commandStr,string apiKey,string serverPath,PushNugetModel pItem) {
            string command = string.Format(commandStr, pItem.FilePath, apiKey, serverPath);
            using (Process process = new Process { StartInfo = psi })
            {
                process.StartInfo.Arguments = $"/c {command} /n";
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.Start();
                string commandResult = process.StandardOutput.ReadToEnd();
                if (commandResult.IndexOf("�����Ͱ�") > -1)
                {
                    pItem.PushResult = "�����Ͱ�";
                }
                else
                {
                    pItem.PushResult = commandResult;
                }
            }

            this.dgvFileLoad.Refresh();
        }

        #endregion
    }
}