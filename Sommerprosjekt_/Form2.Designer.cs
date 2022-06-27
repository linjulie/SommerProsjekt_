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
            this.components = new System.ComponentModel.Container();
            this.popUpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popUpDataSet = new Sommerprosjekt_.PopUpDataSet();
            this.label_header = new System.Windows.Forms.Label();
            this.label_section = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // popUpDataSetBindingSource
            // 
            this.popUpDataSetBindingSource.DataSource = this.popUpDataSet;
            this.popUpDataSetBindingSource.Position = 0;
            // 
            // popUpDataSet
            // 
            this.popUpDataSet.DataSetName = "PopUpDataSet";
            this.popUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Location = new System.Drawing.Point(85, 45);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(53, 16);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Header";
            // 
            // label_section
            // 
            this.label_section.AutoSize = true;
            this.label_section.Location = new System.Drawing.Point(88, 102);
            this.label_section.Name = "label_section";
            this.label_section.Size = new System.Drawing.Size(52, 16);
            this.label_section.TabIndex = 1;
            this.label_section.Text = "Sectoin";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_section);
            this.Controls.Add(this.label_header);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource popUpDataSetBindingSource;
        private PopUpDataSet popUpDataSet;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_section;
    }
}