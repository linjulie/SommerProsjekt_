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
            this.btn_exit = new System.Windows.Forms.Button();
            this.txtBox_Output = new System.Windows.Forms.TextBox();
            this.txt_headerOutput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.popUpDataSet = new Sommerprosjekt_.PopUpDataSet();
            this.popUpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(567, 321);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "btn.test";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txtBox_Output
            // 
            this.txtBox_Output.Location = new System.Drawing.Point(65, 76);
            this.txtBox_Output.Multiline = true;
            this.txtBox_Output.Name = "txtBox_Output";
            this.txtBox_Output.ReadOnly = true;
            this.txtBox_Output.Size = new System.Drawing.Size(448, 323);
            this.txtBox_Output.TabIndex = 1;
            // 
            // txt_headerOutput
            // 
            this.txt_headerOutput.Location = new System.Drawing.Point(65, 31);
            this.txt_headerOutput.Name = "txt_headerOutput";
            this.txt_headerOutput.ReadOnly = true;
            this.txt_headerOutput.Size = new System.Drawing.Size(448, 22);
            this.txt_headerOutput.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.popUpDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(539, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // popUpDataSet
            // 
            this.popUpDataSet.DataSetName = "PopUpDataSet";
            this.popUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popUpDataSetBindingSource
            // 
            this.popUpDataSetBindingSource.DataSource = this.popUpDataSet;
            this.popUpDataSetBindingSource.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_headerOutput);
            this.Controls.Add(this.txtBox_Output);
            this.Controls.Add(this.btn_exit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txtBox_Output;
        private System.Windows.Forms.TextBox txt_headerOutput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource popUpDataSetBindingSource;
        private PopUpDataSet popUpDataSet;
    }
}