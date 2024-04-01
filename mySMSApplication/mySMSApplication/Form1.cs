using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace mySMSApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Connect to the database
                // OleDbConnection conn = new OleDbConnection();

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=Master\Master;Initial Catalog=ozeki;Persist Security Info=True;User ID=ozekiuser;Password=ozekipass";
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    //Send the message
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string SQLInsert =
                        "INSERT INTO " +
                        "ozekimessageout (receiver,msg,status) " +
                        "VALUES " +
                        "('" + tbSender.Text + "','" + tbMsg.Text + "','send')";
                    cmd.CommandText = SQLInsert;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Message sent");
                }
                //Disconnect from the database
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}