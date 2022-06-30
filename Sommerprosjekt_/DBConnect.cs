using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sommerprosjekt_
{
    class DBConnect
    {
        SqlConnection cnn;
        string connectionString; 

        public bool OpenConnection()
        {
            try
            {
                connectionString = "Server=PKDEMOSYSTEM\\SQLEXPRESS;Initial Catalog=Sommerprosjekt;Trusted_Connection=True";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                return true;

            }catch(Exception err)
            {
                MessageBox.Show("Connection error1" + err.Message);
            }
            return false;
        }

        public void CloseConnection()
        {
            cnn.Close();
            cnn.Dispose();
        }

        public PopUpDataSet ExecuteDataSet(string sql)
        {
            try
            {
                PopUpDataSet ds = new PopUpDataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                da.Fill(ds, "result");
                return ds; 
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        
        public SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand(sql, cnn);
                reader = cmd.ExecuteReader();
                return reader;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        
        public int ExeNonQuery(string sql)
        {
            try
            {
                int affected;
                SqlTransaction sqlTransaction = cnn.BeginTransaction();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                sqlTransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return -1;
        }
    }
}
