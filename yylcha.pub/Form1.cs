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
    }
}