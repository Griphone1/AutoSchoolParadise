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
    public partial class RegistrationForm : Form
    {

        private SQLiteConnection DB;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DB   = new SQLiteConnection("Data Source = DB.db; Version=3");
            DB.Open();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void BRegistration_Click(object sender, EventArgs e)
        {
            if (TBSurName.Text != "" && TBName.Text != "" && TBMiddleName.Text != "" && TBCodeWord.Text != "" && TBStartMonth.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into Person(SurName, Name, MiddleName, Phone, StartMonth, CodeWord) " + //Выполнение операций по добавлению в SQLite
                    "values(@surName, @name, @middleName, @phone, @startMonth, @codeWord)";
                CMD.Parameters.Add("@surName", System.Data.DbType.String).Value = TBSurName.Text.ToUpper();
                CMD.Parameters.Add("@name", System.Data.DbType.String).Value = TBName.Text.ToUpper();
                CMD.Parameters.Add("@middleName", System.Data.DbType.String).Value = TBMiddleName.Text.ToUpper();
                CMD.Parameters.Add("@phone", System.Data.DbType.String).Value = TBPhone.Text.ToUpper();
                CMD.Parameters.Add("@startMonth", System.Data.DbType.String).Value = TBStartMonth.Text.ToUpper();
                CMD.Parameters.Add("@codeWord", System.Data.DbType.String).Value = TBCodeWord.Text.ToUpper(); // ToUpper чтобы облегчить поиск в базе данных
                CMD.ExecuteNonQuery(); //Запрос без возвращаемых значений
                
            }
            var result = MessageBox.Show("Регистрация прошла успешно");
            this.Close();
        }
    }
}
