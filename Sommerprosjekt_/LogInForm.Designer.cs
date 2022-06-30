namespace login_form
{
    partial class loginForm
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancelLogin = new System.Windows.Forms.Button();
            this.txtbox_userName = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(78, 279);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 38);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_cancelLogin
            // 
            this.btn_cancelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelLogin.Location = new System.Drawing.Point(311, 279);
            this.btn_cancelLogin.Name = "btn_cancelLogin";
            this.btn_cancelLogin.Size = new System.Drawing.Size(91, 38);
            this.btn_cancelLogin.TabIndex = 1;
            this.btn_cancelLogin.Text = "Cancel";
            this.btn_cancelLogin.UseVisualStyleBackColor = true;
            // 
            // txtbox_userName
            // 
            this.txtbox_userName.Location = new System.Drawing.Point(311, 97);
            this.txtbox_userName.Name = "txtbox_userName";
            this.txtbox_userName.Size = new System.Drawing.Size(100, 22);
            this.txtbox_userName.TabIndex = 2;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(311, 168);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(100, 22);
            this.txtbox_password.TabIndex = 3;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.Location = new System.Drawing.Point(75, 103);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(116, 25);
            this.label_userName.TabIndex = 4;
            this.label_userName.Text = "User name";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(75, 174);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(106, 25);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Password";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 365);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_userName);
            this.Controls.Add(this.btn_cancelLogin);
            this.Controls.Add(this.btn_login);
            this.Name = "loginForm";
            this.Text = "Log In Form";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancelLogin;
        private System.Windows.Forms.TextBox txtbox_userName;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_password;
    }
}