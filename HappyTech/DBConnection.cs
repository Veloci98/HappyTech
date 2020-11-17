using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    class DBConnection
    {
        //private object of the class itself
        private static DBConnection _instance;

        //connection string
        private string connStr;

        //connection to the DB
        private SqlConnection connToDB;

        /// <summary>
        /// Constructor
        /// </summary>
        private DBConnection()
        {
            connStr = Properties.Settings.Default.CandidateFeedbackConnectionString;
        }
        /// <summary>
        /// A static method that creates a unique object of the class itself
        /// </summary>
        /// <returns></returns>
        public static DBConnection getInstanceOfDBConnection()
        {
            // create the object only if the method is called
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        /// <summary>
        /// Returns a data set built based on the query sent as parameter
        /// </summary>
        public DataSet getDataSet(string sqlQuery)
        {
            //create an empty dataset
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                //open the connection
                connToDB.Open();

                //create the object dataAdapter to send a query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                dataAdapter.Fill(dataSet);
            }
            return dataSet;
        }

        /// <summary>
        /// Method that saves data into the database
        /// </summary>
        public void saveToDB(string sqlQuery, string firstname, string surname, string email, string contactNo, string dateOfBirth, string houseNoName, string streetName, string cityName, string county, string postcode, string country, string passportNo)
        {
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                //Open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sqlCommand
                sqlCommand.Parameters.Add(new SqlParameter("Firstname", firstname));
                sqlCommand.Parameters.Add(new SqlParameter("Surname", surname));
                sqlCommand.Parameters.Add(new SqlParameter("Email", email));
                sqlCommand.Parameters.Add(new SqlParameter("Contact_Number", contactNo));
                sqlCommand.Parameters.Add(new SqlParameter("Date_of_Birth", dateOfBirth));
                sqlCommand.Parameters.Add(new SqlParameter("House_Number_Name", houseNoName));
                sqlCommand.Parameters.Add(new SqlParameter("Street_Name", streetName));
                sqlCommand.Parameters.Add(new SqlParameter("City_Name", cityName));
                sqlCommand.Parameters.Add(new SqlParameter("County", county));
                sqlCommand.Parameters.Add(new SqlParameter("Postcode", postcode));
                sqlCommand.Parameters.Add(new SqlParameter("Country", country));
                sqlCommand.Parameters.Add(new SqlParameter("Passport_Number", passportNo));

                //Execute the command
                sqlCommand.ExecuteNonQuery();

                connToDB.Close();
            }

        }

    }

    
}
