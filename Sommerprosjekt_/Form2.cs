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
        public Form2(bool IsHeader)
        {
            InitializeComponent();
            
      
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection connection;
            string sql1, sql2;
            
            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Trusted_Connection=True";
            
            sql1 = "SELECT [Header] FROM dbo.PopUp WHERE PopUpID = 2";
            sql2 = "SELECT [Section] FROM dbo.PopUp WHERE PopUpID = 2";
            
            

        }


    }
}
