
namespace Rental
{
    partial class rentedAudiobooksWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentedAudiobooksWin));
            this.noAudiobookRentedLabel = new System.Windows.Forms.Label();
            this.dataGridViewAudiobook = new System.Windows.Forms.DataGridView();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudiobook)).BeginInit();
            this.SuspendLayout();
            // 
            // noAudiobookRentedLabel
            // 
            this.noAudiobookRentedLabel.AutoSize = true;
            this.noAudiobookRentedLabel.Font = new System.Drawing.Font("Roboto", 20F);
            this.noAudiobookRentedLabel.Location = new System.Drawing.Point(73, 177);
            this.noAudiobookRentedLabel.Name = "noAudiobookRentedLabel";
            this.noAudiobookRentedLabel.Size = new System.Drawing.Size(526, 66);
            this.noAudiobookRentedLabel.TabIndex = 35;
            this.noAudiobookRentedLabel.Text = "You don\'t have any audiobooks rented yet. \r\nCome back after you rent something!\r\n" +
    "";
            this.noAudiobookRentedLabel.Visible = false;
            // 
            // dataGridViewAudiobook
            // 
            this.dataGridViewAudiobook.AllowUserToAddRows = false;
            this.dataGridViewAudiobook.AllowUserToDeleteRows = false;
            this.dataGridViewAudiobook.AllowUserToResizeColumns = false;
            this.dataGridViewAudiobook.AllowUserToResizeRows = false;
            this.dataGridViewAudiobook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewAudiobook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAudiobook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAudiobook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAudiobook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAudiobook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAudiobook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAudiobook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAudiobook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAudiobook.GridColor = System.Drawing.Color.White;
            this.dataGridViewAudiobook.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewAudiobook.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAudiobook.MultiSelect = false;
            this.dataGridViewAudiobook.Name = "dataGridViewAudiobook";
            this.dataGridViewAudiobook.ReadOnly = true;
            this.dataGridViewAudiobook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAudiobook.RowHeadersVisible = false;
            this.dataGridViewAudiobook.RowHeadersWidth = 100;
            this.dataGridViewAudiobook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAudiobook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAudiobook.Size = new System.Drawing.Size(704, 328);
            this.dataGridViewAudiobook.TabIndex = 34;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Roboto", 18F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(171, 365);
            this.returnButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(250, 47);
            this.returnButton.TabIndex = 33;
            this.returnButton.Text = "Return selection";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // rentedAudiobooksWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 425);
            this.Controls.Add(this.noAudiobookRentedLabel);
            this.Controls.Add(this.dataGridViewAudiobook);
            this.Controls.Add(this.returnButton);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rentedAudiobooksWin";
            this.Text = "rentedAudiobooksWin";
            this.Load += new System.EventHandler(this.rentedAudiobooksWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudiobook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noAudiobookRentedLabel;
        private System.Windows.Forms.DataGridView dataGridViewAudiobook;
        private System.Windows.Forms.Button returnButton;
    }
}