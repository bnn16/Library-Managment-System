using library4._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library4._0.Forms
{
    public partial class issueBook : Form
    {
        public issueBook()
        {
            InitializeComponent();
        }

        private void issueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select book_name from books", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                for (int i = 0; i < dr.FieldCount; i++) {
                    comboBoxBookTitles.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            con.Close();

        }
        int count;
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (txtPCN.Text != "") {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from students where pcn = '" + txtPCN.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet newDataSet = new DataSet();
                da.Fill(newDataSet);



                cmd.CommandText = "select count(pcn) from book_history where pcn = '" + txtPCN.Text + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet newDataSet1 = new DataSet();
                da.Fill(newDataSet1);

                count = int.Parse(newDataSet1.Tables[0].Rows[0][0].ToString());



                if (newDataSet.Tables[0].Rows.Count != 0)
                {
                    txtStudentEmail.Text = newDataSet.Tables[0].Rows[0][3].ToString();
                    txtStudentName.Text = newDataSet.Tables[0].Rows[0][1].ToString();
                }
                else
                {
                    txtStudentName.Text = "";
                    txtStudentEmail.Text = "";
                    MessageBox.Show("invalid PCN, please enter a valid number.", "error");
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {
                if (comboBoxBookTitles.SelectedIndex != -1)
                {
                    IssuedBook newBook = new IssuedBook(Int64.Parse(txtPCN.Text), txtStudentName.Text, txtStudentEmail.Text, comboBoxBookTitles.Text, dateTimePicker1.Text);

                    string ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();

                        // Check if there are any copies of the borrowed book remaining
                        using (SqlCommand cmd = new SqlCommand("SELECT book_quantity FROM books WHERE book_name = @bookName", con))
                        {
                            cmd.Parameters.AddWithValue("@bookName", newBook.getBook_borrowed());

                            int bookQuantity = (int)cmd.ExecuteScalar();
                            if (bookQuantity > 0)
                            {
                                // Decrease the quantity of the borrowed book by 1
                                using (SqlCommand cmd1 = new SqlCommand("UPDATE books SET book_quantity = book_quantity - 1 WHERE book_name = @bookName", con))
                                {
                                    cmd1.Parameters.AddWithValue("@bookName", newBook.getBook_borrowed());

                                    try
                                    {
                                        cmd1.ExecuteNonQuery();
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show("An error occurred: " + ex.Message);
                                    }
                                }

                                // Insert the borrowed book into the book_history table
                                using (SqlCommand cmd2 = new SqlCommand("insert into book_history (pcn, students_name, students_email, book_name, book_issue_date) values (@pcn, @studentName, @studentEmail, @bookName, @issueDate)", con))
                                {
                                    cmd2.Parameters.AddWithValue("@pcn", newBook.getPcn());
                                    cmd2.Parameters.AddWithValue("@studentName", newBook.getStudentName());
                                    cmd2.Parameters.AddWithValue("@studentEmail", newBook.getStudentEmail());
                                    cmd2.Parameters.AddWithValue("@bookName", newBook.getBook_borrowed());
                                    cmd2.Parameters.AddWithValue("@issueDate", newBook.getDate_borrowed());

                                    try
                                    {
                                        cmd2.ExecuteNonQuery();
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show("An error occurred: " + ex.Message);
                                    }
                                }

                                MessageBox.Show("Book Issued to Student", "Congrats!");
                                txtStudentEmail.Text = "";
                                txtStudentName.Text = "";
                                txtPCN.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Sorry, this book is currently unavailable", "Error");
                            }
                        }
                    }


                }
            }
        }

                private void txtPCN_TextChanged(object sender, EventArgs e)
        {
            if (txtPCN.Text == "") {
                txtStudentEmail.Text = "";
                txtStudentName.Text = "";
            }

            }
    }
}
