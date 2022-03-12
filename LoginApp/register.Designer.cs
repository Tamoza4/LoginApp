
namespace LoginApp
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.btnExit = new LoginApp.TamozaButton();
            this.btnLogin = new LoginApp.TamozaButton();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextUser = new System.Windows.Forms.Label();
            this.TextPass = new System.Windows.Forms.Label();
            this.TextEmail = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundColor = System.Drawing.Color.Red;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(126, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.BackgroundColor = System.Drawing.Color.Green;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(326, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Register";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxUser.Location = new System.Drawing.Point(170, 158);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(294, 22);
            this.TextBoxUser.TabIndex = 8;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxName.Location = new System.Drawing.Point(170, 191);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(294, 22);
            this.TextBoxName.TabIndex = 9;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxEmail.Location = new System.Drawing.Point(170, 226);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(294, 22);
            this.TextBoxEmail.TabIndex = 10;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxPass.Location = new System.Drawing.Point(170, 261);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(294, 22);
            this.TextBoxPass.TabIndex = 11;
            // 
            // TextUser
            // 
            this.TextUser.AutoSize = true;
            this.TextUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.ForeColor = System.Drawing.SystemColors.Control;
            this.TextUser.Location = new System.Drawing.Point(82, 160);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(71, 15);
            this.TextUser.TabIndex = 12;
            this.TextUser.Text = "User Name:";
            // 
            // TextPass
            // 
            this.TextPass.AutoSize = true;
            this.TextPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPass.ForeColor = System.Drawing.SystemColors.Control;
            this.TextPass.Location = new System.Drawing.Point(82, 266);
            this.TextPass.Name = "TextPass";
            this.TextPass.Size = new System.Drawing.Size(63, 15);
            this.TextPass.TabIndex = 13;
            this.TextPass.Text = "Password:";
            // 
            // TextEmail
            // 
            this.TextEmail.AutoSize = true;
            this.TextEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.TextEmail.Location = new System.Drawing.Point(82, 231);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(42, 15);
            this.TextEmail.TabIndex = 14;
            this.TextEmail.Text = "Email:";
            // 
            // TextName
            // 
            this.TextName.AutoSize = true;
            this.TextName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.ForeColor = System.Drawing.SystemColors.Control;
            this.TextName.Location = new System.Drawing.Point(82, 191);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(42, 15);
            this.TextName.TabIndex = 15;
            this.TextName.Text = "Name:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(18, 411);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<-- Back To Login Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(254, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Register";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextPass);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.register_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TamozaButton btnExit;
        private TamozaButton btnLogin;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label TextUser;
        private System.Windows.Forms.Label TextPass;
        private System.Windows.Forms.Label TextEmail;
        private System.Windows.Forms.Label TextName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}