using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sommerProsjektDataSet.PopUp' table. You can move, or remove it, as needed.
            this.popUpTableAdapter.Fill(this.sommerProsjektDataSet.PopUp);
            
        }

        //------------------Inserts new object-----------------------------------------
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //define variables
            string connectionString;
            string sql;

            // connection string to database
            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Trusted_Connection=True";
            //sql query that inserts new values to the dbo.PopUp table
            sql = "INSERT INTO dbo.PopUp ([PopUpID], [Header], [Section]) VALUES (@id, @header, @section)";
            

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    
                    //this will be changed with aout incremented id...
                    //count amount of columns in PopUp table
                    SqlCommand cmd2 = new SqlCommand("SELECT count(*) AS NUMBEROFCOLUMNS FROM dbo.PopUp", cnn);
                    //saves result in an integer, this will be used to give the new popup object an correct id
                    int result = (int)cmd2.ExecuteScalar();
                    
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    //Adds the new popup object to the database  
                    cmd.Parameters.AddWithValue("@id", result + 1);
                    cmd.Parameters.AddWithValue("@header", txtbox_Header.Text);
                    cmd.Parameters.AddWithValue("@section", inputBox1.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //------------------Shows preview of popup object------------------------------
        private void btn_Preview_Click(object sender, EventArgs e)
        {



        }

        //--------------------------------------Shows all data-------------------------------
        private void btn_connect_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            //connection string 
            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Trusted_Connection=True";

            //establishes the connection to the database
            cnn = new SqlConnection(connectionString);

            //Opens connection
            cnn.Open();

            //Define variables
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output="";

            //SQL statement, fetches everything from the dbo.PopUp table
            sql = "SELECT * FROM dbo.PopUp";

            //executes the SQL query, and connection object
            command = new SqlCommand(sql, cnn);

            //fetches all the rows from the table
            dataReader = command.ExecuteReader();

            //while statement accesses each row one by one
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + "\n";
            }

            //Displaying the output in a messagebox
            MessageBox.Show(Output);

            //Closes connection
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        //------------------------Update object------------------------
        private void btn_update_Click(object sender, EventArgs e)
        {
            //When pressed, the database will be updated with the new values
            string connectionString;
            SqlConnection cnn;
            string sql;
            
            //connection string
            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Trusted_Connection=True";
            
            //establishes the connection to the database
            cnn = new SqlConnection(connectionString);
            
            //Opens connection
            cnn.Open();
            
            //SQL statement, updates the dbo.PopUp table
            sql = "UPDATE dbo.PopUp SET Header = @header, Section = @section WHERE PopUpID = @id";
            
            //executes the SQL query, and connection object
            SqlCommand cmd = new SqlCommand(sql, cnn);
            //Adds the new popup object to the database
            cmd.Parameters.AddWithValue("@id", txtbox_ID.Text);
            cmd.Parameters.AddWithValue("@header", txtbox_Header.Text);
            cmd.Parameters.AddWithValue("@section", inputBox1.Text);
            cmd.ExecuteNonQuery();
            
            //Closes connection
            cnn.Close();
            
        }

        //--------------------Delete object------------------------------
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //When pressed, the object selected will be deleted
            string connectionString;
            SqlConnection cnn;
            string sql;
            
            //connection string
            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Trusted_Connection=True";
            
            //establishes the connection to the database
            cnn = new SqlConnection(connectionString);
            
            //Opens connection
            cnn.Open();
            
            //SQL statement, deletes the selected object from the dbo.PopUp table
            sql = "DELETE FROM dbo.PopUp WHERE PopUpID = @id";
            //executes the SQL query, and connection object
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@id", txtbox_ID.Text);
            cmd.ExecuteNonQuery();
            
            //Closes connection
            cnn.Close();
            
        }


    }
}
