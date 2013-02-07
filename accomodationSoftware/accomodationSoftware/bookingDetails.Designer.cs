namespace accomodationSoftware
{
    partial class bookingDetails
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
            this.dTP_startDate = new System.Windows.Forms.DateTimePicker();
            this.dTP_endDate = new System.Windows.Forms.DateTimePicker();
            this.l_hotelName_bd = new System.Windows.Forms.Label();
            this.l_startDate = new System.Windows.Forms.Label();
            this.l_endDate = new System.Windows.Forms.Label();
            this.gB_pickadate = new System.Windows.Forms.GroupBox();
            this.lv_rooms = new System.Windows.Forms.ListView();
            this.b_bookselected = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.gB_pickadate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTP_startDate
            // 
            this.dTP_startDate.Location = new System.Drawing.Point(6, 32);
            this.dTP_startDate.Name = "dTP_startDate";
            this.dTP_startDate.Size = new System.Drawing.Size(189, 20);
            this.dTP_startDate.TabIndex = 0;
            this.dTP_startDate.ValueChanged += new System.EventHandler(this.dTP_startDate_ValueChanged);
            // 
            // dTP_endDate
            // 
            this.dTP_endDate.Location = new System.Drawing.Point(210, 32);
            this.dTP_endDate.MinDate = new System.DateTime(2013, 1, 10, 0, 0, 0, 0);
            this.dTP_endDate.Name = "dTP_endDate";
            this.dTP_endDate.Size = new System.Drawing.Size(190, 20);
            this.dTP_endDate.TabIndex = 1;
            this.dTP_endDate.ValueChanged += new System.EventHandler(this.dTP_endDate_ValueChanged);
            // 
            // l_hotelName_bd
            // 
            this.l_hotelName_bd.AutoSize = true;
            this.l_hotelName_bd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.l_hotelName_bd.Location = new System.Drawing.Point(13, 13);
            this.l_hotelName_bd.Name = "l_hotelName_bd";
            this.l_hotelName_bd.Size = new System.Drawing.Size(98, 19);
            this.l_hotelName_bd.TabIndex = 2;
            this.l_hotelName_bd.Text = "hotel_name";
            // 
            // l_startDate
            // 
            this.l_startDate.AutoSize = true;
            this.l_startDate.Location = new System.Drawing.Point(6, 16);
            this.l_startDate.Name = "l_startDate";
            this.l_startDate.Size = new System.Drawing.Size(55, 13);
            this.l_startDate.TabIndex = 3;
            this.l_startDate.Text = "Start Date";
            // 
            // l_endDate
            // 
            this.l_endDate.AutoSize = true;
            this.l_endDate.Location = new System.Drawing.Point(207, 16);
            this.l_endDate.Name = "l_endDate";
            this.l_endDate.Size = new System.Drawing.Size(52, 13);
            this.l_endDate.TabIndex = 4;
            this.l_endDate.Text = "End Date";
            // 
            // gB_pickadate
            // 
            this.gB_pickadate.Controls.Add(this.l_startDate);
            this.gB_pickadate.Controls.Add(this.l_endDate);
            this.gB_pickadate.Controls.Add(this.dTP_startDate);
            this.gB_pickadate.Controls.Add(this.dTP_endDate);
            this.gB_pickadate.Location = new System.Drawing.Point(12, 35);
            this.gB_pickadate.Name = "gB_pickadate";
            this.gB_pickadate.Size = new System.Drawing.Size(406, 65);
            this.gB_pickadate.TabIndex = 5;
            this.gB_pickadate.TabStop = false;
            this.gB_pickadate.Text = "Pick a Date";
            // 
            // lv_rooms
            // 
            this.lv_rooms.Location = new System.Drawing.Point(12, 107);
            this.lv_rooms.Name = "lv_rooms";
            this.lv_rooms.Size = new System.Drawing.Size(406, 382);
            this.lv_rooms.TabIndex = 6;
            this.lv_rooms.UseCompatibleStateImageBehavior = false;
            // 
            // b_bookselected
            // 
            this.b_bookselected.Location = new System.Drawing.Point(251, 495);
            this.b_bookselected.Name = "b_bookselected";
            this.b_bookselected.Size = new System.Drawing.Size(86, 23);
            this.b_bookselected.TabIndex = 7;
            this.b_bookselected.Text = "Book Selected";
            this.b_bookselected.UseVisualStyleBackColor = true;
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(343, 495);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 8;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // bookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 524);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_bookselected);
            this.Controls.Add(this.lv_rooms);
            this.Controls.Add(this.gB_pickadate);
            this.Controls.Add(this.l_hotelName_bd);
            this.Name = "bookingDetails";
            this.Text = "Accomodation Software";
            this.Load += new System.EventHandler(this.bookingDetails_Load);
            this.gB_pickadate.ResumeLayout(false);
            this.gB_pickadate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP_startDate;
        private System.Windows.Forms.DateTimePicker dTP_endDate;
        private System.Windows.Forms.Label l_hotelName_bd;
        private System.Windows.Forms.Label l_startDate;
        private System.Windows.Forms.Label l_endDate;
        private System.Windows.Forms.GroupBox gB_pickadate;
        private System.Windows.Forms.ListView lv_rooms;
        private System.Windows.Forms.Button b_bookselected;
        private System.Windows.Forms.Button b_cancel;
    }
}