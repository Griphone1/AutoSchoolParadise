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
    public partial class SceduleWithLections : Form
    {
        private SQLiteConnection DB;
        public SceduleWithLections()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SceduleWithLections_Load(object sender, EventArgs e)
        {
            String sqlQuery;
            sqlQuery = "SELECT Name, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday FROM Instructor";
            DB = new SQLiteConnection("Data source = DBInstructors.db; Version =3");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, DB);

            DB.Open();
            DataTable dTable = new DataTable();
            try
            {
                adapter.Fill(dTable); //Метод Fill определяет, должна ли быть добавлена новая строка или обновлена существующая строка, путем проверки значений первичного 

                if (dTable.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Database is empty");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            DB.Close();
        }
    }
}
