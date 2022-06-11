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
    public partial class rentedAudiobooksWin : Form
    {
        string usernameText;
        RentalDBDataSet.AUDIOBOOK1DataTable rentedAudiobook = new RentalDBDataSet.AUDIOBOOK1DataTable();
        public rentedAudiobooksWin(string userName)
        {
            InitializeComponent();
            this.usernameText = userName;
        }
        private void updateRentedAudiobook()
        {
            new RentalDBDataSetTableAdapters.AUDIOBOOK1TableAdapter()
                .FillAudiobookRentedByUser(rentedAudiobook, usernameText);
            dataGridViewAudiobook.DataSource = rentedAudiobook;
        }
        private void updateFormView()
        {
            if (rentedAudiobook.Count() == 0)
            {
                dataGridViewAudiobook.Visible = false;
                returnButton.Visible = false;
                noAudiobookRentedLabel.Visible = true;
            }
            else
            {
                dataGridViewAudiobook.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 13F, FontStyle.Regular);
                dataGridViewAudiobook.Columns[0].Visible = false;
            }
        }

        private void rentedAudiobooksWin_Load(object sender, EventArgs e)
        {
            updateRentedAudiobook();
            updateFormView();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DialogResult rentDialog = MessageBox.Show("Are you sure?", "Audiobook return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rentDialog == DialogResult.Yes)
            {
                var cellValue = dataGridViewAudiobook.Rows[dataGridViewAudiobook.CurrentCell.RowIndex].Cells[0].Value.ToString();
                new RentalDBDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter()
                    .UpdateRentedID_Audiobook(false, Int32.Parse(cellValue));
                new RentalDBDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter()
                    .DeleteRentalAudiobook(Int32.Parse(cellValue));

                updateRentedAudiobook();
                updateFormView();
            }
        }
    }
}
