using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MarathonSkills15
{
    public partial class Login : template
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new Main().Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT * FROM User WHERE Email = '" + tb_login.Text + "' AND Password = '" + tb_password.Text + "'";
            MySqlConnection myConnection = new MySqlConnection(Program.myCon);
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if ((tb_login.Text == "") && (tb_password.Text == ""))
            {
                MessageBox.Show("Enter data in textBox");
            }
            else
            {
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][4].ToString() == "R")
                    {
                        new MainRunner().Show();
                        Hide();
                    }
                    if (dt.Rows[0][4].ToString() == "C")
                    {
                        new CoordinateMain().Show();
                        Hide();
                    }
                    if (dt.Rows[0][4].ToString() == "A")
                    {
                        new AdminMain().Show();
                        Hide();
                    }

                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }
    }
}
