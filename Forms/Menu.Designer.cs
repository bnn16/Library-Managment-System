namespace library4._0
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.addABookToolStripMenuItem,
            this.newBookToolStripMenuItem,
            this.returnABookToolStripMenuItem,
            this.bookDetailsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 13, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(258, 479);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.addABookToolStripMenuItem1,
            this.addBooksFromFileToolStripMenuItem});
            this.booksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.booksToolStripMenuItem.Image = global::library4._0.Properties.Resources.library;
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(243, 68);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Image = global::library4._0.Properties.Resources.books;
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(370, 70);
            this.studentToolStripMenuItem.Text = "View a Book";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click_1);
            // 
            // addABookToolStripMenuItem1
            // 
            this.addABookToolStripMenuItem1.Image = global::library4._0.Properties.Resources.book;
            this.addABookToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addABookToolStripMenuItem1.Name = "addABookToolStripMenuItem1";
            this.addABookToolStripMenuItem1.Size = new System.Drawing.Size(370, 70);
            this.addABookToolStripMenuItem1.Text = "Add a Book";
            this.addABookToolStripMenuItem1.Click += new System.EventHandler(this.addABookToolStripMenuItem1_Click);
            // 
            // addBooksFromFileToolStripMenuItem
            // 
            this.addBooksFromFileToolStripMenuItem.Image = global::library4._0.Properties.Resources.file;
            this.addBooksFromFileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBooksFromFileToolStripMenuItem.Name = "addBooksFromFileToolStripMenuItem";
            this.addBooksFromFileToolStripMenuItem.Size = new System.Drawing.Size(370, 70);
            this.addBooksFromFileToolStripMenuItem.Text = "Add Books From File";
            this.addBooksFromFileToolStripMenuItem.Click += new System.EventHandler(this.addBooksFromFileToolStripMenuItem_Click);
            // 
            // addABookToolStripMenuItem
            // 
            this.addABookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllStudentsToolStripMenuItem,
            this.addAStudentToolStripMenuItem});
            this.addABookToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.addABookToolStripMenuItem.Image = global::library4._0.Properties.Resources.student;
            this.addABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addABookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.addABookToolStripMenuItem.Name = "addABookToolStripMenuItem";
            this.addABookToolStripMenuItem.Size = new System.Drawing.Size(243, 68);
            this.addABookToolStripMenuItem.Text = "Students";
            // 
            // viewAllStudentsToolStripMenuItem
            // 
            this.viewAllStudentsToolStripMenuItem.Image = global::library4._0.Properties.Resources.customer;
            this.viewAllStudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewAllStudentsToolStripMenuItem.Name = "viewAllStudentsToolStripMenuItem";
            this.viewAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(335, 70);
            this.viewAllStudentsToolStripMenuItem.Text = "View All Students";
            this.viewAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewAllStudentsToolStripMenuItem_Click);
            // 
            // addAStudentToolStripMenuItem
            // 
            this.addAStudentToolStripMenuItem.Image = global::library4._0.Properties.Resources.student__1_;
            this.addAStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addAStudentToolStripMenuItem.Name = "addAStudentToolStripMenuItem";
            this.addAStudentToolStripMenuItem.Size = new System.Drawing.Size(335, 70);
            this.addAStudentToolStripMenuItem.Text = "Add A Student";
            this.addAStudentToolStripMenuItem.Click += new System.EventHandler(this.addAStudentToolStripMenuItem_Click);
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.newBookToolStripMenuItem.Image = global::library4._0.Properties.Resources.reading_book;
            this.newBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(243, 68);
            this.newBookToolStripMenuItem.Text = "Issue A Book";
            this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
            // 
            // returnABookToolStripMenuItem
            // 
            this.returnABookToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.returnABookToolStripMenuItem.Image = global::library4._0.Properties.Resources.holding;
            this.returnABookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnABookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.returnABookToolStripMenuItem.Name = "returnABookToolStripMenuItem";
            this.returnABookToolStripMenuItem.Size = new System.Drawing.Size(243, 68);
            this.returnABookToolStripMenuItem.Text = "Return A Book";
            this.returnABookToolStripMenuItem.Click += new System.EventHandler(this.returnABookToolStripMenuItem_Click);
            // 
            // bookDetailsToolStripMenuItem
            // 
            this.bookDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.bookDetailsToolStripMenuItem.Image = global::library4._0.Properties.Resources.book__1_;
            this.bookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            this.bookDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 68);
            this.bookDetailsToolStripMenuItem.Text = "Book Details";
            this.bookDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Image = global::library4._0.Properties.Resources.exit;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.exitToolStripMenuItem.MergeIndex = 0;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(243, 68);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library4._0.Properties.Resources.librarypic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 479);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addABookToolStripMenuItem;
        private ToolStripMenuItem newBookToolStripMenuItem;
        private ToolStripMenuItem addABookToolStripMenuItem1;
        private ToolStripMenuItem returnABookToolStripMenuItem;
        private ToolStripMenuItem bookDetailsToolStripMenuItem;
        private ToolStripMenuItem viewAllStudentsToolStripMenuItem;
        private ToolStripMenuItem addAStudentToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addBooksFromFileToolStripMenuItem;
    }
}