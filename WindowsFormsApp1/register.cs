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
                
            r_email = textBox1.Text;
            r_account = textBox2.Text;
            r_password = textBox3.Text;
            if (new MSql().Select_3_Tsql_EnterAccount(r_email, r_account))
            {
                new MSql().Insert_0_Tsql_InsertAccount(r_email, r_account, r_password);
                MessageBox.Show("註冊完成");
                this.Close();
            }
        }
     

        private void buttoncheck()
        {
            bool _key = true;
            if (textBox3.Text != textBox4.Text) _key = false;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") _key = false;
            button1.Enabled = _key;
        }

        new private void TextChanged(object sender, EventArgs e)
        {
            buttoncheck();
        }

    }
}
