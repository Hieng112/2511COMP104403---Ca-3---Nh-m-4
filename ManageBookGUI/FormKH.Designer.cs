namespace ManageBookGUI
{
    partial class FormKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKH));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnTimKiemSach = new Button();
            label1 = new Label();
            cboTheLoai = new ComboBox();
            pictureBox6 = new PictureBox();
            btnXemGH = new Button();
            labelHome = new Label();
            pictureBoxHome = new PictureBox();
            txtSearch = new TextBox();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            imageList1 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelGH = new Panel();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            btnXoaGH = new Button();
            btnThanhToan = new Button();
            txtTongThanhTien = new TextBox();
            txtTongSoLuong = new TextBox();
            dataGridView2 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip2 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            thểLoạiToolStripMenuItem = new ToolStripMenuItem();
            khoSáchToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtMaDV = new TextBox();
            txtSoLuong = new TextBox();
            label7 = new Label();
            txtGia = new TextBox();
            label10 = new Label();
            txtMaSach = new TextBox();
            txtLoaiSach = new TextBox();
            txtTenSach = new TextBox();
            btnThemGH = new Button();
            label11 = new Label();
            label8 = new Label();
            txtTenDV = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            panelGH.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 142);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(2434, 381);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 51, 94);
            panel1.Controls.Add(btnTimKiemSach);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboTheLoai);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(btnXemGH);
            panel1.Controls.Add(labelHome);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2483, 107);
            panel1.TabIndex = 1;
            // 
            // btnTimKiemSach
            // 
            btnTimKiemSach.Anchor = AnchorStyles.Top;
            btnTimKiemSach.BackColor = Color.FromArgb(0, 134, 197);
            btnTimKiemSach.BackgroundImage = (Image)resources.GetObject("btnTimKiemSach.BackgroundImage");
            btnTimKiemSach.BackgroundImageLayout = ImageLayout.Stretch;
            btnTimKiemSach.ForeColor = SystemColors.ControlText;
            btnTimKiemSach.Location = new Point(1436, 32);
            btnTimKiemSach.Margin = new Padding(5);
            btnTimKiemSach.Name = "btnTimKiemSach";
            btnTimKiemSach.Size = new Size(54, 48);
            btnTimKiemSach.TabIndex = 32;
            btnTimKiemSach.UseVisualStyleBackColor = false;
            btnTimKiemSach.Click += btnTimKiemSach_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(1503, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 40);
            label1.TabIndex = 28;
            label1.Text = "Thể loại";
            // 
            // cboTheLoai
            // 
            cboTheLoai.Anchor = AnchorStyles.Top;
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(1658, 30);
            cboTheLoai.Margin = new Padding(5);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(243, 40);
            cboTheLoai.TabIndex = 27;
            cboTheLoai.SelectedIndexChanged += cboTheLoai_SelectedIndexChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(2051, 19);
            pictureBox6.Margin = new Padding(5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(86, 75);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // btnXemGH
            // 
            btnXemGH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXemGH.AutoSize = true;
            btnXemGH.BackColor = Color.FromArgb(0, 134, 197);
            btnXemGH.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXemGH.ForeColor = Color.White;
            btnXemGH.Location = new Point(2039, 35);
            btnXemGH.Margin = new Padding(5);
            btnXemGH.Name = "btnXemGH";
            btnXemGH.Size = new Size(301, 62);
            btnXemGH.TabIndex = 25;
            btnXemGH.Text = "Xem giỏ hàng";
            btnXemGH.TextAlign = ContentAlignment.MiddleRight;
            btnXemGH.UseVisualStyleBackColor = false;
            btnXemGH.Click += btnXemGH_Click;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHome.ForeColor = SystemColors.ButtonHighlight;
            labelHome.Location = new Point(114, 27);
            labelHome.Margin = new Padding(5, 0, 5, 0);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(376, 51);
            labelHome.TabIndex = 21;
            labelHome.Text = "11PM BOOKSTORE";
            labelHome.Click += labelHome_Click;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.ErrorImage = Properties.Resources.books;
            pictureBoxHome.Image = (Image)resources.GetObject("pictureBoxHome.Image");
            pictureBoxHome.Location = new Point(15, 5);
            pictureBoxHome.Margin = new Padding(5);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(97, 90);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 20;
            pictureBoxHome.TabStop = false;
            pictureBoxHome.Click += labelHome_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(757, 35);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(730, 39);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(554, 30);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 40);
            label4.TabIndex = 3;
            label4.Text = "Tìm kiếm";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 136);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 5, 0, 5);
            menuStrip1.Size = new Size(202, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.IndianRed;
            imageList1.Images.SetKeyName(0, "add.jpg");
            imageList1.Images.SetKeyName(1, "Recycle-Bin.png");
            // 
            // panelGH
            // 
            panelGH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGH.BackColor = Color.LightCyan;
            panelGH.Controls.Add(groupBox2);
            panelGH.Controls.Add(dataGridView2);
            panelGH.ForeColor = SystemColors.ControlText;
            panelGH.Location = new Point(10, 42);
            panelGH.Margin = new Padding(5);
            panelGH.Name = "panelGH";
            panelGH.Size = new Size(2473, 539);
            panelGH.TabIndex = 1;
            panelGH.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(0, 66, 116);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btnXoaGH);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(txtTongThanhTien);
            groupBox2.Controls.Add(txtTongSoLuong);
            groupBox2.Location = new Point(31, 262);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(2428, 238);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(58, 45);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(152, 37);
            label13.TabIndex = 17;
            label13.Text = "Số lượng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(58, 141);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(160, 37);
            label12.TabIndex = 17;
            label12.Text = "Tổng tiền";
            // 
            // btnXoaGH
            // 
            btnXoaGH.Anchor = AnchorStyles.Top;
            btnXoaGH.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaGH.ImageIndex = 1;
            btnXoaGH.ImageList = imageList1;
            btnXoaGH.Location = new Point(1576, 66);
            btnXoaGH.Margin = new Padding(5);
            btnXoaGH.Name = "btnXoaGH";
            btnXoaGH.Size = new Size(249, 147);
            btnXoaGH.TabIndex = 31;
            btnXoaGH.Text = "Xóa sản phẩm";
            btnXoaGH.TextAlign = ContentAlignment.MiddleRight;
            btnXoaGH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaGH.UseVisualStyleBackColor = true;
            btnXoaGH.Click += btnXoaGH_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Top;
            btnThanhToan.BackColor = Color.FromArgb(0, 134, 197);
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = SystemColors.ButtonHighlight;
            btnThanhToan.Location = new Point(1878, 45);
            btnThanhToan.Margin = new Padding(5);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(450, 173);
            btnThanhToan.TabIndex = 32;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtTongThanhTien
            // 
            txtTongThanhTien.BackColor = Color.White;
            txtTongThanhTien.Enabled = false;
            txtTongThanhTien.Font = new Font("Segoe UI", 12F);
            txtTongThanhTien.Location = new Point(252, 141);
            txtTongThanhTien.Margin = new Padding(5);
            txtTongThanhTien.Name = "txtTongThanhTien";
            txtTongThanhTien.Size = new Size(337, 50);
            txtTongThanhTien.TabIndex = 17;
            txtTongThanhTien.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTongSoLuong
            // 
            txtTongSoLuong.BackColor = Color.White;
            txtTongSoLuong.Enabled = false;
            txtTongSoLuong.Font = new Font("Segoe UI", 12F);
            txtTongSoLuong.Location = new Point(252, 45);
            txtTongSoLuong.Margin = new Padding(5);
            txtTongSoLuong.Name = "txtTongSoLuong";
            txtTongSoLuong.Size = new Size(227, 50);
            txtTongSoLuong.TabIndex = 17;
            txtTongSoLuong.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(29, 5);
            dataGridView2.Margin = new Padding(5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(2429, 248);
            dataGridView2.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(0, 66, 116);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, thểLoạiToolStripMenuItem, khoSáchToolStripMenuItem });
            menuStrip2.Location = new Point(0, 107);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(10, 5, 0, 5);
            menuStrip2.Size = new Size(2483, 51);
            menuStrip2.TabIndex = 19;
            menuStrip2.Text = "menuStrip2";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trangChủToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(192, 41);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            trangChủToolStripMenuItem.Click += trangChủToolStripMenuItem_Click;
            // 
            // thểLoạiToolStripMenuItem
            // 
            thểLoạiToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thểLoạiToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            thểLoạiToolStripMenuItem.Size = new Size(182, 41);
            thểLoạiToolStripMenuItem.Text = "Giới thiệu";
            thểLoạiToolStripMenuItem.Click += thểLoạiToolStripMenuItem_Click;
            // 
            // khoSáchToolStripMenuItem
            // 
            khoSáchToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            khoSáchToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            khoSáchToolStripMenuItem.Name = "khoSáchToolStripMenuItem";
            khoSáchToolStripMenuItem.Size = new Size(179, 41);
            khoSáchToolStripMenuItem.Text = "Kho sách";
            khoSáchToolStripMenuItem.Click += khoSáchToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtMaDV);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(txtLoaiSach);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(btnThemGH);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTenDV);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(5, 685);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(2478, 269);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(4, 51, 94);
            label9.Location = new Point(93, 96);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(167, 42);
            label9.TabIndex = 13;
            label9.Text = "Mã sách";
            // 
            // txtMaDV
            // 
            txtMaDV.Anchor = AnchorStyles.Top;
            txtMaDV.BackColor = Color.White;
            txtMaDV.Enabled = false;
            txtMaDV.Font = new Font("Segoe UI", 10F);
            txtMaDV.Location = new Point(1424, 186);
            txtMaDV.Margin = new Padding(5);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(105, 43);
            txtMaDV.TabIndex = 28;
            txtMaDV.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Anchor = AnchorStyles.Top;
            txtSoLuong.BackColor = Color.White;
            txtSoLuong.Font = new Font("Segoe UI", 8F);
            txtSoLuong.Location = new Point(1966, 195);
            txtSoLuong.Margin = new Padding(5);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(240, 36);
            txtSoLuong.TabIndex = 25;
            txtSoLuong.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(4, 51, 94);
            label7.Location = new Point(93, 182);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(181, 42);
            label7.TabIndex = 6;
            label7.Text = "Tên sách";
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.Top;
            txtGia.BackColor = Color.White;
            txtGia.Enabled = false;
            txtGia.Font = new Font("Segoe UI", 10F);
            txtGia.Location = new Point(1310, 96);
            txtGia.Margin = new Padding(5);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(217, 43);
            txtGia.TabIndex = 16;
            txtGia.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(4, 51, 94);
            label10.Location = new Point(1740, 182);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(174, 42);
            label10.TabIndex = 14;
            label10.Text = "Số lượng";
            // 
            // txtMaSach
            // 
            txtMaSach.Anchor = AnchorStyles.Top;
            txtMaSach.BackColor = Color.White;
            txtMaSach.Enabled = false;
            txtMaSach.Font = new Font("Segoe UI", 10F);
            txtMaSach.Location = new Point(315, 104);
            txtMaSach.Margin = new Padding(5);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(220, 43);
            txtMaSach.TabIndex = 11;
            txtMaSach.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLoaiSach
            // 
            txtLoaiSach.Anchor = AnchorStyles.Top;
            txtLoaiSach.BackColor = Color.White;
            txtLoaiSach.Enabled = false;
            txtLoaiSach.Font = new Font("Segoe UI", 10F);
            txtLoaiSach.Location = new Point(764, 106);
            txtLoaiSach.Margin = new Padding(5);
            txtLoaiSach.Name = "txtLoaiSach";
            txtLoaiSach.Size = new Size(188, 43);
            txtLoaiSach.TabIndex = 9;
            txtLoaiSach.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.Top;
            txtTenSach.BackColor = Color.White;
            txtTenSach.Enabled = false;
            txtTenSach.Font = new Font("Segoe UI", 10F);
            txtTenSach.Location = new Point(315, 186);
            txtTenSach.Margin = new Padding(5);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(636, 43);
            txtTenSach.TabIndex = 7;
            txtTenSach.TextAlign = HorizontalAlignment.Center;
            // 
            // btnThemGH
            // 
            btnThemGH.Anchor = AnchorStyles.Top;
            btnThemGH.BackColor = Color.FromArgb(0, 97, 169);
            btnThemGH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemGH.ForeColor = SystemColors.ButtonHighlight;
            btnThemGH.ImageIndex = 0;
            btnThemGH.ImageList = imageList1;
            btnThemGH.Location = new Point(1740, 85);
            btnThemGH.Margin = new Padding(5);
            btnThemGH.Name = "btnThemGH";
            btnThemGH.Size = new Size(468, 82);
            btnThemGH.TabIndex = 4;
            btnThemGH.Text = "Thêm vào giỏ hàng";
            btnThemGH.TextAlign = ContentAlignment.MiddleRight;
            btnThemGH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemGH.UseVisualStyleBackColor = false;
            btnThemGH.Click += btnThemGH_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(4, 51, 94);
            label11.Location = new Point(1120, 96);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(79, 42);
            label11.TabIndex = 15;
            label11.Text = "Giá";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(4, 51, 94);
            label8.Location = new Point(548, 96);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(188, 42);
            label8.TabIndex = 8;
            label8.Text = "Loại sách";
            // 
            // txtTenDV
            // 
            txtTenDV.Anchor = AnchorStyles.Top;
            txtTenDV.BackColor = Color.White;
            txtTenDV.Enabled = false;
            txtTenDV.Font = new Font("Segoe UI", 10F);
            txtTenDV.Location = new Point(1310, 186);
            txtTenDV.Margin = new Padding(5);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(106, 43);
            txtTenDV.TabIndex = 24;
            txtTenDV.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(4, 51, 94);
            label5.Location = new Point(1120, 182);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 42);
            label5.TabIndex = 22;
            label5.Text = "Dịch vụ";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(panel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(2483, 1399);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "kho sách";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 37);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2473, 1357);
            panel2.TabIndex = 35;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panelGH);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(0, 824);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(2473, 533);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Text = "Giỏ hàng";
            // 
            // FormKH
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2483, 1399);
            Controls.Add(menuStrip2);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "FormKH";
            Text = "FormKH";
            Load += FormKH_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            panelGH.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private ImageList imageList1;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelGH;
        private DataGridView dataGridView2;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem thểLoạiToolStripMenuItem;
        private Label labelHome;
        private PictureBox pictureBoxHome;
        private PictureBox pictureBox6;
        private Button btnXemGH;
        private GroupBox groupBox2;
        private Label label13;
        private Label label12;
        private TextBox txtTongThanhTien;
        private TextBox txtTongSoLuong;
        private Button btnThanhToan;
        private Button btnXoaGH;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtMaDV;
        private TextBox txtSoLuong;
        private Label label7;
        private TextBox txtGia;
        private Label label10;
        private TextBox txtMaSach;
        private TextBox txtLoaiSach;
        private TextBox txtTenSach;
        private Button btnThemGH;
        private Label label11;
        private Label label8;
        private TextBox txtTenDV;
        private Label label5;
        private GroupBox groupBox3;
        private Panel panel2;
        private GroupBox groupBox4;
        private ToolStripMenuItem khoSáchToolStripMenuItem;
        private Label label1;
        private ComboBox cboTheLoai;
        private TextBox txtSearch;
        private Button btnTimKiemSach;
    }
}