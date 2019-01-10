using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication14
{
    public partial class MainMenuForm : Form
    {
        private SQLiteConnection DB;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data source = DB.db; Version =3");
            DB.Open();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm RGForm = new RegistrationForm();
            RGForm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public string WhatPerson()
        {
            return person;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (TBLogin.Text != "" && TBPassword.Text != "")
            {
                person = TBLogin.Text;
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "select * from Person where Name like @name and CodeWord like @codeWord  ";
                CMD.Parameters.Add("@name", System.Data.DbType.String).Value = TBLogin.Text.ToUpper();
                CMD.Parameters.Add("@codeWord", System.Data.DbType.String).Value = TBPassword.Text.ToUpper(); // ToUpper чтобы облегчить поиск в базе данных
                SQLiteDataReader SQL = CMD.ExecuteReader(); // Берем одну запись, читаем из нее данные и переходим к другой, пока все не прочитаем
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        var result = MessageBox.Show("Успешная авторизация");
                        PersonalAccountForm PAForm = new PersonalAccountForm();
                        PAForm.Show();
                    }
                }
                else
                {
                    var result = MessageBox.Show("Неверный логин или пароль");
                }
                this.Hide();
            }
        }

        static string person;

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void BInfo_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
