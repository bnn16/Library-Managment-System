using library4._0.Forms;
using System.Data.SqlClient;

namespace library4._0
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Are you sure?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addABookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Addbook newForm = new Addbook();
            newForm.Show();
        }
        private void studentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            viewAllBooks newForm = new viewAllBooks();
            newForm.Show();

        }

        private readonly string _connectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";

        private void addBooksFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Make sure the csv file is in the correct format, book_name,author,genre,pages,isbn19,publish_date,book_description,book_quantity", "Heads Up!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                    // Read the contents of the CSV file
                    string filePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);
                    // Connect to the SQL database
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        // Iterate through each line of the CSV file (skip the first line as it contains column names)
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] fields = lines[i].Split(',');
                            string bookName = fields[0];
                            string author = fields[1];
                            string genre = fields[2];
                            int pages = Convert.ToInt16(fields[3]);
                            long isbn19 = Int64.Parse(fields[4]);
                            string publishDate = fields[5];
                            string bookDescription = fields[6];
                            int bookQuantity = int.Parse(fields[7]);

                            // Insert the data into the SQL database
                            string sql = "INSERT INTO books (book_name, author, genre, pages, isbn19, publish_date, book_description, book_quantity) " +
                                "VALUES (@bookName, @author, @genre, @pages, @isbn19, @publishDate, @bookDescription, @bookQuantity)";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@bookName", bookName);
                                command.Parameters.AddWithValue("@author", author);
                                command.Parameters.AddWithValue("@genre", genre);
                                command.Parameters.AddWithValue("@pages", pages);
                                command.Parameters.AddWithValue("@isbn19", isbn19);
                                command.Parameters.AddWithValue("@publishDate", publishDate);
                                command.Parameters.AddWithValue("@bookDescription", bookDescription);
                                command.Parameters.AddWithValue("@bookQuantity", bookQuantity);
                                command.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Books added to the Database!", "Success");
                        connection.Close();
                    }
                }
            }
    }

        private void addAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAStudent newForm = new addAStudent();
            newForm.Show();
        }

        private void viewAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAllStudents newForm = new viewAllStudents();
            newForm.Show();
        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueBook newForm = new issueBook();
            newForm.Show();
        }

        private void returnABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnABook newForm = new ReturnABook();
            newForm.Show();
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details newForm = new Details();
            newForm.Show();
        }
    }
}
