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
    public partial class welcomeWin : Form
    {
        public welcomeWin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

    }

        private void goLogin_Click(object sender, EventArgs e)
        {
            new loginWin().Show();
            this.Hide();
        }
    }
}
