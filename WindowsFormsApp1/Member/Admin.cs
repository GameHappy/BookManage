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

        private void AllGroupHide()
        {
            LeaseBook_Group.Visible = false;
           // ReturnBook_Group.Visible = false;
           // LeaseStatus_Group.Visible = false;
           // OverdueBook_Group.Visible = false;
        }
        private void LeaseBook_Click(object sender, EventArgs e)
        {
            LeaseBook_Group.Visible = true;
            LeaseBook_Group.Location = new Point(90, 10);
            LeaseBook_btnF.Enabled = false;
            LeaseBook_btnM.Text = "確認";
            LeaseBook_btnB.Text = "確認";
            LeaseBook_txt1.Enabled = true;
            LeaseBook_txt2.Enabled = true;
            LeaseBook_lab3.Text = "";
            LeaseBook_lab4.Text = "";
            LeaseBook_btnF.Enabled = false;
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
                    LeaseBook_lab3.Text = "會員名稱:" + MD[2] + "\n電子郵件:" + MD[1] + "\n電話號碼:" + MD[4];
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
            Admin_Update();
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
                    LeaseBook_lab4.Text = "作者:" + BD[1] + "\n出版社:" + BD[2] + "\n價格:" + BD[4] + "\nISBN:" + BD[5] + "\n分類:" + BD[6];
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
            Admin_Update();
        }

        private void LeaseBook_btnF_Click(object sender, EventArgs e)
        {
            int RadioIndex=0;//3,7,14
            if (LeaseRadio1.Checked) RadioIndex = 3;
            if (LeaseRadio2.Checked) RadioIndex = 7;
            if (LeaseRadio3.Checked) RadioIndex = 14;
            
            string Lease_UserAccount = LeaseBook_txt1.Text;
            string Lease_BookName = LeaseBook_txt2.Text;
            DateTime Lease_Time = DateTime.Now;
            DateTime Return_Time = Lease_Time.AddDays(RadioIndex);
            if (RadioIndex == 0)
            {
                MessageBox.Show("請選擇租期");
            }
            else new MSql().Insert_4_Tsql_InsertLeaseBook(Lease_UserAccount, Lease_BookName, Lease_Time, Return_Time);
            /*
             * PublicationDate_Picker1.Format = DateTimePickerFormat.Custom;
                PublicationDate_Picker2.Format = DateTimePickerFormat.Custom;
                PublicationDate_Picker1.CustomFormat = "yyyy/MM/dd";
                PublicationDate_Picker2.CustomFormat = "yyyy/MM/dd";
             * */

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AllGroupHide();
        }
        private void Admin_Update()
        {
            if (LeaseBook_btnM.Text == "取消" && LeaseBook_btnB.Text == "取消")
                LeaseBook_btnF.Enabled = true;
            else LeaseBook_btnF.Enabled = false;
        }
    }
}
