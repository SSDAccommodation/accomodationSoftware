using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace accomodationSoftware
{
    public partial class ShowCustomer : Form
    {

        public Db Db;
        
        
        
        public ShowCustomer()
        {
            InitializeComponent();
            Db = new Db();
             
            showCust(Db.getCustomers());
        }


        public void showCust(ArrayList a)
        {
            customerListView.Items.AddRange("");
        }


    }




    






}
