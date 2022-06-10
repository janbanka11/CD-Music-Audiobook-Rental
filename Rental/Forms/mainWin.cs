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
        RentalDBDataSet.MOVIEDataTable dtMovie = new RentalDBDataSet.MOVIEDataTable();
        RentalDBDataSet.CD_DISCDataTable dtCD = new RentalDBDataSet.CD_DISCDataTable();
        RentalDBDataSet.AUDIOBOOKDataTable dtAudiobook = new RentalDBDataSet.AUDIOBOOKDataTable();

        public mainWin(string userName)
        {
            InitializeComponent();
            //user welcome textbox 
            if (userName.Length < 10)
            {
                hiLabel.Text = hiLabel.Text + " " + userName;
            }
            //more settings for admin user only (WIP, won't be like that)
            if (userName != "admin")
            {
                selectSettings.Enabled = false;
                selectSettings.Visible = false;
            }

            userNameText = userName;

            // filling local datatables with content from database
            new RentalDBDataSetTableAdapters.MOVIETableAdapter().Fill(dtMovie);
            new RentalDBDataSetTableAdapters.CD_DISCTableAdapter().Fill(dtCD);
            new RentalDBDataSetTableAdapters.AUDIOBOOKTableAdapter().Fill(dtAudiobook);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 14.5F, FontStyle.Regular);
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            
        }
        private void columnStyle()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["is_rented"].Visible = false;
            dataGridView1.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["title"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }
        private void selectMovie_Click(object sender, EventArgs e)
        {
            //changing datagridview data source if a button is clicked
            if (dataGridView1.DataSource != dtMovie)
            {
                dataGridView1.DataSource = dtMovie;
                columnStyle();
                dataGridView1.Columns["subtitles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void selectMusic_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.DataSource != dtCD)
            {          
                dataGridView1.DataSource = dtCD;
                columnStyle();
            }
        }

        private void selectAudiobook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != dtAudiobook)
            {
                dataGridView1.DataSource = dtAudiobook;
                columnStyle();
            }
        }

        private void rentNow_Click(object sender, EventArgs e)
        {
            //getting id of movie / cd / audiobook for a tabledata adapter to work
            var cellValue = dataGridView1.Rows[0].Cells[0].Value.ToString();

            if (dataGridView1.DataSource == dtMovie)
            {
                
                //insertRentalMovie is custom query to insert a row of relation data between user and movie tables to a table rental_movie
                new RentalDBDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .InsertRentalMovie(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                //updateRentedIDMovie updates is_rented column in movie table to 1 making it not visible in datagridview anymore
                new RentalDBDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .UpdateRentedIDMovie(true, Int32.Parse(cellValue));
                //updating datagridview after renting something
                var a = new RentalDBDataSetTableAdapters.MOVIETableAdapter();
                a.Fill(dtMovie);
                dataGridView1.DataSource = dtMovie;
            }
            else if (dataGridView1.DataSource == dtCD )
            {
                //same as above but for cd table
                new RentalDBDataSetTableAdapters.RENTAL_CD_DISCTableAdapter()
                    .InsertRentalCD(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDBDataSetTableAdapters.RENTAL_CD_DISCTableAdapter()
                    .UpdateRentedID_CD(true, Int32.Parse(cellValue));
                var a = new RentalDBDataSetTableAdapters.CD_DISCTableAdapter();
                a.Fill(dtCD);
                dataGridView1.DataSource = dtCD;
            }
            else
            {
                //same as above but for audiobook table
                new RentalDBDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter()
                    .InsertRentalAudiobook(userNameText, Int32.Parse(cellValue), DateTime.Now, DateTime.Now);
                new RentalDBDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter()
                    .UpdateRentedID_Audiobook(true, Int32.Parse(cellValue));
                var a = new RentalDBDataSetTableAdapters.AUDIOBOOKTableAdapter();
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