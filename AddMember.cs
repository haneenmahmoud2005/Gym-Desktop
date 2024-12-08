using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymDesktop
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(NameTb.Text) ||
                string.IsNullOrWhiteSpace(PhoneTb.Text) ||
                string.IsNullOrWhiteSpace(AgeTb.Text) ||
                string.IsNullOrWhiteSpace(AmountTb.Text) ||
                GenderCb.SelectedItem == null ||
                TimingCb.SelectedItem == null)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            // Connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\source\gym\gym\Database\GymDb.mdf;Integrated Security=True;Connect Timeout=30";

            // Query
            string query = "INSERT INTO MemberTbl (MName, MPhone, MGen, MAge, MAmount, MTraining) VALUES (@Name, @Phone, @Gender, @Age, @Amount, @Timing)";

            // Database operation
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    await con.OpenAsync(); // Open connection asynchronously

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Name", NameTb.Text);
                        cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Age", int.Parse(AgeTb.Text)); // Ensure Age is an integer
                        cmd.Parameters.AddWithValue("@Amount", decimal.Parse(AmountTb.Text)); // Ensure Amount is a valid number
                        cmd.Parameters.AddWithValue("@Timing", TimingCb.SelectedItem.ToString());

                        // Execute the query
                        await cmd.ExecuteNonQueryAsync();

                        // Success message
                        MessageBox.Show("Member Successfully Added");

                        AmountTb.Text = "";
                        AgeTb.Text = "";
                        NameTb.Text = "";
                        PhoneTb.Text = "";
                        GenderCb.SelectedIndex = -1;
                        TimingCb.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear input fields
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.SelectedIndex = -1;
            TimingCb.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
