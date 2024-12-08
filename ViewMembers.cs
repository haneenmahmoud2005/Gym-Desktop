using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymDesktop
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        // Connection string
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\source\gym\gym\Database\GymDb.mdf;Integrated Security=True;Connect Timeout=30";

        // Populate the DataGridView with members
        private void populate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM MemberTbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    MemberSDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any cell content click if needed
        }

        // Handle Search Button click
        private void button2_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();  // Assuming you have a TextBox named SearchTb

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchMembers(searchTerm);
        }

        // Search members based on the search term
        private void SearchMembers(string searchTerm)
        {
            string query = "SELECT * FROM MemberTbl WHERE MName LIKE @SearchTerm OR MPhone LIKE @SearchTerm OR MGen LIKE @SearchTerm OR MAge LIKE @SearchTerm OR MAmount LIKE @SearchTerm";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    var ds = new DataSet();
                    sda.Fill(ds);
                    MemberSDGV.DataSource = ds.Tables[0];

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No members found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}