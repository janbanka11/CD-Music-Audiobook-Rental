
namespace Rental
{
    partial class rentedWin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentedWin));
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMusic = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAudiobook = new System.Windows.Forms.DataGridView();
            this.rENTALMOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalDataSet = new Rental.RentalDataSet();
            this.rENTAL_MOVIETableAdapter = new Rental.RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmovieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaltoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENTALCDDISCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTAL_CD_DISCTableAdapter = new Rental.RentalDataSetTableAdapters.RENTAL_CD_DISCTableAdapter();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalfromDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaltoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rENTALAUDIOBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTAL_AUDIOBOOKTableAdapter = new Rental.RentalDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter();
            this.usernameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaudiobookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalfromDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaltoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudiobook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALMOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALCDDISCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALAUDIOBOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.AllowUserToAddRows = false;
            this.dataGridViewMovie.AllowUserToDeleteRows = false;
            this.dataGridViewMovie.AllowUserToResizeColumns = false;
            this.dataGridViewMovie.AllowUserToResizeRows = false;
            this.dataGridViewMovie.AutoGenerateColumns = false;
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
            this.dataGridViewMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.idmovieDataGridViewTextBoxColumn,
            this.rentalfromDataGridViewTextBoxColumn,
            this.rentaltoDataGridViewTextBoxColumn});
            this.dataGridViewMovie.DataSource = this.rENTALMOVIEBindingSource;
            this.dataGridViewMovie.GridColor = System.Drawing.Color.White;
            this.dataGridViewMovie.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewMovie.MultiSelect = false;
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.ReadOnly = true;
            this.dataGridViewMovie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMovie.RowHeadersVisible = false;
            this.dataGridViewMovie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovie.Size = new System.Drawing.Size(739, 151);
            this.dataGridViewMovie.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Music";
            // 
            // dataGridViewMusic
            // 
            this.dataGridViewMusic.AllowUserToAddRows = false;
            this.dataGridViewMusic.AllowUserToDeleteRows = false;
            this.dataGridViewMusic.AllowUserToResizeColumns = false;
            this.dataGridViewMusic.AllowUserToResizeRows = false;
            this.dataGridViewMusic.AutoGenerateColumns = false;
            this.dataGridViewMusic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMusic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMusic.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMusic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMusic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn1,
            this.idcdDataGridViewTextBoxColumn,
            this.rentalfromDataGridViewTextBoxColumn1,
            this.rentaltoDataGridViewTextBoxColumn1});
            this.dataGridViewMusic.DataSource = this.rENTALCDDISCBindingSource;
            this.dataGridViewMusic.GridColor = System.Drawing.Color.White;
            this.dataGridViewMusic.Location = new System.Drawing.Point(12, 239);
            this.dataGridViewMusic.MultiSelect = false;
            this.dataGridViewMusic.Name = "dataGridViewMusic";
            this.dataGridViewMusic.ReadOnly = true;
            this.dataGridViewMusic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMusic.RowHeadersVisible = false;
            this.dataGridViewMusic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusic.Size = new System.Drawing.Size(739, 151);
            this.dataGridViewMusic.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Audiobooks";
            // 
            // dataGridViewAudiobook
            // 
            this.dataGridViewAudiobook.AllowUserToAddRows = false;
            this.dataGridViewAudiobook.AllowUserToDeleteRows = false;
            this.dataGridViewAudiobook.AllowUserToResizeColumns = false;
            this.dataGridViewAudiobook.AllowUserToResizeRows = false;
            this.dataGridViewAudiobook.AutoGenerateColumns = false;
            this.dataGridViewAudiobook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewAudiobook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAudiobook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAudiobook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAudiobook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAudiobook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAudiobook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAudiobook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAudiobook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn2,
            this.idaudiobookDataGridViewTextBoxColumn,
            this.rentalfromDataGridViewTextBoxColumn2,
            this.rentaltoDataGridViewTextBoxColumn2});
            this.dataGridViewAudiobook.DataSource = this.rENTALAUDIOBOOKBindingSource;
            this.dataGridViewAudiobook.GridColor = System.Drawing.Color.White;
            this.dataGridViewAudiobook.Location = new System.Drawing.Point(12, 435);
            this.dataGridViewAudiobook.MultiSelect = false;
            this.dataGridViewAudiobook.Name = "dataGridViewAudiobook";
            this.dataGridViewAudiobook.ReadOnly = true;
            this.dataGridViewAudiobook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAudiobook.RowHeadersVisible = false;
            this.dataGridViewAudiobook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAudiobook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAudiobook.Size = new System.Drawing.Size(739, 151);
            this.dataGridViewAudiobook.TabIndex = 33;
            // 
            // rENTALMOVIEBindingSource
            // 
            this.rENTALMOVIEBindingSource.DataMember = "RENTAL_MOVIE";
            this.rENTALMOVIEBindingSource.DataSource = this.rentalDataSet;
            // 
            // rentalDataSet
            // 
            this.rentalDataSet.DataSetName = "RentalDataSet";
            this.rentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rENTAL_MOVIETableAdapter
            // 
            this.rENTAL_MOVIETableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 104;
            // 
            // idmovieDataGridViewTextBoxColumn
            // 
            this.idmovieDataGridViewTextBoxColumn.DataPropertyName = "id_movie";
            this.idmovieDataGridViewTextBoxColumn.HeaderText = "id_movie";
            this.idmovieDataGridViewTextBoxColumn.Name = "idmovieDataGridViewTextBoxColumn";
            this.idmovieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmovieDataGridViewTextBoxColumn.Width = 97;
            // 
            // rentalfromDataGridViewTextBoxColumn
            // 
            this.rentalfromDataGridViewTextBoxColumn.DataPropertyName = "rental_from";
            this.rentalfromDataGridViewTextBoxColumn.HeaderText = "rental_from";
            this.rentalfromDataGridViewTextBoxColumn.Name = "rentalfromDataGridViewTextBoxColumn";
            this.rentalfromDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentalfromDataGridViewTextBoxColumn.Width = 115;
            // 
            // rentaltoDataGridViewTextBoxColumn
            // 
            this.rentaltoDataGridViewTextBoxColumn.DataPropertyName = "rental_to";
            this.rentaltoDataGridViewTextBoxColumn.HeaderText = "rental_to";
            this.rentaltoDataGridViewTextBoxColumn.Name = "rentaltoDataGridViewTextBoxColumn";
            this.rentaltoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentaltoDataGridViewTextBoxColumn.Width = 95;
            // 
            // rENTALCDDISCBindingSource
            // 
            this.rENTALCDDISCBindingSource.DataMember = "RENTAL_CD_DISC";
            this.rENTALCDDISCBindingSource.DataSource = this.rentalDataSet;
            // 
            // rENTAL_CD_DISCTableAdapter
            // 
            this.rENTAL_CD_DISCTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn1.Width = 104;
            // 
            // idcdDataGridViewTextBoxColumn
            // 
            this.idcdDataGridViewTextBoxColumn.DataPropertyName = "id_cd";
            this.idcdDataGridViewTextBoxColumn.HeaderText = "id_cd";
            this.idcdDataGridViewTextBoxColumn.Name = "idcdDataGridViewTextBoxColumn";
            this.idcdDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcdDataGridViewTextBoxColumn.Width = 71;
            // 
            // rentalfromDataGridViewTextBoxColumn1
            // 
            this.rentalfromDataGridViewTextBoxColumn1.DataPropertyName = "rental_from";
            this.rentalfromDataGridViewTextBoxColumn1.HeaderText = "rental_from";
            this.rentalfromDataGridViewTextBoxColumn1.Name = "rentalfromDataGridViewTextBoxColumn1";
            this.rentalfromDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rentalfromDataGridViewTextBoxColumn1.Width = 115;
            // 
            // rentaltoDataGridViewTextBoxColumn1
            // 
            this.rentaltoDataGridViewTextBoxColumn1.DataPropertyName = "rental_to";
            this.rentaltoDataGridViewTextBoxColumn1.HeaderText = "rental_to";
            this.rentaltoDataGridViewTextBoxColumn1.Name = "rentaltoDataGridViewTextBoxColumn1";
            this.rentaltoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rentaltoDataGridViewTextBoxColumn1.Width = 95;
            // 
            // rENTALAUDIOBOOKBindingSource
            // 
            this.rENTALAUDIOBOOKBindingSource.DataMember = "RENTAL_AUDIOBOOK";
            this.rENTALAUDIOBOOKBindingSource.DataSource = this.rentalDataSet;
            // 
            // rENTAL_AUDIOBOOKTableAdapter
            // 
            this.rENTAL_AUDIOBOOKTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn2
            // 
            this.usernameDataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn2.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn2.Name = "usernameDataGridViewTextBoxColumn2";
            this.usernameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn2.Width = 104;
            // 
            // idaudiobookDataGridViewTextBoxColumn
            // 
            this.idaudiobookDataGridViewTextBoxColumn.DataPropertyName = "id_audiobook";
            this.idaudiobookDataGridViewTextBoxColumn.HeaderText = "id_audiobook";
            this.idaudiobookDataGridViewTextBoxColumn.Name = "idaudiobookDataGridViewTextBoxColumn";
            this.idaudiobookDataGridViewTextBoxColumn.ReadOnly = true;
            this.idaudiobookDataGridViewTextBoxColumn.Width = 129;
            // 
            // rentalfromDataGridViewTextBoxColumn2
            // 
            this.rentalfromDataGridViewTextBoxColumn2.DataPropertyName = "rental_from";
            this.rentalfromDataGridViewTextBoxColumn2.HeaderText = "rental_from";
            this.rentalfromDataGridViewTextBoxColumn2.Name = "rentalfromDataGridViewTextBoxColumn2";
            this.rentalfromDataGridViewTextBoxColumn2.ReadOnly = true;
            this.rentalfromDataGridViewTextBoxColumn2.Width = 115;
            // 
            // rentaltoDataGridViewTextBoxColumn2
            // 
            this.rentaltoDataGridViewTextBoxColumn2.DataPropertyName = "rental_to";
            this.rentaltoDataGridViewTextBoxColumn2.HeaderText = "rental_to";
            this.rentaltoDataGridViewTextBoxColumn2.Name = "rentaltoDataGridViewTextBoxColumn2";
            this.rentaltoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.rentaltoDataGridViewTextBoxColumn2.Width = 95;
            // 
            // rentedWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(763, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewAudiobook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMusic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMovie);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "rentedWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rented";
            this.Load += new System.EventHandler(this.rentedWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudiobook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALMOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALCDDISCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALAUDIOBOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMusic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewAudiobook;
        private RentalDataSet rentalDataSet;
        private System.Windows.Forms.BindingSource rENTALMOVIEBindingSource;
        private RentalDataSetTableAdapters.RENTAL_MOVIETableAdapter rENTAL_MOVIETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmovieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaltoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalfromDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaltoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource rENTALCDDISCBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaudiobookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalfromDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentaltoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource rENTALAUDIOBOOKBindingSource;
        private RentalDataSetTableAdapters.RENTAL_CD_DISCTableAdapter rENTAL_CD_DISCTableAdapter;
        private RentalDataSetTableAdapters.RENTAL_AUDIOBOOKTableAdapter rENTAL_AUDIOBOOKTableAdapter;
    }
}