namespace ABCAutomotive.FrontEnd.StartUpForms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ABCAutomotive.FrontEnd.Properties.Resources.ABCLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // chkRemember
            // 
            this.chkRemember.AccessibleDescription = "Remember password";
            this.chkRemember.AccessibleName = "Remember Password";
            this.chkRemember.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkRemember.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRemember.Location = new System.Drawing.Point(181, 116);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(136, 24);
            this.chkRemember.TabIndex = 3;
            this.chkRemember.Text = "Remember Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(181, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(178, 64);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(220, 23);
            this.PasswordLabel.TabIndex = 23;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(178, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(220, 23);
            this.UsernameLabel.TabIndex = 21;
            this.UsernameLabel.Text = "User name";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(178, 166);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(56, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 166);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 214);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.CheckBox chkRemember;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}