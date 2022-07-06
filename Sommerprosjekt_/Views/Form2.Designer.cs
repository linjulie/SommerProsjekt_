using System.Drawing;

namespace Sommerprosjekt_
{
    partial class Form2
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
            this.header_lbl = new System.Windows.Forms.Label();
            this.section_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_lbl
            // 
            this.header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_lbl.Location = new System.Drawing.Point(39, 23);
            this.header_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header_lbl.MaximumSize = new System.Drawing.Size(400, 20);
            this.header_lbl.Name = "header_lbl";
            this.header_lbl.Size = new System.Drawing.Size(400, 20);
            this.header_lbl.TabIndex = 2;
            this.header_lbl.Text = "cxvcxvxc";
            // 
            // section_lbl
            // 
            this.section_lbl.AutoSize = true;
            this.section_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_lbl.Location = new System.Drawing.Point(43, 10);
            this.section_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.section_lbl.MaximumSize = new System.Drawing.Size(400, 0);
            this.section_lbl.Name = "section_lbl";
            this.section_lbl.Size = new System.Drawing.Size(38, 18);
            this.section_lbl.TabIndex = 3;
            this.section_lbl.Text = "xcvc";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.section_lbl);
            this.panel1.Location = new System.Drawing.Point(-3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 637);
            this.panel1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 696);
            this.Controls.Add(this.header_lbl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "PopUp Preview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label header_lbl;
        private System.Windows.Forms.Label section_lbl;
        private System.Windows.Forms.Panel panel1;
    }
}