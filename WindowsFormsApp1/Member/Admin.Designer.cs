
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
            this.LeaseBook_lab1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.LeaseBook_Group.Controls.Add(this.label2);
            this.LeaseBook_Group.Controls.Add(this.label1);
            this.LeaseBook_Group.Controls.Add(this.textBox1);
            this.LeaseBook_Group.Controls.Add(this.LeaseBook_lab1);
            this.LeaseBook_Group.Location = new System.Drawing.Point(86, 12);
            this.LeaseBook_Group.Name = "LeaseBook_Group";
            this.LeaseBook_Group.Size = new System.Drawing.Size(389, 215);
            this.LeaseBook_Group.TabIndex = 4;
            this.LeaseBook_Group.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "會員資訊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "書本";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 239);
            this.Controls.Add(this.LeaseBook_Group);
            this.Controls.Add(this.ReturnBook_btn);
            this.Controls.Add(this.LeaseBook_btn);
            this.Controls.Add(this.OverdueBook_btn);
            this.Controls.Add(this.LeaseStatus_btn);
            this.Name = "Admin";
            this.Text = "Admin";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LeaseBook_lab1;
    }
}