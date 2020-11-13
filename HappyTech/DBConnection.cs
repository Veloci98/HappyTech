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

    }

    
}
