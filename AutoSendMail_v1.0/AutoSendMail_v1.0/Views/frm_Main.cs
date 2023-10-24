using AutoSendMail_v1._0.Controls;
using AutoSendMail_v1._0.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSendMail_v1._0
{
    public partial class frm_Main : MetroFramework.Forms.MetroForm
    {


        public frm_Main()
        {
            InitializeComponent();
            lbTrangThai.Visible = false;
        }
      
        List<Email> List_Email = null;
        Attachment attachment = null;
        private void btnThemListMail_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string FileName = theDialog.FileName;
                            List_Email = Email_Ctrl.get_List_Email_by_Url_File(FileName);
                            Load_List_Email();
                            CheckMail_Loi();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        public void Load_List_Email()
        {
            for(int i = 0; i < List_Email.Count; i++)
            {
                List_Email[i].Stt = (i + 1);
            }
            var binding = new BindingSource();
            binding.DataSource = List_Email;
            grv_ListMail.DataSource = binding;
        }
        public void CheckMail_Loi()
        {
            for (int i = 0; i < grv_ListMail.Rows.Count; i++)
            {
                String key = grv_ListMail.Rows[i].Cells[2].Value.ToString();
                if (key.Equals("Lỗi"))
                {
                    grv_ListMail.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;

                }
            }
        }
        private void btnXoaMailLoi_Click(object sender, EventArgs e)
        {
            if (List_Email == null)
            {
                MessageBox.Show("Chưa có danh sách mail", "Thông báo");
            }
            else
            {
                List_Email = Email_Ctrl.Remove_Mail_(List_Email);
                Load_List_Email();
            }
        }

        private void btnXoaAllMail_Click(object sender, EventArgs e)
        {
            List_Email = null;
            Load_List_Email();
        }

        private void btnCheckLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản email vui lòng nhập tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu app vui lòng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau.Focus();
                }
                else
                {
                    MessageBox.Show("Đang tiến hành kiểm tra Email vui lòng chờ trong giây lát", "Thông báo");
                    if (SendMail(txtTaiKhoan.Text, txtTaiKhoan.Text, Send_Values_Check(), "IsBool == true"))
                    {
                        MessageBox.Show("Trạng thái email tốt có thể bắt đầu tiến hành gửi mail.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thông tin tài khoản hoặc mật khẩu app không chính xác vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
        public string Send_Values_Check()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString().Split(' ')[0]+" Check Mail";
        }
        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        public void SaveFile()
        {
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.FilterIndex = 1;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, Get_Email_By_List_Save_File());

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public string Get_Email_By_List_Save_File()
        {
            string values = null;
            for (int i = 0; i < List_Email.Count; i++)
            {
                values += List_Email[i].TenEmail + "\n";
            }
            return values;
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "https://myaccount.google.com/u/3/apppasswords?utm_source=google-account&utm_medium=myaccountsecurity&utm_campaign=tsv-settings&rapt=AEjHL4M-LojgD-7mS4MIm5bZkqQcyrgjzziPl0344S44lO8XeZEZWOv9JCO79byEoCKS_s42d_Yc3IOW2toCNs-gsrjyuCG0IA");
        }
        public bool SendMail(string from,string to,string subject,string body)
        {
            bool flat = false;
            try
            {

                MailMessage mailMessage = new MailMessage(from, to, subject, body);
                if(attachment!=null)
                    mailMessage.Attachments.Add(attachment);
                SmtpClient smtp = new SmtpClient(Smtp_.Name_Server, Smtp_.Port);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                smtp.Send(mailMessage);
                flat = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            return flat;

        }

        private void btnFileDinhKem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
                txtFileDinhKem.Text=openFileDialog.FileName;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTieuDe.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiêu đề mail vui lòng nhập tiêu đề","Thông báo");
                txtTieuDe.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(txtNoiDung.Text))
                {
                    MessageBox.Show("Bạn chưa nhập nội dung mail vui lòng nhập nội dung", "Thông báo");
                    txtNoiDung.Focus();
                }
                else
                {
                    if (List_Email == null)
                    {
                        MessageBox.Show("Chưa có danh sách email nào vui lòng quay lại mục cài đặt, cảm ơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        int Count_Success = 0;
                       // lbTrangThai.Visible = true;
                        attachment = null;
                        try
                        {
                            FileInfo file = new FileInfo(txtFileDinhKem.Text);
                            attachment = new Attachment(txtFileDinhKem.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Chương trình đang thực hiện gửi mail vui lòng chờ.");
                        for (int i = 0; i < List_Email.Count; i++)
                        {
                          //  lbTrangThai.Text = "Trạng thái mail đã gửi: " + Count_Success + "/" + List_Email.Count;
                            if (SendMail(txtTaiKhoan.Text, List_Email[i].TenEmail, txtTieuDe.Text, txtNoiDung.Text))
                                Count_Success++;
                            
                        }
                        MessageBox.Show("Đã gửi thành công " + Count_Success + "/" + List_Email.Count + " Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", " https://www.youtube.com/channel/UCgps48WnGQf3GpX3Q3WelzQ");
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
