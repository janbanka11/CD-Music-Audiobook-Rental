
namespace Rental
{
    partial class rentedMoviesWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentedMoviesWin));
            this.returnButton = new System.Windows.Forms.Button();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.noMoviesRentedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            this.SuspendLayout();
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
            this.returnButton.TabIndex = 30;
            this.returnButton.Text = "Return selection";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.AllowUserToAddRows = false;
            this.dataGridViewMovie.AllowUserToDeleteRows = false;
            this.dataGridViewMovie.AllowUserToResizeColumns = false;
            this.dataGridViewMovie.AllowUserToResizeRows = false;
            this.dataGridViewMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMovie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMovie.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMovie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMovie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMovie.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMovie.GridColor = System.Drawing.Color.White;
            this.dataGridViewMovie.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewMovie.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMovie.MultiSelect = false;
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.ReadOnly = true;
            this.dataGridViewMovie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMovie.RowHeadersVisible = false;
            this.dataGridViewMovie.RowHeadersWidth = 100;
            this.dataGridViewMovie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovie.Size = new System.Drawing.Size(704, 328);
            this.dataGridViewMovie.TabIndex = 31;
            // 
            // noMoviesRentedLabel
            // 
            this.noMoviesRentedLabel.AutoSize = true;
            this.noMoviesRentedLabel.Font = new System.Drawing.Font("Roboto", 20F);
            this.noMoviesRentedLabel.Location = new System.Drawing.Point(73, 177);
            this.noMoviesRentedLabel.Name = "noMoviesRentedLabel";
            this.noMoviesRentedLabel.Size = new System.Drawing.Size(473, 66);
            this.noMoviesRentedLabel.TabIndex = 32;
            this.noMoviesRentedLabel.Text = "You don\'t have any movies rented yet. \r\nCome back after you rent something!\r\n";
            this.noMoviesRentedLabel.Visible = false;
            // 
            // rentedMoviesWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 425);
            this.Controls.Add(this.noMoviesRentedLabel);
            this.Controls.Add(this.dataGridViewMovie);
            this.Controls.Add(this.returnButton);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rentedMoviesWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "rentedMoviesWin";
            this.Load += new System.EventHandler(this.rentedMoviesWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.Label noMoviesRentedLabel;
    }
}