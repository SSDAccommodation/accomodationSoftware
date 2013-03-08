namespace accomodationSoftware
{
    partial class AddCustomer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_byear = new System.Windows.Forms.ComboBox();
            this.cb_bday = new System.Windows.Forms.ComboBox();
            this.cb_bmonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.cb_title = new System.Windows.Forms.ComboBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_expireyear = new System.Windows.Forms.ComboBox();
            this.cb_expiremonth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_creditnum = new System.Windows.Forms.TextBox();
            this.tb_cardholder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.b_saveCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_postcode = new System.Windows.Forms.TextBox();
            this.tb_street = new System.Windows.Forms.TextBox();
            this.accShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_byear);
            this.groupBox1.Controls.Add(this.cb_bday);
            this.groupBox1.Controls.Add(this.cb_bmonth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_surname);
            this.groupBox1.Controls.Add(this.cb_title);
            this.groupBox1.Controls.Add(this.tb_firstname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birthday";
            // 
            // cb_byear
            // 
            this.cb_byear.FormattingEnabled = true;
            this.cb_byear.Items.AddRange(new object[] {
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910"});
            this.cb_byear.Location = new System.Drawing.Point(283, 106);
            this.cb_byear.Name = "cb_byear";
            this.cb_byear.Size = new System.Drawing.Size(51, 24);
            this.cb_byear.TabIndex = 10;
            // 
            // cb_bday
            // 
            this.cb_bday.FormattingEnabled = true;
            this.cb_bday.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_bday.Location = new System.Drawing.Point(134, 106);
            this.cb_bday.Name = "cb_bday";
            this.cb_bday.Size = new System.Drawing.Size(37, 24);
            this.cb_bday.TabIndex = 9;
            // 
            // cb_bmonth
            // 
            this.cb_bmonth.FormattingEnabled = true;
            this.cb_bmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cb_bmonth.Location = new System.Drawing.Point(177, 106);
            this.cb_bmonth.Name = "cb_bmonth";
            this.cb_bmonth.Size = new System.Drawing.Size(99, 24);
            this.cb_bmonth.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(134, 77);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(200, 22);
            this.tb_surname.TabIndex = 5;
            // 
            // cb_title
            // 
            this.cb_title.FormattingEnabled = true;
            this.cb_title.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs.",
            "Dr.",
            "Prof."});
            this.cb_title.Location = new System.Drawing.Point(134, 17);
            this.cb_title.Name = "cb_title";
            this.cb_title.Size = new System.Drawing.Size(55, 24);
            this.cb_title.TabIndex = 4;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(134, 48);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(200, 22);
            this.tb_firstname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cb_expireyear);
            this.groupBox2.Controls.Add(this.cb_expiremonth);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_creditnum);
            this.groupBox2.Controls.Add(this.tb_cardholder);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Expiry Date";
            // 
            // cb_expireyear
            // 
            this.cb_expireyear.FormattingEnabled = true;
            this.cb_expireyear.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012"});
            this.cb_expireyear.Location = new System.Drawing.Point(255, 80);
            this.cb_expireyear.Name = "cb_expireyear";
            this.cb_expireyear.Size = new System.Drawing.Size(79, 24);
            this.cb_expireyear.TabIndex = 5;
            // 
            // cb_expiremonth
            // 
            this.cb_expiremonth.FormattingEnabled = true;
            this.cb_expiremonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cb_expiremonth.Location = new System.Drawing.Point(134, 80);
            this.cb_expiremonth.Name = "cb_expiremonth";
            this.cb_expiremonth.Size = new System.Drawing.Size(114, 24);
            this.cb_expiremonth.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Credit Card Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cardholder´s Name";
            // 
            // tb_creditnum
            // 
            this.tb_creditnum.Location = new System.Drawing.Point(134, 51);
            this.tb_creditnum.Name = "tb_creditnum";
            this.tb_creditnum.Size = new System.Drawing.Size(200, 22);
            this.tb_creditnum.TabIndex = 1;
            // 
            // tb_cardholder
            // 
            this.tb_cardholder.Location = new System.Drawing.Point(134, 22);
            this.tb_cardholder.Name = "tb_cardholder";
            this.tb_cardholder.Size = new System.Drawing.Size(200, 22);
            this.tb_cardholder.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_saveCustomer
            // 
            this.b_saveCustomer.Location = new System.Drawing.Point(237, 479);
            this.b_saveCustomer.Name = "b_saveCustomer";
            this.b_saveCustomer.Size = new System.Drawing.Size(75, 23);
            this.b_saveCustomer.TabIndex = 3;
            this.b_saveCustomer.Text = "OK";
            this.b_saveCustomer.UseVisualStyleBackColor = true;
            this.b_saveCustomer.Click += new System.EventHandler(this.b_saveCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add a new Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_country);
            this.groupBox3.Controls.Add(this.tb_city);
            this.groupBox3.Controls.Add(this.tb_postcode);
            this.groupBox3.Controls.Add(this.tb_street);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 145);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Street";
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Items.AddRange(new object[] {
            "Afghanistan",
            "Aland Islands",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua And Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia And Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazil",
            "British Indian Ocean Territory",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo, The Democratic Republic Of The",
            "Cook Islands",
            "Costa Rica",
            "Cote D\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands (Malvinas)",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "French Guiana",
            "French Polynesia",
            "French Southern Territories",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Heard Island And Mcdonald Islands",
            "Holy See (Vatican City State)",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran, Islamic Republic Of",
            "Iraq",
            "Ireland",
            "Isle Of Man",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jersey",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, Democratic People\'S Republic Of",
            "Korea, Republic Of",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'S Democratic Republic",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libyan Arab Jamahiriya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macao",
            "Macedonia, The Former Yugoslav Republic Of",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia, Federated States Of",
            "Moldova, Republic Of",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territory, Occupied",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts And Nevis",
            "Saint Lucia",
            "Saint Pierre And Miquelon",
            "Saint Vincent And The Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome And Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia And Montenegro",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Georgia And The South Sandwich Islands",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Svalbard And Jan Mayen",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Taiwan, Province Of China",
            "Tajikistan",
            "Tanzania, United Republic Of",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad And Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks And Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "United States Minor Outlying Islands",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Viet Nam",
            "Virgin Islands, British",
            "Virgin Islands, U.S.",
            "Wallis And Futuna",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cb_country.Location = new System.Drawing.Point(132, 109);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(200, 24);
            this.cb_country.TabIndex = 3;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(132, 80);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(200, 22);
            this.tb_city.TabIndex = 2;
            // 
            // tb_postcode
            // 
            this.tb_postcode.Location = new System.Drawing.Point(132, 51);
            this.tb_postcode.Name = "tb_postcode";
            this.tb_postcode.Size = new System.Drawing.Size(104, 22);
            this.tb_postcode.TabIndex = 1;
            // 
            // tb_street
            // 
            this.tb_street.Location = new System.Drawing.Point(132, 22);
            this.tb_street.Name = "tb_street";
            this.tb_street.Size = new System.Drawing.Size(200, 22);
            this.tb_street.TabIndex = 0;
            // 
            // accShow
            // 
            this.accShow.Location = new System.Drawing.Point(11, 479);
            this.accShow.Name = "accShow";
            this.accShow.Size = new System.Drawing.Size(94, 23);
            this.accShow.TabIndex = 6;
            this.accShow.Text = "acc show test";
            this.accShow.UseVisualStyleBackColor = true;
            this.accShow.Click += new System.EventHandler(this.accShow_Click);
            // 
            // new_customer
            // 
            this.AcceptButton = this.b_saveCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 509);
            this.Controls.Add(this.accShow);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_saveCustomer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "new_customer";
            this.Text = "Accomodation Software";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_saveCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_title;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.ComboBox cb_byear;
        private System.Windows.Forms.ComboBox cb_bday;
        private System.Windows.Forms.ComboBox cb_bmonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_street;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_postcode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_expireyear;
        private System.Windows.Forms.ComboBox cb_expiremonth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_creditnum;
        private System.Windows.Forms.TextBox tb_cardholder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button accShow;
    }
}

