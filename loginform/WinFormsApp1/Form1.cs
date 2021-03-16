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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select Count(*) From Login where username = '" + textBox1.Text +
                "'and password = '" + textBox2.Text + "'",con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows[0][0].ToString()=="1")
            {

                this.Hide();
                Form2 F = new Form2();
                F.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password");
            }

           
        }
    }
}
