using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;
using ServiceStack.Redis.Support;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using yylcha.pub.model.nugetM;

namespace yylcha.pub.views
{
    public partial class FrmNugetList : UIForm
    {
        private static string serviceAddress = string.Empty;
        private static Feed Feed = new Feed();
        /// <summary>
        /// 服务器包的列表展示窗体
        /// </summary>
        public FrmNugetList(string address)
        {
            serviceAddress = address;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        /// <param name="style"></param>
        public void ShowForm(UIStyle style)
        {
            if (string.IsNullOrEmpty(serviceAddress))
            {
                return;
            }
            GetNugetPkgList();
            this.Style = style;
            this.ShowDialog();
        }

        public async void GetNugetPkgList()
        {
            string url = Path.Combine(serviceAddress, "nuget/Packages");
            //HttpClient client = new HttpClient();
            //string response = await client.GetStringAsync(url);
            //using (StringReader sr = new StringReader(response))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(Feed));
            //    Feed = (Feed)serializer.Deserialize(sr);
            //    if (Feed != null)
            //    {
            //        List<string> titleList = Feed.Entry.GroupBy(d => d.Title).Select(d => d.Key.Text)?.Distinct()?.ToList();
            //        foreach (var item in titleList)
            //        {
            //            this.uiTvNugetPkg.Nodes.Add(new TreeNode(item));
            //        }
            //    }
            //}
            ILogger logger = NullLogger.Instance;
            CancellationToken token = CancellationToken.None;
            SourceCacheContext cache = new SourceCacheContext();
            SourceRepository repository = Repository.Factory.GetCoreV2(new PackageSource(url));
            FindPackageByIdResource resource = repository.GetResource<FindPackageByIdResource>();
            IEnumerable<NuGetVersion> versions =await resource.GetAllVersionsAsync("Com.No1", cache,logger,token);
        }
    }
}
