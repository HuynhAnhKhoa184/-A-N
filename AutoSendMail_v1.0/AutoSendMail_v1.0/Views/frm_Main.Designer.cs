namespace AutoSendMail_v1._0
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.link = new System.Windows.Forms.LinkLabel();
            this.btnCheckLogin = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grv_ListMail = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaAllMail = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.btnThemListMail = new System.Windows.Forms.Button();
            this.btnXoaMailLoi = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFileDinhKem = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.txtFileDinhKem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_ListMail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(31, 78);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1005, 393);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox3);
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(997, 351);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cài đặt chung";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.link);
            this.groupBox3.Controls.Add(this.btnCheckLogin);
            this.groupBox3.Controls.Add(this.txtMatKhau);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTaiKhoan);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(0, 258);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(995, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(435, 16);
            this.link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(234, 16);
            this.link.TabIndex = 7;
            this.link.TabStop = true;
            this.link.Text = "Chưa có mật khẩu app? Click vào đây.";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // btnCheckLogin
            // 
            this.btnCheckLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckLogin.ForeColor = System.Drawing.Color.White;
            this.btnCheckLogin.Location = new System.Drawing.Point(435, 38);
            this.btnCheckLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckLogin.Name = "btnCheckLogin";
            this.btnCheckLogin.Size = new System.Drawing.Size(172, 33);
            this.btnCheckLogin.TabIndex = 6;
            this.btnCheckLogin.Text = "Check đăng nhập";
            this.btnCheckLogin.UseVisualStyleBackColor = false;
            this.btnCheckLogin.Click += new System.EventHandler(this.btnCheckLogin_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(125, 47);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(300, 22);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu App:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(125, 16);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(300, 22);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ email:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.grv_ListMail);
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(995, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // grv_ListMail
            // 
            this.grv_ListMail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_ListMail.BackgroundColor = System.Drawing.Color.White;
            this.grv_ListMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_ListMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenEmail,
            this.colTrangThai});
            this.grv_ListMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_ListMail.Location = new System.Drawing.Point(4, 19);
            this.grv_ListMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grv_ListMail.Name = "grv_ListMail";
            this.grv_ListMail.RowHeadersWidth = 51;
            this.grv_ListMail.Size = new System.Drawing.Size(987, 181);
            this.grv_ListMail.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "Stt";
            this.colSTT.HeaderText = "Số thứ tự";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colTenEmail
            // 
            this.colTenEmail.DataPropertyName = "TenEmail";
            this.colTenEmail.HeaderText = "Địa chỉ email";
            this.colTenEmail.MinimumWidth = 6;
            this.colTenEmail.Name = "colTenEmail";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThaiMail";
            this.colTrangThai.HeaderText = "Trạng thái mail";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnXoaAllMail);
            this.groupBox1.Controls.Add(this.btnLuuFile);
            this.groupBox1.Controls.Add(this.btnThemListMail);
            this.groupBox1.Controls.Add(this.btnXoaMailLoi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(997, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnXoaAllMail
            // 
            this.btnXoaAllMail.BackColor = System.Drawing.Color.DeepPink;
            this.btnXoaAllMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaAllMail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAllMail.ForeColor = System.Drawing.Color.White;
            this.btnXoaAllMail.Location = new System.Drawing.Point(627, 16);
            this.btnXoaAllMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaAllMail.Name = "btnXoaAllMail";
            this.btnXoaAllMail.Size = new System.Drawing.Size(172, 33);
            this.btnXoaAllMail.TabIndex = 4;
            this.btnXoaAllMail.Text = "Xóa tất cả mail";
            this.btnXoaAllMail.UseVisualStyleBackColor = false;
            this.btnXoaAllMail.Click += new System.EventHandler(this.btnXoaAllMail_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.BackColor = System.Drawing.Color.Green;
            this.btnLuuFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuFile.ForeColor = System.Drawing.Color.White;
            this.btnLuuFile.Location = new System.Drawing.Point(807, 16);
            this.btnLuuFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(172, 33);
            this.btnLuuFile.TabIndex = 5;
            this.btnLuuFile.Text = "Lưu File Mail";
            this.btnLuuFile.UseVisualStyleBackColor = false;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // btnThemListMail
            // 
            this.btnThemListMail.BackColor = System.Drawing.Color.Blue;
            this.btnThemListMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemListMail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemListMail.ForeColor = System.Drawing.Color.White;
            this.btnThemListMail.Location = new System.Drawing.Point(8, 16);
            this.btnThemListMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemListMail.Name = "btnThemListMail";
            this.btnThemListMail.Size = new System.Drawing.Size(172, 33);
            this.btnThemListMail.TabIndex = 2;
            this.btnThemListMail.Text = "Thêm list mail";
            this.btnThemListMail.UseVisualStyleBackColor = false;
            this.btnThemListMail.Click += new System.EventHandler(this.btnThemListMail_Click);
            // 
            // btnXoaMailLoi
            // 
            this.btnXoaMailLoi.BackColor = System.Drawing.Color.Red;
            this.btnXoaMailLoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMailLoi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMailLoi.ForeColor = System.Drawing.Color.White;
            this.btnXoaMailLoi.Location = new System.Drawing.Point(188, 16);
            this.btnXoaMailLoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaMailLoi.Name = "btnXoaMailLoi";
            this.btnXoaMailLoi.Size = new System.Drawing.Size(172, 33);
            this.btnXoaMailLoi.TabIndex = 3;
            this.btnXoaMailLoi.Text = "Xóa mail lỗi";
            this.btnXoaMailLoi.UseVisualStyleBackColor = false;
            this.btnXoaMailLoi.Click += new System.EventHandler(this.btnXoaMailLoi_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBox5);
            this.metroTabPage2.Controls.Add(this.groupBox4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(997, 351);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Gửi mail";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.btnFileDinhKem);
            this.groupBox5.Controls.Add(this.btnSendMail);
            this.groupBox5.Controls.Add(this.txtFileDinhKem);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 298);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(997, 53);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btnFileDinhKem
            // 
            this.btnFileDinhKem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFileDinhKem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDinhKem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileDinhKem.ForeColor = System.Drawing.Color.White;
            this.btnFileDinhKem.Location = new System.Drawing.Point(4, 12);
            this.btnFileDinhKem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFileDinhKem.Name = "btnFileDinhKem";
            this.btnFileDinhKem.Size = new System.Drawing.Size(172, 33);
            this.btnFileDinhKem.TabIndex = 8;
            this.btnFileDinhKem.Text = "File đính kèm nếu có";
            this.btnFileDinhKem.UseVisualStyleBackColor = false;
            this.btnFileDinhKem.Click += new System.EventHandler(this.btnFileDinhKem_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(792, 12);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(195, 33);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Tiến hành gửi mail";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // txtFileDinhKem
            // 
            this.txtFileDinhKem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileDinhKem.ForeColor = System.Drawing.Color.Blue;
            this.txtFileDinhKem.Location = new System.Drawing.Point(184, 16);
            this.txtFileDinhKem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileDinhKem.Name = "txtFileDinhKem";
            this.txtFileDinhKem.ReadOnly = true;
            this.txtFileDinhKem.Size = new System.Drawing.Size(599, 24);
            this.txtFileDinhKem.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lbTrangThai);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNoiDung);
            this.groupBox4.Controls.Add(this.txtTieuDe);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(997, 284);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Crimson;
            this.lbTrangThai.Location = new System.Drawing.Point(663, 27);
            this.lbTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(162, 17);
            this.lbTrangThai.TabIndex = 4;
            this.lbTrangThai.Text = "Trạng thái mail đã gửi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNoiDung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(4, 68);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(989, 212);
            this.txtNoiDung.TabIndex = 2;
            this.txtNoiDung.Text = "";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(89, 23);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(564, 24);
            this.txtTieuDe.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiêu đề:";
            // 
            
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 486);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Auto Send Mail v1.0";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_ListMail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grv_ListMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaAllMail;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.Button btnThemListMail;
        private System.Windows.Forms.Button btnXoaMailLoi;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Button btnCheckLogin;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFileDinhKem;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox txtFileDinhKem;
        private System.Windows.Forms.Label lbTrangThai;
    }
}

