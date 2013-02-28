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
            string[] temp = new string[12];
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
                    temp[0] = (c.Title);
                    temp[1] = (c.Firstname);
                    temp[2] = (c.Surname);
                    temp[3] = (c.Birthday);
                    temp[4] = (c.Street);
                    temp[5] = (c.Postcode);
                    temp[6] = (c.City);
                    temp[7] = (c.Country);
                    temp[8] = (c.CardholderName);
                    temp[9] = (c.Cardnumber);
                    temp[10] = (c.Expiremonth);
                    temp[11] = (c.Expireyear);
                    dg_customer.Rows.Add(temp);
                }
            }
            catch(Exception e){
                System.Console.WriteLine(e.ToString());
            }
            }


    }




    






}
