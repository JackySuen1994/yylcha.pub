using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yylcha.pub.model.zip
{
    public class DeZipModel
    {
        /// <summary>
        /// 文件命名成
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 解压缩结果 0 未解析 1 解析成功 2解析失败
        /// </summary>
        public string IsDeResult { get; set; } = "待解析";

        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; set; }
    }
}
