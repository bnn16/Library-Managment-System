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
    public partial class viewAllStudents : Form
    {
        public viewAllStudents()
        {
            InitializeComponent();
        }

        private void viewAllStudents_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from students";
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
                con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from students where id = " + id + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                rid = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                txtStudentName.Text = dataSet.Tables[0].Rows[0][1].ToString();
                txtStudentPCN.Text = dataSet.Tables[0].Rows[0][2].ToString();
                txtStudentEmail.Text = dataSet.Tables[0].Rows[0][3].ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM books WHERE students_name LIKE '" + textBox1.Text + "%' OR students_email LIKE '" + textBox1.Text + "%' OR pcn LIKE '" + textBox1.Text+ "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from students";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update students set students_name = '" + txtStudentName.Text + "', students_email= '" + txtStudentEmail.Text + "', pcb = '" + txtStudentPCN.Text+ "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from students where id=" + rid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);


            SqlConnection con1 = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from students";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet dataSet1 = new DataSet();
            da.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
