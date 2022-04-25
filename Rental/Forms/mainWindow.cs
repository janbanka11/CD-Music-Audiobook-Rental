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
        public mainWin()
        {
            InitializeComponent();
            helloLabel.Text = "Hello, ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmdd = new RentalDataSetTableAdapters.CUSTOMERTableAdapter();
            cmdd.Insert(textBox1.Text.Trim(),"d","d","d",25,"626555444");
            cmdd.Fill(this.rentalDataSet.CUSTOMER);
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            this.cUSTOMERTableAdapter.Fill(this.rentalDataSet.CUSTOMER);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cUSTOMERTableAdapter.FillBy(this.rentalDataSet.CUSTOMER);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = cUSTOMERBindingSource1;
            this.dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.Columns["username"].HeaderText = "new Username";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = mOVIEBindingSource;
            this.dataGridView1.AutoGenerateColumns = true;
        }
    }
}

    

