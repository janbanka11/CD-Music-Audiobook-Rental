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
   
    public partial class registrationWin : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOV7VTS; Initial Catalog=Rental;Integrated Security=True;");
        SqlCommand cmd;
       
        public registrationWin()
        {
            InitializeComponent();
        }
        private void registrationWin_Load(object sender, EventArgs e)
        {
            TextBoxExtensions.CorrectHeight(firstName);
            TextBoxExtensions.CorrectHeight(lastName);
            TextBoxExtensions.CorrectHeight(userName);
            TextBoxExtensions.CorrectHeight(age);
            TextBoxExtensions.CorrectHeight(telNumber);
            TextBoxExtensions.CorrectHeight(password);
            TextBoxExtensions.CorrectHeight(confPassword);
        }


        private void goLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginWin = new loginWin();
            loginWin.Closed += (s, args) => this.Close();
            loginWin.Show();
        }

        private void intKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || age.Text == "" ||
                telNumber.Text == "" || firstName.Text == "" || 
                lastName.Text == "" || password.Text == "" ||
                confPassword.Text == "")
            {
                MessageBox.Show("Please fill all information", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (password.Text == confPassword.Text && Int32.Parse(age.Text) > 0
                    && Int32.Parse(age.Text) < 120 && telNumber.Text.Length == 9)
                {
                    con.Open();
                    cmd = new SqlCommand("insert into customer values " + "('" + userName.Text.Trim(' ') + "','" + password.Text + "','" + firstName.Text + "','" + lastName.Text + "','" + age.Text + "','" + telNumber.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful");
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
                con.Close();
            }
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void telNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
