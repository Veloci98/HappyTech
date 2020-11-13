using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class FeedbackApplicationForm : Form
    {
        public FeedbackApplicationForm()
        {
            InitializeComponent();
            hideAllUserControls();
            dashboardUserControl1.Show();
        }

        private void FeedbackApplicationForm_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Runs the clock and date labels in the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeDateTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeDateTimer.Start();
        }

        // NAVIGATION PANEL CONTROLS =========================================================
        private void hideAllUserControls()
        {
            dashboardUserControl1.Hide();
            addEditCandidateUserControl1.Hide();
            viewAllCandidatesUserControl1.Hide();
            editTemplatesUserControl1.Hide();
            sendAllFeedbackUserControl1.Hide();
        }

        private void dashboardNavButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            dashboardUserControl1.Show();
        }

        private void addEditCandidateNavButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            addEditCandidateUserControl1.Show();
        }

        private void viewAllCandidatesNavButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            viewAllCandidatesUserControl1.Show();
        }

        private void editTemplatesNavButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            editTemplatesUserControl1.Show();
        }

        private void sendAllFeedbackNavButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            sendAllFeedbackUserControl1.Show();
        }

        private void exitNavButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
