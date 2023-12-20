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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cmb_floor
            // 
            this.cmb_floor.FormattingEnabled = true;
            this.cmb_floor.Location = new System.Drawing.Point(56, 39);
            this.cmb_floor.Name = "cmb_floor";
            this.cmb_floor.Size = new System.Drawing.Size(286, 21);
            this.cmb_floor.TabIndex = 1;
            this.cmb_floor.SelectedIndexChanged += new System.EventHandler(this.cmb_floor_SelectedIndexChanged);
            // 
            // cmb_RoomNo
            // 
            this.cmb_RoomNo.FormattingEnabled = true;
            this.cmb_RoomNo.Location = new System.Drawing.Point(56, 88);
            this.cmb_RoomNo.Name = "cmb_RoomNo";
            this.cmb_RoomNo.Size = new System.Drawing.Size(286, 21);
            this.cmb_RoomNo.TabIndex = 2;
            // 
            // dt_checkIn
            // 
            this.dt_checkIn.Location = new System.Drawing.Point(56, 142);
            this.dt_checkIn.Name = "dt_checkIn";
            this.dt_checkIn.Size = new System.Drawing.Size(200, 20);
            this.dt_checkIn.TabIndex = 3;
            // 
            // dt_check_out
            // 
            this.dt_check_out.Location = new System.Drawing.Point(56, 193);
            this.dt_check_out.Name = "dt_check_out";
            this.dt_check_out.Size = new System.Drawing.Size(200, 20);
            this.dt_check_out.TabIndex = 4;
            // 
            // time_checkIn
            // 
            this.time_checkIn.Location = new System.Drawing.Point(275, 142);
            this.time_checkIn.Name = "time_checkIn";
            this.time_checkIn.Size = new System.Drawing.Size(200, 20);
            this.time_checkIn.TabIndex = 5;
            // 
            // time_check_out
            // 
            this.time_check_out.Location = new System.Drawing.Point(275, 193);
            this.time_check_out.Name = "time_check_out";
            this.time_check_out.Size = new System.Drawing.Size(200, 20);
            this.time_check_out.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Book Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Floor No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Room No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Check In Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Check Out Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Check In Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Check Out Time";
            // 
            // RequestReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 398);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}