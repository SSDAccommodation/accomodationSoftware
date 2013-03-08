﻿namespace accomodationSoftware
{
    partial class Menu
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
            this.Add_customer_button = new System.Windows.Forms.Button();
            this.accInfoButton = new System.Windows.Forms.Button();
            this.bookingButton = new System.Windows.Forms.Button();
            this.showCustomerButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p_showcustomer = new System.Windows.Forms.Panel();
            this.p_accomodations = new System.Windows.Forms.Panel();
            this.tb_accosearchname = new System.Windows.Forms.TextBox();
            this.cb_accosearchcity = new System.Windows.Forms.ComboBox();
            this.cb_accosearchcountry = new System.Windows.Forms.ComboBox();
            this.l_accosearchname = new System.Windows.Forms.Label();
            this.l_accosearchcity = new System.Windows.Forms.Label();
            this.b_selectaccomodation = new System.Windows.Forms.Button();
            this.b_accosearch = new System.Windows.Forms.Button();
            this.l_accocountry = new System.Windows.Forms.Label();
            this.dgv_searchaccomodation = new System.Windows.Forms.DataGridView();
            this.b_addcustomer = new System.Windows.Forms.Button();
            this.b_selectcustomer = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.l_surname = new System.Windows.Forms.Label();
            this.dg_customer = new System.Windows.Forms.DataGridView();
            this.p_accomodationinfo = new System.Windows.Forms.Panel();
            this.ll_accosearchback = new System.Windows.Forms.LinkLabel();
            this.ll_showaccoinfoback = new System.Windows.Forms.LinkLabel();
            this.b_bookingDetails = new System.Windows.Forms.Button();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.l_hotelname = new System.Windows.Forms.Label();
            this.pb_hotel = new System.Windows.Forms.PictureBox();
            this.p_bookingdetails = new System.Windows.Forms.Panel();
            this.dgv_bookings = new System.Windows.Forms.DataGridView();
            this.b_bookselected = new System.Windows.Forms.Button();
            this.gB_pickadate = new System.Windows.Forms.GroupBox();
            this.l_startDate = new System.Windows.Forms.Label();
            this.l_endDate = new System.Windows.Forms.Label();
            this.dTP_startDate = new System.Windows.Forms.DateTimePicker();
            this.dTP_endDate = new System.Windows.Forms.DateTimePicker();
            this.l_hotelName_bd = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.p_showcustomer.SuspendLayout();
            this.p_accomodations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchaccomodation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).BeginInit();
            this.p_accomodationinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).BeginInit();
            this.p_bookingdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).BeginInit();
            this.gB_pickadate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_customer_button
            // 
            this.Add_customer_button.Location = new System.Drawing.Point(10, 131);
            this.Add_customer_button.Name = "Add_customer_button";
            this.Add_customer_button.Size = new System.Drawing.Size(150, 23);
            this.Add_customer_button.TabIndex = 0;
            this.Add_customer_button.Text = "Add customer";
            this.Add_customer_button.UseVisualStyleBackColor = true;
            this.Add_customer_button.Click += new System.EventHandler(this.Add_customer_button_Click);
            // 
            // accInfoButton
            // 
            this.accInfoButton.Location = new System.Drawing.Point(12, 160);
            this.accInfoButton.Name = "accInfoButton";
            this.accInfoButton.Size = new System.Drawing.Size(150, 23);
            this.accInfoButton.TabIndex = 1;
            this.accInfoButton.Text = "Accommodation info";
            this.accInfoButton.UseVisualStyleBackColor = true;
            this.accInfoButton.Click += new System.EventHandler(this.accInfoButton_Click);
            // 
            // bookingButton
            // 
            this.bookingButton.Location = new System.Drawing.Point(11, 72);
            this.bookingButton.Name = "bookingButton";
            this.bookingButton.Size = new System.Drawing.Size(150, 23);
            this.bookingButton.TabIndex = 2;
            this.bookingButton.Text = "Bookings";
            this.bookingButton.UseVisualStyleBackColor = true;
            this.bookingButton.Click += new System.EventHandler(this.bookingButton_Click);
            // 
            // showCustomerButton
            // 
            this.showCustomerButton.Location = new System.Drawing.Point(11, 102);
            this.showCustomerButton.Name = "showCustomerButton";
            this.showCustomerButton.Size = new System.Drawing.Size(149, 23);
            this.showCustomerButton.TabIndex = 3;
            this.showCustomerButton.Text = "Show Customers";
            this.showCustomerButton.UseVisualStyleBackColor = true;
            this.showCustomerButton.Click += new System.EventHandler(this.showCustomerButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // p_showcustomer
            // 
            this.p_showcustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_showcustomer.Controls.Add(this.b_addcustomer);
            this.p_showcustomer.Controls.Add(this.b_selectcustomer);
            this.p_showcustomer.Controls.Add(this.b_search);
            this.p_showcustomer.Controls.Add(this.tb_surname);
            this.p_showcustomer.Controls.Add(this.l_surname);
            this.p_showcustomer.Controls.Add(this.dg_customer);
            this.p_showcustomer.Location = new System.Drawing.Point(168, 28);
            this.p_showcustomer.Name = "p_showcustomer";
            this.p_showcustomer.Size = new System.Drawing.Size(742, 511);
            this.p_showcustomer.TabIndex = 5;
            // 
            // p_accomodations
            // 
            this.p_accomodations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_accomodations.Controls.Add(this.ll_accosearchback);
            this.p_accomodations.Controls.Add(this.tb_accosearchname);
            this.p_accomodations.Controls.Add(this.cb_accosearchcity);
            this.p_accomodations.Controls.Add(this.cb_accosearchcountry);
            this.p_accomodations.Controls.Add(this.l_accosearchname);
            this.p_accomodations.Controls.Add(this.l_accosearchcity);
            this.p_accomodations.Controls.Add(this.b_selectaccomodation);
            this.p_accomodations.Controls.Add(this.b_accosearch);
            this.p_accomodations.Controls.Add(this.l_accocountry);
            this.p_accomodations.Controls.Add(this.dgv_searchaccomodation);
            this.p_accomodations.Location = new System.Drawing.Point(168, 28);
            this.p_accomodations.Name = "p_accomodations";
            this.p_accomodations.Size = new System.Drawing.Size(741, 511);
            this.p_accomodations.TabIndex = 10;
            this.p_accomodations.Visible = false;
            // 
            // tb_accosearchname
            // 
            this.tb_accosearchname.Location = new System.Drawing.Point(460, 47);
            this.tb_accosearchname.Name = "tb_accosearchname";
            this.tb_accosearchname.Size = new System.Drawing.Size(158, 20);
            this.tb_accosearchname.TabIndex = 26;
            // 
            // cb_accosearchcity
            // 
            this.cb_accosearchcity.FormattingEnabled = true;
            this.cb_accosearchcity.Items.AddRange(new object[] {
            "Abu Dhabi",
            "Abuja",
            "Accra",
            "Adamstown",
            "Addis Ababa",
            "Algiers",
            "Alofi",
            "Amman",
            "Amsterdam",
            "Andorra la Vella",
            "Ankara",
            "Antananarivo",
            "Apia",
            "Ashgabat",
            "Asmara",
            "Astana",
            "Asunción",
            "Athens",
            "Avarua",
            "Baghdad",
            "Baku",
            "Bamako",
            "Bandar Seri Begawan",
            "Bangkok",
            "Bangui",
            "Banjul",
            "Basseterre",
            "Beijing",
            "Beirut",
            "Belfast",
            "Belgrade",
            "Belmopan",
            "Berlin",
            "Bern",
            "Bishkek",
            "Bissau",
            "Bogotá",
            "Brasília",
            "Bratislava",
            "Brazzaville",
            "Bridgetown",
            "Brussels",
            "Bucharest",
            "Budapest",
            "Buenos Aires",
            "Bujumbura",
            "Cairo",
            "Canberra",
            "Caracas",
            "Cardiff",
            "Castries",
            "Cayenne",
            "Charlotte Amalie",
            "Chisinau",
            "Cockburn Town",
            "Conakry",
            "Copenhagen",
            "Dakar",
            "Damascus",
            "Dhaka",
            "Dili",
            "Djibouti",
            "Dodoma",
            "Dar es Salaam",
            "Doha",
            "Douglas",
            "Dublin",
            "Dushanbe",
            "Edinburgh",
            "Edinburgh of the Seven Seas",
            "El Aaiún",
            "Episkopi Cantonment",
            "Flying Fish Cove",
            "Freetown",
            "Funafuti",
            "Gaborone",
            "George Town",
            "Georgetown",
            "Georgetown",
            "Gibraltar",
            "Grytviken",
            "Guatemala City",
            "Gustavia",
            "Hagåtña",
            "Hamilton",
            "Hanga Roa",
            "Hanoi",
            "Harare",
            "Hargeisa",
            "Havana",
            "Helsinki",
            "Honiara",
            "Islamabad",
            "Jakarta",
            "Jamestown",
            "Jerusalem",
            "Jerusalem",
            "Ramallah and Gaza",
            "Juba",
            "Kabul",
            "Kampala",
            "Kathmandu",
            "Khartoum",
            "Kiev",
            "Kigali",
            "Kingston",
            "Kingston",
            "Kingstown",
            "Kinshasa",
            "Kuala Lumpur",
            "Kuwait City",
            "Libreville",
            "Lilongwe",
            "Lima",
            "Lisbon",
            "Ljubljana",
            "Lomé",
            "London",
            "Luanda",
            "Lusaka",
            "Luxembourg",
            "Madrid",
            "Majuro",
            "Malabo",
            "Malé",
            "Managua",
            "Manama",
            "Manila",
            "Maputo",
            "Marigot",
            "Maseru",
            "Mata-Utu",
            "Mbabane",
            "Lobamba",
            "Melekeok",
            "Mexico City",
            "Minsk",
            "Mogadishu",
            "Monaco",
            "Monrovia",
            "Montevideo",
            "Moroni",
            "Moscow",
            "Muscat",
            "Nairobi",
            "Nassau",
            "Naypyidaw",
            "N\'Djamena",
            "New Delhi",
            "Niamey",
            "Nicosia",
            "Nicosia",
            "Nouakchott",
            "Nouméa",
            "Nukuʻalofa",
            "Nuuk",
            "Oranjestad",
            "Oslo",
            "Ottawa",
            "Ouagadougou",
            "Pago Pago",
            "Palikir",
            "Panama City",
            "Papeete",
            "Paramaribo",
            "Paris",
            "Philipsburg",
            "Phnom Penh",
            "Plymouth",
            "Brades Estate",
            "Podgorica",
            "Port Louis",
            "Port Moresby",
            "Port Vila",
            "Port-au-Prince",
            "Port of Spain",
            "Porto-Novo",
            "Cotonou",
            "Prague",
            "Praia",
            "Pretoria",
            "Bloemfontein",
            "Cape Town",
            "Pristina",
            "Pyongyang",
            "Quito",
            "Rabat",
            "Reykjavík",
            "Riga",
            "Riyadh",
            "Road Town",
            "Rome",
            "Roseau",
            "Saipan",
            "San José",
            "San Juan",
            "San Marino",
            "San Salvador",
            "Sanaá",
            "Santiago",
            "Santo Domingo",
            "São Tomé",
            "Sarajevo",
            "Seoul",
            "Singapore",
            "Skopje",
            "Sofia",
            "Sri Jayawardenapura-Kotte",
            "Colombo",
            "St. George\'s",
            "St. Helier",
            "St. John\'s",
            "St. Peter Port",
            "St. Pierre",
            "Stanley",
            "Stepanakert",
            "Stockholm",
            "Sucre",
            "La Paz",
            "Sukhumi",
            "Suva",
            "Taipei",
            "Tallinn",
            "Tarawa",
            "Tashkent",
            "Tbilisi",
            "Tegucigalpa",
            "Tehran",
            "Thimphu",
            "Tirana",
            "Tiraspol",
            "Tokyo",
            "Tórshavn",
            "Tripoli",
            "Tskhinvali",
            "Tunis",
            "Ulan Bator",
            "Vaduz",
            "Valletta",
            "The Valley",
            "Vatican City",
            "Victoria",
            "Vienna",
            "Vientiane",
            "Vilnius",
            "Warsaw",
            "Washington, D.C.",
            "Wellington",
            "West Island",
            "Willemstad",
            "Windhoek",
            "Yamoussoukro",
            "Abidjan",
            "Yaoundé",
            "Yaren",
            "Yerevan",
            "Zagreb"});
            this.cb_accosearchcity.Location = new System.Drawing.Point(257, 47);
            this.cb_accosearchcity.Name = "cb_accosearchcity";
            this.cb_accosearchcity.Size = new System.Drawing.Size(153, 21);
            this.cb_accosearchcity.TabIndex = 25;
            // 
            // cb_accosearchcountry
            // 
            this.cb_accosearchcountry.FormattingEnabled = true;
            this.cb_accosearchcountry.Items.AddRange(new object[] {
            " China",
            " India",
            " United States",
            " Indonesia",
            " Brazil",
            " Pakistan",
            " Nigeria",
            " Bangladesh",
            " Russia",
            " Japan",
            " Mexico",
            " Philippines",
            " Vietnam",
            " Ethiopia",
            " Egypt",
            " Germany",
            " Iran",
            " Turkey",
            " Democratic Republic of the Congo",
            " Thailand",
            " France",
            " United Kingdom",
            " Italy",
            " South Africa",
            " South Korea",
            " Myanmar",
            " Colombia",
            " Spain",
            " Ukraine",
            " Tanzania",
            " Argentina",
            " Kenya",
            " Poland",
            " Algeria",
            " Canada",
            " Uganda",
            " Iraq",
            " Morocco",
            " Sudan",
            " Peru",
            " Malaysia",
            " Uzbekistan",
            " Saudi Arabia",
            " Venezuela",
            " Nepal",
            " Afghanistan",
            " Ghana",
            " North Korea",
            " Yemen",
            " Mozambique",
            " Taiwan",
            " Australia",
            " Syria",
            " Ivory Coast",
            " Madagascar",
            " Angola",
            " Sri Lanka",
            " Cameroon",
            " Romania",
            " Kazakhstan",
            " Netherlands",
            " Chile",
            " Niger",
            " Malawi",
            " Burkina Faso",
            " Ecuador",
            " Guatemala",
            " Mali",
            " Cambodia",
            " Zambia",
            " Zimbabwe",
            " Senegal",
            " Chad",
            " Cuba",
            " Belgium",
            " Guinea",
            " Greece",
            " Tunisia",
            " Portugal",
            " Rwanda",
            " Czech Republic",
            " Bolivia",
            " Haiti",
            " Hungary",
            " Somalia",
            " Sweden",
            " Belarus",
            " Dominican Republic",
            " Benin",
            " Azerbaijan",
            " Burundi",
            " Austria",
            " Honduras",
            " United Arab Emirates",
            " South Sudan",
            " Switzerland",
            " Israel",
            " Tajikistan",
            " Bulgaria",
            " Serbia",
            " Hong Kong (China)",
            " Papua New Guinea",
            " Libya",
            " Laos",
            " Paraguay",
            " Jordan",
            " Togo",
            " El Salvador",
            " Sierra Leone",
            " Nicaragua",
            " Denmark",
            " Eritrea",
            " Kyrgyzstan",
            " Finland",
            " Slovakia",
            " Singapore",
            " Turkmenistan",
            " Norway",
            " Ireland",
            " Central African Republic",
            " Georgia",
            " New Zealand",
            " Costa Rica",
            " Palestinian territories",
            " Lebanon",
            " Croatia",
            " Liberia",
            " Republic of the Congo",
            " Bosnia and Herzegovina",
            " Puerto Rico (USA)",
            " Oman",
            " Kuwait",
            " Moldova",
            " Panama",
            " Mauritania",
            " Uruguay",
            " Armenia",
            " Lithuania",
            " Albania",
            " Mongolia",
            " Jamaica",
            " Lesotho",
            " Namibia",
            " Macedonia",
            " Slovenia",
            " Latvia",
            " Botswana",
            " Qatar",
            " Gambia",
            " Kosovo",
            " Gabon",
            " Guinea-Bissau",
            " Trinidad and Tobago",
            " Estonia",
            " Mauritius",
            " Bahrain",
            " Swaziland",
            " Timor-Leste",
            " Fiji",
            " Cyprus",
            " Réunion (France)",
            " Djibouti",
            " Guyana",
            " Equatorial Guinea",
            " Comoros",
            " Bhutan",
            " Montenegro",
            " Macau (China)",
            " Western Sahara (Morocco)",
            " Transnistria",
            " Solomon Islands",
            " Suriname",
            " Luxembourg",
            " Cape Verde",
            " Malta",
            " Guadeloupe (France)",
            " Martinique (France)",
            " Brunei",
            " Bahamas",
            " Iceland",
            " Maldives",
            " Belize",
            " Northern Cyprus",
            " Barbados",
            " French Polynesia (France)",
            " Vanuatu",
            " New Caledonia (France)",
            " Abkhazia",
            " French Guiana (France)",
            " Mayotte (France)",
            " Samoa",
            " São Tomé and Príncipe",
            " Saint Lucia",
            " Guam (USA)",
            " Curaçao (Netherlands)",
            " Nagorno-Karabakh",
            " United States Virgin Islands (USA)",
            " Kiribati",
            " Tonga",
            " Grenada",
            " Federated States of Micronesia",
            " Aruba (Netherlands)",
            " Saint Vincent and the Grenadines",
            " Jersey (UK)",
            " Seychelles",
            " Antigua and Barbuda",
            " Isle of Man (UK)",
            " Andorra",
            " Dominica",
            " Bermuda (UK)",
            " Guernsey (UK)",
            " Greenland (Denmark)",
            " Marshall Islands",
            " American Samoa (USA)",
            " Cayman Islands (UK)",
            " South Ossetia",
            " Northern Mariana Islands (USA)",
            " Saint Kitts and Nevis",
            " Faroe Islands (Denmark)",
            " Sint Maarten (Netherlands)",
            " Saint Martin (France)",
            " Liechtenstein",
            " Monaco",
            " San Marino",
            " Turks and Caicos Islands (UK)",
            " Gibraltar (UK)",
            " British Virgin Islands (UK)",
            " Åland Islands (Finland)",
            " Caribbean Netherlands (Netherlands)",
            " Palau",
            " Cook Islands (NZ)",
            " Anguilla (UK)",
            " Wallis and Futuna (France)",
            " Tuvalu",
            " Nauru",
            " Saint Barthélemy (France)",
            " Saint Pierre and Miquelon (France)",
            " Montserrat (UK)",
            " Saint Helena, Ascension and Tristan da Cunha (UK)",
            " Falkland Islands (UK)[20]",
            " Svalbard and Jan Mayen (Norway)",
            " Norfolk Island (Australia)",
            " Christmas Island (Australia)",
            " Niue (NZ)",
            " Tokelau (NZ)",
            " Vatican City",
            " Cocos (Keeling) Islands (Australia)",
            " Pitcairn Islands (UK)"});
            this.cb_accosearchcountry.Location = new System.Drawing.Point(65, 46);
            this.cb_accosearchcountry.Name = "cb_accosearchcountry";
            this.cb_accosearchcountry.Size = new System.Drawing.Size(153, 21);
            this.cb_accosearchcountry.TabIndex = 24;
            // 
            // l_accosearchname
            // 
            this.l_accosearchname.AutoSize = true;
            this.l_accosearchname.Location = new System.Drawing.Point(416, 50);
            this.l_accosearchname.Name = "l_accosearchname";
            this.l_accosearchname.Size = new System.Drawing.Size(38, 13);
            this.l_accosearchname.TabIndex = 23;
            this.l_accosearchname.Text = "Name:";
            // 
            // l_accosearchcity
            // 
            this.l_accosearchcity.AutoSize = true;
            this.l_accosearchcity.Location = new System.Drawing.Point(224, 50);
            this.l_accosearchcity.Name = "l_accosearchcity";
            this.l_accosearchcity.Size = new System.Drawing.Size(27, 13);
            this.l_accosearchcity.TabIndex = 22;
            this.l_accosearchcity.Text = "City:";
            // 
            // b_selectaccomodation
            // 
            this.b_selectaccomodation.Location = new System.Drawing.Point(605, 484);
            this.b_selectaccomodation.Name = "b_selectaccomodation";
            this.b_selectaccomodation.Size = new System.Drawing.Size(121, 23);
            this.b_selectaccomodation.TabIndex = 20;
            this.b_selectaccomodation.Text = "Select Accomodation";
            this.b_selectaccomodation.UseVisualStyleBackColor = true;
            this.b_selectaccomodation.Click += new System.EventHandler(this.b_selectaccomodation_Click);
            // 
            // b_accosearch
            // 
            this.b_accosearch.Location = new System.Drawing.Point(651, 44);
            this.b_accosearch.Name = "b_accosearch";
            this.b_accosearch.Size = new System.Drawing.Size(75, 23);
            this.b_accosearch.TabIndex = 18;
            this.b_accosearch.Text = "Search";
            this.b_accosearch.UseVisualStyleBackColor = true;
            this.b_accosearch.Click += new System.EventHandler(this.b_accosearch_Click);
            // 
            // l_accocountry
            // 
            this.l_accocountry.AutoSize = true;
            this.l_accocountry.Location = new System.Drawing.Point(13, 50);
            this.l_accocountry.Name = "l_accocountry";
            this.l_accocountry.Size = new System.Drawing.Size(46, 13);
            this.l_accocountry.TabIndex = 16;
            this.l_accocountry.Text = "Country:";
            // 
            // dgv_searchaccomodation
            // 
            this.dgv_searchaccomodation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchaccomodation.Location = new System.Drawing.Point(16, 73);
            this.dgv_searchaccomodation.Name = "dgv_searchaccomodation";
            this.dgv_searchaccomodation.Size = new System.Drawing.Size(710, 405);
            this.dgv_searchaccomodation.TabIndex = 15;
            // 
            // b_addcustomer
            // 
            this.b_addcustomer.Location = new System.Drawing.Point(525, 481);
            this.b_addcustomer.Name = "b_addcustomer";
            this.b_addcustomer.Size = new System.Drawing.Size(98, 23);
            this.b_addcustomer.TabIndex = 14;
            this.b_addcustomer.Text = "Add Customer";
            this.b_addcustomer.UseVisualStyleBackColor = true;
            this.b_addcustomer.Click += new System.EventHandler(this.b_addcustomer_Click);
            // 
            // b_selectcustomer
            // 
            this.b_selectcustomer.Location = new System.Drawing.Point(629, 481);
            this.b_selectcustomer.Name = "b_selectcustomer";
            this.b_selectcustomer.Size = new System.Drawing.Size(98, 23);
            this.b_selectcustomer.TabIndex = 13;
            this.b_selectcustomer.Text = "Select Customer";
            this.b_selectcustomer.UseVisualStyleBackColor = true;
            this.b_selectcustomer.Click += new System.EventHandler(this.b_selectcustomer_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(249, 45);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 23);
            this.b_search.TabIndex = 8;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(72, 47);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(171, 20);
            this.tb_surname.TabIndex = 7;
            // 
            // l_surname
            // 
            this.l_surname.AutoSize = true;
            this.l_surname.Location = new System.Drawing.Point(14, 50);
            this.l_surname.Name = "l_surname";
            this.l_surname.Size = new System.Drawing.Size(52, 13);
            this.l_surname.TabIndex = 6;
            this.l_surname.Text = "Surname:";
            // 
            // dg_customer
            // 
            this.dg_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_customer.Location = new System.Drawing.Point(17, 73);
            this.dg_customer.Name = "dg_customer";
            this.dg_customer.Size = new System.Drawing.Size(710, 402);
            this.dg_customer.TabIndex = 5;
            // 
            // p_accomodationinfo
            // 
            this.p_accomodationinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_accomodationinfo.Controls.Add(this.b_bookingDetails);
            this.p_accomodationinfo.Controls.Add(this.ll_showaccoinfoback);
            this.p_accomodationinfo.Controls.Add(this.l_hotelname);
            this.p_accomodationinfo.Controls.Add(this.pb_hotel);
            this.p_accomodationinfo.Controls.Add(this.rtb_address);
            this.p_accomodationinfo.Controls.Add(this.rtb_description);
            this.p_accomodationinfo.Location = new System.Drawing.Point(168, 28);
            this.p_accomodationinfo.Name = "p_accomodationinfo";
            this.p_accomodationinfo.Size = new System.Drawing.Size(741, 511);
            this.p_accomodationinfo.TabIndex = 27;
            this.p_accomodationinfo.Visible = false;
            // 
            // ll_accosearchback
            // 
            this.ll_accosearchback.AutoSize = true;
            this.ll_accosearchback.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_accosearchback.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_accosearchback.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ll_accosearchback.Location = new System.Drawing.Point(10, 4);
            this.ll_accosearchback.Name = "ll_accosearchback";
            this.ll_accosearchback.Size = new System.Drawing.Size(38, 39);
            this.ll_accosearchback.TabIndex = 28;
            this.ll_accosearchback.TabStop = true;
            this.ll_accosearchback.Text = "<";
            // 
            // ll_showaccoinfoback
            // 
            this.ll_showaccoinfoback.AutoSize = true;
            this.ll_showaccoinfoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_showaccoinfoback.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ll_showaccoinfoback.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ll_showaccoinfoback.Location = new System.Drawing.Point(15, 4);
            this.ll_showaccoinfoback.Name = "ll_showaccoinfoback";
            this.ll_showaccoinfoback.Size = new System.Drawing.Size(38, 39);
            this.ll_showaccoinfoback.TabIndex = 29;
            this.ll_showaccoinfoback.TabStop = true;
            this.ll_showaccoinfoback.Text = "<";
            // 
            // b_bookingDetails
            // 
            this.b_bookingDetails.Location = new System.Drawing.Point(627, 481);
            this.b_bookingDetails.Name = "b_bookingDetails";
            this.b_bookingDetails.Size = new System.Drawing.Size(99, 23);
            this.b_bookingDetails.TabIndex = 35;
            this.b_bookingDetails.Text = "Booking Details";
            this.b_bookingDetails.UseVisualStyleBackColor = true;
            // 
            // rtb_description
            // 
            this.rtb_description.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_description.Location = new System.Drawing.Point(16, 269);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.ReadOnly = true;
            this.rtb_description.Size = new System.Drawing.Size(710, 209);
            this.rtb_description.TabIndex = 33;
            this.rtb_description.Text = "";
            // 
            // rtb_address
            // 
            this.rtb_address.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_address.Location = new System.Drawing.Point(16, 83);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.ReadOnly = true;
            this.rtb_address.Size = new System.Drawing.Size(483, 180);
            this.rtb_address.TabIndex = 32;
            this.rtb_address.Text = "";
            // 
            // l_hotelname
            // 
            this.l_hotelname.AutoSize = true;
            this.l_hotelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_hotelname.Location = new System.Drawing.Point(11, 47);
            this.l_hotelname.Name = "l_hotelname";
            this.l_hotelname.Size = new System.Drawing.Size(149, 29);
            this.l_hotelname.TabIndex = 31;
            this.l_hotelname.Text = "hotel_name";
            // 
            // pb_hotel
            // 
            this.pb_hotel.Location = new System.Drawing.Point(505, 83);
            this.pb_hotel.Name = "pb_hotel";
            this.pb_hotel.Size = new System.Drawing.Size(221, 180);
            this.pb_hotel.TabIndex = 30;
            this.pb_hotel.TabStop = false;
            // 
            // p_bookingdetails
            // 
            this.p_bookingdetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_bookingdetails.Controls.Add(this.linkLabel1);
            this.p_bookingdetails.Controls.Add(this.dgv_bookings);
            this.p_bookingdetails.Controls.Add(this.b_bookselected);
            this.p_bookingdetails.Controls.Add(this.gB_pickadate);
            this.p_bookingdetails.Controls.Add(this.l_hotelName_bd);
            this.p_bookingdetails.Location = new System.Drawing.Point(168, 28);
            this.p_bookingdetails.Name = "p_bookingdetails";
            this.p_bookingdetails.Size = new System.Drawing.Size(742, 511);
            this.p_bookingdetails.TabIndex = 36;
            this.p_bookingdetails.Visible = false;
            // 
            // dgv_bookings
            // 
            this.dgv_bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookings.Location = new System.Drawing.Point(16, 150);
            this.dgv_bookings.Name = "dgv_bookings";
            this.dgv_bookings.Size = new System.Drawing.Size(711, 329);
            this.dgv_bookings.TabIndex = 14;
            // 
            // b_bookselected
            // 
            this.b_bookselected.Location = new System.Drawing.Point(641, 485);
            this.b_bookselected.Name = "b_bookselected";
            this.b_bookselected.Size = new System.Drawing.Size(86, 23);
            this.b_bookselected.TabIndex = 12;
            this.b_bookselected.Text = "Book Selected";
            this.b_bookselected.UseVisualStyleBackColor = true;
            this.b_bookselected.Click += new System.EventHandler(this.b_bookselected_Click);
            // 
            // gB_pickadate
            // 
            this.gB_pickadate.Controls.Add(this.l_startDate);
            this.gB_pickadate.Controls.Add(this.l_endDate);
            this.gB_pickadate.Controls.Add(this.dTP_startDate);
            this.gB_pickadate.Controls.Add(this.dTP_endDate);
            this.gB_pickadate.Location = new System.Drawing.Point(16, 79);
            this.gB_pickadate.Name = "gB_pickadate";
            this.gB_pickadate.Size = new System.Drawing.Size(406, 65);
            this.gB_pickadate.TabIndex = 11;
            this.gB_pickadate.TabStop = false;
            this.gB_pickadate.Text = "Pick a Date";
            // 
            // l_startDate
            // 
            this.l_startDate.AutoSize = true;
            this.l_startDate.Location = new System.Drawing.Point(6, 16);
            this.l_startDate.Name = "l_startDate";
            this.l_startDate.Size = new System.Drawing.Size(55, 13);
            this.l_startDate.TabIndex = 3;
            this.l_startDate.Text = "Start Date";
            // 
            // l_endDate
            // 
            this.l_endDate.AutoSize = true;
            this.l_endDate.Location = new System.Drawing.Point(207, 16);
            this.l_endDate.Name = "l_endDate";
            this.l_endDate.Size = new System.Drawing.Size(52, 13);
            this.l_endDate.TabIndex = 4;
            this.l_endDate.Text = "End Date";
            // 
            // dTP_startDate
            // 
            this.dTP_startDate.Location = new System.Drawing.Point(6, 32);
            this.dTP_startDate.Name = "dTP_startDate";
            this.dTP_startDate.Size = new System.Drawing.Size(189, 20);
            this.dTP_startDate.TabIndex = 0;
            this.dTP_startDate.ValueChanged += new System.EventHandler(this.dTP_startDate_ValueChanged);
            // 
            // dTP_endDate
            // 
            this.dTP_endDate.Location = new System.Drawing.Point(210, 32);
            this.dTP_endDate.MinDate = new System.DateTime(2013, 1, 10, 0, 0, 0, 0);
            this.dTP_endDate.Name = "dTP_endDate";
            this.dTP_endDate.Size = new System.Drawing.Size(190, 20);
            this.dTP_endDate.TabIndex = 1;
            this.dTP_endDate.ValueChanged += new System.EventHandler(this.dTP_endDate_ValueChanged);
            // 
            // l_hotelName_bd
            // 
            this.l_hotelName_bd.AutoSize = true;
            this.l_hotelName_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_hotelName_bd.Location = new System.Drawing.Point(12, 50);
            this.l_hotelName_bd.Name = "l_hotelName_bd";
            this.l_hotelName_bd.Size = new System.Drawing.Size(134, 25);
            this.l_hotelName_bd.TabIndex = 10;
            this.l_hotelName_bd.Text = "hotel_name";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(10, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 39);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 551);
            this.Controls.Add(this.showCustomerButton);
            this.Controls.Add(this.bookingButton);
            this.Controls.Add(this.accInfoButton);
            this.Controls.Add(this.Add_customer_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.p_bookingdetails);
            this.Controls.Add(this.p_accomodationinfo);
            this.Controls.Add(this.p_showcustomer);
            this.Controls.Add(this.p_accomodations);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p_showcustomer.ResumeLayout(false);
            this.p_showcustomer.PerformLayout();
            this.p_accomodations.ResumeLayout(false);
            this.p_accomodations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchaccomodation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_customer)).EndInit();
            this.p_accomodationinfo.ResumeLayout(false);
            this.p_accomodationinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).EndInit();
            this.p_bookingdetails.ResumeLayout(false);
            this.p_bookingdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).EndInit();
            this.gB_pickadate.ResumeLayout(false);
            this.gB_pickadate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_customer_button;
        private System.Windows.Forms.Button accInfoButton;
        private System.Windows.Forms.Button bookingButton;
        private System.Windows.Forms.Button showCustomerButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel p_showcustomer;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label l_surname;
        private System.Windows.Forms.DataGridView dg_customer;
        private System.Windows.Forms.Panel p_accomodations;
        private System.Windows.Forms.Button b_addcustomer;
        private System.Windows.Forms.Button b_selectcustomer;
        private System.Windows.Forms.Label l_accosearchname;
        private System.Windows.Forms.Label l_accosearchcity;
        private System.Windows.Forms.Button b_selectaccomodation;
        private System.Windows.Forms.Button b_accosearch;
        private System.Windows.Forms.Label l_accocountry;
        private System.Windows.Forms.DataGridView dgv_searchaccomodation;
        private System.Windows.Forms.TextBox tb_accosearchname;
        private System.Windows.Forms.ComboBox cb_accosearchcity;
        private System.Windows.Forms.ComboBox cb_accosearchcountry;
        private System.Windows.Forms.LinkLabel ll_accosearchback;
        private System.Windows.Forms.Panel p_accomodationinfo;
        private System.Windows.Forms.LinkLabel ll_showaccoinfoback;
        private System.Windows.Forms.Button b_bookingDetails;
        private System.Windows.Forms.Label l_hotelname;
        private System.Windows.Forms.PictureBox pb_hotel;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.Panel p_bookingdetails;
        private System.Windows.Forms.DataGridView dgv_bookings;
        private System.Windows.Forms.Button b_bookselected;
        private System.Windows.Forms.GroupBox gB_pickadate;
        private System.Windows.Forms.Label l_startDate;
        private System.Windows.Forms.Label l_endDate;
        private System.Windows.Forms.DateTimePicker dTP_startDate;
        private System.Windows.Forms.DateTimePicker dTP_endDate;
        private System.Windows.Forms.Label l_hotelName_bd;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}