
namespace WindowsFormsApp1.Member
{
    partial class MemberProfile
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
            this.name_lab = new System.Windows.Forms.Label();
            this.gender_lab = new System.Windows.Forms.Label();
            this.phone_lab = new System.Windows.Forms.Label();
            this.admin_lab = new System.Windows.Forms.Label();
            this.admin_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.gender_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_lab
            // 
            this.name_lab.AutoSize = true;
            this.name_lab.Location = new System.Drawing.Point(10, 15);
            this.name_lab.Name = "name_lab";
            this.name_lab.Size = new System.Drawing.Size(29, 12);
            this.name_lab.TabIndex = 0;
            this.name_lab.Text = "姓名";
            // 
            // gender_lab
            // 
            this.gender_lab.AutoSize = true;
            this.gender_lab.Location = new System.Drawing.Point(10, 55);
            this.gender_lab.Name = "gender_lab";
            this.gender_lab.Size = new System.Drawing.Size(29, 12);
            this.gender_lab.TabIndex = 1;
            this.gender_lab.Text = "性別";
            // 
            // phone_lab
            // 
            this.phone_lab.AutoSize = true;
            this.phone_lab.Location = new System.Drawing.Point(10, 95);
            this.phone_lab.Name = "phone_lab";
            this.phone_lab.Size = new System.Drawing.Size(53, 12);
            this.phone_lab.TabIndex = 2;
            this.phone_lab.Text = "聯絡電話";
            // 
            // admin_lab
            // 
            this.admin_lab.AutoSize = true;
            this.admin_lab.Location = new System.Drawing.Point(12, 178);
            this.admin_lab.Name = "admin_lab";
            this.admin_lab.Size = new System.Drawing.Size(197, 12);
            this.admin_lab.TabIndex = 3;
            this.admin_lab.Text = "若為管理員請在右側輸入管理員密碼";
            // 
            // admin_txt
            // 
            this.admin_txt.Location = new System.Drawing.Point(215, 175);
            this.admin_txt.Name = "admin_txt";
            this.admin_txt.Size = new System.Drawing.Size(70, 22);
            this.admin_txt.TabIndex = 4;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(70, 90);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 22);
            this.phone_txt.TabIndex = 5;
            // 
            // gender_txt
            // 
            this.gender_txt.Location = new System.Drawing.Point(70, 50);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(100, 22);
            this.gender_txt.TabIndex = 6;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(70, 10);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemberProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.gender_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.admin_txt);
            this.Controls.Add(this.admin_lab);
            this.Controls.Add(this.phone_lab);
            this.Controls.Add(this.gender_lab);
            this.Controls.Add(this.name_lab);
            this.Name = "MemberProfile";
            this.Text = "MemberProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lab;
        private System.Windows.Forms.Label gender_lab;
        private System.Windows.Forms.Label phone_lab;
        private System.Windows.Forms.Label admin_lab;
        private System.Windows.Forms.TextBox admin_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox gender_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button button1;
    }
}