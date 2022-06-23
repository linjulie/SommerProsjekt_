using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sommerprosjekt_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
      
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string header = System.IO.File.ReadLines("C:\\demo\\header.txt").First();
            txt_headerOutput.Text = header;

            // read from text file: 
            string text = System.IO.File.ReadAllText("C:\\demo\\demo.txt");
            txtBox_Output.Text = text;
            
            //Will show preview of text written in previous form...

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
