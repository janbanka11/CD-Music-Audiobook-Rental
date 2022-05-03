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
    //main window with all functionality that shows up after logging in
    public partial class mainWin : Form
    {
        private string userNameText;
        RentalDataSet.MOVIEDataTable dtMovie = new RentalDataSet.MOVIEDataTable();
        RentalDataSet.CD_DISCDataTable dtCD = new RentalDataSet.CD_DISCDataTable();
        RentalDataSet.AUDIOBOOKDataTable dtAudiobook = new RentalDataSet.AUDIOBOOKDataTable();

        public mainWin(string userName)
        {
            InitializeComponent();
            //hello textbox functionality
            if (userName.Length < 10)
            {
                helloLabel.Text = "Hi " + userName;
            }
            //more settings for admin user only (WIP, won't be like that)
            if (userName != "admin")
            {
                selectSettings.Enabled = false;
                selectSettings.Visible = false;
            }

            userNameText = userName;
            // filling local datatables with content from database
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
            //changing datagridview data source if a button is clicked
            if (dataGridView1.DataSource != mOVIEBindingSource && dataGridView1.DataSource != dtMovie)
            {
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dtMovie;
            }
        }

        private void selectMusic_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != cDDISCBindingSource && dataGridView1.DataSource != dtCD)
            {
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dtCD;
            }
        }

        private void selectAudiobook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != aUDIOBOOKBindingSource && dataGridView1.DataSource != dtAudiobook)
            {
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dtAudiobook;
            }
        }

        private void rentNow_Click(object sender, EventArgs e)
        {
            //getting id of movie / cd / audiobook for a tabledata adapter to work
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            var cellValue = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();

            if (dataGridView1.DataSource == dtMovie || dataGridView1.DataSource == mOVIEBindingSource)
            {
                //insertRentalMovie is custom query to insert a row of relation data between user and movie tables to a table rental_movie
                new RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .InsertRentalMovie(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                //updateRentedIDMovie updates is_rented column in movie table to 1 making it not visible in datagridview anymore
                new RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .UpdateRentedIDMovie(Int32.Parse(cellValue));
                //updating datagridview after renting something
                var a = new RentalDataSetTableAdapters.MOVIETableAdapter();
                a.Fill(dtMovie);
                dataGridView1.DataSource = dtMovie;
            }
            else if (dataGridView1.DataSource == dtCD || dataGridView1.DataSource == cDDISCBindingSource)
            {
                //same as above but for cd table
                new RentalDataSetTableAdapters.RENTAL_CD_DISCTableAdapter()
                    .InsertRentalCD(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDataSetTableAdapters.RENTAL_CD_DISCTableAdapter()
                    .UpdateRentedID_CD(Int32.Parse(cellValue));
                var a = new RentalDataSetTableAdapters.CD_DISCTableAdapter();
                a.Fill(dtCD);
                dataGridView1.DataSource = dtCD;
            }
            else
            {
                //same as above but for audiobook table
                new RentalDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter()
                    .InsertRentalAudiobook(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter()
                    .UpdateRentedID_Audiobook(Int32.Parse(cellValue));
                var a = new RentalDataSetTableAdapters.AUDIOBOOKTableAdapter();
                a.Fill(dtAudiobook);
                dataGridView1.DataSource = dtAudiobook;
            }
            MessageBox.Show("Rented successfuly!", "Sucesss", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void selectRented_Click(object sender, EventArgs e)
        { 
            var rentedWin = new rentedWin(userNameText);
            rentedWin.Show();
        }
    }
}
