namespace accomodationSoftware
{
    partial class Details
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
            this.lv_details = new System.Windows.Forms.ListView();
            this.b_book = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_details
            // 
            this.lv_details.Location = new System.Drawing.Point(13, 13);
            this.lv_details.Name = "lv_details";
            this.lv_details.Size = new System.Drawing.Size(259, 200);
            this.lv_details.TabIndex = 0;
            this.lv_details.UseCompatibleStateImageBehavior = false;
            // 
            // b_book
            // 
            this.b_book.Location = new System.Drawing.Point(197, 227);
            this.b_book.Name = "b_book";
            this.b_book.Size = new System.Drawing.Size(75, 23);
            this.b_book.TabIndex = 1;
            this.b_book.Text = "Book";
            this.b_book.UseVisualStyleBackColor = true;
            this.b_book.Click += new System.EventHandler(this.b_book_Click);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(13, 227);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(75, 23);
            this.b_back.TabIndex = 2;
            this.b_back.Text = "Back";
            this.b_back.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_book);
            this.Controls.Add(this.lv_details);
            this.Name = "Details";
            this.Text = "Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_details;
        private System.Windows.Forms.Button b_book;
        private System.Windows.Forms.Button b_back;

    }
}