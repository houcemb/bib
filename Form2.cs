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
namespace bib
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bib;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail, motDePass;
            mail = textBox1.Text;
            motDePass = textBox2.Text;
            try
            {
                string query = "select * from test where email= '" + textBox1.Text + "' and mdp = '" + textBox2.Text + "'"; 
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show("bienvenue");
                }
                else
                {
                    MessageBox.Show("error1");
                }
            }
            catch { MessageBox.Show("error2"); }
            finally { conn.Close(); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
