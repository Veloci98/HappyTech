using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class Constants
    {
        //SQL queries
        public static string ViewAllCandidates = "SELECT * FROM Candidate";
        public static string InsertCandidate = 
            "INSERT INTO Candidate " +
            "(Firstname, " +
            "Surname, " +
            "Email, " +
            "Contact_Number, " +
            "Date_of_Birth, " +
            "House_Number_Name, " +
            "Street_Name, " +
            "City_Name, " +
            "County, " +
            "Postcode, " +
            "Country, " +
            "Passport_Number) " +

            "VALUES " +
            "(@Firstname, " +
            "@Surname, " +
            "@Email, " +
            "@Contact_Number, " +
            "@Date_of_Birth, " +
            "@House_Number_Name, " +
            "@Street_Name, " +
            "@City_Name, " +
            "@County, " +
            "@Postcode, " +
            "@Country, " +
            "@Passport_Number)";
    }
}
