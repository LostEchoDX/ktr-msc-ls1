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


namespace Test_MSC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=BusinessCards;Trusted_Connection=True;");
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Profiles where ID = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            command.Connection = con;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect ID & Password");
            con.Close();
        }
    }
}
