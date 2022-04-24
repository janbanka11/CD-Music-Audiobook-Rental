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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOV7VTS; Initial Catalog=Rental;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        public loginWin()
        {
            InitializeComponent();
            TextBoxExtensions.CorrectHeight(username);
            TextBoxExtensions.CorrectHeight(password);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "select * from customer where username= '" + username.Text.Trim() + "' and password='" + password.Text.Trim() + "'";
            cmd = new SqlCommand(login, con);
           
            SqlDataReader da = cmd.ExecuteReader();
            if(da.Read())
            {
                this.Hide();
                var mainWin = new mainWin();
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
            con.Close();
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
