
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentedWin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.audiobookButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.movieButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.audiobookButton);
            this.panel1.Controls.Add(this.musicButton);
            this.panel1.Controls.Add(this.movieButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 485);
            this.panel1.TabIndex = 0;
            // 
            // audiobookButton
            // 
            this.audiobookButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.audiobookButton.BackgroundImage = global::Rental.Properties.Resources.icons8_audio_book_100;
            this.audiobookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.audiobookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audiobookButton.FlatAppearance.BorderSize = 0;
            this.audiobookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audiobookButton.Font = new System.Drawing.Font("Roboto", 18F);
            this.audiobookButton.ForeColor = System.Drawing.Color.White;
            this.audiobookButton.Location = new System.Drawing.Point(0, 329);
            this.audiobookButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.audiobookButton.Name = "audiobookButton";
            this.audiobookButton.Size = new System.Drawing.Size(71, 47);
            this.audiobookButton.TabIndex = 30;
            this.audiobookButton.UseVisualStyleBackColor = false;
            this.audiobookButton.Click += new System.EventHandler(this.audiobookButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.musicButton.BackgroundImage = global::Rental.Properties.Resources.icons8_headphones_96;
            this.musicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicButton.FlatAppearance.BorderSize = 0;
            this.musicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicButton.Font = new System.Drawing.Font("Roboto", 18F);
            this.musicButton.ForeColor = System.Drawing.Color.White;
            this.musicButton.Location = new System.Drawing.Point(4, 210);
            this.musicButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(67, 47);
            this.musicButton.TabIndex = 29;
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // movieButton
            // 
            this.movieButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.movieButton.BackgroundImage = global::Rental.Properties.Resources.icons8_movie_80;
            this.movieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.movieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movieButton.FlatAppearance.BorderSize = 0;
            this.movieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieButton.Font = new System.Drawing.Font("Roboto", 18F);
            this.movieButton.ForeColor = System.Drawing.Color.White;
            this.movieButton.Location = new System.Drawing.Point(4, 89);
            this.movieButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(67, 54);
            this.movieButton.TabIndex = 28;
            this.movieButton.UseVisualStyleBackColor = false;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // rentedWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(695, 485);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "rentedWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your rentals";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.rentedWin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button audiobookButton;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button movieButton;
    }
}