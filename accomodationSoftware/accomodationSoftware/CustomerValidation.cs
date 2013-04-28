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
    public partial class CustomerValidation : Form
    {
        public Database Db { get; set; }
        public Customer C { get; set; }
        public CustomerValidation(Customer c)
        {
            InitializeComponent();
            C = c;
            b_cancel.DialogResult = DialogResult.Cancel;
        }

        private void tb_cnumber_TextChanged(object sender, EventArgs e)
        {
            if (C.Cardnumber.Substring(C.Cardnumber.Length - 4) == tb_cnumber.Text)
                b_ok.DialogResult = DialogResult.OK;
            else
                b_ok.DialogResult = DialogResult.Cancel;
        }
    }
}
