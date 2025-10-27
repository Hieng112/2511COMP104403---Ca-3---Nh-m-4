namespace ManageBookGUI
{
    partial class FormThongTinCaNhan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongTinCaNhan));
            panelHoSo = new Panel();
            labelHome = new Label();
            pictureBoxHome = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelTaiKhoan = new Label();
            groupBox1 = new GroupBox();
            rdbtnNu = new RadioButton();
            rdbtnNam = new RadioButton();
            dateTimePickerNgaySinh = new DateTimePicker();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenTK = new TextBox();
            txtMaTK = new TextBox();
            labelSDT = new Label();
            labelEmail = new Label();
            labelDiaChi = new Label();
            labelPhai = new Label();
            labelNgSinh = new Label();
            labelTenTK = new Label();
            labelMaTK = new Label();
            btnChinhSua = new Button();
            imageListInfo = new ImageList(components);
            bindingSource1 = new BindingSource(components);
            panelHoSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panelHoSo
            // 
            panelHoSo.BackColor = Color.FromArgb(4, 51, 94);
            panelHoSo.BorderStyle = BorderStyle.Fixed3D;
            panelHoSo.Controls.Add(labelHome);
            panelHoSo.Controls.Add(pictureBoxHome);
            panelHoSo.Controls.Add(pictureBox1);
            panelHoSo.Controls.Add(label1);
            panelHoSo.Controls.Add(labelTaiKhoan);
            panelHoSo.Dock = DockStyle.Top;
            panelHoSo.Location = new Point(0, 0);
            panelHoSo.Margin = new Padding(5, 5, 5, 5);
            panelHoSo.Name = "panelHoSo";
            panelHoSo.Size = new Size(1254, 97);
            panelHoSo.TabIndex = 0;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Microsoft Tai Le", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHome.ForeColor = SystemColors.ButtonHighlight;
            labelHome.Location = new Point(78, 34);
            labelHome.Margin = new Padding(5, 0, 5, 0);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(276, 37);
            labelHome.TabIndex = 61;
            labelHome.Text = "11PM BOOKSTORE";
            labelHome.Click += labelHome_Click;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = (Image)resources.GetObject("pictureBoxHome.Image");
            pictureBoxHome.Location = new Point(16, 13);
            pictureBoxHome.Margin = new Padding(5, 5, 5, 5);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(60, 59);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 60;
            pictureBoxHome.TabStop = false;
            pictureBoxHome.Click += labelHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1081, 5);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(460, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 51);
            label1.TabIndex = 1;
            label1.Text = "HỒ SƠ CỦA TÔI";
            // 
            // labelTaiKhoan
            // 
            labelTaiKhoan.AutoSize = true;
            labelTaiKhoan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTaiKhoan.ForeColor = SystemColors.ControlLightLight;
            labelTaiKhoan.ImageAlign = ContentAlignment.TopCenter;
            labelTaiKhoan.Location = new Point(1064, 58);
            labelTaiKhoan.Margin = new Padding(5, 0, 5, 0);
            labelTaiKhoan.Name = "labelTaiKhoan";
            labelTaiKhoan.Size = new Size(93, 29);
            labelTaiKhoan.TabIndex = 0;
            labelTaiKhoan.Text = "TenTK";
            labelTaiKhoan.TextAlign = ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(4, 51, 94);
            groupBox1.Controls.Add(rdbtnNu);
            groupBox1.Controls.Add(rdbtnNam);
            groupBox1.Controls.Add(dateTimePickerNgaySinh);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenTK);
            groupBox1.Controls.Add(txtMaTK);
            groupBox1.Controls.Add(labelSDT);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelDiaChi);
            groupBox1.Controls.Add(labelPhai);
            groupBox1.Controls.Add(labelNgSinh);
            groupBox1.Controls.Add(labelTenTK);
            groupBox1.Controls.Add(labelMaTK);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(80, 142);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(1053, 678);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // rdbtnNu
            // 
            rdbtnNu.AutoSize = true;
            rdbtnNu.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            rdbtnNu.Location = new Point(715, 325);
            rdbtnNu.Margin = new Padding(5, 5, 5, 5);
            rdbtnNu.Name = "rdbtnNu";
            rdbtnNu.Size = new Size(99, 46);
            rdbtnNu.TabIndex = 32;
            rdbtnNu.TabStop = true;
            rdbtnNu.Text = "Nữ";
            rdbtnNu.UseVisualStyleBackColor = true;
            // 
            // rdbtnNam
            // 
            rdbtnNam.AutoSize = true;
            rdbtnNam.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            rdbtnNam.Location = new Point(452, 325);
            rdbtnNam.Margin = new Padding(5, 5, 5, 5);
            rdbtnNam.Name = "rdbtnNam";
            rdbtnNam.Size = new Size(130, 46);
            rdbtnNam.TabIndex = 31;
            rdbtnNam.TabStop = true;
            rdbtnNam.Text = "Nam";
            rdbtnNam.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePickerNgaySinh.Location = new Point(414, 243);
            dateTimePickerNgaySinh.Margin = new Padding(5, 5, 5, 5);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(527, 44);
            dateTimePickerNgaySinh.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(413, 477);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(526, 44);
            txtEmail.TabIndex = 29;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F);
            txtDiaChi.Location = new Point(413, 400);
            txtDiaChi.Margin = new Padding(5, 5, 5, 5);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(527, 44);
            txtDiaChi.TabIndex = 25;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Microsoft Sans Serif", 12F);
            txtSDT.Location = new Point(414, 566);
            txtSDT.Margin = new Padding(5, 5, 5, 5);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(526, 44);
            txtSDT.TabIndex = 26;
            // 
            // txtTenTK
            // 
            txtTenTK.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenTK.Location = new Point(414, 162);
            txtTenTK.Margin = new Padding(5, 5, 5, 5);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(526, 44);
            txtTenTK.TabIndex = 28;
            // 
            // txtMaTK
            // 
            txtMaTK.Enabled = false;
            txtMaTK.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaTK.Location = new Point(414, 77);
            txtMaTK.Margin = new Padding(5, 5, 5, 5);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(527, 44);
            txtMaTK.TabIndex = 27;
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelSDT.Location = new Point(98, 573);
            labelSDT.Margin = new Padding(5, 0, 5, 0);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(260, 42);
            labelSDT.TabIndex = 6;
            labelSDT.Text = "Số điện thoại:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelEmail.Location = new Point(98, 485);
            labelEmail.Margin = new Padding(5, 0, 5, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(126, 42);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelDiaChi.Location = new Point(98, 400);
            labelDiaChi.Margin = new Padding(5, 0, 5, 0);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(150, 42);
            labelDiaChi.TabIndex = 4;
            labelDiaChi.Text = "Địa chỉ:";
            // 
            // labelPhai
            // 
            labelPhai.AutoSize = true;
            labelPhai.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelPhai.Location = new Point(98, 331);
            labelPhai.Margin = new Padding(5, 0, 5, 0);
            labelPhai.Name = "labelPhai";
            labelPhai.Size = new Size(108, 42);
            labelPhai.TabIndex = 3;
            labelPhai.Text = "Phái:";
            // 
            // labelNgSinh
            // 
            labelNgSinh.AutoSize = true;
            labelNgSinh.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelNgSinh.Location = new Point(98, 251);
            labelNgSinh.Margin = new Padding(5, 0, 5, 0);
            labelNgSinh.Name = "labelNgSinh";
            labelNgSinh.Size = new Size(205, 42);
            labelNgSinh.TabIndex = 2;
            labelNgSinh.Text = "Ngày sinh:";
            // 
            // labelTenTK
            // 
            labelTenTK.AutoSize = true;
            labelTenTK.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelTenTK.Location = new Point(98, 162);
            labelTenTK.Margin = new Padding(5, 0, 5, 0);
            labelTenTK.Name = "labelTenTK";
            labelTenTK.Size = new Size(269, 42);
            labelTenTK.TabIndex = 1;
            labelTenTK.Text = "Tên tài khoản:";
            // 
            // labelMaTK
            // 
            labelMaTK.AutoSize = true;
            labelMaTK.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            labelMaTK.Location = new Point(98, 77);
            labelMaTK.Margin = new Padding(5, 0, 5, 0);
            labelMaTK.Name = "labelMaTK";
            labelMaTK.Size = new Size(255, 42);
            labelMaTK.TabIndex = 0;
            labelMaTK.Text = "Mã tài khoản:";
            // 
            // btnChinhSua
            // 
            btnChinhSua.BackColor = Color.FromArgb(0, 134, 197);
            btnChinhSua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChinhSua.ForeColor = SystemColors.ButtonHighlight;
            btnChinhSua.ImageAlign = ContentAlignment.MiddleRight;
            btnChinhSua.ImageIndex = 0;
            btnChinhSua.ImageList = imageListInfo;
            btnChinhSua.Location = new Point(494, 830);
            btnChinhSua.Margin = new Padding(5, 5, 5, 5);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(195, 66);
            btnChinhSua.TabIndex = 49;
            btnChinhSua.Text = "Cập nhật";
            btnChinhSua.TextAlign = ContentAlignment.MiddleRight;
            btnChinhSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChinhSua.UseVisualStyleBackColor = false;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // imageListInfo
            // 
            imageListInfo.ColorDepth = ColorDepth.Depth32Bit;
            imageListInfo.ImageStream = (ImageListStreamer)resources.GetObject("imageListInfo.ImageStream");
            imageListInfo.TransparentColor = Color.Transparent;
            imageListInfo.Images.SetKeyName(0, "fix_.jpg");
            imageListInfo.Images.SetKeyName(1, "save.jpg");
            // 
            // FormThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1254, 930);
            Controls.Add(btnChinhSua);
            Controls.Add(groupBox1);
            Controls.Add(panelHoSo);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormThongTinCaNhan";
            Text = "FormThongTinCaNhan";
            panelHoSo.ResumeLayout(false);
            panelHoSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHoSo;
        private Label labelTaiKhoan;
        private Label label1;
        private GroupBox groupBox1;
        private Label labelSDT;
        private Label labelEmail;
        private Label labelDiaChi;
        private Label labelPhai;
        private Label labelNgSinh;
        private Label labelTenTK;
        private Label labelMaTK;
        private RadioButton rdbtnNu;
        private RadioButton rdbtnNam;
        private DateTimePicker dateTimePickerNgaySinh;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenTK;
        private TextBox txtMaTK;
        private Button btnChinhSua;
        private ImageList imageListInfo;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private Label labelHome;
        private PictureBox pictureBoxHome;
    }
}