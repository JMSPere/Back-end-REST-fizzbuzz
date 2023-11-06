using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace CrossCutting.Configuration
{
    public class CreateConfigManager : IConfiguration
    {
        public string FilePath
        {
            get
            {
                string projectPath = AppDomain.CurrentDomain.BaseDirectory + "\\bin";
                DateTime dateTime = DateTime.Now;
                string fileName = dateTime.ToString(WebConfigurationManager.AppSettings["dateFormat"]);

                string filePath = Path.Combine(projectPath, fileName);
                return filePath;
            }
        }

        public int MaxNumber
        {
            get
            {
                int maxNumber = Convert.ToInt32(WebConfigurationManager.AppSettings["maxNumber"]);
                return maxNumber;
            }
        }
    }
}
