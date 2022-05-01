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
    public partial class loginWin : Form
    {
       
        public loginWin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);
            TextBoxExtensions.CorrectHeight(username);
            TextBoxExtensions.CorrectHeight(password);
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            

            var usernameSearch = new RentalDataSetTableAdapters.CUSTOMERTableAdapter()
                .GetDataByUsername(username.Text);
            var passwordSearch = new RentalDataSetTableAdapters.CUSTOMERTableAdapter()
                .GetDataByPassword(password.Text);

            if (usernameSearch.Count > 0 && passwordSearch.Count > 0)
            {
                this.Hide();
                var mainWin = new mainWin(username.Text.ToString());
                mainWin.Closed += (s, args) => this.Close();
                mainWin.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                password.Text = "";
                username.Focus();
            }
        }

        private void goRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationWin = new registrationWin();
            registrationWin.Closed += (s, args) => this.Close();
            registrationWin.Show();
        }

        
    }
}
