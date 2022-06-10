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
    public partial class settingsWin : Form
    {
        string usernameText;
        public settingsWin(string username)
        {
            InitializeComponent();
            this.usernameText = username;
        }

        private void checkBoxChanged(CheckBox c, TextBox t)
        {
            if(c.Checked)
            {
                t.Enabled = true;
                t.BackColor = SystemColors.HotTrack;
            }
            else
            {
                t.Enabled = false;
                t.BackColor = SystemColors.ControlDark;
            }
        }

        private void firstNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChanged(firstNameCheckBox, firstNametextBox);
        }

        private void lastNamecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChanged(lastNamecheckBox, lastNametextBox);
        }

        private void userNamecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChanged(userNamecheckBox, userNametextBox);
        }

        private void passwordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordcheckBox.Checked)
            {
                passwordtextBox.Enabled = true;
                passwordtextBox.BackColor = SystemColors.HotTrack;
                confPasswordtextBox.Visible = true;
                confirmPasswordLabel.Visible = true;
            }
            else
            {
                passwordtextBox.Enabled = false;
                passwordtextBox.BackColor = SystemColors.ControlDark;
                confPasswordtextBox.Visible = false;
                confirmPasswordLabel.Visible = false;
            }
        }

        private void agecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChanged(agecheckBox, agetextBox);
        }

        private void phonecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChanged(phonecheckBox, phonetextBox);
        }
    }
}
