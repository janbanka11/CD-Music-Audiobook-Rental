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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UOV7VTS; Initial Catalog=Rental;Integrated Security=True;");
        SqlCommand cmdd;
        DataSet dataset = new DataSet();
        public mainWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmdd = new RentalDataSetTableAdapters.CUSTOMERTableAdapter();
            cmdd.Insert(textBox1.Text.Trim(),"d","d","d",25,"626555444");
            cmdd.Fill(this.rentalDataSet.CUSTOMER);
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalDataSet.CUSTOMER' table. You can move, or remove it, as needed.
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
    }
}

    

