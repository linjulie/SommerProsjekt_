﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
        //retrieving a connectionstring by name
        static string GetConnectionstring(string name)
        {
            //set returnvalue equals null incase of failure
            string returnValue = null;
            
            //looking for the name in the connectionstring settings
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            
            //if found then return the conection string
            if (settings != null)
                returnValue = settings.ConnectionString;
            
            return returnValue;
        }
        
        //to update the datagridview the GetData function does a query to get all data,
        //this happens after each insert, update and delete
        public static DataTable GetData(string sqlCommand)
        {
            string connectionString = GetConnectionstring("myConnectionString");

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

            connectionString = GetConnectionstring("myConnectionString");
            sql = "INSERT INTO dbo.PopUpTable ([Header], [Section]) VALUES (@Header, @Section)";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                //Adds the new popup object to the database  
                cmd.Parameters.AddWithValue("@header", header);
                cmd.Parameters.AddWithValue("@section", section);

                try
                {
                    cnn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    cnn.Close();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void UpdateObject(string id, string header, string section)
        {
            string connectionString;
            string sql;
            //SqlConnection cnn;

            connectionString = GetConnectionstring("myConnectionString");
            sql = "UPDATE dbo.PopUpTable SET Header = @header, Section = @section WHERE PopUpID = @id";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@header", header);
                cmd.Parameters.AddWithValue("@section", section);

                try
                {
                    cnn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    cnn.Close();
                    Console.WriteLine("RowsAffected: {0}, updated object with id: {1}", rowsAffected, id);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void DeleteObject(string id)
        {
            string connectionString;
            string sql;


            connectionString = GetConnectionstring("myConnectionString");
            sql = "DELETE FROM dbo.PopUpTable WHERE PopUpID = @id";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cnn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    cnn.Close();
                    Console.WriteLine("RowsAffected: {0}, deleted object with id:{1}", rowsAffected, id);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }


        

        public void DspAllData()
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

