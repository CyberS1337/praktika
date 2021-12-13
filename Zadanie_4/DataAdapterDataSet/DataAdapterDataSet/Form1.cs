using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbDataReader myReader;
            string CustomerString;
            oleDbConnection1.Open();
            myReader = oleDbCommand1.ExecuteReader();
            while(myReader.Read())
            {
                CustomerString = myReader[1].ToString() + " " + myReader[2].ToString();
                listBox1.Items.Add(CustomerString);
            }
            myReader.Close();
            oleDbConnection1.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Exercise2 = new Form2();
            Exercise2.Show();
        }
    }
}
