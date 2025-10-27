namespace ManageBookGUI
{
    partial class FormSignInCustomer
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
            label1 = new Label();
            labelAccount = new Label();
            tBoxAccount = new TextBox();
            tBoxPassword = new TextBox();
            labelPassword = new Label();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(348, 50);
            label1.Name = "label1";
            label1.Size = new Size(280, 49);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.Click += label1_Click;
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Location = new Point(182, 157);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(115, 32);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "Tài khoản";
            // 
            // tBoxAccount
            // 
            tBoxAccount.Location = new Point(348, 152);
            tBoxAccount.Name = "tBoxAccount";
            tBoxAccount.Size = new Size(384, 39);
            tBoxAccount.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Location = new Point(348, 229);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(384, 39);
            tBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(182, 234);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(115, 32);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.LightSteelBlue;
            btnSignIn.Font = new Font("Times New Roman", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignIn.ForeColor = SystemColors.ActiveCaptionText;
            btnSignIn.Location = new Point(401, 310);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(166, 59);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // FormSignInCustomer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 477);
            Controls.Add(btnSignIn);
            Controls.Add(tBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(tBoxAccount);
            Controls.Add(labelAccount);
            Controls.Add(label1);
            Name = "FormSignInCustomer";
            Text = "Đăng nhập Khách Hàng";
            Load += FormSignInCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelAccount;
        private TextBox tBoxAccount;
        private TextBox tBoxPassword;
        private Label labelPassword;
        private Button btnSignIn;
    }
}