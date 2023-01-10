namespace library4._0.Forms
{
    partial class ReturnABook
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
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPCN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.txtBookIssueDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(35, 350);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 14;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(35, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student PCN";
            // 
            // txtPCN
            // 
            this.txtPCN.Location = new System.Drawing.Point(35, 304);
            this.txtPCN.Name = "txtPCN";
            this.txtPCN.Size = new System.Drawing.Size(100, 23);
            this.txtPCN.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.dataGridView1.Location = new System.Drawing.Point(208, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(580, 229);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnReturnBook);
            this.panel1.Controls.Add(this.txtBookIssueDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.asd);
            this.panel1.Location = new System.Drawing.Point(208, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 152);
            this.panel1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(105, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 34);
            this.label9.TabIndex = 33;
            this.label9.Text = "Book Issue \r\nDate";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(457, 38);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(83, 58);
            this.btnReturnBook.TabIndex = 1;
            this.btnReturnBook.Text = "Return \r\nBook";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBookFunction);
            // 
            // txtBookIssueDate
            // 
            this.txtBookIssueDate.Location = new System.Drawing.Point(190, 62);
            this.txtBookIssueDate.Name = "txtBookIssueDate";
            this.txtBookIssueDate.ReadOnly = true;
            this.txtBookIssueDate.Size = new System.Drawing.Size(204, 23);
            this.txtBookIssueDate.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(105, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 34);
            this.label8.TabIndex = 32;
            this.label8.Text = "Book Return\r\nDate";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(190, 25);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(204, 23);
            this.txtBookName.TabIndex = 31;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.asd.Location = new System.Drawing.Point(108, 25);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(44, 34);
            this.asd.TabIndex = 30;
            this.asd.Text = "Book\r\nName";
            // 
            // ReturnABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnABook";
            this.Text = "ReturnABook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearchStudent;
        private Label label5;
        private TextBox txtPCN;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label9;
        private Button btnReturnBook;
        private TextBox txtBookIssueDate;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox txtBookName;
        private Label asd;
    }
}