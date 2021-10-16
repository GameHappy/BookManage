using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.book
{
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }
        private string SQL_Code;
        private static CheckBox[] CB = new CheckBox[8];
        private void BookSearch_Load(object sender, EventArgs e)
        {
            Update_Filter();

            {
                for (int i = 0; i < CB.Length; i++)
                {
                    CB[i] = new CheckBox();
                    //CB[i].Appearance = Appearance.Button;
                    CB[i].Location = new Point(10, 30 + i * 30);
                    CB[i].Width = 80;
                    CB[i].CheckedChanged += new EventHandler(cb_filter_changed);
                }
                {
                    CB[0].Text = "編號";
                    CB[1].Text = "名稱";
                    CB[2].Text = "作者";
                    CB[3].Text = "出版社";
                    CB[4].Text = "出版日期";
                    CB[5].Text = "原始價格";
                    CB[6].Text = "ISBN";
                    CB[7].Text = "分類";
                }//CheckBox名稱設定
                Controls.AddRange(CB);
            }//CheckBox篩選物件
            {
                Button btn_filter = new Button();
                btn_filter.Location = new Point(10, CB.Length * 30 + 30);
                btn_filter.Size = new Size(50, 30);
                btn_filter.Text = "確認";
                btn_filter.Click += new EventHandler(btn_filter_click);
                Controls.Add(btn_filter);
            }//Button篩選物件
            {
                PublicationDate_Picker1.Format = DateTimePickerFormat.Custom;
                PublicationDate_Picker2.Format = DateTimePickerFormat.Custom;
                PublicationDate_Picker1.CustomFormat = "yyyy/MM/dd";
                PublicationDate_Picker2.CustomFormat = "yyyy/MM/dd";
            }//出版日期設定
            {
                Class_list.Items.Clear();
                Class_list.Items.AddRange(new MSql().Select_2_Tsql_ListClass().Split('|'));
            }//類別
        }
        private void check_SearchID(object sender) {

            ID_num.Enabled = true;
            if (sender is Button)
            {
                SQL_Code += "編號 = " + ID_num.Value.ToString() + " or ";
            }
        }
        private void check_SearchName(object sender) {
            Name_Text.Enabled = true;
            if (sender is Button)
            {
                SQL_Code += "名稱 = '" + Name_Text.Text + "' or ";
            }
        }
        private void check_SearchWriter(object sender) { 
            Writer_Text.Enabled = true;
            if (sender is Button)
            {
                SQL_Code += "作者 = '" + Writer_Text.Text + "' or ";
            }
        }
        private void check_SearchPublisher(object sender) { 
            Publisher_text.Enabled = true;
            if (sender is Button)
            {
                SQL_Code += "出版社 = '" + Publisher_text.Text + "' or ";
            }
        }
        private void check_SearchPublicationDate(object sender) {
            PublicationDate_Picker1.Enabled = true;
            PublicationDate_Picker2.Enabled = true;
            PublicationDate_Picker1.Format = DateTimePickerFormat.Custom;
            PublicationDate_Picker2.Format = DateTimePickerFormat.Custom;
            

            
            if (sender is Button)
            {
                PublicationDate_Picker1.CustomFormat = "yyyyMMdd";
                PublicationDate_Picker2.CustomFormat = "yyyyMMdd";
                string D1 = PublicationDate_Picker1.Text;
                string D2 = PublicationDate_Picker2.Text;
                PublicationDate_Picker1.CustomFormat = "yyyy/MM/dd";
                PublicationDate_Picker2.CustomFormat = "yyyy/MM/dd";
                SQL_Code += "出版日期 >= '" + D1 + "' and 出版日期 <= '" + D2 + "' or ";
            }
        }
        private void check_SearchPrice(object sender) {
            Price_num.Enabled = true;
            Price_num2.Enabled = true;
            if (sender is Button)
            {
                SQL_Code += "價格 >= " + Price_num.Value.ToString() + " and 價格 <=" + Price_num2.Value.ToString() + " or ";
            }
        }
        private void check_SearchISBN(object sender) {
            ISBN_text.Enabled = true;
            if (sender is Button)
            {
                SQL_Code += "ISBN = '" + ISBN_text.Text + "' or ";
            }
        }
        private void check_SearchClass(object sender) {
            Class_list.Enabled = true;
            if (sender is Button)
            {
                SQL_Code += "分類 = " + (Class_list.SelectedIndex + 1).ToString() + " or ";
            }
        }

        private void Update_Filter()
        {
            SQL_Code = "SELECT * FROM tabbook WHERE ";
            ID_num.Enabled = false;
            Name_Text.Enabled =  false;
            Writer_Text.Enabled = false;
            Publisher_text.Enabled = false;
            PublicationDate_Picker1.Enabled = false;
            PublicationDate_Picker2.Enabled = false;
            Price_num.Enabled = false;
            Price_num2.Enabled = false;
            ISBN_text.Enabled = false;
            Class_list.Enabled = false;

        }

        protected void cb_filter_changed(object sender,EventArgs e)
        {
            Update_Filter();
            if (CB[0].Checked) { check_SearchID(sender); }
            if (CB[1].Checked) { check_SearchName(sender); }
            if (CB[2].Checked) { check_SearchWriter(sender); }
            if (CB[3].Checked) { check_SearchPublisher(sender); }
            if (CB[4].Checked) { check_SearchPublicationDate(sender);
                PublicationDate_Picker1.Value = PublicationDate_Picker1.MinDate;
                PublicationDate_Picker2.Value = DateTime.Now;
            }
            if (CB[5].Checked) { check_SearchPrice(sender); }
            if (CB[6].Checked) { check_SearchISBN(sender); }
            if (CB[7].Checked) { check_SearchClass(sender); }
            
        }
        protected void btn_filter_click(object sender,EventArgs e)
        {
            Update_Filter();
            if (CB[0].Checked) { check_SearchID(sender);}
            if (CB[1].Checked) { check_SearchName(sender); }
            if (CB[2].Checked) { check_SearchWriter(sender); }
            if (CB[3].Checked) { check_SearchPublisher(sender); }
            if (CB[4].Checked) { check_SearchPublicationDate(sender); }
            if (CB[5].Checked) { check_SearchPrice(sender); }
            if (CB[6].Checked) { check_SearchISBN(sender); }
            if (CB[7].Checked) { check_SearchClass(sender); }
            if (SQL_Code.Length <= (28)) { SQL_Code = "SELECT * FROM tabbook"; }
            else {SQL_Code = SQL_Code.Substring(0, SQL_Code.Length - 3); }
            
            new book.BookSearch_Finish().Get_SQL_Code(SQL_Code);
            new book.BookSearch_Finish().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
