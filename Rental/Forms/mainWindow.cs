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
        RentalDataSet.MOVIEDataTable dtMovie = new RentalDataSet.MOVIEDataTable();
        RentalDataSet.CD_DISCDataTable dtCD = new RentalDataSet.CD_DISCDataTable();
        RentalDataSet.AUDIOBOOKDataTable dtAudiobook = new RentalDataSet.AUDIOBOOKDataTable();

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
            new RentalDataSetTableAdapters.MOVIETableAdapter().Fill(dtMovie);
            new RentalDataSetTableAdapters.CD_DISCTableAdapter().Fill(dtCD);
            new RentalDataSetTableAdapters.AUDIOBOOKTableAdapter().Fill(dtAudiobook);
            dataGridView1.DataSource = dtMovie;
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            this.mOVIETableAdapter.Fill(this.rentalDataSet.MOVIE);
            this.cD_DISCTableAdapter.Fill(this.rentalDataSet.CD_DISC);
            this.aUDIOBOOKTableAdapter.Fill(this.rentalDataSet.AUDIOBOOK);
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
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            var cellValue = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();

            if (dataGridView1.DataSource == dtMovie || dataGridView1.DataSource == mOVIEBindingSource)
            {
                new RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .InsertRentalMovie(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter().UpdateRentedIDMovie(Int32.Parse(cellValue));
                var a = new RentalDataSetTableAdapters.MOVIETableAdapter();
                a.Fill(dtMovie);
                dataGridView1.DataSource = dtMovie;
            }
            else if (dataGridView1.DataSource == dtCD || dataGridView1.DataSource == cDDISCBindingSource)
            {
                new RentalDataSetTableAdapters.RENTAL_CD_DISCTableAdapter().InsertRentalCD(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDataSetTableAdapters.RENTAL_CD_DISCTableAdapter().UpdateRentedID_CD(Int32.Parse(cellValue));
                var a = new RentalDataSetTableAdapters.CD_DISCTableAdapter();
                a.Fill(dtCD);
                dataGridView1.DataSource = dtCD;
            }
            else
            {
                new RentalDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter().InsertRentalAudiobook(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter().UpdateRentedID_Audiobook(Int32.Parse(cellValue));
                var a = new RentalDataSetTableAdapters.AUDIOBOOKTableAdapter();
                a.Fill(dtAudiobook);
                dataGridView1.DataSource = dtAudiobook;
            }
        }

        private void selectRented_Click(object sender, EventArgs e)
        {

        }
    }
}
