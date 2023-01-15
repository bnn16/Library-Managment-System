using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace library4._0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from login where username = @username and pass = @password";
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapt.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Menu newForm = new Menu();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong User/Pass", "Error", MessageBoxButtons.OK);
            }

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\SQLEXPRESS; database=Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into login(username, pass) values(@username, @password)";
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataAdapter sqlDataAdapt = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapt.Fill(dataSet);

            txtUsername.Text = "";
            txtPassword.Text = "";

            MessageBox.Show("Account Created, please login", "Success!");
        }

    }
}