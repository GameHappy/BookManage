
namespace WindowsFormsApp1
{
    partial class BookMain
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
            this.ADMIN_Group = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resetbutton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resetbutton2 = new System.Windows.Forms.Button();
            this.resetbutton3 = new System.Windows.Forms.Button();
            this.Member_Group = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ADMIN_Group.SuspendLayout();
            this.Member_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ADMIN_Group
            // 
            this.ADMIN_Group.BackColor = System.Drawing.SystemColors.Control;
            this.ADMIN_Group.Controls.Add(this.button3);
            this.ADMIN_Group.Controls.Add(this.button2);
            this.ADMIN_Group.Controls.Add(this.button1);
            this.ADMIN_Group.Location = new System.Drawing.Point(10, 10);
            this.ADMIN_Group.Name = "ADMIN_Group";
            this.ADMIN_Group.Size = new System.Drawing.Size(94, 256);
            this.ADMIN_Group.TabIndex = 1;
            this.ADMIN_Group.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "客戶訊息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "編輯書籍";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "查看書籍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetbutton1
            // 
            this.resetbutton1.Location = new System.Drawing.Point(218, 159);
            this.resetbutton1.Name = "resetbutton1";
            this.resetbutton1.Size = new System.Drawing.Size(103, 35);
            this.resetbutton1.TabIndex = 3;
            this.resetbutton1.Text = "重製書本資料庫";
            this.resetbutton1.UseVisualStyleBackColor = true;
            this.resetbutton1.Click += new System.EventHandler(this.resetbutton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 22);
            this.textBox1.TabIndex = 4;
            // 
            // resetbutton2
            // 
            this.resetbutton2.Location = new System.Drawing.Point(218, 195);
            this.resetbutton2.Name = "resetbutton2";
            this.resetbutton2.Size = new System.Drawing.Size(103, 35);
            this.resetbutton2.TabIndex = 5;
            this.resetbutton2.Text = "重製會員";
            this.resetbutton2.UseVisualStyleBackColor = true;
            this.resetbutton2.Click += new System.EventHandler(this.resetbutton2_Click);
            // 
            // resetbutton3
            // 
            this.resetbutton3.Location = new System.Drawing.Point(218, 233);
            this.resetbutton3.Name = "resetbutton3";
            this.resetbutton3.Size = new System.Drawing.Size(103, 35);
            this.resetbutton3.TabIndex = 6;
            this.resetbutton3.Text = "重製租借清單";
            this.resetbutton3.UseVisualStyleBackColor = true;
            this.resetbutton3.Click += new System.EventHandler(this.resetbutton3_Click);
            // 
            // Member_Group
            // 
            this.Member_Group.BackColor = System.Drawing.SystemColors.Control;
            this.Member_Group.Controls.Add(this.button6);
            this.Member_Group.Controls.Add(this.button7);
            this.Member_Group.Controls.Add(this.button8);
            this.Member_Group.Location = new System.Drawing.Point(110, 10);
            this.Member_Group.Name = "Member_Group";
            this.Member_Group.Size = new System.Drawing.Size(94, 256);
            this.Member_Group.TabIndex = 3;
            this.Member_Group.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 50);
            this.button6.TabIndex = 2;
            this.button6.Text = "訊息";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 50);
            this.button7.TabIndex = 1;
            this.button7.Text = "個人檔案";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 50);
            this.button8.TabIndex = 0;
            this.button8.Text = "查看書籍";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 275);
            this.Controls.Add(this.Member_Group);
            this.Controls.Add(this.resetbutton3);
            this.Controls.Add(this.resetbutton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resetbutton1);
            this.Controls.Add(this.ADMIN_Group);
            this.Controls.Add(this.label1);
            this.Name = "BookMain";
            this.Text = "BookMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookMain_FormClosing);
            this.Load += new System.EventHandler(this.BookMain_Load);
            this.ADMIN_Group.ResumeLayout(false);
            this.Member_Group.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ADMIN_Group;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetbutton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resetbutton2;
        private System.Windows.Forms.Button resetbutton3;
        private System.Windows.Forms.GroupBox Member_Group;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}