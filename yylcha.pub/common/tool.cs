using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yylcha.pub.common
{
    public class tool
    {
        public static string GetTimeSpan() {
            //Get timestamp with TimeSpan
            DateTime now = DateTime.Now;
            DateTime startTime = new DateTime(1970, 1, 1);
            TimeSpan span = now - startTime;
            return Convert.ToInt64(span.TotalSeconds).ToString();
        }
    }
}
