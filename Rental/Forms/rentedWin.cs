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
    public partial class rentedWin : Form
    {
        public rentedWin(string userName)
        {
            //RentalDataSet.MOVIEDataTable dtMovieRented = new RentalDataSet.MOVIEDataTable();
            //RentalDataSet.CD_DISCDataTable dtCDRented = new RentalDataSet.CD_DISCDataTable();
            //RentalDataSet.AUDIOBOOKDataTable dtAudiobookRented = new RentalDataSet.AUDIOBOOKDataTable();
            //new RentalDataSetTableAdapters.MOVIETableAdapter().Fill(dtMovieRented);
            //new RentalDataSetTableAdapters.CD_DISCTableAdapter().Fill(dtCDRented);
            //new RentalDataSetTableAdapters.AUDIOBOOKTableAdapter().Fill(dtAudiobookRented);

            //RentalDataSet.RENTAL_MOVIEDataTable dtMovieRented = new RentalDataSet.RENTAL_MOVIEDataTable();
            
                        //dtMovieRented.Fill(new RentalDataSetTableAdapters.QueriesTableAdapter().ScalarQuery(userName));
            InitializeComponent();
            //try
            //{
            //    RentalDataSet.MOVIEDataTable dtMovieRented2 = new RentalDataSet.MOVIEDataTable();
            //    new RentalDataSetTableAdapters.MOVIETableAdapter().FillByMovieRentedByUser(dtMovieRented2, userName);
            //    dataGridViewMovie.DataSource = dtMovieRented2;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.ToString());
            //}
        }

        private void rentedWin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalDataSet.RENTAL_AUDIOBOOK' table. You can move, or remove it, as needed.
            this.rENTAL_AUDIOBOOKTableAdapter.Fill(this.rentalDataSet.RENTAL_AUDIOBOOK);
            // TODO: This line of code loads data into the 'rentalDataSet.RENTAL_CD_DISC' table. You can move, or remove it, as needed.
            this.rENTAL_CD_DISCTableAdapter.Fill(this.rentalDataSet.RENTAL_CD_DISC);
            // TODO: This line of code loads data into the 'rentalDataSet.RENTAL_MOVIE' table. You can move, or remove it, as needed.
            this.rENTAL_MOVIETableAdapter.Fill(this.rentalDataSet.RENTAL_MOVIE);

        }

        
    }
}
