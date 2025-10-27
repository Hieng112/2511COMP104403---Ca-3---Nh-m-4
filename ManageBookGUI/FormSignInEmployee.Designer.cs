namespace ManageBookGUI
{
    partial class FormSignInEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignInEmployee));
            labelTitle = new Label();
            labelAccount = new Label();
            textBoxTaiKhoan = new TextBox();
            textBoxMatKhau = new TextBox();
            labelPassword = new Label();
            btnSignIn = new Button();
            pictureBox1 = new PictureBox();
            radioButtonNV = new RadioButton();
            radioButtonQTV = new RadioButton();
            label1 = new Label();
            btnTogglePW = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.White;
            labelTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(4, 51, 94);
            labelTitle.Location = new Point(578, 131);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(341, 64);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐĂNG NHẬP";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.BackColor = Color.FromArgb(4, 51, 94);
            labelAccount.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAccount.ForeColor = SystemColors.ButtonHighlight;
            labelAccount.Location = new Point(431, 531);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(148, 32);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "Tài khoản";
            // 
            // textBoxTaiKhoan
            // 
            textBoxTaiKhoan.Location = new Point(603, 531);
            textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            textBoxTaiKhoan.Size = new Size(381, 39);
            textBoxTaiKhoan.TabIndex = 2;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Location = new Point(603, 603);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(381, 39);
            textBoxMatKhau.TabIndex = 4;
            textBoxMatKhau.UseSystemPasswordChar = true;
            textBoxMatKhau.TextChanged += tBoxPassword_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.FromArgb(4, 51, 94);
            labelPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = SystemColors.ButtonHighlight;
            labelPassword.Location = new Point(431, 603);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(138, 32);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.HighlightText;
            btnSignIn.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignIn.ForeColor = Color.FromArgb(4, 51, 94);
            btnSignIn.ImageAlign = ContentAlignment.BottomCenter;
            btnSignIn.Location = new Point(630, 701);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(200, 77);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "ĐĂNG NHẬP";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1433, 965);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // radioButtonNV
            // 
            radioButtonNV.AutoSize = true;
            radioButtonNV.BackColor = SystemColors.ButtonHighlight;
            radioButtonNV.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonNV.ForeColor = Color.FromArgb(4, 51, 94);
            radioButtonNV.Location = new Point(603, 323);
            radioButtonNV.Margin = new Padding(5);
            radioButtonNV.Name = "radioButtonNV";
            radioButtonNV.Size = new Size(227, 46);
            radioButtonNV.TabIndex = 7;
            radioButtonNV.TabStop = true;
            radioButtonNV.Text = "Nhân viên";
            radioButtonNV.UseVisualStyleBackColor = false;
            radioButtonNV.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonQTV
            // 
            radioButtonQTV.AutoSize = true;
            radioButtonQTV.BackColor = SystemColors.ButtonHighlight;
            radioButtonQTV.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonQTV.ForeColor = Color.FromArgb(4, 51, 94);
            radioButtonQTV.Location = new Point(603, 420);
            radioButtonQTV.Margin = new Padding(5);
            radioButtonQTV.Name = "radioButtonQTV";
            radioButtonQTV.Size = new Size(273, 46);
            radioButtonQTV.TabIndex = 8;
            radioButtonQTV.TabStop = true;
            radioButtonQTV.Text = "Quản trị viên";
            radioButtonQTV.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(563, 244);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 33);
            label1.TabIndex = 9;
            label1.Text = "Vui lòng chọn chức năng";
            label1.Click += label1_Click;
            // 
            // btnTogglePW
            // 
            btnTogglePW.Location = new Point(994, 603);
            btnTogglePW.Margin = new Padding(5);
            btnTogglePW.Name = "btnTogglePW";
            btnTogglePW.Size = new Size(36, 43);
            btnTogglePW.TabIndex = 10;
            btnTogglePW.Text = "👁️";
            btnTogglePW.UseVisualStyleBackColor = true;
            btnTogglePW.Click += btnTogglePW_Click;
            // 
            // FormSignInEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1428, 962);
            Controls.Add(btnTogglePW);
            Controls.Add(label1);
            Controls.Add(radioButtonQTV);
            Controls.Add(radioButtonNV);
            Controls.Add(btnSignIn);
            Controls.Add(textBoxMatKhau);
            Controls.Add(labelPassword);
            Controls.Add(textBoxTaiKhoan);
            Controls.Add(labelAccount);
            Controls.Add(labelTitle);
            Controls.Add(pictureBox1);
            Name = "FormSignInEmployee";
            Text = "Đăng nhập Nhân Viên";
            Load += FormSignInEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelAccount;
        private TextBox textBoxTaiKhoan;
        private TextBox textBoxMatKhau;
        private Label labelPassword;
        private Button btnSignIn;
        private PictureBox pictureBox1;
        private RadioButton radioButtonNV;
        private RadioButton radioButtonQTV;
        private Label label1;
        private Button btnTogglePW;
    }
}