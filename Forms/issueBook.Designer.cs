namespace library4._0.Forms
{
    partial class issueBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBookTitles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.txtPCN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Email";
            // 
            // comboBoxBookTitles
            // 
            this.comboBoxBookTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookTitles.FormattingEnabled = true;
            this.comboBoxBookTitles.Location = new System.Drawing.Point(418, 166);
            this.comboBoxBookTitles.Name = "comboBoxBookTitles";
            this.comboBoxBookTitles.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBookTitles.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Issue Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(418, 122);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.ReadOnly = true;
            this.txtStudentEmail.Size = new System.Drawing.Size(100, 23);
            this.txtStudentEmail.TabIndex = 6;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(418, 83);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(100, 23);
            this.txtStudentName.TabIndex = 7;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueBook.Location = new System.Drawing.Point(434, 276);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(75, 23);
            this.btnIssueBook.TabIndex = 8;
            this.btnIssueBook.Text = "Issue";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // txtPCN
            // 
            this.txtPCN.Location = new System.Drawing.Point(78, 146);
            this.txtPCN.Name = "txtPCN";
            this.txtPCN.Size = new System.Drawing.Size(100, 23);
            this.txtPCN.TabIndex = 9;
            this.txtPCN.TextChanged += new System.EventHandler(this.txtPCN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Student PCN";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchStudent.Location = new System.Drawing.Point(78, 192);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 11;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // issueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(693, 360);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPCN);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBookTitles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "issueBook";
            this.Text = "issueBook";
            this.Load += new System.EventHandler(this.issueBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxBookTitles;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtStudentEmail;
        private TextBox txtStudentName;
        private Button btnIssueBook;
        private TextBox txtPCN;
        private Label label5;
        private Button btnSearchStudent;
    }
}