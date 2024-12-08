using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymDesktop
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

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

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all fields
            NameTb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            GenderCb.Text = "";
            PhoneTb.Text = "";
            TimingCb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the selected row's ID (assuming the ID column in the database is "ID")
            int selectedRowIndex = MemberSDGV.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = MemberSDGV.Rows[selectedRowIndex];
            int memberId = Convert.ToInt32(selectedRow.Cells["MId"].Value);  // Use the correct column name

            // Confirm with the user before deleting
            var confirmation = MessageBox.Show("Are you sure you want to delete this member?", "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM MemberTbl WHERE MId=@ID";  // Use the correct column name

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", memberId);  // Use the correct column name

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        populate(); // Refresh the DataGridView to remove the deleted member
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MemberSDGV.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = MemberSDGV.Rows[e.RowIndex];

                // Populate the fields using column names
                NameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                PhoneTb.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                GenderCb.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                AgeTb.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                AmountTb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                TimingCb.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
            }
            else
            {
                // If no valid row is selected, show a message
                MessageBox.Show("Please select a valid row.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if the ID is selected and all fields are filled
            if (string.IsNullOrWhiteSpace(NameTb.Text) || string.IsNullOrWhiteSpace(PhoneTb.Text) || string.IsNullOrWhiteSpace(GenderCb.Text))
            {
                MessageBox.Show("Please select a member and make sure all fields are filled.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row's ID (assuming the ID is in the correct column, let's say it's "MemberID")
            int selectedRowIndex = MemberSDGV.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = MemberSDGV.Rows[selectedRowIndex];
            int MId = Convert.ToInt32(selectedRow.Cells["MId"].Value);  // Use the correct column name here

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE MemberTbl SET MName=@Name, MPhone=@Phone, MGen=@Gender, MAge=@Age, MAmount=@Amount, MTraining=@Timing WHERE MId=@ID";  // Adjust the column name

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", MId);
                    cmd.Parameters.AddWithValue("@Name", NameTb.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Gender", GenderCb.Text);
                    cmd.Parameters.AddWithValue("@Age", AgeTb.Text);
                    cmd.Parameters.AddWithValue("@Amount", AmountTb.Text);
                    cmd.Parameters.AddWithValue("@Timing", TimingCb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member information updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    populate(); // Refresh the DataGridView to show updated data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
