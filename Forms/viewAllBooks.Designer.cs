namespace library4._0
{
    partial class viewAllBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtBoxBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxBookTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxBookDescription = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBookGenre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxBookISBN = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Label();
            this.asdasd = new System.Windows.Forms.Label();
            this.txtBoxBookPages = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.btnDeleteBook);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnEditBook);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.txtBoxBookQuantity);
            this.panel1.Controls.Add(this.txtBoxBookTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxBookDescription);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtBoxBookAuthor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBoxBookGenre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBoxBookISBN);
            this.panel1.Controls.Add(this.asd);
            this.panel1.Controls.Add(this.asdasd);
            this.panel1.Controls.Add(this.txtBoxBookPages);
            this.panel1.Location = new System.Drawing.Point(12, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 152);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(656, 86);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(83, 58);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete\r\nBook";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(318, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Description";
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(656, 12);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(83, 58);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Edit \r\nBook";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quantity.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Quantity.Location = new System.Drawing.Point(318, 115);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 36;
            this.Quantity.Text = "Quantity";
            // 
            // txtBoxBookQuantity
            // 
            this.txtBoxBookQuantity.Location = new System.Drawing.Point(400, 111);
            this.txtBoxBookQuantity.Name = "txtBoxBookQuantity";
            this.txtBoxBookQuantity.Size = new System.Drawing.Size(204, 23);
            this.txtBoxBookQuantity.TabIndex = 37;
            // 
            // txtBoxBookTitle
            // 
            this.txtBoxBookTitle.Location = new System.Drawing.Point(98, 20);
            this.txtBoxBookTitle.Name = "txtBoxBookTitle";
            this.txtBoxBookTitle.Size = new System.Drawing.Size(204, 23);
            this.txtBoxBookTitle.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Title";
            // 
            // txtBoxBookDescription
            // 
            this.txtBoxBookDescription.Location = new System.Drawing.Point(400, 82);
            this.txtBoxBookDescription.Name = "txtBoxBookDescription";
            this.txtBoxBookDescription.Size = new System.Drawing.Size(204, 23);
            this.txtBoxBookDescription.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // txtBoxBookAuthor
            // 
            this.txtBoxBookAuthor.Location = new System.Drawing.Point(98, 49);
            this.txtBoxBookAuthor.Name = "txtBoxBookAuthor";
            this.txtBoxBookAuthor.Size = new System.Drawing.Size(204, 23);
            this.txtBoxBookAuthor.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Author";
            // 
            // txtBoxBookGenre
            // 
            this.txtBoxBookGenre.Location = new System.Drawing.Point(98, 78);
            this.txtBoxBookGenre.Name = "txtBoxBookGenre";
            this.txtBoxBookGenre.Size = new System.Drawing.Size(204, 23);
            this.txtBoxBookGenre.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(318, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 34);
            this.label8.TabIndex = 32;
            this.label8.Text = "Publication\r\ndate ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(25, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Genre";
            // 
            // txtBoxBookISBN
            // 
            this.txtBoxBookISBN.Location = new System.Drawing.Point(400, 20);
            this.txtBoxBookISBN.Name = "txtBoxBookISBN";
            this.txtBoxBookISBN.Size = new System.Drawing.Size(204, 23);
            this.txtBoxBookISBN.TabIndex = 31;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.asd.Location = new System.Drawing.Point(318, 23);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(49, 17);
            this.asd.TabIndex = 30;
            this.asd.Text = "ISBN13";
            // 
            // asdasd
            // 
            this.asdasd.AutoSize = true;
            this.asdasd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asdasd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.asdasd.Location = new System.Drawing.Point(25, 110);
            this.asdasd.Name = "asdasd";
            this.asdasd.Size = new System.Drawing.Size(49, 20);
            this.asdasd.TabIndex = 28;
            this.asdasd.Text = "Pages";
            // 
            // txtBoxBookPages
            // 
            this.txtBoxBookPages.Location = new System.Drawing.Point(98, 107);
            this.txtBoxBookPages.Name = "txtBoxBookPages";
            this.txtBoxBookPages.Size = new System.Drawing.Size(204, 23);
            this.txtBoxBookPages.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 229);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataSource = typeof(library4._0.Classes.Book);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(library4._0.Classes.Book);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(273, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // viewAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "viewAllBooks";
            this.Text = "viewAllBooks";
            this.Load += new System.EventHandler(this.viewAllBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnDeleteBook;
        private Label label9;
        private Button btnEditBook;
        private Label Quantity;
        private TextBox txtBoxBookQuantity;
        private TextBox txtBoxBookTitle;
        private Label label3;
        private TextBox txtBoxBookDescription;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBoxBookAuthor;
        private Label label4;
        private TextBox txtBoxBookGenre;
        private Label label8;
        private Label label5;
        private TextBox txtBoxBookISBN;
        private Label asd;
        private Label asdasd;
        private TextBox txtBoxBookPages;
        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private BindingSource bookBindingSource1;
        private Label label1;
        private TextBox textBox1;
    }
}