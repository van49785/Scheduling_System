namespace ASM2_DDD
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxEmail = new TextBox();
            tbxPass = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            kbxPass = new CheckBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(201, 114);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 153);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 229);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(92, 176);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(296, 27);
            tbxEmail.TabIndex = 4;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(92, 261);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(296, 27);
            tbxPass.TabIndex = 5;
            tbxPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkViolet;
            btnLogin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(109, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 49);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Yellow;
            btnCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(263, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 49);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // kbxPass
            // 
            kbxPass.AutoSize = true;
            kbxPass.Location = new Point(94, 302);
            kbxPass.Name = "kbxPass";
            kbxPass.Size = new Size(134, 24);
            kbxPass.TabIndex = 8;
            kbxPass.Text = "Show password";
            kbxPass.UseVisualStyleBackColor = true;
            kbxPass.CheckedChanged += kbxPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(127, 39);
            label5.Name = "label5";
            label5.Size = new Size(235, 32);
            label5.TabIndex = 9;
            label5.Text = "Scheduling System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(470, 450);
            Controls.Add(label5);
            Controls.Add(kbxPass);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(tbxPass);
            Controls.Add(tbxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Loign";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxEmail;
        private TextBox tbxPass;
        private Button btnLogin;
        private Button btnCancel;
        private CheckBox kbxPass;
        private Label label5;
    }
}