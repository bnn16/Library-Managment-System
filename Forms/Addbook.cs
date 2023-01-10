using library4._0.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library4._0
{
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void buttonCancelAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {

            if (txtBoxBookTitle.Text != "" && txtBoxBookAuthor.Text != "" && txtBoxBookGenre.Text != "" && txtBoxBookPages.Text != "" && txtBoxBookISBN.Text != "" && txtBoxBookDescription.Text != "")
            {
                Book newBookObject = new Book(txtBoxBookTitle.Text, txtBoxBookAuthor.Text, txtBoxBookGenre.Text, Int32.Parse(txtBoxBookPages.Text), Int64.Parse(txtBoxBookISBN.Text), dateTimePicker1.Value.ToString(), txtBoxBookDescription.Text, Int32.Parse(txtBoxBookQuantity.Text));

                String bookName = newBookObject.getTitle();
                String bookAuthor = newBookObject.getAuthor();
                String bookGenre = newBookObject.getGenre();
                int bookPages = newBookObject.getPages();
                long bookISBN = newBookObject.getISBN();
                String date = newBookObject.getDate();
                String book_desc = newBookObject.getDesc();
                int book_quant = newBookObject.getBookQuantity();




                try
                {



                    // NOT SECURE!
                    //SqlConnection con = new SqlConnection();
                    //con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True"; 
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.Connection = con;

                    //con.Open();
                    //cmd.CommandText = "insert into books (book_name, author, genre, pages, isbn19, publish_date, book_description) VALUES ('" + bookName + "','" + bookAuthor + "','" + bookGenre + "','" + bookPages + "','" + bookISBN + "','" + date + "','" + book_desc + "')";
                    //cmd.ExecuteNonQuery();
                    //con.Close();

                    //SECURE WAY
                    string query = "INSERT INTO books (book_name, author, genre, pages, isbn19, publish_date, book_description, book_quantity) VALUES (@bookName, @bookAuthor, @bookGenre, @bookPages, @bookISBN, @date, @bookDesc, @quantity)";
                    using (SqlConnection connection = new SqlConnection("data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@bookName", bookName);
                            command.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                            command.Parameters.AddWithValue("@bookGenre", bookGenre);
                            command.Parameters.AddWithValue("@bookPages", bookPages);
                            command.Parameters.AddWithValue("@bookISBN", bookISBN);
                            command.Parameters.AddWithValue("@date", date);
                            command.Parameters.AddWithValue("@bookDesc", book_desc);
                            command.Parameters.AddWithValue("@quantity", book_quant);

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {

                    txtBoxBookAuthor.Text = "";
                    txtBoxBookDescription.Text = "";
                    txtBoxBookGenre.Text = "";
                    txtBoxBookISBN.Text = "";
                    txtBoxBookPages.Text = "";
                    txtBoxBookTitle.Text = "";
                    txtBoxBookQuantity.Text = "";
                    MessageBox.Show("Book Created", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the fields!", "error");
            }
        }
    }
}
