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

        public static string UserAccount;

        public void SetUserAccount(string acc)
        {
            UserAccount = acc;
        }
        //
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
            new Member.Admin().Show();
        }

        private void BookMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BookMain_Load(object sender, EventArgs e)
        {
            string[] userdata = new string[0];
            userdata = new MSql().Select_5_Tsql_SearchMember(UserAccount).Split('|');
            label1.Text = "Hello! " + UserAccount+ "\n" ;

            if (Convert.ToBoolean(userdata[6]))
            {
                //ADMIN 
                label1.Text += "ADMIN MODE";
                
            }
            else
            {
                ADMIN_Group.Visible = false;
                Member_Group.Location = new Point(10, 10);
                resetbutton1.Visible = false;
                resetbutton2.Visible = false;
                resetbutton3.Visible = false;
                textBox1.Visible = false;
            }
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

        private void resetbutton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "zxcv5716")
            {
                new MSql().Build_1_Tsql_CreateTables();
                new MSql().Build_0_Tsql_CreateAccount();
                MessageBox.Show("重製完成");
            }
        }
        private void resetbutton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "zxcv5716")
            {
                new MSql().Build_3_Tsql_CreateMember();
                MessageBox.Show("重製完成");
            }
        }
        private void resetbutton3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "zxcv5716")
            {
                new MSql().Build_4_Tsql_CreateLeaseBook();
                MessageBox.Show("重製完成");
            }
        }
    }
}
