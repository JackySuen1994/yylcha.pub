using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yylcha.pub.model.redis
{
    public class CodeManagementModel
    {
        public string IsSelected { get; set; }
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string UniqueKey { get; set; }
        /// <summary>
        /// 代码类别
        /// </summary>
        public string CodeType { get; set; }
        /// <summary>
        /// 代码路径
        /// </summary>
        public string LocalPath { get; set; }
    }
}
