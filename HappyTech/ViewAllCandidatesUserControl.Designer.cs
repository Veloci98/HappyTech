namespace HappyTech
{
    partial class ViewAllCandidatesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.candidateDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // candidateDataGridView
            // 
            this.candidateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.candidateDataGridView.Location = new System.Drawing.Point(0, 0);
            this.candidateDataGridView.Name = "candidateDataGridView";
            this.candidateDataGridView.Size = new System.Drawing.Size(985, 561);
            this.candidateDataGridView.TabIndex = 0;
            this.candidateDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidateDataGridView_CellContentClick);
            // 
            // ViewAllCandidatesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.candidateDataGridView);
            this.Name = "ViewAllCandidatesUserControl";
            this.Size = new System.Drawing.Size(985, 561);
            this.Load += new System.EventHandler(this.ViewAllCandidatesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView candidateDataGridView;
    }
}
