namespace library4._0.Forms
{
    partial class addAStudent
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
            this.buttonCancelAddBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentPCN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelAddBook
            // 
            this.buttonCancelAddBook.BackColor = System.Drawing.Color.White;
            this.buttonCancelAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.buttonCancelAddBook.Location = new System.Drawing.Point(230, 266);
            this.buttonCancelAddBook.Name = "buttonCancelAddBook";
            this.buttonCancelAddBook.Size = new System.Drawing.Size(111, 44);
            this.buttonCancelAddBook.TabIndex = 38;
            this.buttonCancelAddBook.Text = "Cancel";
            this.buttonCancelAddBook.UseVisualStyleBackColor = false;
            this.buttonCancelAddBook.Click += new System.EventHandler(this.buttonClose);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.White;
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.buttonAddBook.Location = new System.Drawing.Point(64, 266);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(111, 44);
            this.buttonAddBook.TabIndex = 37;
            this.buttonAddBook.Text = "Add Student";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddAStudentClick);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(137, 190);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(204, 23);
            this.txtStudentEmail.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(64, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "Student \r\nEmail";
            // 
            // txtStudentPCN
            // 
            this.txtStudentPCN.Location = new System.Drawing.Point(137, 159);
            this.txtStudentPCN.Name = "txtStudentPCN";
            this.txtStudentPCN.Size = new System.Drawing.Size(204, 23);
            this.txtStudentPCN.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(64, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "PCN";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(137, 127);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(204, 23);
            this.txtStudentName.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(64, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addAStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(437, 388);
            this.Controls.Add(this.buttonCancelAddBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStudentPCN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "addAStudent";
            this.Text = "addAStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonCancelAddBook;
        private Button buttonAddBook;
        private TextBox txtStudentEmail;
        private Label label5;
        private TextBox txtStudentPCN;
        private Label label4;
        private TextBox txtStudentName;
        private Label label3;
        private Label label1;
    }
}