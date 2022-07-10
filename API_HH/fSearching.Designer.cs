namespace API_HH
{
    partial class fSearching
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
            this.gvSearchingResults = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnOverview = new System.Windows.Forms.Button();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Salary_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Salary_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Employer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchingResults)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSearchingResults
            // 
            this.gvSearchingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchingResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Name,
            this.Column_Salary_from,
            this.Column_Salary_to,
            this.Column_Employer,
            this.Column_Address,
            this.Column_info});
            this.gvSearchingResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvSearchingResults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvSearchingResults.Location = new System.Drawing.Point(0, 0);
            this.gvSearchingResults.Name = "gvSearchingResults";
            this.gvSearchingResults.Size = new System.Drawing.Size(743, 281);
            this.gvSearchingResults.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 298);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(429, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // btnOverview
            // 
            this.btnOverview.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOverview.Location = new System.Drawing.Point(505, 298);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(217, 40);
            this.btnOverview.TabIndex = 4;
            this.btnOverview.Text = "Search";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Salary_from
            // 
            this.Column_Salary_from.HeaderText = "Salary_from";
            this.Column_Salary_from.Name = "Column_Salary_from";
            // 
            // Column_Salary_to
            // 
            this.Column_Salary_to.HeaderText = "Salary_to";
            this.Column_Salary_to.Name = "Column_Salary_to";
            // 
            // Column_Employer
            // 
            this.Column_Employer.HeaderText = "Employer";
            this.Column_Employer.Name = "Column_Employer";
            // 
            // Column_Address
            // 
            this.Column_Address.HeaderText = "Address";
            this.Column_Address.Name = "Column_Address";
            // 
            // Column_info
            // 
            this.Column_info.HeaderText = "info";
            this.Column_info.Name = "Column_info";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 334);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 5;
            // 
            // fSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 365);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gvSearchingResults);
            this.Name = "fSearching";
            this.Text = "Searching Results Table";
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchingResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSearchingResults;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Salary_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Salary_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Employer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_info;
        private System.Windows.Forms.Label lblCount;
    }
}