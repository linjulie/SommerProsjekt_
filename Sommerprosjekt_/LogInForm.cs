using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace login_form
{
    public partial class loginForm : Form
    {
        SqlConnection con = new SqlConnection();
        public loginForm()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=SommerProsjekt;Integrated Security=True";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENTDataSet.login' table. You can move, or remove it, as needed.  
            //this.loginTableAdapter.Fill(this.sTUDENTDataSet.login);  
            SqlConnection con = new SqlConnection("Data Source=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=SommerPorsjekt;Integrated Security=True");
            con.Open();

            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=SommerProsjekt;Integrated Security=True";
            con.Open();
            //string UserID = txtbox_userName.Text;
           // string Password = txtbox_password.Text;
            SqlCommand cmd = new SqlCommand("select userid,password from login where UserID='" + txtbox_userName.Text + "'and Password='" + txtbox_password.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome");
                loginForm form1 = new loginForm();
                form1.Show();;
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}