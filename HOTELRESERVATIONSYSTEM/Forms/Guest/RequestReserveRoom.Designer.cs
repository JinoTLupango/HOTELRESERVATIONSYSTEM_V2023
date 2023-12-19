namespace HOTELRESERVATIONSYSTEM.Forms.Guest
{
    partial class RequestReserveRoom
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_floor = new System.Windows.Forms.ComboBox();
            this.cmb_RoomNo = new System.Windows.Forms.ComboBox();
            this.dt_checkIn = new System.Windows.Forms.DateTimePicker();
            this.dt_check_out = new System.Windows.Forms.DateTimePicker();
            this.time_checkIn = new System.Windows.Forms.DateTimePicker();
            this.time_check_out = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cmb_floor
            // 
            this.cmb_floor.FormattingEnabled = true;
            this.cmb_floor.Location = new System.Drawing.Point(58, 26);
            this.cmb_floor.Name = "cmb_floor";
            this.cmb_floor.Size = new System.Drawing.Size(286, 21);
            this.cmb_floor.TabIndex = 1;
            this.cmb_floor.SelectedIndexChanged += new System.EventHandler(this.cmb_floor_SelectedIndexChanged);
            // 
            // cmb_RoomNo
            // 
            this.cmb_RoomNo.FormattingEnabled = true;
            this.cmb_RoomNo.Location = new System.Drawing.Point(58, 68);
            this.cmb_RoomNo.Name = "cmb_RoomNo";
            this.cmb_RoomNo.Size = new System.Drawing.Size(286, 21);
            this.cmb_RoomNo.TabIndex = 2;
            // 
            // dt_checkIn
            // 
            this.dt_checkIn.Location = new System.Drawing.Point(58, 106);
            this.dt_checkIn.Name = "dt_checkIn";
            this.dt_checkIn.Size = new System.Drawing.Size(200, 20);
            this.dt_checkIn.TabIndex = 3;
            // 
            // dt_check_out
            // 
            this.dt_check_out.Location = new System.Drawing.Point(58, 146);
            this.dt_check_out.Name = "dt_check_out";
            this.dt_check_out.Size = new System.Drawing.Size(200, 20);
            this.dt_check_out.TabIndex = 4;
            // 
            // time_checkIn
            // 
            this.time_checkIn.Location = new System.Drawing.Point(277, 106);
            this.time_checkIn.Name = "time_checkIn";
            this.time_checkIn.Size = new System.Drawing.Size(200, 20);
            this.time_checkIn.TabIndex = 5;
            // 
            // time_check_out
            // 
            this.time_check_out.Location = new System.Drawing.Point(277, 146);
            this.time_check_out.Name = "time_check_out";
            this.time_check_out.Size = new System.Drawing.Size(200, 20);
            this.time_check_out.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Book Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RequestReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time_check_out);
            this.Controls.Add(this.time_checkIn);
            this.Controls.Add(this.dt_check_out);
            this.Controls.Add(this.dt_checkIn);
            this.Controls.Add(this.cmb_RoomNo);
            this.Controls.Add(this.cmb_floor);
            this.Controls.Add(this.textBox1);
            this.Name = "RequestReserveRoom";
            this.Text = "RequestReserveRoom";
            this.Load += new System.EventHandler(this.RequestReserveRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_floor;
        private System.Windows.Forms.ComboBox cmb_RoomNo;
        private System.Windows.Forms.DateTimePicker dt_checkIn;
        private System.Windows.Forms.DateTimePicker dt_check_out;
        private System.Windows.Forms.DateTimePicker time_checkIn;
        private System.Windows.Forms.DateTimePicker time_check_out;
        private System.Windows.Forms.Button button1;
    }
}