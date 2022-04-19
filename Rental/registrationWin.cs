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

namespace Rental
{
    public partial class welcomeWin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOV7VTS; Initial Catalog=Rental;Integrated Security=True;");
        SqlCommand cmd;
       
        public welcomeWin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void goLogin_Click(object sender, EventArgs e)
        {
            new loginWin().Show();
            new mainWindow().Show();
            this.Hide();
        }

       

        private void confPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (password.Text == confPassword.Text && Int32.Parse(age.Text) > 0
                && Int32.Parse(age.Text) < 120 && telNumber.Text.Length == 9)
            {
                con.Open();
                cmd = new SqlCommand("insert into customer values " + "('" + userName.Text.Trim(' ') + "','" + password.Text + "','" + firstName.Text + "','" + lastName.Text + "','" + age.Text + "','" + telNumber.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration sucessfull");
                con.Close();
            }
            else
            {
                MessageBox.Show("Incorrect data, please try again", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Text = "";
                password.Text = "";
                confPassword.Text = "";
                firstName.Text = "";
                lastName.Text = "";
                age.Text = "";
                telNumber.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
