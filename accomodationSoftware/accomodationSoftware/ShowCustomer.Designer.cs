namespace accomodationSoftware
{
    partial class ShowCustomer
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
            this.customerListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // customerListView
            // 
            this.customerListView.Location = new System.Drawing.Point(13, 13);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(340, 336);
            this.customerListView.TabIndex = 0;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            // 
            // ShowCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 361);
            this.Controls.Add(this.customerListView);
            this.Name = "ShowCustomer";
            this.Text = "ShowCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customerListView;
    }
}