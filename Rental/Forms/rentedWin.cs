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
        string usernameText;

        RentalDBDataSet.MOVIE1DataTable rentedMovie = new RentalDBDataSet.MOVIE1DataTable();
        RentalDBDataSet.CD_DISC1DataTable rentedMusic = new RentalDBDataSet.CD_DISC1DataTable();
        RentalDBDataSet.AUDIOBOOK1DataTable rentedAudiobook = new RentalDBDataSet.AUDIOBOOK1DataTable();
        public rentedWin(string userName)
        {
            InitializeComponent();
            this.usernameText = userName;
        }

        private void rentedWin_Load(object sender, EventArgs e)
        {
            new RentalDBDataSetTableAdapters.MOVIE1TableAdapter()
                .FillMovieRentedByUser(rentedMovie, usernameText);
            dataGridViewMovie.DataSource = rentedMovie;

            new RentalDBDataSetTableAdapters.CD_DISC1TableAdapter()
                .FillCDRentedByUser(rentedMusic, usernameText);
            dataGridViewMusic.DataSource = rentedMusic;

            new RentalDBDataSetTableAdapters.AUDIOBOOK1TableAdapter()
                .FillAudiobookRentedByUser(rentedAudiobook, usernameText);
            dataGridViewAudiobook.DataSource = rentedAudiobook;
            
        }

        
    }
}
