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
        string userNameText;
        public settingsWin(string username)
        {
            InitializeComponent();
            this.userNameText = username;
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

        private void confirmChangesButton_Click(object sender, EventArgs e)
        {
            string changes = "Successfuly made changes to: ";
            if(firstNameCheckBox.Checked) //checking if checkbox is checked, if yes, proceed with update query
            {
                new RentalDBDataSetTableAdapters.CUSTOMERTableAdapter()
                    .UpdateFirstName(firstNametextBox.Text, userNameText);
                changes += " first name";
            }
            if(lastNamecheckBox.Checked)
            {
                new RentalDBDataSetTableAdapters.CUSTOMERTableAdapter()
                    .UpdateLastName(lastNametextBox.Text, userNameText);
                changes += " last name";
            }
            if(agecheckBox.Checked)
            {
                new RentalDBDataSetTableAdapters.CUSTOMERTableAdapter()
                    .UpdateAge(Int32.Parse(agetextBox.Text), userNameText);
                changes += " age";
            }
            if (passwordcheckBox.Checked)
            {
                if (passwordtextBox.Text != confPasswordtextBox.Text)
                {
                    MessageBox.Show("Password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordtextBox.Text = "";
                    confPasswordtextBox.Text = "";
                    passwordtextBox.Focus();
                }
                else
                {
                    new RentalDBDataSetTableAdapters.CUSTOMERTableAdapter()
                        .UpdatePassword(passwordtextBox.Text, userNameText);
                    changes += " password";
                }
            }
            if(phonecheckBox.Checked)
            {
                new RentalDBDataSetTableAdapters.CUSTOMERTableAdapter()
                    .UpdatePhoneNumber(Int32.Parse(phonetextBox.Text), userNameText);
                changes += " phone number";
            }
            if(changes != "Successfuly made changes to: ")
            {
                MessageBox.Show(changes, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No changes made", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void agetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void phonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
