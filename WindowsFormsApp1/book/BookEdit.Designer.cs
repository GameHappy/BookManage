
namespace WindowsFormsApp1.book
{
    partial class BookEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Insert_Book_Group = new System.Windows.Forms.GroupBox();
            this.Insert_Class = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_Book_Group = new System.Windows.Forms.GroupBox();
            this.edit_Class = new System.Windows.Forms.ComboBox();
            this.bookedit_delete = new System.Windows.Forms.Button();
            this.bookedit_Finish = new System.Windows.Forms.Button();
            this.edit_publicationDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.edit_ISBN = new System.Windows.Forms.TextBox();
            this.bookedit_index = new System.Windows.Forms.Button();
            this.edit_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edit_publisher = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edit_writer = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Edit_Class_Group = new System.Windows.Forms.GroupBox();
            this.Class_Finish = new System.Windows.Forms.Button();
            this.Class_Button_Delete = new System.Windows.Forms.Button();
            this.Class_Button_Down = new System.Windows.Forms.Button();
            this.Class_Button_Up = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Class_Button1 = new System.Windows.Forms.Button();
            this.Class_TextBox1 = new System.Windows.Forms.TextBox();
            this.Class_Label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Insert_Book_Group.SuspendLayout();
            this.Edit_Book_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Edit_Class_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "新增書籍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改書籍";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Insert_Book_Group
            // 
            this.Insert_Book_Group.Controls.Add(this.Insert_Class);
            this.Insert_Book_Group.Controls.Add(this.button4);
            this.Insert_Book_Group.Controls.Add(this.dateTimePicker1);
            this.Insert_Book_Group.Controls.Add(this.textBox6);
            this.Insert_Book_Group.Controls.Add(this.textBox5);
            this.Insert_Book_Group.Controls.Add(this.textBox3);
            this.Insert_Book_Group.Controls.Add(this.textBox2);
            this.Insert_Book_Group.Controls.Add(this.textBox1);
            this.Insert_Book_Group.Controls.Add(this.label7);
            this.Insert_Book_Group.Controls.Add(this.label6);
            this.Insert_Book_Group.Controls.Add(this.label5);
            this.Insert_Book_Group.Controls.Add(this.label4);
            this.Insert_Book_Group.Controls.Add(this.label3);
            this.Insert_Book_Group.Controls.Add(this.label2);
            this.Insert_Book_Group.Controls.Add(this.label1);
            this.Insert_Book_Group.Location = new System.Drawing.Point(668, 19);
            this.Insert_Book_Group.Name = "Insert_Book_Group";
            this.Insert_Book_Group.Size = new System.Drawing.Size(313, 333);
            this.Insert_Book_Group.TabIndex = 2;
            this.Insert_Book_Group.TabStop = false;
            // 
            // Insert_Class
            // 
            this.Insert_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Insert_Class.FormattingEnabled = true;
            this.Insert_Class.Location = new System.Drawing.Point(76, 197);
            this.Insert_Class.Name = "Insert_Class";
            this.Insert_Class.Size = new System.Drawing.Size(121, 20);
            this.Insert_Class.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "加入";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(76, 167);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(122, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(76, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "分類";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "價格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "出版日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "出版社";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "作者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名稱";
            // 
            // Edit_Book_Group
            // 
            this.Edit_Book_Group.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Book_Group.Controls.Add(this.edit_Class);
            this.Edit_Book_Group.Controls.Add(this.bookedit_delete);
            this.Edit_Book_Group.Controls.Add(this.bookedit_Finish);
            this.Edit_Book_Group.Controls.Add(this.edit_publicationDate);
            this.Edit_Book_Group.Controls.Add(this.label9);
            this.Edit_Book_Group.Controls.Add(this.edit_ISBN);
            this.Edit_Book_Group.Controls.Add(this.bookedit_index);
            this.Edit_Book_Group.Controls.Add(this.edit_Price);
            this.Edit_Book_Group.Controls.Add(this.label10);
            this.Edit_Book_Group.Controls.Add(this.edit_publisher);
            this.Edit_Book_Group.Controls.Add(this.label11);
            this.Edit_Book_Group.Controls.Add(this.edit_writer);
            this.Edit_Book_Group.Controls.Add(this.textBox4);
            this.Edit_Book_Group.Controls.Add(this.edit_name);
            this.Edit_Book_Group.Controls.Add(this.label12);
            this.Edit_Book_Group.Controls.Add(this.label8);
            this.Edit_Book_Group.Controls.Add(this.label13);
            this.Edit_Book_Group.Controls.Add(this.dataGridView1);
            this.Edit_Book_Group.Controls.Add(this.label14);
            this.Edit_Book_Group.Controls.Add(this.label15);
            this.Edit_Book_Group.Location = new System.Drawing.Point(93, 12);
            this.Edit_Book_Group.Name = "Edit_Book_Group";
            this.Edit_Book_Group.Size = new System.Drawing.Size(569, 540);
            this.Edit_Book_Group.TabIndex = 4;
            this.Edit_Book_Group.TabStop = false;
            // 
            // edit_Class
            // 
            this.edit_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edit_Class.FormattingEnabled = true;
            this.edit_Class.Location = new System.Drawing.Point(297, 475);
            this.edit_Class.Name = "edit_Class";
            this.edit_Class.Size = new System.Drawing.Size(121, 20);
            this.edit_Class.TabIndex = 27;
            // 
            // bookedit_delete
            // 
            this.bookedit_delete.Enabled = false;
            this.bookedit_delete.Location = new System.Drawing.Point(286, 499);
            this.bookedit_delete.Name = "bookedit_delete";
            this.bookedit_delete.Size = new System.Drawing.Size(39, 23);
            this.bookedit_delete.TabIndex = 24;
            this.bookedit_delete.Text = "刪除";
            this.bookedit_delete.UseVisualStyleBackColor = true;
            this.bookedit_delete.Click += new System.EventHandler(this.bookedit_delete_Click);
            // 
            // bookedit_Finish
            // 
            this.bookedit_Finish.Enabled = false;
            this.bookedit_Finish.Location = new System.Drawing.Point(241, 499);
            this.bookedit_Finish.Name = "bookedit_Finish";
            this.bookedit_Finish.Size = new System.Drawing.Size(39, 23);
            this.bookedit_Finish.TabIndex = 23;
            this.bookedit_Finish.Text = "修改";
            this.bookedit_Finish.UseVisualStyleBackColor = true;
            this.bookedit_Finish.Click += new System.EventHandler(this.bookedit_Finish_Click);
            // 
            // edit_publicationDate
            // 
            this.edit_publicationDate.Location = new System.Drawing.Point(93, 503);
            this.edit_publicationDate.Name = "edit_publicationDate";
            this.edit_publicationDate.Size = new System.Drawing.Size(122, 22);
            this.edit_publicationDate.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "分類";
            // 
            // edit_ISBN
            // 
            this.edit_ISBN.Location = new System.Drawing.Point(297, 441);
            this.edit_ISBN.Name = "edit_ISBN";
            this.edit_ISBN.Size = new System.Drawing.Size(122, 22);
            this.edit_ISBN.TabIndex = 20;
            // 
            // bookedit_index
            // 
            this.bookedit_index.Location = new System.Drawing.Point(173, 379);
            this.bookedit_index.Name = "bookedit_index";
            this.bookedit_index.Size = new System.Drawing.Size(42, 23);
            this.bookedit_index.TabIndex = 3;
            this.bookedit_index.Text = "確認";
            this.bookedit_index.UseVisualStyleBackColor = true;
            this.bookedit_index.Click += new System.EventHandler(this.bookedit_index_Click);
            // 
            // edit_Price
            // 
            this.edit_Price.Location = new System.Drawing.Point(297, 411);
            this.edit_Price.Name = "edit_Price";
            this.edit_Price.Size = new System.Drawing.Size(122, 22);
            this.edit_Price.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "ISBN";
            // 
            // edit_publisher
            // 
            this.edit_publisher.Location = new System.Drawing.Point(93, 473);
            this.edit_publisher.Name = "edit_publisher";
            this.edit_publisher.Size = new System.Drawing.Size(122, 22);
            this.edit_publisher.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "價格";
            // 
            // edit_writer
            // 
            this.edit_writer.Location = new System.Drawing.Point(93, 441);
            this.edit_writer.Name = "edit_writer";
            this.edit_writer.Size = new System.Drawing.Size(122, 22);
            this.edit_writer.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 379);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 22);
            this.textBox4.TabIndex = 2;
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(93, 411);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(122, 22);
            this.edit_name.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "出版日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "請輸入要修改的編號";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "出版社";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 17;
            this.label14.Text = "作者";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "名稱";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "管理分類";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Edit_Class_Group
            // 
            this.Edit_Class_Group.Controls.Add(this.Class_Finish);
            this.Edit_Class_Group.Controls.Add(this.Class_Button_Delete);
            this.Edit_Class_Group.Controls.Add(this.Class_Button_Down);
            this.Edit_Class_Group.Controls.Add(this.Class_Button_Up);
            this.Edit_Class_Group.Controls.Add(this.listBox1);
            this.Edit_Class_Group.Controls.Add(this.Class_Button1);
            this.Edit_Class_Group.Controls.Add(this.Class_TextBox1);
            this.Edit_Class_Group.Controls.Add(this.Class_Label1);
            this.Edit_Class_Group.Controls.Add(this.dataGridView2);
            this.Edit_Class_Group.Location = new System.Drawing.Point(93, 19);
            this.Edit_Class_Group.Name = "Edit_Class_Group";
            this.Edit_Class_Group.Size = new System.Drawing.Size(298, 267);
            this.Edit_Class_Group.TabIndex = 6;
            this.Edit_Class_Group.TabStop = false;
            // 
            // Class_Finish
            // 
            this.Class_Finish.Location = new System.Drawing.Point(203, 170);
            this.Class_Finish.Name = "Class_Finish";
            this.Class_Finish.Size = new System.Drawing.Size(49, 23);
            this.Class_Finish.TabIndex = 33;
            this.Class_Finish.Text = "覆蓋";
            this.Class_Finish.UseVisualStyleBackColor = true;
            this.Class_Finish.Click += new System.EventHandler(this.Class_Finish_Click);
            // 
            // Class_Button_Delete
            // 
            this.Class_Button_Delete.Location = new System.Drawing.Point(227, 107);
            this.Class_Button_Delete.Name = "Class_Button_Delete";
            this.Class_Button_Delete.Size = new System.Drawing.Size(25, 25);
            this.Class_Button_Delete.TabIndex = 32;
            this.Class_Button_Delete.Text = "刪";
            this.Class_Button_Delete.UseVisualStyleBackColor = true;
            this.Class_Button_Delete.Click += new System.EventHandler(this.Class_Button_Delete_Click);
            // 
            // Class_Button_Down
            // 
            this.Class_Button_Down.Location = new System.Drawing.Point(227, 139);
            this.Class_Button_Down.Name = "Class_Button_Down";
            this.Class_Button_Down.Size = new System.Drawing.Size(25, 25);
            this.Class_Button_Down.TabIndex = 31;
            this.Class_Button_Down.Text = "下";
            this.Class_Button_Down.UseVisualStyleBackColor = true;
            this.Class_Button_Down.Click += new System.EventHandler(this.Class_Button_Down_Click);
            // 
            // Class_Button_Up
            // 
            this.Class_Button_Up.Location = new System.Drawing.Point(227, 76);
            this.Class_Button_Up.Name = "Class_Button_Up";
            this.Class_Button_Up.Size = new System.Drawing.Size(25, 25);
            this.Class_Button_Up.TabIndex = 30;
            this.Class_Button_Up.Text = "上";
            this.Class_Button_Up.UseVisualStyleBackColor = true;
            this.Class_Button_Up.Click += new System.EventHandler(this.Class_Button_Up_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(146, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 88);
            this.listBox1.TabIndex = 29;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Class_Button1
            // 
            this.Class_Button1.Location = new System.Drawing.Point(146, 46);
            this.Class_Button1.Name = "Class_Button1";
            this.Class_Button1.Size = new System.Drawing.Size(41, 23);
            this.Class_Button1.TabIndex = 28;
            this.Class_Button1.Text = "新增";
            this.Class_Button1.UseVisualStyleBackColor = true;
            this.Class_Button1.Click += new System.EventHandler(this.Class_Button1_Click);
            // 
            // Class_TextBox1
            // 
            this.Class_TextBox1.Location = new System.Drawing.Point(203, 17);
            this.Class_TextBox1.Name = "Class_TextBox1";
            this.Class_TextBox1.Size = new System.Drawing.Size(83, 22);
            this.Class_TextBox1.TabIndex = 27;
            // 
            // Class_Label1
            // 
            this.Class_Label1.AutoSize = true;
            this.Class_Label1.Location = new System.Drawing.Point(144, 22);
            this.Class_Label1.Name = "Class_Label1";
            this.Class_Label1.Size = new System.Drawing.Size(53, 12);
            this.Class_Label1.TabIndex = 26;
            this.Class_Label1.Text = "類別名稱";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(134, 232);
            this.dataGridView2.TabIndex = 25;
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 1061);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Edit_Class_Group);
            this.Controls.Add(this.Edit_Book_Group);
            this.Controls.Add(this.Insert_Book_Group);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "BookEdit";
            this.Text = "BookEdit";
            this.Load += new System.EventHandler(this.BookEdit_Load);
            this.Insert_Book_Group.ResumeLayout(false);
            this.Insert_Book_Group.PerformLayout();
            this.Edit_Book_Group.ResumeLayout(false);
            this.Edit_Book_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Edit_Class_Group.ResumeLayout(false);
            this.Edit_Class_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Insert_Book_Group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Edit_Book_Group;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bookedit_index;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker edit_publicationDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edit_ISBN;
        private System.Windows.Forms.TextBox edit_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edit_publisher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edit_writer;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bookedit_Finish;
        private System.Windows.Forms.Button bookedit_delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox Edit_Class_Group;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Class_Button1;
        private System.Windows.Forms.TextBox Class_TextBox1;
        private System.Windows.Forms.Label Class_Label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Class_Button_Delete;
        private System.Windows.Forms.Button Class_Button_Down;
        private System.Windows.Forms.Button Class_Button_Up;
        private System.Windows.Forms.Button Class_Finish;
        private System.Windows.Forms.ComboBox edit_Class;
        private System.Windows.Forms.ComboBox Insert_Class;
    }
}