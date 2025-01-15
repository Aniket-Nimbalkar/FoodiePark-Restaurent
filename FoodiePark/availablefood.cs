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
using System.Data.Common;

namespace FoodiePark
{
    public partial class availablefood : Form
    {
        public availablefood()
        {
            InitializeComponent();
        }

        private void availableDishes_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANIKET;Initial Catalog=FoodieParkRestaurant;Integrated Security=True;
            Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from FoodAvailable", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void getAvailabillity_Click(object sender, EventArgs e)
        {

        }

        private void addFood_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANIKET;Initial Catalog=FoodieParkRestaurant;Integrated Security=True;
            Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from FoodAvailable", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void saveFood_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANIKET;Initial Catalog=FoodieParkRestaurant;Integrated Security=True;
            Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO FoodAvailable VALUES(@FoodId, @FoodName, @FoodPrice, @Quantity, @Availability)", con);

            cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodid.Text));
            cmd.Parameters.AddWithValue("@FoodName", foodname.Text);
            cmd.Parameters.AddWithValue("@FoodPrice", price.Text);
            cmd.Parameters.AddWithValue("@Quantity", quantity.Text);
            cmd.Parameters.AddWithValue("@Availability", availabillity.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void newFood_Click(object sender, EventArgs e)
        {
            foodid.Text = "";
            foodname.Text = "";
            price.Text = "";
            quantity.Text = "";
            availabillity.Text = "";
        }

        private void updateFood_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANIKET;Initial Catalog=FoodieParkRestaurant;Integrated Security=True;
            Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE FoodAvailable SET foodname = @FoodName, FoodPrice = @FoodPrice, quantity = @Quantity, availabillity = @Availability WHERE foodid = @FoodId", con);

            cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodid.Text));
            cmd.Parameters.AddWithValue("@FoodName", foodname.Text);
            cmd.Parameters.AddWithValue("@FoodPrice", price.Text);
            cmd.Parameters.AddWithValue("@Quantity", quantity.Text);
            cmd.Parameters.AddWithValue("@Availability", availabillity.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteFood_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANIKET;Initial Catalog=FoodieParkRestaurant;Integrated Security=True;
            Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("delete FoodAvailable  where foodid = @FoodId", con);

            cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodid.Text));
            

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void displayFood_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANIKET;Initial Catalog=FoodieParkRestaurant;Integrated Security=True;
            Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from FoodAvailable", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chickenwings_Click(object sender, EventArgs e)
        {

        }
    }
}
