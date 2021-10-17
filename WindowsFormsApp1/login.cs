using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        

        public login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      
        private void _login_Click(object sender, EventArgs e)
        {

            if (new MSql().Select_0_Tsql_Login(textBox1.Text, textBox2.Text) == "login in") this.Hide();

        }

        private void register_Click(object sender, EventArgs e)
        {
            register _form = new register();
            _form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MSql().Sql_Set(textBox4.Text);
            MessageBox.Show("設定完成");
        }
    } // EndOfClass
}
    

