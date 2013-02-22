﻿using System;
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
            try
            {
                dg_customer.ColumnCount = 12;
                dg_customer.Columns[0].Name = "Title";
                dg_customer.Columns[1].Name = "Firstname";
                dg_customer.Columns[2].Name = "Surname";
                dg_customer.Columns[3].Name = "Birthday";
                dg_customer.Columns[4].Name = "Street";
                dg_customer.Columns[5].Name = "Postcode";
                dg_customer.Columns[6].Name = "City";
                dg_customer.Columns[7].Name = "Country";
                dg_customer.Columns[8].Name = "Cardholder Name";
                dg_customer.Columns[9].Name = "Cardnumber";
                dg_customer.Columns[10].Name = "Expiremonth";
                dg_customer.Columns[11].Name = "Expireyear";

                    foreach (Customer c in a)
                    {
                        dg_customer.Rows.Add(c.Title);
                        dg_customer.Rows.Add(c.Firstname);
                        dg_customer.Rows.Add(c.Surname);
                        dg_customer.Rows.Add(c.Birthday);
                        dg_customer.Rows.Add(c.Street);
                        dg_customer.Rows.Add(c.Postcode);
                        dg_customer.Rows.Add(c.City);
                        dg_customer.Rows.Add(c.Country);
                        dg_customer.Rows.Add(c.CardholderName);
                        dg_customer.Rows.Add(c.Cardnumber);
                        dg_customer.Rows.Add(c.Expiremonth);
                        dg_customer.Rows.Add(c.Expireyear);
                    }
            }
            catch(Exception e){
                System.Console.WriteLine(e.ToString());
            }
            }


    }




    






}
