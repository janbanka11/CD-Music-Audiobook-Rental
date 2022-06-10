
namespace Rental
{
    partial class rentedCDWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentedCDWin));
            this.noCDRentedLabel = new System.Windows.Forms.Label();
            this.dataGridViewCD = new System.Windows.Forms.DataGridView();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCD)).BeginInit();
            this.SuspendLayout();
            // 
            // noCDRentedLabel
            // 
            this.noCDRentedLabel.AutoSize = true;
            this.noCDRentedLabel.Font = new System.Drawing.Font("Roboto", 20F);
            this.noCDRentedLabel.Location = new System.Drawing.Point(73, 177);
            this.noCDRentedLabel.Name = "noCDRentedLabel";
            this.noCDRentedLabel.Size = new System.Drawing.Size(460, 66);
            this.noCDRentedLabel.TabIndex = 35;
            this.noCDRentedLabel.Text = "You don\'t have any music rented yet. \r\nCome back after you rent something!\r\n";
            this.noCDRentedLabel.Visible = false;
            // 
            // dataGridViewCD
            // 
            this.dataGridViewCD.AllowUserToAddRows = false;
            this.dataGridViewCD.AllowUserToDeleteRows = false;
            this.dataGridViewCD.AllowUserToResizeColumns = false;
            this.dataGridViewCD.AllowUserToResizeRows = false;
            this.dataGridViewCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCD.GridColor = System.Drawing.Color.White;
            this.dataGridViewCD.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewCD.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCD.MultiSelect = false;
            this.dataGridViewCD.Name = "dataGridViewCD";
            this.dataGridViewCD.ReadOnly = true;
            this.dataGridViewCD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCD.RowHeadersVisible = false;
            this.dataGridViewCD.RowHeadersWidth = 100;
            this.dataGridViewCD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCD.Size = new System.Drawing.Size(704, 328);
            this.dataGridViewCD.TabIndex = 34;
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
            // rentedCDWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 425);
            this.Controls.Add(this.noCDRentedLabel);
            this.Controls.Add(this.dataGridViewCD);
            this.Controls.Add(this.returnButton);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rentedCDWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rentedCDWin";
            this.Load += new System.EventHandler(this.rentedCDWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noCDRentedLabel;
        private System.Windows.Forms.DataGridView dataGridViewCD;
        private System.Windows.Forms.Button returnButton;
    }
}