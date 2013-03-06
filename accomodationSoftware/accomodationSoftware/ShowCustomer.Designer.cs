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
            this.dg_customer = new System.Windows.Forms.DataGridView();
            this.l_surname = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.b_search = new System.Windows.Forms.Button();
            this.b_acc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_customer
            // 
            this.dg_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_customer.Location = new System.Drawing.Point(12, 64);
            this.dg_customer.Name = "dg_customer";
            this.dg_customer.Size = new System.Drawing.Size(341, 243);
            this.dg_customer.TabIndex = 0;
            this.dg_customer.DoubleClick += new System.EventHandler(this.dg_customer_DoubleClick);
            // 
            // l_surname
            // 
            this.l_surname.AutoSize = true;
            this.l_surname.Location = new System.Drawing.Point(13, 26);
            this.l_surname.Name = "l_surname";
            this.l_surname.Size = new System.Drawing.Size(52, 13);
            this.l_surname.TabIndex = 1;
            this.l_surname.Text = "Surname:";
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(80, 23);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(171, 20);
            this.tb_surname.TabIndex = 2;
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(278, 20);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 23);
            this.b_search.TabIndex = 3;
            this.b_search.Text = "search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // b_acc
            // 
            this.b_acc.Location = new System.Drawing.Point(255, 326);
            this.b_acc.Name = "b_acc";
            this.b_acc.Size = new System.Drawing.Size(98, 23);
            this.b_acc.TabIndex = 4;
            this.b_acc.Text = "Accomodation";
            this.b_acc.UseVisualStyleBackColor = true;
            this.b_acc.Click += new System.EventHandler(this.b_acc_Click);
            // 
            // ShowCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 361);
            this.Controls.Add(this.b_acc);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.l_surname);
            this.Controls.Add(this.dg_customer);
            this.Name = "ShowCustomer";
            this.Text = "ShowCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_customer;
        private System.Windows.Forms.Label l_surname;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Button b_acc;

    }
}