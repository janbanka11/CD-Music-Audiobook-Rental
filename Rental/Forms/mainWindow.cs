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

    public partial class mainWin : Form
    {
        public mainWin(string userName)
        {
            InitializeComponent();
            if (userName.Length < 10)
            {
                helloLabel.Text = "Hi " + userName;
            }
            if (userName != "admin")
            {
                selectSettings.Enabled = false;
                selectSettings.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var cmdd = new RentalDataSetTableAdapters.CUSTOMERTableAdapter();
            //cmdd.Insert(textBox1.Text.Trim(),"d","d","d",25,"626555444");
            //cmdd.Fill(this.rentalDataSet.CUSTOMER);
        }




        private void selectMovie_Click(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = mOVIEBindingSource;
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalDataSet.AUDIOBOOK' table. You can move, or remove it, as needed.
            this.aUDIOBOOKTableAdapter.Fill(this.rentalDataSet.AUDIOBOOK);
            // TODO: This line of code loads data into the 'rentalDataSet.CD_DISC' table. You can move, or remove it, as needed.
            this.cD_DISCTableAdapter.Fill(this.rentalDataSet.CD_DISC);
            // TODO: This line of code loads data into the 'rentalDataSet.MOVIE' table. You can move, or remove it, as needed.
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            // TODO: This line of code loads data into the 'rentalDataSet.MOVIE' table. You can move, or remove it, as needed.
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            // TODO: This line of code loads data into the 'rentalDataSet.CD_DISC' table. You can move, or remove it, as needed.
            this.cD_DISCTableAdapter.Fill(this.rentalDataSet.CD_DISC);
            // TODO: This line of code loads data into the 'rentalDataSet.CD_DISC' table. You can move, or remove it, as needed.



        }

        private void selectMusic_Click(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = cDDISCBindingSource;
        }

        private void selectAudiobook_Click(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = aUDIOBOOKBindingSource;
        }
    }
}

    

