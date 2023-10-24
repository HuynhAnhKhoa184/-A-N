using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSendMail_v1._0.Models
{
    public class ReadFile
    {
        private string url_file;
        public ReadFile(string url)
        {
            this.Url_file = url;
        }
        public List<string> Get_Line_File()
        {
            List<string> list = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(this.Url_file);
            foreach (string line in lines)
            {
                list.Add(line);
            }
            return list;
        }
        public string Url_file { get => url_file; set => url_file = value; }
    }
}
