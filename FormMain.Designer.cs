namespace ManageBookGUI
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelTilte = new Label();
            panel1 = new Panel();
            grBoxContact = new GroupBox();
            labelGroup = new Label();
            labelPhone = new Label();
            pictureBox1 = new PictureBox();
            btnDangNhapNhanVien = new Button();
            btnMuaSach = new Button();
            btnCSKH = new Button();
            btnThoat = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            grBoxContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelTilte
            // 
            labelTilte.AutoSize = true;
            labelTilte.Dock = DockStyle.Fill;
            labelTilte.Font = new Font("Microsoft Sans Serif", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTilte.ForeColor = Color.FromArgb(255, 128, 0);
            labelTilte.Location = new Point(0, 0);
            labelTilte.Margin = new Padding(2, 0, 2, 0);
            labelTilte.Name = "labelTilte";
            labelTilte.Size = new Size(592, 104);
            labelTilte.TabIndex = 6;
            labelTilte.Text = "11PM's Book";
            labelTilte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(grBoxContact);
            panel1.Controls.Add(labelTilte);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 73);
            panel1.TabIndex = 7;
            // 
            // grBoxContact
            // 
            grBoxContact.Controls.Add(labelGroup);
            grBoxContact.Controls.Add(labelPhone);
            grBoxContact.Dock = DockStyle.Right;
            grBoxContact.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grBoxContact.Location = new Point(816, 0);
            grBoxContact.Margin = new Padding(2);
            grBoxContact.Name = "grBoxContact";
            grBoxContact.Padding = new Padding(2);
            grBoxContact.Size = new Size(359, 73);
            grBoxContact.TabIndex = 9;
            grBoxContact.TabStop = false;
            grBoxContact.Text = "Liên Hệ";
            // 
            // labelGroup
            // 
            labelGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelGroup.Location = new Point(13, 23);
            labelGroup.Margin = new Padding(2, 0, 2, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(306, 33);
            labelGroup.TabIndex = 7;
            labelGroup.Text = "11PM Group Support";
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelPhone.Location = new Point(213, 23);
            labelPhone.Margin = new Padding(2, 0, 2, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(221, 33);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "📞 09812xxxxx";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FormMain_Background;
            pictureBox1.Location = new Point(-6, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1919, 997);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnDangNhapNhanVien
            // 
            btnDangNhapNhanVien.BackColor = Color.FromArgb(4, 51, 94);
            btnDangNhapNhanVien.Font = new Font("Microsoft Sans Serif", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhapNhanVien.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhapNhanVien.Location = new Point(133, 290);
            btnDangNhapNhanVien.Margin = new Padding(5);
            btnDangNhapNhanVien.Name = "btnDangNhapNhanVien";
            btnDangNhapNhanVien.Size = new Size(460, 142);
            btnDangNhapNhanVien.TabIndex = 5;
            btnDangNhapNhanVien.Text = "Đăng nhập nhân viên";
            btnDangNhapNhanVien.UseVisualStyleBackColor = false;
            btnDangNhapNhanVien.Click += btnDangNhapNhanVien_Click;
            // 
            // btnMuaSach
            // 
            btnMuaSach.BackColor = Color.FromArgb(4, 51, 94);
            btnMuaSach.Font = new Font("Microsoft Sans Serif", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMuaSach.ForeColor = SystemColors.ButtonHighlight;
            btnMuaSach.Location = new Point(133, 442);
            btnMuaSach.Margin = new Padding(5);
            btnMuaSach.Name = "btnMuaSach";
            btnMuaSach.Size = new Size(460, 142);
            btnMuaSach.TabIndex = 10;
            btnMuaSach.Text = "Xem, Mua sách";
            btnMuaSach.UseVisualStyleBackColor = false;
            btnMuaSach.Click += btnMuaSach_Click;
            // 
            // btnCSKH
            // 
            btnCSKH.BackColor = Color.FromArgb(4, 51, 94);
            btnCSKH.Font = new Font("Microsoft Sans Serif", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCSKH.ForeColor = SystemColors.ButtonHighlight;
            btnCSKH.Location = new Point(133, 594);
            btnCSKH.Margin = new Padding(5);
            btnCSKH.Name = "btnCSKH";
            btnCSKH.Size = new Size(460, 142);
            btnCSKH.TabIndex = 11;
            btnCSKH.Text = "Chăm sóc khách hàng";
            btnCSKH.UseVisualStyleBackColor = false;
            btnCSKH.Click += btnCSKH_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(4, 51, 94);
            btnThoat.Font = new Font("Microsoft Sans Serif", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(133, 746);
            btnThoat.Margin = new Padding(5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(460, 142);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Tai Le", 40.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(4, 51, 94);
            textBox1.Location = new Point(601, 99);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1058, 137);
            textBox1.TabIndex = 13;
            textBox1.Text = "11PM BOOKSTORE";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(239, 19);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(322, 307);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1909, 990);
            Controls.Add(textBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnCSKH);
            Controls.Add(btnMuaSach);
            Controls.Add(btnDangNhapNhanVien);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "11PM BOOKSTORE";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grBoxContact.ResumeLayout(false);
            grBoxContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTilte;
        private Panel panel1;
        private Label labelPhone;
        private Label labelGroup;
        private GroupBox grBoxContact;
        private PictureBox pictureBox1;
        private Button btnDangNhapNhanVien;
        private Button btnMuaSach;
        private Button btnCSKH;
        private Button btnThoat;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}
