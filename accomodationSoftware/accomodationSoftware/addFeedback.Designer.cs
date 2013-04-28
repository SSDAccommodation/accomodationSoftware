namespace accomodationSoftware
{
    partial class addFeedback
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
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_ok = new System.Windows.Forms.Button();
            this.rtb_feedback = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(449, 197);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 0;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(368, 197);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 1;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // rtb_feedback
            // 
            this.rtb_feedback.Location = new System.Drawing.Point(13, 13);
            this.rtb_feedback.Name = "rtb_feedback";
            this.rtb_feedback.Size = new System.Drawing.Size(511, 178);
            this.rtb_feedback.TabIndex = 2;
            this.rtb_feedback.Text = "";
            // 
            // addFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 232);
            this.Controls.Add(this.rtb_feedback);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.b_cancel);
            this.Name = "addFeedback";
            this.Text = "Feedback";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.RichTextBox rtb_feedback;
    }
}