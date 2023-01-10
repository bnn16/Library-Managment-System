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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }
        private readonly string ConnectionString = "data source = BNNXD\\SQLEXPRESS; database=Library; integrated security=True";

        private void Details_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from book_history where book_return_date is null", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet newDataSet = new DataSet();
                        da.Fill(newDataSet);

                        dataGridView1.DataSource = newDataSet.Tables[0];
                    }
                }
                using (SqlCommand cmd = new SqlCommand("select * from book_history where book_return_date is not null", con))
                {

                    using (SqlDataAdapter da1 = new SqlDataAdapter(cmd))
                    {
                        DataSet newDataSet1 = new DataSet();
                        da1.Fill(newDataSet1);

                        dataGridView2.DataSource = newDataSet1.Tables[0];
                    }
                }
            }
        }
    }
}

