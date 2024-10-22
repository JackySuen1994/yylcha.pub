using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yylcha.pub.model.redis
{
    public class RedisPullResult
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string UniqueKey { get; set; }
        /// <summary>
        /// pull 日志
        /// </summary>
        public string PullLog { get; set; }
    }
}
