namespace MovieSearchApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.lblMovieSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.lstYear = new System.Windows.Forms.ListBox();
            this.lstType = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstImdbID = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtTotalResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.txtPageNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(172, 42);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(341, 23);
            this.txtSearchTerm.TabIndex = 0;
            // 
            // lblMovieSearch
            // 
            this.lblMovieSearch.AutoSize = true;
            this.lblMovieSearch.Location = new System.Drawing.Point(41, 45);
            this.lblMovieSearch.Name = "lblMovieSearch";
            this.lblMovieSearch.Size = new System.Drawing.Size(119, 15);
            this.lblMovieSearch.TabIndex = 1;
            this.lblMovieSearch.Text = "Enter Name of Movie";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 15;
            this.lstName.Location = new System.Drawing.Point(64, 146);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(263, 484);
            this.lstName.TabIndex = 3;

            // 
            // lstYear
            // 
            this.lstYear.FormattingEnabled = true;
            this.lstYear.ItemHeight = 15;
            this.lstYear.Location = new System.Drawing.Point(427, 146);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(89, 484);
            this.lstYear.TabIndex = 4;
            // 
            // lstType
            // 
            this.lstType.FormattingEnabled = true;
            this.lstType.ItemHeight = 15;
            this.lstType.Location = new System.Drawing.Point(333, 146);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(89, 484);
            this.lstType.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(701, 612);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstImdbID
            // 
            this.lstImdbID.FormattingEnabled = true;
            this.lstImdbID.ItemHeight = 15;
            this.lstImdbID.Location = new System.Drawing.Point(522, 146);
            this.lstImdbID.Name = "lstImdbID";
            this.lstImdbID.Size = new System.Drawing.Size(89, 484);
            this.lstImdbID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Movie Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "imdbID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(688, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(663, 155);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export Results";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtTotalResults
            // 
            this.txtTotalResults.Location = new System.Drawing.Point(121, 84);
            this.txtTotalResults.Name = "txtTotalResults";
            this.txtTotalResults.Size = new System.Drawing.Size(100, 23);
            this.txtTotalResults.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Results";
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.Location = new System.Drawing.Point(273, 92);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(33, 15);
            this.lblPageNum.TabIndex = 21;
            this.lblPageNum.Text = "Page";
            // 
            // txtPageNum
            // 
            this.txtPageNum.Location = new System.Drawing.Point(312, 84);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(100, 23);
            this.txtPageNum.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 647);
            this.Controls.Add(this.lblPageNum);
            this.Controls.Add(this.txtPageNum);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstImdbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstType);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMovieSearch);
            this.Controls.Add(this.txtSearchTerm);
            this.Name = "Form1";
            this.Text = "Movie Search Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSearchTerm;
        private Label lblMovieSearch;
        private Button btnSearch;
        private ListBox lstName;
        private ListBox lstYear;
        private ListBox lstType;
        private Button btnExit;
        private ListBox lstImdbID;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnClear;
        private SaveFileDialog saveFileDialog1;
        private Button btnExport;
        private TextBox txtTotalResults;
        private Label label1;
        private Label lblPageNum;
        private TextBox txtPageNum;
    }
}