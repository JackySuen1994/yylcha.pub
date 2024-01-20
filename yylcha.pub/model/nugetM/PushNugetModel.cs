using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yylcha.pub.model.nugetM
{
    public class PushNugetModel
    {
        /// <summary>
        /// files name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// files local path
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// push result
        /// </summary>
        public string PushResult { get; set; }
    }
}
