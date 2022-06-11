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

            //user label
            hiLabel.Text = hiLabel.Text + " " + userName;
            if (userName.Length > 12)
            {
                userpictureBox.Location = new Point(userpictureBox.Location.X - userName.Length, userpictureBox.Location.Y);
                hiLabel.Location = new Point(hiLabel.Location.X - userName.Length - 10, hiLabel.Location.Y);
            }
            //more settings for user named admin
            if (userName != "admin")
            {
                selectSettings.Enabled = false;
                selectSettings.Visible = false;
            }

            userNameText = userName;
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            // filling local datatables with content from database
            new RentalDBDataSetTableAdapters.MOVIETableAdapter().Fill(dtMovie);
            new RentalDBDataSetTableAdapters.CD_DISCTableAdapter().Fill(dtCD);
            new RentalDBDataSetTableAdapters.AUDIOBOOKTableAdapter().Fill(dtAudiobook);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 14.5F, FontStyle.Regular);

            dateTimePicker.Value = DateTime.Now;
           
        }
        private void columnStyle()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["is_rented"].Visible = false;
            dataGridView1.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["title"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void rentFun()
        {
            var cellValue = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (dataGridView1.DataSource == dtMovie)
            {
                //insertRentalMovie is custom query to insert a row of relation data between user and movie tables to a table rental_movie
                new RentalDBDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .InsertRentalMovie(userNameText, Int32.Parse(cellValue), DateTime.Now, dateTimePicker.Value);
                //updateRentedIDMovie updates is_rented column in movie table to 1 making it not visible in datagridview anymore
                new RentalDBDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .UpdateRentedIDMovie(true, Int32.Parse(cellValue));
                //updating datagridview after renting something
                var a = new RentalDBDataSetTableAdapters.MOVIETableAdapter();
                a.Fill(dtMovie);
                dataGridView1.DataSource = dtMovie;
            }
            else if (dataGridView1.DataSource == dtCD)
            {
                //same as above but for cd table
                new RentalDBDataSetTableAdapters.RENTAL_CD_DISCTableAdapter()
                    .InsertRentalCD(userNameText, Int32.Parse(cellValue), DateTime.Now, dateTimePicker.Value);
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
                    .InsertRentalAudiobook(userNameText, Int32.Parse(cellValue), DateTime.Now, dateTimePicker.Value);
                new RentalDBDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter()
                    .UpdateRentedID_Audiobook(true, Int32.Parse(cellValue));
                var a = new RentalDBDataSetTableAdapters.AUDIOBOOKTableAdapter();
                a.Fill(dtAudiobook);
                dataGridView1.DataSource = dtAudiobook;
            }
            MessageBox.Show("Rented successfuly!", "Sucesss", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void selectMovie_Click(object sender, EventArgs e)
        {
            //changing datagridview data source if a button is clicked
            if (dataGridView1.DataSource != dtMovie)
            {
                dataGridView1.DataSource = dtMovie;
                columnStyle();
                dataGridView1.Columns["subtitles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                rentNow.Visible = true;
                dateTimePicker.Visible = true;
                returnDateLabel.Visible = true;
                backgroundImg.Visible = false;
            }
        }

        private void selectMusic_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.DataSource != dtCD)
            {          
                dataGridView1.DataSource = dtCD;
                columnStyle();
                rentNow.Visible = true;
                dateTimePicker.Visible = true;
                returnDateLabel.Visible = true;
                backgroundImg.Visible = false;
            }
        }

        private void selectAudiobook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != dtAudiobook)
            {
                dataGridView1.DataSource = dtAudiobook;
                columnStyle();
                rentNow.Visible = true;
                dateTimePicker.Visible = true;
                returnDateLabel.Visible = true;
                backgroundImg.Visible = false;
            }
        }

        private void rentNow_Click(object sender, EventArgs e)
        {
            //getting id of movie / cd / audiobook for a tabledata adapter to work
            Console.WriteLine("----------------" + dateTimePicker.Value + "---------------");
            TimeSpan diff = dateTimePicker.Value.Date - DateTime.Today.Date;

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select an item to rent", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dateTimePicker.Value.Date == DateTime.Today.Date)
            {
                MessageBox.Show("Provide the return date", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(diff.Days > 30 || diff.Days < 0)
            {
                MessageBox.Show("You can rent for maximum of 30 days", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                rentFun();
            }
        }

        private void selectRented_Click(object sender, EventArgs e)
        {
            var rentedWin = new rentedWin(userNameText);
            rentedWin.Show();
        }

        private void selectBill_Click(object sender, EventArgs e)
        {
            var a = new RentalDBDataSetTableAdapters.QueriesTableAdapter().SelectUserBill(userNameText);
            string result = a.ToString();
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Nothing to pay for.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your total bill is " + result + " PLN", "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userSettings_Click(object sender, EventArgs e)
        {
            var settingsWin = new settingsWin(userNameText);
            settingsWin.Show();
        }

        private void selectSettings_Click(object sender, EventArgs e)
        {

        }
    }
}