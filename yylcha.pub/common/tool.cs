using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using yylcha.pub.model.nugetM;

namespace yylcha.pub.common
{
    public class tool
    {
        private static string NugetConfig = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "config/PushNuget.json");
        public static string GetTimeSpan()
        {
            //Get timestamp with TimeSpan
            DateTime now = DateTime.Now;
            DateTime startTime = new DateTime(1970, 1, 1);
            TimeSpan span = now - startTime;
            return Convert.ToInt64(span.TotalSeconds).ToString();
        }

        /// <summary>
        /// 读取nuget发布包本地文件
        /// </summary>
        /// <returns></returns>
        public static List<ExecuteCommandModel> GetNugetModel() {
            if (File.Exists(NugetConfig))
            {
                try
                {
                    using (var reader=new StreamReader(NugetConfig))
                    {
                        string fileContent = reader.ReadToEnd();
                        if (!string.IsNullOrEmpty(fileContent))
                        {
                            Root root = JsonConvert.DeserializeObject<Root>(fileContent);
                            if (root != null && root.CommandList.Count > 0)
                            {
                                return root.CommandList;
                            }
                        }
                    }
                }
                catch
                {
                }
            }
           
            return null;
        }
    }
}
