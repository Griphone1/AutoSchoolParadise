namespace WindowsFormsApplication14
{
    partial class PersonalAccountForm
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
            this.BRecord = new System.Windows.Forms.Button();
            this.BScedule = new System.Windows.Forms.Button();
            this.LExam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.BInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BRecord
            // 
            this.BRecord.Location = new System.Drawing.Point(19, 48);
            this.BRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BRecord.Name = "BRecord";
            this.BRecord.Size = new System.Drawing.Size(324, 42);
            this.BRecord.TabIndex = 0;
            this.BRecord.Text = "Запись к инструктору";
            this.BRecord.UseVisualStyleBackColor = true;
            this.BRecord.Click += new System.EventHandler(this.BRecord_Click);
            // 
            // BScedule
            // 
            this.BScedule.Location = new System.Drawing.Point(19, 134);
            this.BScedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BScedule.Name = "BScedule";
            this.BScedule.Size = new System.Drawing.Size(324, 38);
            this.BScedule.TabIndex = 1;
            this.BScedule.Text = "Расписание";
            this.BScedule.UseVisualStyleBackColor = true;
            this.BScedule.Click += new System.EventHandler(this.button2_Click);
            // 
            // LExam
            // 
            this.LExam.AutoSize = true;
            this.LExam.Location = new System.Drawing.Point(16, 283);
            this.LExam.Name = "LExam";
            this.LExam.Size = new System.Drawing.Size(297, 34);
            this.LExam.TabIndex = 3;
            this.LExam.Text = "Экзамены будут проведены спустя полгода\r\nпосле начала обучения";
            this.LExam.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Личный кабинет пользователя -";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(240, 11);
            this.LName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(16, 17);
            this.LName.TabIndex = 5;
            this.LName.Text = "1";
            // 
            // BInfo
            // 
            this.BInfo.Location = new System.Drawing.Point(19, 214);
            this.BInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BInfo.Name = "BInfo";
            this.BInfo.Size = new System.Drawing.Size(324, 41);
            this.BInfo.TabIndex = 6;
            this.BInfo.Text = "Справка";
            this.BInfo.UseVisualStyleBackColor = true;
            this.BInfo.Click += new System.EventHandler(this.BInfo_Click);
            // 
            // PersonalAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 326);
            this.Controls.Add(this.BInfo);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LExam);
            this.Controls.Add(this.BScedule);
            this.Controls.Add(this.BRecord);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PersonalAccountForm";
            this.Text = "Личный кабинет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonalAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BRecord;
        private System.Windows.Forms.Button BScedule;
        private System.Windows.Forms.Label LExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Button BInfo;
    }
}