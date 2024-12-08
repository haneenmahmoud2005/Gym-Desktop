namespace GymDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(UidTb.Text=="" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else if(UidTb.Text=="Admin" && PassTb.Text=="Admin") {
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Id or Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
