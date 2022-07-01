using System;
using System.Collections;
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

        //------------"global" variable---------------------------
        public static string header = "";
        public static string section = "";


        //------------------Shows preview of popup object------------------------------
        private void btn_Preview_Click(object sender, EventArgs e)
        {
            //set global variables to be txtbox input
            header = txtbox_Header.Text;
            section = inputBox1.Text;

            //When pressed, values entered in header and section are shown in a popup window
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sommerProsjektDataSet2.PopUpTable' table. You can move, or remove it, as needed.
            this.popUpTableTableAdapter.Fill(this.sommerProsjektDataSet2.PopUpTable);
            // TODO: This line of code loads data into the 'sommerProsjektDataSet.PopUp' table. You can move, or remove it, as needed.
            //this.popUpTableAdapter.Fill(this.sommerProsjektDataSet.PopUp);
            
        }

        //------------------Inserts new object-----------------------------------------
        private void btn_Save_Click(object sender, EventArgs e)
        {
            var hc = new Controllers.HomeController();
            hc.InsertObject(txtbox_Header.Text, inputBox1.Text);

            //Refreshes the datagridview
            string sql = "SELECT * FROM PopUpTable";
            popUpTableBindingSource.DataSource = Controllers.HomeController.GetData(sql);
            dataGridView1.DataSource = popUpTableBindingSource;

        }

        //--------------------------------------Shows all data-------------------------------
        private void btn_connect_Click(object sender, EventArgs e)
        {
            var hc = new Controllers.HomeController();
            hc.DisplayAllData();
        }

        //------------------------Update object------------------------
        private void btn_update_Click(object sender, EventArgs e)
        {
            var hc = new Controllers.HomeController();
            hc.UpdateObject(txtbox_ID.Text, txtbox_Header.Text, inputBox1.Text);

            string sql = "SELECT * FROM PopUpTable";
            popUpTableBindingSource.DataSource = Controllers.HomeController.GetData(sql);
            dataGridView1.DataSource = popUpTableBindingSource;

        }

        //--------------------Delete object------------------------------
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var hc = new Controllers.HomeController();
            hc.DeleteObject(txtbox_ID.Text);

            //Refreshes the datagridview
            string sql = "SELECT * FROM PopUpTable";
            popUpTableBindingSource.DataSource = Controllers.HomeController.GetData(sql);
            dataGridView1.DataSource = popUpTableBindingSource;
        }


    }
}
