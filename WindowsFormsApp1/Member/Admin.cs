using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Member
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void LeaseBook_Click(object sender, EventArgs e)
        {
            LeaseBook_Group.Location = new Point(90, 10);
            LeaseBook_btnF.Enabled = false;
            LeaseBook_btnM.Text = "確認";
            LeaseBook_btnB.Text = "確認";
            LeaseBook_txt1.Enabled = true;
            LeaseBook_txt2.Enabled = true;
            LeaseBook_lab3.Text = "";
            LeaseBook_lab4.Text = "";
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {

        }

        private void LeaseStatus_Click(object sender, EventArgs e)
        {

        }

        private void OverdueBook_Click(object sender, EventArgs e)
        {

        }

        private void LeaseBook_btnM_Click(object sender, EventArgs e)
        {
            if (LeaseBook_btnM.Text == "確認")
            {
                string MemberData = new MSql().Select_5_Tsql_SearchMember(LeaseBook_txt1.Text);
                if (MemberData != "")
                {
                    string[] MD = new string[0];
                    MD = MemberData.Split('|');
                    LeaseBook_lab3.Text = "會員名稱:" + MD[1] + "\n電子郵件:" + MD[0] + "\n電話號碼:" + MD[2];
                    LeaseBook_txt1.Enabled = false;
                    LeaseBook_btnM.Text = "取消";
                }
                else
                {
                    MessageBox.Show("找不到用戶");
                }
                
            }
            else
            {
                LeaseBook_txt1.Enabled = true;
                LeaseBook_lab3.Text = "";
                LeaseBook_btnM.Text = "確認";
            }
            
        }

        private void LeaseBook_btnB_Click(object sender, EventArgs e)
        {
            if (LeaseBook_btnB.Text == "確認")
            {
                string BookData = new MSql().Select_6_Tsql_SearchBook(LeaseBook_txt2.Text);
                if (BookData != "")
                {
                    string[] BD = new string[0];
                    BD = BookData.Split('|');
                    LeaseBook_lab4.Text = "會員名稱:" + BD[1] + "\n電子郵件:" + BD[0] + "\n電話號碼:" + BD[2];
                    LeaseBook_txt2.Enabled = false;
                    LeaseBook_btnB.Text = "取消";
                }
                else
                {
                    MessageBox.Show("找不到書名");
                }

            }
            else
            {
                LeaseBook_txt2.Enabled = true;
                LeaseBook_lab4.Text = "";
                LeaseBook_btnB.Text = "確認";
            }
        }

        private void LeaseBook_btnF_Click(object sender, EventArgs e)
        {

        }
    }
}
