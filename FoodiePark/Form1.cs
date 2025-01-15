using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodiePark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANIKET;Initial Catalog=FoodieParkRestaurant;Integrated Security=True;
            Encrypt=False");

            con.Open();

            string Username = txtUserName.Text;
            string Password = txtPassWord.Text;

            /* SqlCommand cmd = new SqlCommand(" select username, password from logindata where username = '" + Username + 
                " ' and  password = '" + Password + " ' " , con ); */

            SqlCommand cmd = new SqlCommand("SELECT username, password FROM logindata WHERE username = @username AND password = @password", con);

            //Console.WriteLine($"Username: {Username}");
           // Console.WriteLine($"Password: {Password}");

            cmd.Parameters.AddWithValue("username", Username);
            cmd.Parameters.AddWithValue("password", Password);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //Console.WriteLine("SQL Query: " + cmd.CommandText);


            DataTable dt = new DataTable();

            adapter.Fill(dt);

            //Console.WriteLine("Rows Count: " + dt.Rows.Count);

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Login Successfull");

                Main ui = new Main();

                ui.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();
        }
    }
}
