using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace accomodationSoftware
{
    public partial class addFeedback : Form
    {
        private Facility CurrentFacility;
        private Accomodation CurrentAccomondation;
        private Customer CurrentCustomer;
        public Database Db { get; set; }

        public addFeedback(Facility currentFacility, Customer currentCust)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            CurrentFacility = currentFacility;
            CurrentAccomondation = null;
            rtb_feedback.Text = CurrentFacility.Feedback;
            CurrentCustomer = currentCust;
            Db = new Database();
        }

        public addFeedback(Accomodation currentAccomondation, Customer currentCust)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            CurrentFacility = null;
            CurrentAccomondation = currentAccomondation;
            rtb_feedback.Text = CurrentAccomondation.Feedback;
            CurrentCustomer = currentCust;
            Db = new Database();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (CurrentAccomondation != null)
            {
                try
                {
                    CurrentAccomondation.Feedback = rtb_feedback.Text;
                    Db.updateAccFeedback(CurrentAccomondation, CurrentCustomer);
                }
                catch (Exception easd)
                {
                    Console.WriteLine(easd.ToString());
                }
                
            }
            else
            {
                CurrentFacility.Feedback = rtb_feedback.Text;
                Db.updateFacFeedback(CurrentFacility, CurrentCustomer);
            }
            this.Close();
        }
    }
}
