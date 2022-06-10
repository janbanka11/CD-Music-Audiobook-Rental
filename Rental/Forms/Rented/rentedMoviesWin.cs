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
    public partial class rentedMoviesWin : Form
    {
        string usernameText;
        RentalDBDataSet.MOVIE1DataTable rentedMovie = new RentalDBDataSet.MOVIE1DataTable();
        public rentedMoviesWin(string userName)
        {
            InitializeComponent();
            this.usernameText = userName;
        }

        private void updateRentedMovies()
        {
            new RentalDBDataSetTableAdapters.MOVIE1TableAdapter()
                .FillMovieRentedByUser(rentedMovie, usernameText);
            dataGridViewMovie.DataSource = rentedMovie;
        }
        private void updateFormView()
        {
            if (rentedMovie.Count() == 0)
            {
                dataGridViewMovie.Visible = false;
                returnButton.Visible = false;
                noMoviesRentedLabel.Visible = true;
            }
            else
            {
                dataGridViewMovie.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 13F, FontStyle.Regular);
                dataGridViewMovie.Columns[0].Visible = false;
            }
        }
        private void rentedMoviesWin_Load(object sender, EventArgs e) // getting rented movies by user and setting datagridview header style
        {
            updateRentedMovies();
            updateFormView();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DialogResult rentDialog = MessageBox.Show("Are you sure?", "Movie return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rentDialog == DialogResult.Yes)
            {
                var cellValue = dataGridViewMovie.Rows[dataGridViewMovie.CurrentCell.RowIndex].Cells[0].Value.ToString();

                new RentalDBDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                        .UpdateRentedIDMovie(false, Int32.Parse(cellValue));
                new RentalDBDataSetTableAdapters.RENTAL_MOVIETableAdapter()
                    .deleteRentalMovie(Int32.Parse(cellValue));

                updateRentedMovies();
                updateFormView();
            }
        }
    }
}
