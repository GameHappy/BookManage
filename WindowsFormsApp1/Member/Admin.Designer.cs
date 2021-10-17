
namespace WindowsFormsApp1.Member
{
    partial class Admin
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
            this.LeaseStatus_btn = new System.Windows.Forms.Button();
            this.OverdueBook_btn = new System.Windows.Forms.Button();
            this.LeaseBook_btn = new System.Windows.Forms.Button();
            this.ReturnBook_btn = new System.Windows.Forms.Button();
            this.LeaseBook_Group = new System.Windows.Forms.GroupBox();
            this.LeaseBook_btnB = new System.Windows.Forms.Button();
            this.LeaseBook_btnM = new System.Windows.Forms.Button();
            this.LeaseBook_btnF = new System.Windows.Forms.Button();
            this.LeaseBook_lab5 = new System.Windows.Forms.Label();
            this.LeaseRadio2 = new System.Windows.Forms.RadioButton();
            this.LeaseRadio1 = new System.Windows.Forms.RadioButton();
            this.LeaseRadio3 = new System.Windows.Forms.RadioButton();
            this.LeaseBook_lab4 = new System.Windows.Forms.Label();
            this.LeaseBook_txt2 = new System.Windows.Forms.TextBox();
            this.LeaseBook_lab2 = new System.Windows.Forms.Label();
            this.LeaseBook_lab3 = new System.Windows.Forms.Label();
            this.LeaseBook_txt1 = new System.Windows.Forms.TextBox();
            this.LeaseBook_lab1 = new System.Windows.Forms.Label();
            this.LeaseBook_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeaseStatus_btn
            // 
            this.LeaseStatus_btn.Location = new System.Drawing.Point(10, 130);
            this.LeaseStatus_btn.Name = "LeaseStatus_btn";
            this.LeaseStatus_btn.Size = new System.Drawing.Size(70, 23);
            this.LeaseStatus_btn.TabIndex = 0;
            this.LeaseStatus_btn.Text = "租借狀況";
            this.LeaseStatus_btn.UseVisualStyleBackColor = true;
            this.LeaseStatus_btn.Click += new System.EventHandler(this.LeaseStatus_Click);
            // 
            // OverdueBook_btn
            // 
            this.OverdueBook_btn.Location = new System.Drawing.Point(10, 180);
            this.OverdueBook_btn.Name = "OverdueBook_btn";
            this.OverdueBook_btn.Size = new System.Drawing.Size(70, 23);
            this.OverdueBook_btn.TabIndex = 1;
            this.OverdueBook_btn.Text = "逾期客戶";
            this.OverdueBook_btn.UseVisualStyleBackColor = true;
            this.OverdueBook_btn.Click += new System.EventHandler(this.OverdueBook_Click);
            // 
            // LeaseBook_btn
            // 
            this.LeaseBook_btn.Location = new System.Drawing.Point(10, 30);
            this.LeaseBook_btn.Name = "LeaseBook_btn";
            this.LeaseBook_btn.Size = new System.Drawing.Size(70, 23);
            this.LeaseBook_btn.TabIndex = 2;
            this.LeaseBook_btn.Text = "出租";
            this.LeaseBook_btn.UseVisualStyleBackColor = true;
            this.LeaseBook_btn.Click += new System.EventHandler(this.LeaseBook_Click);
            // 
            // ReturnBook_btn
            // 
            this.ReturnBook_btn.Location = new System.Drawing.Point(10, 80);
            this.ReturnBook_btn.Name = "ReturnBook_btn";
            this.ReturnBook_btn.Size = new System.Drawing.Size(70, 23);
            this.ReturnBook_btn.TabIndex = 3;
            this.ReturnBook_btn.Text = "還書";
            this.ReturnBook_btn.UseVisualStyleBackColor = true;
            this.ReturnBook_btn.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // LeaseBook_Group
            // 
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_btnB);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_btnM);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_btnF);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_lab5);
            this.LeaseBook_Group.Controls.Add(this.LeaseRadio2);
            this.LeaseBook_Group.Controls.Add(this.LeaseRadio1);
            this.LeaseBook_Group.Controls.Add(this.LeaseRadio3);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_lab4);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_txt2);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_lab2);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_lab3);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_txt1);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_lab1);
            this.LeaseBook_Group.Location = new System.Drawing.Point(90, 10);
            this.LeaseBook_Group.Name = "LeaseBook_Group";
            this.LeaseBook_Group.Size = new System.Drawing.Size(471, 215);
            this.LeaseBook_Group.TabIndex = 4;
            this.LeaseBook_Group.TabStop = false;
            // 
            // LeaseBook_btnB
            // 
            this.LeaseBook_btnB.Location = new System.Drawing.Point(330, 18);
            this.LeaseBook_btnB.Name = "LeaseBook_btnB";
            this.LeaseBook_btnB.Size = new System.Drawing.Size(38, 23);
            this.LeaseBook_btnB.TabIndex = 10;
            this.LeaseBook_btnB.Text = "確認";
            this.LeaseBook_btnB.UseVisualStyleBackColor = true;
            this.LeaseBook_btnB.Click += new System.EventHandler(this.LeaseBook_btnB_Click);
            // 
            // LeaseBook_btnM
            // 
            this.LeaseBook_btnM.Location = new System.Drawing.Point(146, 18);
            this.LeaseBook_btnM.Name = "LeaseBook_btnM";
            this.LeaseBook_btnM.Size = new System.Drawing.Size(38, 23);
            this.LeaseBook_btnM.TabIndex = 9;
            this.LeaseBook_btnM.Text = "確認";
            this.LeaseBook_btnM.UseVisualStyleBackColor = true;
            this.LeaseBook_btnM.Click += new System.EventHandler(this.LeaseBook_btnM_Click);
            // 
            // LeaseBook_btnF
            // 
            this.LeaseBook_btnF.Location = new System.Drawing.Point(416, 100);
            this.LeaseBook_btnF.Name = "LeaseBook_btnF";
            this.LeaseBook_btnF.Size = new System.Drawing.Size(49, 23);
            this.LeaseBook_btnF.TabIndex = 5;
            this.LeaseBook_btnF.Text = "租借";
            this.LeaseBook_btnF.UseVisualStyleBackColor = true;
            this.LeaseBook_btnF.Click += new System.EventHandler(this.LeaseBook_btnF_Click);
            // 
            // LeaseBook_lab5
            // 
            this.LeaseBook_lab5.AutoSize = true;
            this.LeaseBook_lab5.Location = new System.Drawing.Point(414, 19);
            this.LeaseBook_lab5.Name = "LeaseBook_lab5";
            this.LeaseBook_lab5.Size = new System.Drawing.Size(53, 12);
            this.LeaseBook_lab5.TabIndex = 8;
            this.LeaseBook_lab5.Text = "租借時間";
            // 
            // LeaseRadio2
            // 
            this.LeaseRadio2.AutoSize = true;
            this.LeaseRadio2.Location = new System.Drawing.Point(416, 56);
            this.LeaseRadio2.Name = "LeaseRadio2";
            this.LeaseRadio2.Size = new System.Drawing.Size(41, 16);
            this.LeaseRadio2.TabIndex = 7;
            this.LeaseRadio2.TabStop = true;
            this.LeaseRadio2.Text = "7天";
            this.LeaseRadio2.UseVisualStyleBackColor = true;
            // 
            // LeaseRadio1
            // 
            this.LeaseRadio1.AutoSize = true;
            this.LeaseRadio1.Location = new System.Drawing.Point(416, 34);
            this.LeaseRadio1.Name = "LeaseRadio1";
            this.LeaseRadio1.Size = new System.Drawing.Size(41, 16);
            this.LeaseRadio1.TabIndex = 6;
            this.LeaseRadio1.TabStop = true;
            this.LeaseRadio1.Text = "3天";
            this.LeaseRadio1.UseVisualStyleBackColor = true;
            // 
            // LeaseRadio3
            // 
            this.LeaseRadio3.AutoSize = true;
            this.LeaseRadio3.Location = new System.Drawing.Point(416, 78);
            this.LeaseRadio3.Name = "LeaseRadio3";
            this.LeaseRadio3.Size = new System.Drawing.Size(47, 16);
            this.LeaseRadio3.TabIndex = 6;
            this.LeaseRadio3.TabStop = true;
            this.LeaseRadio3.Text = "14天";
            this.LeaseRadio3.UseVisualStyleBackColor = true;
            // 
            // LeaseBook_lab4
            // 
            this.LeaseBook_lab4.AutoSize = true;
            this.LeaseBook_lab4.Location = new System.Drawing.Point(195, 50);
            this.LeaseBook_lab4.Name = "LeaseBook_lab4";
            this.LeaseBook_lab4.Size = new System.Drawing.Size(53, 12);
            this.LeaseBook_lab4.TabIndex = 5;
            this.LeaseBook_lab4.Text = "書本資訊";
            // 
            // LeaseBook_txt2
            // 
            this.LeaseBook_txt2.Location = new System.Drawing.Point(254, 18);
            this.LeaseBook_txt2.Name = "LeaseBook_txt2";
            this.LeaseBook_txt2.Size = new System.Drawing.Size(70, 22);
            this.LeaseBook_txt2.TabIndex = 4;
            // 
            // LeaseBook_lab2
            // 
            this.LeaseBook_lab2.AutoSize = true;
            this.LeaseBook_lab2.Location = new System.Drawing.Point(195, 23);
            this.LeaseBook_lab2.Name = "LeaseBook_lab2";
            this.LeaseBook_lab2.Size = new System.Drawing.Size(53, 12);
            this.LeaseBook_lab2.TabIndex = 3;
            this.LeaseBook_lab2.Text = "書本名稱";
            // 
            // LeaseBook_lab3
            // 
            this.LeaseBook_lab3.AutoSize = true;
            this.LeaseBook_lab3.Location = new System.Drawing.Point(11, 50);
            this.LeaseBook_lab3.Name = "LeaseBook_lab3";
            this.LeaseBook_lab3.Size = new System.Drawing.Size(53, 12);
            this.LeaseBook_lab3.TabIndex = 2;
            this.LeaseBook_lab3.Text = "會員資訊";
            // 
            // LeaseBook_txt1
            // 
            this.LeaseBook_txt1.Location = new System.Drawing.Point(70, 18);
            this.LeaseBook_txt1.Name = "LeaseBook_txt1";
            this.LeaseBook_txt1.Size = new System.Drawing.Size(70, 22);
            this.LeaseBook_txt1.TabIndex = 1;
            // 
            // LeaseBook_lab1
            // 
            this.LeaseBook_lab1.AutoSize = true;
            this.LeaseBook_lab1.Location = new System.Drawing.Point(11, 26);
            this.LeaseBook_lab1.Name = "LeaseBook_lab1";
            this.LeaseBook_lab1.Size = new System.Drawing.Size(53, 12);
            this.LeaseBook_lab1.TabIndex = 0;
            this.LeaseBook_lab1.Text = "會員帳號";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 264);
            this.Controls.Add(this.LeaseBook_Group);
            this.Controls.Add(this.ReturnBook_btn);
            this.Controls.Add(this.LeaseBook_btn);
            this.Controls.Add(this.OverdueBook_btn);
            this.Controls.Add(this.LeaseStatus_btn);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.LeaseBook_Group.ResumeLayout(false);
            this.LeaseBook_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LeaseStatus_btn;
        private System.Windows.Forms.Button OverdueBook_btn;
        private System.Windows.Forms.Button LeaseBook_btn;
        private System.Windows.Forms.Button ReturnBook_btn;
        private System.Windows.Forms.GroupBox LeaseBook_Group;
        private System.Windows.Forms.Label LeaseBook_lab2;
        private System.Windows.Forms.Label LeaseBook_lab3;
        private System.Windows.Forms.TextBox LeaseBook_txt1;
        private System.Windows.Forms.Label LeaseBook_lab1;
        private System.Windows.Forms.Button LeaseBook_btnB;
        private System.Windows.Forms.Button LeaseBook_btnM;
        private System.Windows.Forms.Button LeaseBook_btnF;
        private System.Windows.Forms.Label LeaseBook_lab5;
        private System.Windows.Forms.RadioButton LeaseRadio2;
        private System.Windows.Forms.RadioButton LeaseRadio1;
        private System.Windows.Forms.RadioButton LeaseRadio3;
        private System.Windows.Forms.Label LeaseBook_lab4;
        private System.Windows.Forms.TextBox LeaseBook_txt2;
    }
}