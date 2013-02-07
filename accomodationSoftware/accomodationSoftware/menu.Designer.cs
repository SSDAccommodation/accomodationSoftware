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
            this.SuspendLayout();
            // 
            // Add_customer_button
            // 
            this.Add_customer_button.Location = new System.Drawing.Point(12, 12);
            this.Add_customer_button.Name = "Add_customer_button";
            this.Add_customer_button.Size = new System.Drawing.Size(150, 23);
            this.Add_customer_button.TabIndex = 0;
            this.Add_customer_button.Text = "add customer";
            this.Add_customer_button.UseVisualStyleBackColor = true;
            this.Add_customer_button.Click += new System.EventHandler(this.Add_customer_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 261);
            this.Controls.Add(this.Add_customer_button);
            this.Name = "Menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_customer_button;
    }
}