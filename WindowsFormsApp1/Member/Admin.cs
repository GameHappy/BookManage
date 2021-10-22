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

        private void AllGroupHide()
        {
            LeaseBook_Group.Visible = false;
            ReturnBook_Group.Visible = false;
            LeaseStatus_Group.Visible = false;
            OverdueBook_Group.Visible = false;
        }
        private void LeaseBook_Click(object sender, EventArgs e)
        {
            AllGroupHide();
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
            AllGroupHide();
            ReturnBook_Group.Visible = true;
            ReturnBook_Group.Location = new Point(90, 10);
            ReturnBook_btn2.Enabled = false;
        }

        private void LeaseStatus_Click(object sender, EventArgs e)
        {
            AllGroupHide();
            LeaseStatus_Group.Visible = true;
            LeaseStatus_Group.Location = new Point(90, 10);
            string SQL_Code = @"SELECT mem.名稱,lease.租借帳號,lease.名稱 書名,book.ISBN,lease.租借時間,lease.還期日
                                FROM tableasebook lease
                                INNER JOIN tabbook book,tabmember mem
                                WHERE mem.帳號=lease.租借帳號 AND book.名稱 = lease.名稱";
            LeaseStatus_dGV.DataSource = new MSql().SelectDataSource(SQL_Code);
            LeaseStatus_dGV.Columns[4].Width = 80; LeaseStatus_dGV.Columns[5].Width = 80;
        }

        private void OverdueBook_Click(object sender, EventArgs e)
        {
            AllGroupHide();
            OverdueBook_Group.Visible = true;
            OverdueBook_Group.Location = new Point(90, 10);
            string N_Time = DateTime.Now.ToString("yyyyMMdd");
            
            string SQL_Code = @"SELECT mem.名稱,lease.租借帳號,lease.名稱 書名,book.ISBN,lease.租借時間,lease.還期日
                                FROM tableasebook lease
                                INNER JOIN tabbook book,tabmember mem
                                WHERE mem.帳號=lease.租借帳號 AND book.名稱 = lease.名稱
                                AND lease.還期日 < '" + N_Time + "'";
            OverdueBook_dGV.DataSource = new MSql().SelectDataSource(SQL_Code);
            OverdueBook_dGV.Columns[4].Width = 80; OverdueBook_dGV.Columns[5].Width = 80;

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
            if (LeaseRadio1.Checked) RadioIndex = -1;
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

        
        private void ReturnBook_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReturnBook_btn1.Text == "確認")
                {
                    string SQL_Code = @"SELECT mem.名稱 租書人,lease.* 
                                        FROM tableasebook lease 
                                        INNER JOIN tabmember mem 
                                        WHERE mem.帳號=lease.租借帳號 AND( '" + ReturnBook_txt.Text + "' = mem.名稱  OR '" + ReturnBook_txt.Text + "' = lease.租借帳號)";
                    ReturnBook_dGV.DataSource = new MSql().SelectDataSource(SQL_Code);
                    //if (ReturnBook_datagrid.DataSource == null) {  }

                    ReturnBook_btn1.Text = "取消";
                    ReturnBook_btn2.Enabled = true;
                }
                else
                {
                    ReturnBook_btn1.Text = "確認";
                    ReturnBook_btn2.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void ReturnBook_btn2_Click(object sender, EventArgs e)
        {
            string SQL_Code = @"DELETE tableasebook 
                                FROM tabbook ,tabmember ,tableasebook
                                WHERE (tabmember.帳號 = tableasebook.租借帳號 AND tabbook.名稱 = tableasebook.名稱) 
                                AND ('" + ReturnBook_txt.Text + @"' = tabmember.名稱 OR '" + ReturnBook_txt.Text + @"' = tableasebook.租借帳號) 
                                AND ('" + ReturnBook_txt2.Text + @"' = tabbook.ISBN OR '" + ReturnBook_txt2.Text + @"' = tableasebook.名稱)";
            new MSql().Submit_Tsql_NonQuery(SQL_Code);
            ReturnBook_dGV.DataSource = new MSql().SelectDataSource(SQL_Code);

        }
    }
}
