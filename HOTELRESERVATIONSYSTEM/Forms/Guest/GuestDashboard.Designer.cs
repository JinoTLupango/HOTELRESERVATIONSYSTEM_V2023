namespace HOTELRESERVATIONSYSTEM.Forms
{
    partial class GuestDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listOfAvaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAvaiToolStripMenuItem,
            this.myReservationToolStripMenuItem,
            this.myProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listOfAvaiToolStripMenuItem
            // 
            this.listOfAvaiToolStripMenuItem.Name = "listOfAvaiToolStripMenuItem";
            this.listOfAvaiToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.listOfAvaiToolStripMenuItem.Text = "Check Available Room";
            this.listOfAvaiToolStripMenuItem.Click += new System.EventHandler(this.listOfAvaiToolStripMenuItem_Click);
            // 
            // myReservationToolStripMenuItem
            // 
            this.myReservationToolStripMenuItem.Name = "myReservationToolStripMenuItem";
            this.myReservationToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.myReservationToolStripMenuItem.Text = "My Reservation";
            this.myReservationToolStripMenuItem.Click += new System.EventHandler(this.myReservationToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.myProfileToolStripMenuItem.Text = "My profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // GuestDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 439);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GuestDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestDashboard";
            this.Load += new System.EventHandler(this.GuestDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listOfAvaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
    }
}