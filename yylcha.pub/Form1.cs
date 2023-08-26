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

        private void btnOk_Click(object sender, EventArgs e)
        {
            string sourcePath = this.txtSourcePath.Text;
            if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("请输入需要解析的文件路径！");
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
                MessageBox.Show("文件夹中没有待解析的文件");
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
                MessageBox.Show("请输入压缩路径！");
                return;
            }
            if (deZipList.FirstOrDefault().IsDeResult.Equals("解析成功"))
            {
                MessageBox.Show("已经解析过，不可重复解析");
                return;
            }
            //0 备份 1 删除 2 保留
            int endType = this.cbxEndType.SelectedIndex;
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
            this.dgvFileInfo.Refresh();
        }
    }
}