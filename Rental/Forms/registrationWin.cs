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

        public registrationWin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);
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
           // var usernameSearch = new RentalDataSetTableAdapters.CUSTOMERTableAdapter()
           //     .GetDataByUsername(userName.Text);
            var usernameSearch = new RentalDBDataSetTableAdapters.CUSTOMERTableAdapter()
                .GetDataByUsername(userName.Text);

            if (userName.Text == "" || age.Text == "" ||
                telNumber.Text == "" || firstName.Text == "" || 
                lastName.Text == "" || password.Text == "" ||
                confPassword.Text == "")
            {
                MessageBox.Show("Please fill all information", "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(usernameSearch.Count > 0)
            {
                MessageBox.Show("User already exists!", "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Text = "";
                userName.Focus();
            }
            else
            {
                if (password.Text != confPassword.Text)
                {
                    MessageBox.Show("Passwords don't match!", "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Text = "";
                    confPassword.Text = "";
                    password.Focus();
                }
                else if(Int32.Parse(age.Text) < 5 && Int32.Parse(age.Text) > 120)
                {
                    MessageBox.Show("Incorrect age!", "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    age.Text = "";
                    age.Focus();
                }
                else if(telNumber.Text.Length != 9)
                {
                    MessageBox.Show("Incorrect phone number!", "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    telNumber.Text = "";
                    telNumber.Focus();
                }
                else
                {
                    //var registration = new RentalDataSetTableAdapters.CUSTOMERTableAdapter();
                    var registration = new RentalDBDataSetTableAdapters.CUSTOMERTableAdapter();
                    registration.Insert(userName.Text, password.Text, firstName.Text,
                                        lastName.Text, Int32.Parse(age.Text), Int32.Parse(telNumber.Text));
                    MessageBox.Show("Registration successful");
                }
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
