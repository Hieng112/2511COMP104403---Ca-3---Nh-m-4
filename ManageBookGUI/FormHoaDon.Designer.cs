namespace ManageBookGUI
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            groupBox1 = new GroupBox();
            dgvHoaDonBan = new DataGridView();
            btnMuaHang = new Button();
            imageList1 = new ImageList(components);
            txtTongSoLuong = new TextBox();
            label13 = new Label();
            txtTongThanhTien = new TextBox();
            label12 = new Label();
            groupBox2 = new GroupBox();
            btnCheck = new Button();
            groupBox3 = new GroupBox();
            btnSearch = new Button();
            txtSearchSDT = new TextBox();
            label6 = new Label();
            btnConfirm = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSdt = new TextBox();
            label2 = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            labelHome = new Label();
            pictureBoxHome = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBan).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(dgvHoaDonBan);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(2259, 1125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // dgvHoaDonBan
            // 
            dgvHoaDonBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDonBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonBan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHoaDonBan.BackgroundColor = Color.WhiteSmoke;
            dgvHoaDonBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonBan.Location = new Point(20, 115);
            dgvHoaDonBan.Margin = new Padding(5);
            dgvHoaDonBan.Name = "dgvHoaDonBan";
            dgvHoaDonBan.RowHeadersWidth = 51;
            dgvHoaDonBan.Size = new Size(2215, 480);
            dgvHoaDonBan.TabIndex = 26;
            // 
            // btnMuaHang
            // 
            btnMuaHang.Anchor = AnchorStyles.Top;
            btnMuaHang.BackColor = Color.FromArgb(0, 134, 197);
            btnMuaHang.Font = new Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMuaHang.ForeColor = SystemColors.ButtonHighlight;
            btnMuaHang.ImageIndex = 0;
            btnMuaHang.ImageList = imageList1;
            btnMuaHang.Location = new Point(848, 262);
            btnMuaHang.Margin = new Padding(5);
            btnMuaHang.Name = "btnMuaHang";
            btnMuaHang.Size = new Size(351, 130);
            btnMuaHang.TabIndex = 28;
            btnMuaHang.Text = "&MUA HÀNG";
            btnMuaHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMuaHang.UseVisualStyleBackColor = false;
            btnMuaHang.Click += btnMuaHang_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "giohang.png");
            // 
            // txtTongSoLuong
            // 
            txtTongSoLuong.Anchor = AnchorStyles.Top;
            txtTongSoLuong.BackColor = Color.White;
            txtTongSoLuong.Enabled = false;
            txtTongSoLuong.Font = new Font("Segoe UI", 15F);
            txtTongSoLuong.Location = new Point(372, 165);
            txtTongSoLuong.Margin = new Padding(5);
            txtTongSoLuong.Name = "txtTongSoLuong";
            txtTongSoLuong.Size = new Size(368, 61);
            txtTongSoLuong.TabIndex = 29;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label13.Location = new Point(96, 178);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(185, 42);
            label13.TabIndex = 30;
            label13.Text = "&Số lượng:";
            // 
            // txtTongThanhTien
            // 
            txtTongThanhTien.Anchor = AnchorStyles.Top;
            txtTongThanhTien.BackColor = Color.White;
            txtTongThanhTien.Enabled = false;
            txtTongThanhTien.Font = new Font("Segoe UI", 15F);
            txtTongThanhTien.Location = new Point(372, 258);
            txtTongThanhTien.Margin = new Padding(5);
            txtTongThanhTien.Name = "txtTongThanhTien";
            txtTongThanhTien.Size = new Size(368, 61);
            txtTongThanhTien.TabIndex = 31;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label12.Location = new Point(96, 264);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(220, 46);
            label12.TabIndex = 32;
            label12.Text = "&Tổng Tiền:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(4, 51, 94);
            groupBox2.Controls.Add(btnCheck);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btnMuaHang);
            groupBox2.Controls.Add(txtTongSoLuong);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtTongThanhTien);
            groupBox2.Controls.Add(label12);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(0, 607);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(2259, 518);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN NGƯỜI MUA";
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Top;
            btnCheck.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = Color.FromArgb(4, 51, 94);
            btnCheck.ImageList = imageList1;
            btnCheck.Location = new Point(848, 165);
            btnCheck.Margin = new Padding(5);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(351, 75);
            btnCheck.TabIndex = 36;
            btnCheck.Text = "LỊCH SỬ";
            btnCheck.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.BackColor = Color.Gainsboro;
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(txtSearchSDT);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnConfirm);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtSdt);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtMaKH);
            groupBox3.Controls.Add(txtTenKH);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.ForeColor = Color.FromArgb(4, 51, 94);
            groupBox3.Location = new Point(1266, 56);
            groupBox3.Margin = new Padding(5, 6, 5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 6, 5, 6);
            groupBox3.Size = new Size(983, 437);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "HỘI VIÊN";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.FromArgb(192, 255, 192);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.Location = new Point(930, 70);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(54, 48);
            btnSearch.TabIndex = 33;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchSDT
            // 
            txtSearchSDT.Font = new Font("Segoe UI", 9F);
            txtSearchSDT.Location = new Point(639, 74);
            txtSearchSDT.Margin = new Padding(5, 6, 5, 6);
            txtSearchSDT.Name = "txtSearchSDT";
            txtSearchSDT.Size = new Size(287, 39);
            txtSearchSDT.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(4, 51, 94);
            label6.Location = new Point(575, 80);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 29);
            label6.TabIndex = 30;
            label6.Text = "Tìm";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(4, 51, 94);
            btnConfirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.ImageList = imageList1;
            btnConfirm.Location = new Point(297, 320);
            btnConfirm.Margin = new Padding(5);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(416, 91);
            btnConfirm.TabIndex = 29;
            btnConfirm.Text = "TẠO HỘI VIÊN MỚI";
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(247, 256);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(678, 39);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 51, 94);
            label4.Location = new Point(21, 256);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Segoe UI", 9F);
            txtSdt.Location = new Point(247, 202);
            txtSdt.Margin = new Padding(5, 6, 5, 6);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(678, 39);
            txtSdt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(4, 51, 94);
            label2.Location = new Point(21, 205);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 29);
            label2.TabIndex = 4;
            label2.Text = "SDT:";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 9F);
            txtMaKH.Location = new Point(247, 74);
            txtMaKH.Margin = new Padding(5, 6, 5, 6);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(296, 39);
            txtMaKH.TabIndex = 3;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Segoe UI", 9F);
            txtTenKH.Location = new Point(247, 146);
            txtTenKH.Margin = new Padding(5, 6, 5, 6);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(678, 39);
            txtTenKH.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 51, 94);
            label3.Location = new Point(21, 85);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 29);
            label3.TabIndex = 1;
            label3.Text = "&Mã Khách Hàng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 51, 94);
            label5.Location = new Point(21, 146);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 29);
            label5.TabIndex = 0;
            label5.Text = "Tên Khách Hàng:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(796, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(653, 69);
            label1.TabIndex = 2;
            label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 51, 94);
            panel1.Controls.Add(labelHome);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2259, 106);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Microsoft Tai Le", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHome.ForeColor = SystemColors.ButtonHighlight;
            labelHome.Location = new Point(98, 34);
            labelHome.Margin = new Padding(5, 0, 5, 0);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(349, 48);
            labelHome.TabIndex = 61;
            labelHome.Text = "11PM BOOKSTORE";
            labelHome.Click += labelHome_Click;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = (Image)resources.GetObject("pictureBoxHome.Image");
            pictureBoxHome.Location = new Point(23, 19);
            pictureBoxHome.Margin = new Padding(5);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(65, 64);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 60;
            pictureBoxHome.TabStop = false;
            pictureBoxHome.Click += labelHome_Click;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(2259, 1125);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBan).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMuaHang;
        private TextBox txtTongSoLuong;
        private Label label13;
        private TextBox txtTongThanhTien;
        private Label label12;
        private DataGridView dgvHoaDonBan;
        private GroupBox groupBox2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBoxHome;
        private ImageList imageList1;
        private Label labelHome;
        private GroupBox groupBox3;
        private Button btnConfirm;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSdt;
        private Label label2;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private Label label3;
        private Label label5;
        private Button btnCheck;
        private TextBox txtSearchSDT;
        private Label label6;
        private Button btnSearch;
    }
}