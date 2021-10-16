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
        static string  myConnectionString;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        static void login_3_Tsql_CheckTables(string tsql,MySqlConnection connection,string Enter_Account = "",string Enter_Password = "")
        {
            Enter_Account = " " + Enter_Account;//??
            try
            {
                using (var command = new MySqlCommand(tsql, connection))
                {
                    MySqlDataReader dataReader = command.ExecuteReader();
                    string reader_name,reader_password;
                    bool _key = false;
                    while (dataReader.Read())
                    {
                        reader_name = Convert.ToString(dataReader["account"]);
                        if (reader_name == Enter_Account)
                        {
                            _key = true;
                            reader_password = Convert.ToString(dataReader["pw"]);
                            if(reader_password == Enter_Password)
                            {
                                MessageBox.Show("登入成功");
                                new BookMain().Show();
                            }
                            else
                            {
                                MessageBox.Show("密碼錯誤");
                                break;
                            }
                        }
                    }
                    if (!_key) MessageBox.Show("帳號錯誤");
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.ToString());
            }
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

        private void button1_Click(object sender, EventArgs e)
        {//重置資料庫
                if(textBox3.Text == "zxcv5716")
            {
                new MSql().Build_0_Tsql_CreateAccount();
                MessageBox.Show("已重置完成");
            }
            else
            {
                MessageBox.Show("請輸入正確密碼");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConnectionString = "server=" +textBox4.Text + ",3306;uid=root;" +
    "pwd=zxcv5716;database=book;";
            new MSql().Sql_Set(textBox4.Text);
            MessageBox.Show("設定完成");
        }
    } // EndOfClass
}
    

