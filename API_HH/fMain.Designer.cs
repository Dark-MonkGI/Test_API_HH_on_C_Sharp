namespace API_HH
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPars = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOpenForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(41, 12);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(507, 258);
            this.tbResult.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTest.Location = new System.Drawing.Point(41, 325);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(132, 52);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnPars
            // 
            this.btnPars.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPars.Location = new System.Drawing.Point(229, 325);
            this.btnPars.Name = "btnPars";
            this.btnPars.Size = new System.Drawing.Size(132, 52);
            this.btnPars.TabIndex = 2;
            this.btnPars.Text = "Pars";
            this.btnPars.UseVisualStyleBackColor = true;
            this.btnPars.Click += new System.EventHandler(this.btnPars_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(416, 325);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 52);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpenForms
            // 
            this.btnOpenForms.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenForms.Location = new System.Drawing.Point(647, 12);
            this.btnOpenForms.Name = "btnOpenForms";
            this.btnOpenForms.Size = new System.Drawing.Size(141, 52);
            this.btnOpenForms.TabIndex = 4;
            this.btnOpenForms.Text = "Open Forms";
            this.btnOpenForms.UseVisualStyleBackColor = true;
            this.btnOpenForms.Click += new System.EventHandler(this.btnOpenForms_Click);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenForms);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPars);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbResult);
            this.Name = "MainForms";
            this.Text = "HH API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPars;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpenForms;
    }
}

