using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace yylcha.pub.model.nugetM
{
    public class ExecuteCommandModel
    {
        /// <summary>
        /// 自定义命令
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// 服务器地址
        /// </summary>
        public string ServicePath { get; set; }

        /// <summary>
        /// Nuget Key
        /// </summary>
        public string Apikey { get; set; }
    }

    /// <summary>
    /// xml对象
    /// </summary>
    public class Root
    {
        public List<ExecuteCommandModel> CommandList { get; set; }
    }
}
