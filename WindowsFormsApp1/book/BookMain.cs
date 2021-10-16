using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BookMain : Form
    {
        public BookMain()
        {
            InitializeComponent();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "zxcv5716")
            {
                new MSql().Build_1_Tsql_CreateTables();
                MessageBox.Show("重製完成");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new book.BookSearch().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new book.BookEdit().Show();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BookMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BookMain_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "zxcv5716")
            {
                new MSql().Build_3_Tsql_CreateMember();
                MessageBox.Show("重製完成");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "zxcv5716")
            {
                new MSql().Build_4_Tsql_CreateLeaseBook();
                MessageBox.Show("重製完成");
            }
        }
    }
}
