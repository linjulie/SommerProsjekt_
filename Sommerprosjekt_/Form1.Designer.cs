namespace Sommerprosjekt_
{
    partial class Form1
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
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtbox_Header = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(73, 81);
            this.inputBox1.Multiline = true;
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(460, 280);
            this.inputBox1.TabIndex = 2;
            this.inputBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(584, 338);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(584, 380);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(75, 23);
            this.btn_Preview.TabIndex = 4;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(584, 424);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txtbox_Header
            // 
            this.txtbox_Header.Location = new System.Drawing.Point(121, 41);
            this.txtbox_Header.Name = "txtbox_Header";
            this.txtbox_Header.Size = new System.Drawing.Size(335, 22);
            this.txtbox_Header.TabIndex = 6;
            this.txtbox_Header.TextChanged += new System.EventHandler(this.txtbox_Header_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Header";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Header);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.inputBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txtbox_Header;
        private System.Windows.Forms.Label label1;
    }
}

