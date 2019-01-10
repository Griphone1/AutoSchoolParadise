namespace WindowsFormsApplication14
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.RegistrationButtonOnMainMenu = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationButtonOnMainMenu
            // 
            this.RegistrationButtonOnMainMenu.Location = new System.Drawing.Point(615, 417);
            this.RegistrationButtonOnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationButtonOnMainMenu.Name = "RegistrationButtonOnMainMenu";
            this.RegistrationButtonOnMainMenu.Size = new System.Drawing.Size(153, 41);
            this.RegistrationButtonOnMainMenu.TabIndex = 0;
            this.RegistrationButtonOnMainMenu.Text = "Регистрация";
            this.RegistrationButtonOnMainMenu.UseVisualStyleBackColor = true;
            this.RegistrationButtonOnMainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(454, 416);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(129, 42);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.Text = "Вход";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "АВТОШКОЛА \"PARADISE\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(450, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 220);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(225, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(517, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "                       Девиз нашей компании:\r\n \"Хватка тигра, скорость лани, не у" +
    "гонишься за нами\".";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBLogin
            // 
            this.TBLogin.Location = new System.Drawing.Point(82, 426);
            this.TBLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(100, 22);
            this.TBLogin.TabIndex = 7;
            this.TBLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(308, 426);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 22);
            this.TBPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(225, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Логин:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // BInfo
            // 
            this.BInfo.Location = new System.Drawing.Point(788, 417);
            this.BInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BInfo.Name = "BInfo";
            this.BInfo.Size = new System.Drawing.Size(171, 41);
            this.BInfo.TabIndex = 12;
            this.BInfo.Text = "Справка";
            this.BInfo.UseVisualStyleBackColor = true;
            this.BInfo.Click += new System.EventHandler(this.BInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(450, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Самая выгодная цена в городе: 13000 рублей!!!";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 467);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.RegistrationButtonOnMainMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrationButtonOnMainMenu;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BInfo;
        private System.Windows.Forms.Label label6;
    }
}

