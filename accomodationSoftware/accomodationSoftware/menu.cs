using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accomodationSoftware
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Add_customer_button_Click(object sender, EventArgs e)
        {
            new_customer accForm = new new_customer();
            accForm.Show();
        }
    }
}
