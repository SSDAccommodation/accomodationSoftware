namespace accomodationSoftware
{
    partial class Menu
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
            this.Add_customer_button = new System.Windows.Forms.Button();
            this.accInfoButton = new System.Windows.Forms.Button();
            this.bookingButton = new System.Windows.Forms.Button();
            this.showCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_customer_button
            // 
            this.Add_customer_button.Location = new System.Drawing.Point(11, 12);
            this.Add_customer_button.Name = "Add_customer_button";
            this.Add_customer_button.Size = new System.Drawing.Size(150, 23);
            this.Add_customer_button.TabIndex = 0;
            this.Add_customer_button.Text = "Add customer";
            this.Add_customer_button.UseVisualStyleBackColor = true;
            this.Add_customer_button.Click += new System.EventHandler(this.Add_customer_button_Click);
            // 
            // accInfoButton
            // 
            this.accInfoButton.Location = new System.Drawing.Point(11, 42);
            this.accInfoButton.Name = "accInfoButton";
            this.accInfoButton.Size = new System.Drawing.Size(150, 23);
            this.accInfoButton.TabIndex = 1;
            this.accInfoButton.Text = "Accommodation info";
            this.accInfoButton.UseVisualStyleBackColor = true;
            this.accInfoButton.Click += new System.EventHandler(this.accInfoButton_Click);
            // 
            // bookingButton
            // 
            this.bookingButton.Location = new System.Drawing.Point(11, 72);
            this.bookingButton.Name = "bookingButton";
            this.bookingButton.Size = new System.Drawing.Size(150, 23);
            this.bookingButton.TabIndex = 2;
            this.bookingButton.Text = "Bookings";
            this.bookingButton.UseVisualStyleBackColor = true;
            this.bookingButton.Click += new System.EventHandler(this.bookingButton_Click);
            // 
            // showCustomerButton
            // 
            this.showCustomerButton.Location = new System.Drawing.Point(11, 102);
            this.showCustomerButton.Name = "showCustomerButton";
            this.showCustomerButton.Size = new System.Drawing.Size(149, 23);
            this.showCustomerButton.TabIndex = 3;
            this.showCustomerButton.Text = "Show Customers";
            this.showCustomerButton.UseVisualStyleBackColor = true;
            this.showCustomerButton.Click += new System.EventHandler(this.showCustomerButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 261);
            this.Controls.Add(this.showCustomerButton);
            this.Controls.Add(this.bookingButton);
            this.Controls.Add(this.accInfoButton);
            this.Controls.Add(this.Add_customer_button);
            this.Name = "Menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_customer_button;
        private System.Windows.Forms.Button accInfoButton;
        private System.Windows.Forms.Button bookingButton;
        private System.Windows.Forms.Button showCustomerButton;
    }
}