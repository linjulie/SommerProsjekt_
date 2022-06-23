using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
            
            //saves the entered text to the demo tetx file. replaces previous text if new text is entered
            TextWriter txt = new StreamWriter("C:\\demo\\demo.txt");
            txt.Write(inputBox1.Text);
            txt.Close();

            TextWriter txt2 = new StreamWriter("C:\\demo\\header.txt");
            txt2.Write(txtbox_Header.Text);
            txt2.Close();
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // when pressed window will be exited
            this.Close();
            
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            //Opens a window showing the preview of the pop-up
            Form2 form2 = new Form2();
            form2.ShowDialog(); 


        }

        private void txtbox_Header_TextChanged(object sender, EventArgs e)
        {
            //user can enter a header limited to one line
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
