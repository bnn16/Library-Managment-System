using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library4._0
{
    public partial class viewAllBooks : Form
    {
        public viewAllBooks()
        {
            InitializeComponent();
        }

        private void viewAllBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from books";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
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

                cmd.CommandText = "select * from books where id = " + id + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                rid = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                CultureInfo provider = new CultureInfo("en-US");


                txtBoxBookTitle.Text = dataSet.Tables[0].Rows[0][1].ToString();
                txtBoxBookAuthor.Text = dataSet.Tables[0].Rows[0][2].ToString();
                txtBoxBookGenre.Text = dataSet.Tables[0].Rows[0][3].ToString();
                txtBoxBookPages.Text = dataSet.Tables[0].Rows[0][4].ToString();
                txtBoxBookISBN.Text = dataSet.Tables[0].Rows[0][5].ToString();

                DateTime dateTime;
                if (DateTime.TryParse(dataSet.Tables[0].Rows[0][6].ToString(), out dateTime))
                {
                    dateTimePicker1.Text = dateTime.ToString();
                }
                else
                {
                    dateTimePicker1.Text = DateTime.ParseExact(dataSet.Tables[0].Rows[0][6].ToString(), "dd/MM/yyyy", provider).ToString();

                }
                txtBoxBookDescription.Text = dataSet.Tables[0].Rows[0][7].ToString();
                txtBoxBookQuantity.Text = dataSet.Tables[0].Rows[0][8].ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM books WHERE book_name LIKE '" + textBox1.Text + "%' OR genre LIKE '" + textBox1.Text + "%' OR author LIKE '" + textBox1.Text + "%' OR isbn19 LIKE '" + textBox1.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from books";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update books set book_name = '"+txtBoxBookTitle.Text+"', author= '"+txtBoxBookAuthor.Text +"', genre = '" + txtBoxBookGenre.Text+ "', pages= '"+txtBoxBookPages.Text +"', isbn19='"+txtBoxBookISBN.Text +"', publish_date= '"+dateTimePicker1.Text+"', book_description='"+txtBoxBookDescription.Text +"', book_quantity='"+ txtBoxBookQuantity.Text +"' where id ="+ rid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

            MessageBox.Show("Book edited", "Success",MessageBoxButtons.OK);


            //reload the connection
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1;

            cmd1.CommandText = "select * from books";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet dataSet1 = new DataSet();
            da1.Fill(dataSet1);

            dataGridView1.DataSource = dataSet1.Tables[0];
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText =  "delete from books where id="+rid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            MessageBox.Show("Book Deleted", "Success", MessageBoxButtons.OK);

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1;

            cmd1.CommandText = "select * from books";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet dataSet1 = new DataSet();
            da1.Fill(dataSet1);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

   }
}
