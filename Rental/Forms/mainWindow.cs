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
using System.Threading;
namespace Rental
{

    public partial class mainWin : Form
    {
        private string userNameText;
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
            userNameText = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var cmdd = new RentalDataSetTableAdapters.CUSTOMERTableAdapter();
            //cmdd.Insert(textBox1.Text.Trim(),"d","d","d",25,"626555444");
            //cmdd.Fill(this.rentalDataSet.CUSTOMER);
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            this.cD_DISCTableAdapter.Fill(this.rentalDataSet.CD_DISC);
            this.aUDIOBOOKTableAdapter.Fill(this.rentalDataSet.AUDIOBOOK);
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            this.cD_DISCTableAdapter.Fill(this.rentalDataSet.CD_DISC);
            this.aUDIOBOOKTableAdapter.Fill(this.rentalDataSet.AUDIOBOOK);
            this.aUDIOBOOKTableAdapter.Fill(this.rentalDataSet.AUDIOBOOK);
            this.cD_DISCTableAdapter.Fill(this.rentalDataSet.CD_DISC);
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            this.cD_DISCTableAdapter.Fill(this.rentalDataSet.CD_DISC);
        }
        private void selectMovie_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != mOVIEBindingSource)
            {
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.Columns.Clear();
                dataGridView1.DataSource = mOVIEBindingSource;
            }
        }
        private void selectMusic_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != cDDISCBindingSource)
            {
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.Columns.Clear();
                dataGridView1.DataSource = cDDISCBindingSource;
            }
        }

        private void selectAudiobook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != aUDIOBOOKBindingSource)
            {
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.Columns.Clear();
                dataGridView1.DataSource = aUDIOBOOKBindingSource;
            }
        }

        private void rentNow_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex - 1;
            var cellValue = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
            if (dataGridView1.DataSource == mOVIEBindingSource)
            {
                new RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .InsertRentalMovie(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter().UpdateRentedIDMovie(Int32.Parse(cellValue));
            }
            MessageBox.Show("Rented successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}

    

