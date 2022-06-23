using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sommerprosjekt_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Limited to x amount of characters
            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //When OK is pressed, save text to database

        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // when pressed window will be exited
            this.Close();
            
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); 


        }

        private void txtbox_Header_TextChanged(object sender, EventArgs e)
        {
            //Limited to one line

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
