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
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();
        }

        private void HideAllGroup()
        {
            Insert_Book_Group.Visible = false;
            Edit_Book_Group.Visible = false;
            Edit_Class_Group.Visible = false;
            Insert_Book_Group.Location = new Point(100, 10);
            Edit_Book_Group.Location = new Point(100, 10);
            Edit_Class_Group.Location = new Point(100, 10);
            Insert_Book_Group.Size = new Size(270, 380);
            Edit_Book_Group.Size = new Size(270, 380);
            Edit_Class_Group.Size = new Size(300, 380);
        }
        private void UpdateSqlForDataGrid(int _index)
        {
            if (_index == 1)
            {
                dataGridView1.Dock = DockStyle.None;
                dataGridView1.DataSource = new MSql().SelectDataSource("SELECT * FROM tabbook");
            }
            else
            {
                dataGridView2.Dock = DockStyle.None;
                dataGridView2.DataSource = new MSql().SelectDataSource("SELECT * FROM tabclass");
            }
        }
        
        //物件導向
        private void button4_Click(object sender, EventArgs e)
        {
            
            new WindowsFormsApp1.MSql().Insert_1_Tsql_InsertTables(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, int.Parse( textBox5.Text), textBox6.Text, int.Parse( Insert_Class.Items[Insert_Class.SelectedIndex].ToString()));
           
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {
            this.Width = 440;this.Height = 400;
            HideAllGroup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 440; this.Height = 400;
            HideAllGroup();
            Insert_Book_Group.Visible = true;
            Insert_Class.Items.Clear();
            Insert_Class.Items.AddRange(new MSql().Select_2_Tsql_ListClass().Split('|'));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HideAllGroup();
            Edit_Book_Group.Visible = true;
            UpdateSqlForDataGrid(1);
            dataGridView1.Width = 600; dataGridView1.Height = 320;
           this.Width = 800; this.Height = 600;
            Edit_Book_Group.Size = new Size(800, 600);
            edit_Class.Items.Clear();
            edit_Class.Items.AddRange(new MSql().Select_2_Tsql_ListClass().Split('|'));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 440; this.Height = 400;
            HideAllGroup();
            Edit_Class_Group.Visible = true;
            UpdateSqlForDataGrid(2);
            dataGridView2.Width = 135;dataGridView2.Height = 400;
            dataGridView2.Columns[0].Width = 30;dataGridView2.Columns[1].Width = 60;

            Class_Button_Delete.Enabled = false; Class_Button_Down.Enabled = false; Class_Button_Up.Enabled = false;
            string[] listtext = new string[0];
            listtext = new MSql().Select_2_Tsql_ListClass().Split('|');
            listBox1.Items.Clear();
            listBox1.Items.AddRange(listtext);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedcellcount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            //MessageBox.Show(selectedcellcount.ToString());
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex ].Value.ToString());
            
        }

        private void bookedit_index_Click(object sender, EventArgs e)
        {
            if  (bookedit_index.Text == "確認")
            {
                //後端事件
                int _num = int.Parse(textBox4.Text);
                string _msg = new MSql().Select_1_Tsql_SearchID(_num);
                if (_msg != "null")
                {
                    string[] bookdata = new string[6];
                    bookdata = _msg.Split('|');

                    bookdata[3] = bookdata[3].Substring(0, 10).Replace(" ", "");
                    edit_name.Text = bookdata[0];
                    edit_writer.Text = bookdata[1];
                    edit_publisher.Text = bookdata[2];
                    edit_publicationDate.Value = DateTime.Parse(bookdata[3]);
                    edit_Price.Text = bookdata[4];
                    edit_ISBN.Text = bookdata[5];
                    edit_Class.SelectedIndex = int.Parse( bookdata[6])-1;

                    //該表單事件
                    textBox4.Enabled = false;
                    bookedit_index.Text = "取消";
                    bookedit_delete.Enabled = true;
                    bookedit_Finish.Enabled = true;
                }
            }
            else
            {

                textBox4.Enabled = true;
                bookedit_index.Text = "確認";
                bookedit_delete.Enabled = false;
                bookedit_Finish.Enabled = false;
            }
            
        }

        private void bookedit_Finish_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBox4.Text);
            
            string[] bookdata = new string[7];
            bookdata[0] = edit_name.Text;
            bookdata[1] = edit_writer.Text;
            bookdata[2] = edit_publisher.Text;
            bookdata[3] = edit_publicationDate.Value.ToString();
            bookdata[4] = edit_Price.Text;
            bookdata[5] = edit_ISBN.Text;
            bookdata[6] = (edit_Class.SelectedIndex + 1).ToString();

            bookdata[3] = bookdata[3].Substring(0, 10).Replace(" ", "");
            new MSql().Update_1_Tsql_UpdateTabBook(index,bookdata);
            button2_Click(sender, e);

        }

        private void bookedit_delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("確定要刪除資料?", "警告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                new MSql().Delete_1_Tsql_DeleteTabBook(int.Parse(textBox4.Text));
                MessageBox.Show("資料已刪除");
                button2_Click(sender,e);
            }
        }

        private void Class_Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Class_TextBox1.Text);
        }

        private void Class_Button_Up_Click(object sender, EventArgs e)
        {
            Class_ListSwap(listBox1.SelectedIndex, listBox1.SelectedIndex - 1);
        }

        private void Class_Button_Down_Click(object sender, EventArgs e)
        {
            Class_ListSwap(listBox1.SelectedIndex, listBox1.SelectedIndex + 1);
        }

        private void Class_Button_Delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Class_ListSwap(int indexA, int indexB)
        {
            string[] _list = new string[listBox1.Items.Count];
            for(int i = 0; i < _list.Length; i++)
            {
                _list[i] = listBox1.Items[i].ToString();
            }
            string _swap = _list[indexB]; _list[indexB] = _list[indexA]; _list[indexA] = _swap;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(_list);
            listBox1.SelectedIndex = indexB;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) { Class_Button_Delete.Enabled = true;Class_Button_Down.Enabled = true;Class_Button_Up.Enabled = true; }
            if (listBox1.SelectedIndex == 0) Class_Button_Up.Enabled = false; else Class_Button_Up.Enabled = true;
            if (listBox1.SelectedIndex == listBox1.Items.Count-1) Class_Button_Down.Enabled = false; else Class_Button_Down.Enabled = true;

        }

        private void Class_Finish_Click(object sender, EventArgs e)
        {
            new MSql().Build_2_Tsql_CreateClassTable();
            string[] _list = new string[listBox1.Items.Count];
            for (int i = 0; i < _list.Length; i++)
            {
                _list[i] = listBox1.Items[i].ToString();
            }
            new MSql().Insert_2_Tsql_InsertClass(_list);
            button3_Click(sender, e);
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }
    }
}
