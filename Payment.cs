using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymDesktop
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\source\gym\gym\Database\GymDb.mdf;Integrated Security=True;Connect Timeout=30";

        // Fill ComboBox with Member Names
        private void FillName()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MName FROM MemberTbl", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    NameCb.DisplayMember = "MName";
                    NameCb.ValueMember = "MName";
                    NameCb.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Populate DataGridView with Payment Records
        private void populate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM PaymentTbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    PaymentSDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterByName()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM PaymentTbl where PMember='" + SearchName.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    PaymentSDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear Inputs
            NameCb.Text = "";
            AmountTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameCb.Text) || string.IsNullOrWhiteSpace(AmountTb.Text))
            {
                MessageBox.Show("Missing Information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(AmountTb.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string payPeriod = $"{Periode.Value.Month}{Periode.Value.Year}";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if payment already exists for the selected member and month
                    string checkQuery = "SELECT COUNT(*) FROM PaymentTbl WHERE PMember = @PMember AND PMonth = @PMonth";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@PMember", NameCb.SelectedValue.ToString());
                    checkCmd.Parameters.AddWithValue("@PMonth", payPeriod);
                    int paymentCount = (int)checkCmd.ExecuteScalar();

                    if (paymentCount > 0)
                    {
                        MessageBox.Show("Already Paid For This Month", "Duplicate Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Insert the payment record
                        string insertQuery = "INSERT INTO PaymentTbl (PMonth, PMember, PAmount) VALUES (@PMonth, @PMember, @PAmount)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@PMonth", payPeriod);
                        insertCmd.Parameters.AddWithValue("@PMember", NameCb.SelectedValue.ToString());
                        insertCmd.Parameters.AddWithValue("@PAmount", amount);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Amount Paid Successfully", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void PaymentSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
