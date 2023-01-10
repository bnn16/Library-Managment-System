using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library4._0.Forms
{
    public partial class ReturnABook : Form
    {
        public ReturnABook()
        {
            InitializeComponent();
        }

        private readonly string ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from book_history where pcn = '" + txtPCN.Text + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet newDataSet1 = new DataSet();
                da1.Fill(newDataSet1);

                if (newDataSet1.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = newDataSet1.Tables[0];
                }
                else {
                    txtPCN.Clear();
                    MessageBox.Show("invalid PCN or all books are returned already. Please enter a valid number.", "error");
                }
            
            }
        int rid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Column Header clicked.");
            }
            else
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from book_history where pcn = '" + txtPCN.Text + "' and id = " + id + " and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet newDataSet1 = new DataSet();
                da1.Fill(newDataSet1);
                rid = int.Parse(newDataSet1.Tables[0].Rows[0][0].ToString());

                txtBookName.Text = newDataSet1.Tables[0].Rows[0][4].ToString();
                txtBookIssueDate.Text = newDataSet1.Tables[0].Rows[0][5].ToString();
            }
        }

        private void btnReturnBookFunction(object sender, EventArgs e)
        {

            // Update the book_history table
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update book_history set book_return_date = @returnDate where id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@returnDate", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@id", rid);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet newDataSet = new DataSet();
                        da.Fill(newDataSet);
                    }
                }

                // Retrieve the title of the returned book
                string bookTitle = "";
                using (SqlCommand cmd = new SqlCommand("SELECT book_name FROM book_history WHERE id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", rid);
                    bookTitle = (string)cmd.ExecuteScalar();
                }
                // Increase the quantity of the returned book by 1
                using (SqlCommand cmd = new SqlCommand("UPDATE books SET book_quantity = book_quantity + 1 WHERE book_name = @title", con))
                {
                    cmd.Parameters.AddWithValue("@title", bookTitle);
                    cmd.ExecuteNonQuery();
                }
            }

            // Retrieve data from the book_history table
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from book_history where pcn = @pcn and book_return_date is null", con))
                {
                    cmd.Parameters.AddWithValue("@pcn", txtPCN.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet newDataSet = new DataSet();
                        da.Fill(newDataSet);

                        dataGridView1.DataSource = newDataSet.Tables[0];
                    }
                }
            }
            MessageBox.Show("Book Returned", "Success!");
        }
    }
}
