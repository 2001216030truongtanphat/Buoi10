using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _35_2001216030_TruongTanPhat_B10
{
    public partial class Form1 : Form
    {
        private SqlConnection cn = new SqlConnection("Data Source=A209PC43;Initial Catalog = IDN;Integrated Security=True");
        private SqlDataAdapter myAdapt;
        private SqlCommand com;
        private DataSet ds;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadIDN_ComboBox();
            ketnoiCSDL();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {
            layDS();
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                string insrt = "Insert Into CRUD Values(" + textBox1 + " , N'" + textBox2 + "')";
                com = new SqlCommand(insrt, cn);
                com.ExecuteNonQuery();
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail");
            }
            
        }
        private void layDS()
        {
            var sql = "Select count(*) from CRUD";
            com =  new SqlCommand(sql, cn);
            cn.Open();
            com.ExecuteNonQuery();
            int a = 0;
            a = (int)com.ExecuteScalar();
            cn.Close();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MessageBox.Show("Sucessfully");
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail");
            }
        }

        private void loadIDN_ComboBox()
        {
            cn.Open();
            string selStr = "Select * From CRUD";
            com = new SqlCommand(selStr, cn);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(Convert.ToInt32(rd["id"].ToString()));
            }
            cn.Close();
        }

        private void ketnoiCSDL()
        {
            cn.Open();
            var sql = "Select * from CRUD";
            com = new SqlCommand(sql, cn);
            com.CommandType = CommandType.Text;
            myAdapt = new SqlDataAdapter(com);
            dt = new DataTable();
            myAdapt.Fill(dt);
            cn.Close();
            dgvIDN.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
