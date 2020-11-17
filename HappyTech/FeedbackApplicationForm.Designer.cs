namespace HappyTech
{
    partial class FeedbackApplicationForm
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
            this.components = new System.ComponentModel.Container();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.exitNavButton = new System.Windows.Forms.Button();
            this.navigationButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.sendAllFeedbackNavButton = new System.Windows.Forms.Button();
            this.editTemplatesNavButton = new System.Windows.Forms.Button();
            this.viewAllCandidatesNavButton = new System.Windows.Forms.Button();
            this.addEditCandidateNavButton = new System.Windows.Forms.Button();
            this.dashboardNavButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeDateTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeDateTimer = new System.Windows.Forms.Timer(this.components);
            this.dashboardUserControl1 = new HappyTech.DashboardUserControl();
            this.addEditCandidateUserControl1 = new HappyTech.ucAddEditCandidate();
            this.viewAllCandidatesUserControl1 = new HappyTech.ViewAllCandidatesUserControl();
            this.editTemplatesUserControl1 = new HappyTech.EditTemplatesUserControl();
            this.sendAllFeedbackUserControl1 = new HappyTech.SendAllFeedbackUserControl();
            this.navigationPanel.SuspendLayout();
            this.navigationButtonTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.timeDateTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.navigationPanel.Controls.Add(this.exitNavButton);
            this.navigationPanel.Controls.Add(this.navigationButtonTable);
            this.navigationPanel.Controls.Add(this.pictureBox1);
            this.navigationPanel.Controls.Add(this.timeDateTable);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 561);
            this.navigationPanel.TabIndex = 0;
            // 
            // exitNavButton
            // 
            this.exitNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitNavButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitNavButton.ForeColor = System.Drawing.Color.White;
            this.exitNavButton.Location = new System.Drawing.Point(-4, 518);
            this.exitNavButton.Name = "exitNavButton";
            this.exitNavButton.Size = new System.Drawing.Size(210, 44);
            this.exitNavButton.TabIndex = 3;
            this.exitNavButton.Text = "Exit";
            this.exitNavButton.UseVisualStyleBackColor = true;
            this.exitNavButton.Click += new System.EventHandler(this.exitNavButton_Click);
            // 
            // navigationButtonTable
            // 
            this.navigationButtonTable.ColumnCount = 1;
            this.navigationButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationButtonTable.Controls.Add(this.sendAllFeedbackNavButton, 0, 4);
            this.navigationButtonTable.Controls.Add(this.editTemplatesNavButton, 0, 3);
            this.navigationButtonTable.Controls.Add(this.viewAllCandidatesNavButton, 0, 2);
            this.navigationButtonTable.Controls.Add(this.addEditCandidateNavButton, 0, 1);
            this.navigationButtonTable.Controls.Add(this.dashboardNavButton, 0, 0);
            this.navigationButtonTable.Location = new System.Drawing.Point(-4, 147);
            this.navigationButtonTable.Name = "navigationButtonTable";
            this.navigationButtonTable.RowCount = 5;
            this.navigationButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.navigationButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.navigationButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.navigationButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.navigationButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.navigationButtonTable.Size = new System.Drawing.Size(210, 259);
            this.navigationButtonTable.TabIndex = 2;
            // 
            // sendAllFeedbackNavButton
            // 
            this.sendAllFeedbackNavButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendAllFeedbackNavButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendAllFeedbackNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sendAllFeedbackNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendAllFeedbackNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendAllFeedbackNavButton.ForeColor = System.Drawing.Color.White;
            this.sendAllFeedbackNavButton.Location = new System.Drawing.Point(3, 207);
            this.sendAllFeedbackNavButton.Name = "sendAllFeedbackNavButton";
            this.sendAllFeedbackNavButton.Size = new System.Drawing.Size(204, 49);
            this.sendAllFeedbackNavButton.TabIndex = 4;
            this.sendAllFeedbackNavButton.Text = "Send All Feedback";
            this.sendAllFeedbackNavButton.UseVisualStyleBackColor = true;
            this.sendAllFeedbackNavButton.Click += new System.EventHandler(this.sendAllFeedbackNavButton_Click);
            // 
            // editTemplatesNavButton
            // 
            this.editTemplatesNavButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editTemplatesNavButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editTemplatesNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editTemplatesNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTemplatesNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTemplatesNavButton.ForeColor = System.Drawing.Color.White;
            this.editTemplatesNavButton.Location = new System.Drawing.Point(3, 156);
            this.editTemplatesNavButton.Name = "editTemplatesNavButton";
            this.editTemplatesNavButton.Size = new System.Drawing.Size(204, 45);
            this.editTemplatesNavButton.TabIndex = 3;
            this.editTemplatesNavButton.Text = "Edit Templates";
            this.editTemplatesNavButton.UseVisualStyleBackColor = true;
            this.editTemplatesNavButton.Click += new System.EventHandler(this.editTemplatesNavButton_Click);
            // 
            // viewAllCandidatesNavButton
            // 
            this.viewAllCandidatesNavButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllCandidatesNavButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewAllCandidatesNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewAllCandidatesNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllCandidatesNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllCandidatesNavButton.ForeColor = System.Drawing.Color.White;
            this.viewAllCandidatesNavButton.Location = new System.Drawing.Point(3, 105);
            this.viewAllCandidatesNavButton.Name = "viewAllCandidatesNavButton";
            this.viewAllCandidatesNavButton.Size = new System.Drawing.Size(204, 45);
            this.viewAllCandidatesNavButton.TabIndex = 2;
            this.viewAllCandidatesNavButton.Text = "View All Candidates";
            this.viewAllCandidatesNavButton.UseVisualStyleBackColor = true;
            this.viewAllCandidatesNavButton.Click += new System.EventHandler(this.viewAllCandidatesNavButton_Click);
            // 
            // addEditCandidateNavButton
            // 
            this.addEditCandidateNavButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEditCandidateNavButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addEditCandidateNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addEditCandidateNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditCandidateNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditCandidateNavButton.ForeColor = System.Drawing.Color.White;
            this.addEditCandidateNavButton.Location = new System.Drawing.Point(3, 54);
            this.addEditCandidateNavButton.Name = "addEditCandidateNavButton";
            this.addEditCandidateNavButton.Size = new System.Drawing.Size(204, 45);
            this.addEditCandidateNavButton.TabIndex = 1;
            this.addEditCandidateNavButton.Text = "Add / Edit Candidate";
            this.addEditCandidateNavButton.UseVisualStyleBackColor = true;
            this.addEditCandidateNavButton.Click += new System.EventHandler(this.addEditCandidateNavButton_Click);
            // 
            // dashboardNavButton
            // 
            this.dashboardNavButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardNavButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashboardNavButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dashboardNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardNavButton.ForeColor = System.Drawing.Color.White;
            this.dashboardNavButton.Location = new System.Drawing.Point(3, 3);
            this.dashboardNavButton.Name = "dashboardNavButton";
            this.dashboardNavButton.Size = new System.Drawing.Size(204, 45);
            this.dashboardNavButton.TabIndex = 0;
            this.dashboardNavButton.Text = "Dashboard";
            this.dashboardNavButton.UseVisualStyleBackColor = true;
            this.dashboardNavButton.Click += new System.EventHandler(this.dashboardNavButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyTech.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timeDateTable
            // 
            this.timeDateTable.ColumnCount = 1;
            this.timeDateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeDateTable.Controls.Add(this.dateLabel, 0, 1);
            this.timeDateTable.Controls.Add(this.timeLabel, 0, 0);
            this.timeDateTable.Location = new System.Drawing.Point(0, 4);
            this.timeDateTable.Name = "timeDateTable";
            this.timeDateTable.RowCount = 2;
            this.timeDateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeDateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeDateTable.Size = new System.Drawing.Size(203, 48);
            this.timeDateTable.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(3, 24);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(197, 24);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(3, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(197, 24);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeDateTimer
            // 
            this.timeDateTimer.Enabled = true;
            this.timeDateTimer.Tick += new System.EventHandler(this.timeDateTimer_Tick);
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.BackColor = System.Drawing.Color.White;
            this.dashboardUserControl1.Location = new System.Drawing.Point(199, 0);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(985, 561);
            this.dashboardUserControl1.TabIndex = 1;
            // 
            // addEditCandidateUserControl1
            // 
            this.addEditCandidateUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEditCandidateUserControl1.BackColor = System.Drawing.Color.White;
            this.addEditCandidateUserControl1.Location = new System.Drawing.Point(199, 0);
            this.addEditCandidateUserControl1.Name = "addEditCandidateUserControl1";
            this.addEditCandidateUserControl1.Size = new System.Drawing.Size(985, 561);
            this.addEditCandidateUserControl1.TabIndex = 2;
            // 
            // viewAllCandidatesUserControl1
            // 
            this.viewAllCandidatesUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAllCandidatesUserControl1.Location = new System.Drawing.Point(199, 0);
            this.viewAllCandidatesUserControl1.Name = "viewAllCandidatesUserControl1";
            this.viewAllCandidatesUserControl1.Size = new System.Drawing.Size(985, 561);
            this.viewAllCandidatesUserControl1.TabIndex = 3;
            // 
            // editTemplatesUserControl1
            // 
            this.editTemplatesUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTemplatesUserControl1.Location = new System.Drawing.Point(199, 0);
            this.editTemplatesUserControl1.Name = "editTemplatesUserControl1";
            this.editTemplatesUserControl1.Size = new System.Drawing.Size(985, 561);
            this.editTemplatesUserControl1.TabIndex = 4;
            // 
            // sendAllFeedbackUserControl1
            // 
            this.sendAllFeedbackUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendAllFeedbackUserControl1.Location = new System.Drawing.Point(199, 0);
            this.sendAllFeedbackUserControl1.Name = "sendAllFeedbackUserControl1";
            this.sendAllFeedbackUserControl1.Size = new System.Drawing.Size(985, 561);
            this.sendAllFeedbackUserControl1.TabIndex = 5;
            // 
            // FeedbackApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.sendAllFeedbackUserControl1);
            this.Controls.Add(this.editTemplatesUserControl1);
            this.Controls.Add(this.viewAllCandidatesUserControl1);
            this.Controls.Add(this.addEditCandidateUserControl1);
            this.Controls.Add(this.dashboardUserControl1);
            this.Controls.Add(this.navigationPanel);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FeedbackApplicationForm";
            this.Text = "HappyTech Feedback Application";
            this.Load += new System.EventHandler(this.FeedbackApplicationForm_Load);
            this.navigationPanel.ResumeLayout(false);
            this.navigationButtonTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.timeDateTable.ResumeLayout(false);
            this.timeDateTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.TableLayoutPanel timeDateTable;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timeDateTimer;
        private System.Windows.Forms.TableLayoutPanel navigationButtonTable;
        private System.Windows.Forms.Button dashboardNavButton;
        private System.Windows.Forms.Button exitNavButton;
        private System.Windows.Forms.Button sendAllFeedbackNavButton;
        private System.Windows.Forms.Button editTemplatesNavButton;
        private System.Windows.Forms.Button viewAllCandidatesNavButton;
        private System.Windows.Forms.Button addEditCandidateNavButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DashboardUserControl dashboardUserControl1;
        private ucAddEditCandidate addEditCandidateUserControl1;
        private ViewAllCandidatesUserControl viewAllCandidatesUserControl1;
        private EditTemplatesUserControl editTemplatesUserControl1;
        private SendAllFeedbackUserControl sendAllFeedbackUserControl1;
    }
}

