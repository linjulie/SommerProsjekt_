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

        private void Form2_Load(object sender, EventArgs e)
        {
            /*string connectionString;
            string sql1, sql2;
            
            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Trusted_Connection=True";
            sql1 = "SELECT [Header], [Section] FROM dbo.PopUp WHERE PopUpID = 2";


            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql1, cnn);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  */ 


        }

       
    }
}
