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
    public partial class ScheduleForm : Form
    {
        private SQLiteConnection DB;

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
            String sqlQuery;
            sqlQuery = "SELECT Name, Monday, Tuesday, Wednesday, Thursday, Friday FROM Instructor";
            MainMenuForm MMF = new MainMenuForm();
            DB = new SQLiteConnection("Data source = DBInstructors.db; Version =3");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, DB);
            
            DB.Open();
            DataTable dTable = new DataTable();
            try
            {
                adapter.Fill(dTable); //Метод Fill определяет, должна ли быть добавлена новая строка или обновлена существующая строка, путем проверки значений первичного ключа
                

                if (dTable.Rows.Count > 0)
                {
                    DGVScedule.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        DGVScedule.Rows.Add(dTable.Rows[i].ItemArray);
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVScedule_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVScedule.CurrentRow != null)
            {
                string sqlQuery = "update Instructor set Name = @Name, Monday = @Monday, Tuesday = @Tuesday, Wednesday = @Wednesday, Thursday = @Thursday, Friday = @Friday";
                DB = new SQLiteConnection("Data source = DBInstructors.db; Version =3");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, DB);
                DB.Open();
                DataTable dTable = new DataTable();
                DataGridViewRow dgvRow = DGVScedule.CurrentRow;
                SQLiteCommand sqlCmd = new SQLiteCommand(sqlQuery, DB);
                sqlCmd.Parameters.AddWithValue("@Name", Convert.ToString(dgvRow.Cells["txtName"].Value));
                sqlCmd.Parameters.AddWithValue("@Monday", dgvRow.Cells["txtMonday"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Tuesday", dgvRow.Cells["txtTuesday"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Wednesday", dgvRow.Cells["txtWednesday"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Thursday", dgvRow.Cells["txtThursday"].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@Friday", dgvRow.Cells["txtFriday"].Value.ToString());
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter("SELECT Name, Monday, Tuesday, Wednesday, Thursday, Friday FROM Instructor", DB);
                sqlCmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DGVScedule.DataSource = dtbl;
            }
        }
    }
}
