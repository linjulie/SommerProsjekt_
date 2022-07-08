using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sommerprosjekt_.Controllers
{
    internal class SqlQueries
    {
        //to update the datagridview the GetData function does a query to get all data,
        //this happens after each insert, update and delete

        public static DataTable GetData(string sqlCommand)
        {
            string connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Integrated Security=True";

            SqlConnection popupConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, popupConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
        
        public void InsertObject(string header, string section)
        {
            string connectionString;
            string sql;

            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Integrated Security=True";
            sql = "INSERT INTO dbo.PopUpTable ([Header], [Section]) VALUES (@Header, @Section)";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    //Adds the new popup object to the database  
                    cmd.Parameters.AddWithValue("@header", header);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        
        public void UpdateObject(string id, string header, string section)
        {
            string connectionString;
            string sql;
            SqlConnection cnn;

            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Integrated Security=True";
            sql = "UPDATE dbo.PopUpTable SET Header = @header, Section = @section WHERE PopUpID = @id";
            
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@header", header);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void DeleteObject(string id)
        {
            string connectionString;
            string sql;
            SqlConnection cnn;

            connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Integrated Security=True";

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            sql = "DELETE FROM dbo.PopUpTable WHERE PopUpID = @id";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            cnn.Close();
            
        }

        public void DisplayAllData()
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
            string sql, Output = "";

            //SQL statement, fetches everything from the dbo.PopUp table
            sql = "SELECT * FROM dbo.PopUpTable";

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
    }
}
