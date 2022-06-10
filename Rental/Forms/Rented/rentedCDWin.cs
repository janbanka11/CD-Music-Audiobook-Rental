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
    public partial class rentedCDWin : Form
    {
        string usernameText;
        RentalDBDataSet.CD_DISC1DataTable rentedCD = new RentalDBDataSet.CD_DISC1DataTable();
        public rentedCDWin(string userName)
        {
            InitializeComponent();
            this.usernameText = userName;
        }
        private void updateRentedCD()
        {
            new RentalDBDataSetTableAdapters.CD_DISC1TableAdapter()
                .FillCDRentedByUser(rentedCD, usernameText);
            dataGridViewCD.DataSource = rentedCD;
        }
        private void updateFormView()
        {
            if (rentedCD.Count() == 0)
            {
                dataGridViewCD.Visible = false;
                returnButton.Visible = false;
                noCDRentedLabel.Visible = true;
            }
            else
            {
                dataGridViewCD.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 13F, FontStyle.Regular);
                dataGridViewCD.Columns[0].Visible = false;
            }
        }
        private void rentedCDWin_Load(object sender, EventArgs e)
        {
            updateRentedCD();
            updateFormView();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DialogResult rentDialog = MessageBox.Show("Are you sure?", "Music return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rentDialog == DialogResult.Yes)
            {
                var cellValue = dataGridViewCD.Rows[dataGridViewCD.CurrentCell.RowIndex].Cells[0].Value.ToString();

                new RentalDBDataSetTableAdapters.RENTAL_CD_DISCTableAdapter()
                    .UpdateRentedID_CD(false, Int32.Parse(cellValue));
                new RentalDBDataSetTableAdapters.RENTAL_CD_DISCTableAdapter()
                    .DeleteRentalCD(Int32.Parse(cellValue));

                updateRentedCD();
                updateFormView();
            }
        }
    }
}
