private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Connect to the database
                OleDbConnection conn = new OleDbConnection();

                conn.ConnectionString = "Provider=SQLNCLI;Server=.\\;User ID=ozekiuser;password=ozekipass;Database=ozeki;Persist Security Info=True";
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    //Send the message
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    string SQLInsert = 
                        "INSERT INTO "+
                        "ozekimessageout (receiver,msg,status) "+
                        "VALUES "+
                        "('"+tbSender.Text+"','"+tbMsg.Text+"','send')";
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