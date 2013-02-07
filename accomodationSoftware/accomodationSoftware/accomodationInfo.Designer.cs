namespace addCustomer
{
    partial class accomodationInfo
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
            this.pb_hotel = new System.Windows.Forms.PictureBox();
            this.l_hotelname = new System.Windows.Forms.Label();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.b_back = new System.Windows.Forms.Button();
            this.b_bookingDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hotel
            // 
            this.pb_hotel.Location = new System.Drawing.Point(231, 54);
            this.pb_hotel.Name = "pb_hotel";
            this.pb_hotel.Size = new System.Drawing.Size(221, 180);
            this.pb_hotel.TabIndex = 0;
            this.pb_hotel.TabStop = false;
            // 
            // l_hotelname
            // 
            this.l_hotelname.AutoSize = true;
            this.l_hotelname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_hotelname.Location = new System.Drawing.Point(13, 13);
            this.l_hotelname.Name = "l_hotelname";
            this.l_hotelname.Size = new System.Drawing.Size(98, 19);
            this.l_hotelname.TabIndex = 1;
            this.l_hotelname.Text = "hotel_name";
            // 
            // rtb_address
            // 
            this.rtb_address.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_address.Location = new System.Drawing.Point(12, 54);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.ReadOnly = true;
            this.rtb_address.Size = new System.Drawing.Size(198, 180);
            this.rtb_address.TabIndex = 2;
            this.rtb_address.Text = "";
            // 
            // rtb_description
            // 
            this.rtb_description.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_description.Location = new System.Drawing.Point(12, 259);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.ReadOnly = true;
            this.rtb_description.Size = new System.Drawing.Size(440, 249);
            this.rtb_description.TabIndex = 3;
            this.rtb_description.Text = "";
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(377, 514);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 5;
            this.b_back.Text = "Back";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_bookingDetails
            // 
            this.b_bookingDetails.Location = new System.Drawing.Point(272, 514);
            this.b_bookingDetails.Name = "b_bookingDetails";
            this.b_bookingDetails.Size = new System.Drawing.Size(99, 23);
            this.b_bookingDetails.TabIndex = 6;
            this.b_bookingDetails.Text = "Booking Details";
            this.b_bookingDetails.UseVisualStyleBackColor = true;
            this.b_bookingDetails.Click += new System.EventHandler(this.b_bookingDetails_Click);
            // 
            // accomodationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 544);
            this.Controls.Add(this.b_bookingDetails);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.rtb_description);
            this.Controls.Add(this.rtb_address);
            this.Controls.Add(this.l_hotelname);
            this.Controls.Add(this.pb_hotel);
            this.Name = "accomodationInfo";
            this.Text = "Accomodation Software";
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hotel;
        private System.Windows.Forms.Label l_hotelname;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button b_bookingDetails;
    }
}