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
    public partial class addAStudent : Form
    {
        public addAStudent()
        {
            InitializeComponent();
        }

        private void buttonClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddAStudentClick(object sender, EventArgs e)
        {
            if (txtStudentEmail.Text != "" && txtStudentName.Text != "" && txtStudentPCN.Text != "")
            {
                Student newStudentObject = new Student(txtStudentName.Text, long.Parse(txtStudentPCN.Text), txtStudentEmail.Text);

                String students_name = newStudentObject.getName();
                String students_email = newStudentObject.getEmail();
                long pcn = newStudentObject.getPcn();


                try
                {

                    string query = "INSERT INTO students (students_name, pcn, students_email) VALUES (@students_name, @pcn, @students_email)";
                    using (SqlConnection connection = new SqlConnection("data source = MSI\\SQLEXPRESS; database=Library; integrated security=True"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@students_name", students_name);
                            command.Parameters.AddWithValue("@pcn", pcn);
                            command.Parameters.AddWithValue("@students_email", students_email);


                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {

                    txtStudentEmail.Text = "";
                    txtStudentName.Text = "";
                    txtStudentPCN.Text = "";
                    MessageBox.Show("Created a Student", "Success", MessageBoxButtons.OK);
              
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the fields!", "error");
            }
        }
    }
    }
