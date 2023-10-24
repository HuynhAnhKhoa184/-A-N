using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AutoSendMail_v1._0.Models
{
    
    public class Email
    {
        private int stt;
        private string tenEmail;
        private string trangThaiMail;
        public Email(int stt, string tenEmail)
        {
            this.Stt = stt;
            this.TenEmail = tenEmail;
            if (IsEmail(TenEmail))
            {
                this.TrangThaiMail = "Sẵn sàng";
            }
            else
            {
                this.TrangThaiMail = "Lỗi";
            }
        }
        public bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public int Stt { get => stt; set => stt = value; }
        public string TenEmail { get => tenEmail; set => tenEmail = value; }
        public string TrangThaiMail { get => trangThaiMail; set => trangThaiMail = value; }
    }
}
