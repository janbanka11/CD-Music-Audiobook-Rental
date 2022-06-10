using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental
{
    public partial class rentedWin : Form
    {
        string usernameText;
        rentedMoviesWin rmw;
        rentedCDWin rcdw;
        rentedAudiobooksWin raw;
        public rentedWin(string userName)
        {
            InitializeComponent();
            this.usernameText = userName;
           
        }
        
        private void rentedWin_Load(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is MdiClient)
                {
                    c.BackColor = Color.White;
                }
            }
            rmw = new rentedMoviesWin(usernameText);
            rmw.MdiParent = this;
            rmw.Dock = DockStyle.Fill;

            rcdw = new rentedCDWin(usernameText);
            rcdw.MdiParent = this;
            rcdw.Dock = DockStyle.Fill;

            raw = new rentedAudiobooksWin(usernameText);
            raw.MdiParent = this;
            raw.Dock = DockStyle.Fill;

        }

        private void movieButton_Click(object sender, EventArgs e)
        {
            rcdw.Hide();
            raw.Hide();
            rmw.Show();
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            rmw.Hide();
            raw.Hide();
            rcdw.Show();
        }

        private void audiobookButton_Click(object sender, EventArgs e)
        {
            rmw.Hide();
            rcdw.Hide();
            raw.Show();
        }
    }
}
