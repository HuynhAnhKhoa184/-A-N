using AutoSendMail_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutoSendMail_v1._0.Controls
{
    public class Email_Ctrl
    {
        public static List<Email> get_List_Email_by_Url_File(string url_file)
        {
            List<Email> list = new List<Email>();
            List<string> List_Email_File = new ReadFile(url_file).Get_Line_File();
            for(int i = 0; i < List_Email_File.Count; i++)
            {
                Email email = new Email(i + 1, List_Email_File[i]);
                list.Add(email);
            }
            return list;
        }
        public static List<Email> Remove_Mail_(List<Email> list)
        {
            for(int i=0; i < list.Count; i++)
            {
                if (list[i].TrangThaiMail.Equals("Lỗi"))
                    list.Remove(list[i]);
            }
        //    var item_Remove = list.ToList().SingleOrDefault(r => r.TrangThaiMail == "Lỗi");
        //    if(item_Remove!= null)
        //        list.Remove(item_Remove);
            return list;
        }
    }
}
