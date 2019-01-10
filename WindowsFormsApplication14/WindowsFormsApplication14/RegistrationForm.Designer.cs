namespace WindowsFormsApplication14
{
    partial class RegistrationForm
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
            this.TBSurName = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBMiddleName = new System.Windows.Forms.TextBox();
            this.TBStartMonth = new System.Windows.Forms.TextBox();
            this.TBCodeWord = new System.Windows.Forms.TextBox();
            this.LSurName = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LMiddleName = new System.Windows.Forms.Label();
            this.LPhone = new System.Windows.Forms.Label();
            this.LStartMonth = new System.Windows.Forms.Label();
            this.BRegistration = new System.Windows.Forms.Button();
            this.LCodeWord = new System.Windows.Forms.Label();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBSurName
            // 
            this.TBSurName.Location = new System.Drawing.Point(23, 22);
            this.TBSurName.Name = "TBSurName";
            this.TBSurName.Size = new System.Drawing.Size(100, 22);
            this.TBSurName.TabIndex = 0;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(23, 61);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 22);
            this.TBName.TabIndex = 1;
            // 
            // TBMiddleName
            // 
            this.TBMiddleName.Location = new System.Drawing.Point(23, 105);
            this.TBMiddleName.Name = "TBMiddleName";
            this.TBMiddleName.Size = new System.Drawing.Size(100, 22);
            this.TBMiddleName.TabIndex = 2;
            // 
            // TBStartMonth
            // 
            this.TBStartMonth.Location = new System.Drawing.Point(23, 198);
            this.TBStartMonth.Name = "TBStartMonth";
            this.TBStartMonth.Size = new System.Drawing.Size(100, 22);
            this.TBStartMonth.TabIndex = 3;
            this.TBStartMonth.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TBCodeWord
            // 
            this.TBCodeWord.Location = new System.Drawing.Point(23, 243);
            this.TBCodeWord.Name = "TBCodeWord";
            this.TBCodeWord.Size = new System.Drawing.Size(100, 22);
            this.TBCodeWord.TabIndex = 4;
            this.TBCodeWord.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LSurName
            // 
            this.LSurName.AutoSize = true;
            this.LSurName.Location = new System.Drawing.Point(143, 27);
            this.LSurName.Name = "LSurName";
            this.LSurName.Size = new System.Drawing.Size(70, 17);
            this.LSurName.TabIndex = 5;
            this.LSurName.Text = "Фамилия";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(143, 66);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 17);
            this.LName.TabIndex = 6;
            this.LName.Text = "Имя";
            this.LName.Click += new System.EventHandler(this.label2_Click);
            // 
            // LMiddleName
            // 
            this.LMiddleName.AutoSize = true;
            this.LMiddleName.Location = new System.Drawing.Point(143, 108);
            this.LMiddleName.Name = "LMiddleName";
            this.LMiddleName.Size = new System.Drawing.Size(71, 17);
            this.LMiddleName.TabIndex = 7;
            this.LMiddleName.Text = "Отчество";
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Location = new System.Drawing.Point(143, 156);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(68, 17);
            this.LPhone.TabIndex = 8;
            this.LPhone.Text = "Телефон";
            // 
            // LStartMonth
            // 
            this.LStartMonth.AutoSize = true;
            this.LStartMonth.Location = new System.Drawing.Point(143, 198);
            this.LStartMonth.Name = "LStartMonth";
            this.LStartMonth.Size = new System.Drawing.Size(102, 34);
            this.LStartMonth.TabIndex = 9;
            this.LStartMonth.Text = "Месяц начала\r\n обучения";
            this.LStartMonth.Click += new System.EventHandler(this.label5_Click);
            // 
            // BRegistration
            // 
            this.BRegistration.Location = new System.Drawing.Point(12, 282);
            this.BRegistration.Name = "BRegistration";
            this.BRegistration.Size = new System.Drawing.Size(252, 43);
            this.BRegistration.TabIndex = 10;
            this.BRegistration.Text = "Зарегестрироваться";
            this.BRegistration.UseVisualStyleBackColor = true;
            this.BRegistration.Click += new System.EventHandler(this.BRegistration_Click);
            // 
            // LCodeWord
            // 
            this.LCodeWord.AutoSize = true;
            this.LCodeWord.Location = new System.Drawing.Point(143, 246);
            this.LCodeWord.Name = "LCodeWord";
            this.LCodeWord.Size = new System.Drawing.Size(106, 17);
            this.LCodeWord.TabIndex = 11;
            this.LCodeWord.Text = "Кодовое слово";
            this.LCodeWord.Click += new System.EventHandler(this.label6_Click);
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(23, 151);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(100, 22);
            this.TBPhone.TabIndex = 12;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 339);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.LCodeWord);
            this.Controls.Add(this.BRegistration);
            this.Controls.Add(this.LStartMonth);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.LMiddleName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LSurName);
            this.Controls.Add(this.TBCodeWord);
            this.Controls.Add(this.TBStartMonth);
            this.Controls.Add(this.TBMiddleName);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBSurName);
            this.Name = "RegistrationForm";
            this.Text = "Окно регистрации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBSurName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBMiddleName;
        private System.Windows.Forms.TextBox TBStartMonth;
        private System.Windows.Forms.TextBox TBCodeWord;
        private System.Windows.Forms.Label LSurName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LMiddleName;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.Label LStartMonth;
        private System.Windows.Forms.Button BRegistration;
        private System.Windows.Forms.Label LCodeWord;
        private System.Windows.Forms.TextBox TBPhone;
    }
}