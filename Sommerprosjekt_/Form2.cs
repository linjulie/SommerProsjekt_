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
            //BindGrid();
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

        /*private void BindGrid()
        {
            string constring = @"Data Source=\PopUp.mdf";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM PopUp", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }*/

    }
}
