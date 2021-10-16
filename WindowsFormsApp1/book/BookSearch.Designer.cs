
namespace WindowsFormsApp1.book
{
    partial class BookSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID_num = new System.Windows.Forms.NumericUpDown();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Writer_Text = new System.Windows.Forms.TextBox();
            this.Publisher_text = new System.Windows.Forms.TextBox();
            this.PublicationDate_Picker1 = new System.Windows.Forms.DateTimePicker();
            this.PublicationDate_Picker2 = new System.Windows.Forms.DateTimePicker();
            this.Price_num = new System.Windows.Forms.NumericUpDown();
            this.Price_num2 = new System.Windows.Forms.NumericUpDown();
            this.ISBN_text = new System.Windows.Forms.TextBox();
            this.PublicationDate_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Class_list = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ID_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_num2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜尋條件";
            // 
            // ID_num
            // 
            this.ID_num.Location = new System.Drawing.Point(110, 30);
            this.ID_num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ID_num.Name = "ID_num";
            this.ID_num.Size = new System.Drawing.Size(48, 22);
            this.ID_num.TabIndex = 1;
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(110, 60);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(100, 22);
            this.Name_Text.TabIndex = 2;
            // 
            // Writer_Text
            // 
            this.Writer_Text.Location = new System.Drawing.Point(110, 90);
            this.Writer_Text.Name = "Writer_Text";
            this.Writer_Text.Size = new System.Drawing.Size(100, 22);
            this.Writer_Text.TabIndex = 3;
            // 
            // Publisher_text
            // 
            this.Publisher_text.Location = new System.Drawing.Point(110, 120);
            this.Publisher_text.Name = "Publisher_text";
            this.Publisher_text.Size = new System.Drawing.Size(100, 22);
            this.Publisher_text.TabIndex = 4;
            // 
            // PublicationDate_Picker1
            // 
            this.PublicationDate_Picker1.Location = new System.Drawing.Point(110, 150);
            this.PublicationDate_Picker1.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.PublicationDate_Picker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PublicationDate_Picker1.Name = "PublicationDate_Picker1";
            this.PublicationDate_Picker1.Size = new System.Drawing.Size(121, 22);
            this.PublicationDate_Picker1.TabIndex = 5;
            // 
            // PublicationDate_Picker2
            // 
            this.PublicationDate_Picker2.Location = new System.Drawing.Point(254, 150);
            this.PublicationDate_Picker2.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.PublicationDate_Picker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PublicationDate_Picker2.Name = "PublicationDate_Picker2";
            this.PublicationDate_Picker2.Size = new System.Drawing.Size(121, 22);
            this.PublicationDate_Picker2.TabIndex = 6;
            // 
            // Price_num
            // 
            this.Price_num.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Price_num.Location = new System.Drawing.Point(110, 180);
            this.Price_num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Price_num.Name = "Price_num";
            this.Price_num.Size = new System.Drawing.Size(60, 22);
            this.Price_num.TabIndex = 7;
            // 
            // Price_num2
            // 
            this.Price_num2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Price_num2.Location = new System.Drawing.Point(193, 180);
            this.Price_num2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Price_num2.Name = "Price_num2";
            this.Price_num2.Size = new System.Drawing.Size(60, 22);
            this.Price_num2.TabIndex = 8;
            // 
            // ISBN_text
            // 
            this.ISBN_text.Location = new System.Drawing.Point(110, 210);
            this.ISBN_text.Name = "ISBN_text";
            this.ISBN_text.Size = new System.Drawing.Size(100, 22);
            this.ISBN_text.TabIndex = 9;
            // 
            // PublicationDate_Label
            // 
            this.PublicationDate_Label.AutoSize = true;
            this.PublicationDate_Label.Location = new System.Drawing.Point(237, 157);
            this.PublicationDate_Label.Name = "PublicationDate_Label";
            this.PublicationDate_Label.Size = new System.Drawing.Size(11, 12);
            this.PublicationDate_Label.TabIndex = 11;
            this.PublicationDate_Label.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "~";
            // 
            // Class_list
            // 
            this.Class_list.FormattingEnabled = true;
            this.Class_list.Location = new System.Drawing.Point(110, 240);
            this.Class_list.Name = "Class_list";
            this.Class_list.Size = new System.Drawing.Size(77, 20);
            this.Class_list.TabIndex = 13;
            this.Class_list.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 409);
            this.Controls.Add(this.Class_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PublicationDate_Label);
            this.Controls.Add(this.ISBN_text);
            this.Controls.Add(this.Price_num2);
            this.Controls.Add(this.Price_num);
            this.Controls.Add(this.PublicationDate_Picker2);
            this.Controls.Add(this.PublicationDate_Picker1);
            this.Controls.Add(this.Publisher_text);
            this.Controls.Add(this.Writer_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.ID_num);
            this.Controls.Add(this.label1);
            this.Name = "BookSearch";
            this.Text = "BookSearch";
            this.Load += new System.EventHandler(this.BookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ID_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ID_num;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox Writer_Text;
        private System.Windows.Forms.TextBox Publisher_text;
        private System.Windows.Forms.DateTimePicker PublicationDate_Picker1;
        private System.Windows.Forms.DateTimePicker PublicationDate_Picker2;
        private System.Windows.Forms.NumericUpDown Price_num;
        private System.Windows.Forms.NumericUpDown Price_num2;
        private System.Windows.Forms.TextBox ISBN_text;
        private System.Windows.Forms.Label PublicationDate_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Class_list;
    }
}