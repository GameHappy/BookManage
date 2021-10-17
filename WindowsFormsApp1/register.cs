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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string r_email, r_account, r_password;
            string r_name, r_gender, r_phone;
            bool r_admin = false;
                
            r_email = textBox1.Text;
            r_account = textBox2.Text;
            r_password = textBox3.Text;
            r_name = textBox5.Text;
            if (radioButton1.Checked) r_gender = "男"; else r_gender = "女";
            r_phone = textBox7.Text;
            if (textBox6.Text == "zxcv4715") r_admin = true;
            if (new MSql().Select_3_Tsql_EnterAccount(r_email, r_account))
            {
                new MSql().Insert_0_Tsql_InsertAccount(r_email, r_account, r_password);
                new MSql().Insert_3_Tsql_InsertMember(r_account,r_email,r_name,r_gender,r_phone,r_admin);
                MessageBox.Show("註冊完成");
                this.Close();
            }
        }
     

        private void buttoncheck()
        {
            bool _key = true;
            if (textBox3.Text != textBox4.Text) _key = false;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||  textBox7.Text == "") _key = false;
            if (radioButton1.Checked == false && radioButton2.Checked == false) _key = false;
            button1.Enabled = _key;
        }

        new private void TextChanged(object sender, EventArgs e)
        {
            buttoncheck();
        }

    }
}
