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
            this.SuspendLayout();
            // 
            // header_lbl
            // 
            this.header_lbl.AutoSize = true;
            this.header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_lbl.Location = new System.Drawing.Point(29, 13);
            this.header_lbl.Name = "header_lbl";
            this.header_lbl.Size = new System.Drawing.Size(0, 16);
            this.header_lbl.TabIndex = 2;
            // 
            // section_lbl
            // 
            this.section_lbl.AutoSize = true;
            this.section_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_lbl.Location = new System.Drawing.Point(29, 80);
            this.section_lbl.Name = "section_lbl";
            this.section_lbl.Size = new System.Drawing.Size(0, 16);
            this.section_lbl.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.section_lbl);
            this.Controls.Add(this.header_lbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label header_lbl;
        private System.Windows.Forms.Label section_lbl;
    }
}