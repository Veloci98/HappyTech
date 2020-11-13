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
    public partial class ViewAllCandidatesUserControl : UserControl
    {
        public ViewAllCandidatesUserControl()
        {
            InitializeComponent();
        }

        private void ViewAllCandidatesUserControl_Load(object sender, EventArgs e)
        {
            //Display the data from table Candidate into the DataGridView
            //Get the dataset from the DB and assign it to the dataGridView's DataSource
            //candidateDataGridView.Datasource = ....
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM Candidate");
            candidateDataGridView.DataSource = ds.Tables[0];

        }
    }
}
