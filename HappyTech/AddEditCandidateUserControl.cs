using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class ucAddEditCandidate : UserControl
    {
        public ucAddEditCandidate()
        {
            InitializeComponent();
        }


        private void saveCandidateButton_Click(object sender, EventArgs e)
        {
            // get the values from the text boxes

            string Firstname = tbFirstname.Text;
            string Surname = tbSurname.Text;
            string Email = tbEmail.Text;
            string Contact_Number = tbContact_Number.Text;
            string Date_of_Birth = tbDate_of_Birth.Text;
            string House_Number = tbHouse_Number_Name.Text;
            string Street_Name = tbStreet_Name.Text;
            string City_Name = tbCity_Name.Text;
            string County = tbCounty.Text;
            string Postcode = tbPostcode.Text;
            string Country = tbCountry.Text;
            string Passport_Number = tbPassport_Number.Text;

            //if ((Firstname != "") || (Surname != "") || (Email != "") || (Contact_Number != "") || (Date_of_Birth != "") || (House_Number != "") || (Street_Name != "") || (City_Name != "") || (County != "") || (Postcode != "") || (Country != "") || (Passport_Number != ""))
            //{
                
            //}

            if ((Firstname == "") || (Surname == "") || (Email == "") || (Contact_Number == "") ||
                (Date_of_Birth == "") || (House_Number == "") || (Street_Name == "") || (City_Name == "") ||
                (County == "") || (Postcode == "") || (Country == "") || (Passport_Number == ""))
            {
                MessageBox.Show("Please fill in all the fields before saving!", "Oops, something went wrong!");
            }
            else
            {
                DBConnection.getInstanceOfDBConnection().saveToDB(Constants.InsertCandidate, Firstname, Surname, Email,
                    Contact_Number, Date_of_Birth, House_Number, Street_Name, City_Name, County, Postcode, Country,
                    Passport_Number);
            }

        }

        private void newCandidateButton_Click(object sender, EventArgs e)
        {
            tbFirstname.Clear();
            tbSurname.Clear();
            tbEmail.Clear();
            tbContact_Number.Clear();
            tbDate_of_Birth.Clear();
            tbHouse_Number_Name.Clear();
            tbStreet_Name.Clear();
            tbCity_Name.Clear();
            tbCounty.Clear();
            tbPostcode.Clear();
            tbCountry.Clear();
            tbPassport_Number.Clear();
        }
    }
}
