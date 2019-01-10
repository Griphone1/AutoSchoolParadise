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
    public partial class PersonalAccountForm : Form
    {
        private SQLiteConnection DBP;

        public PersonalAccountForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SceduleWithLections scd = new SceduleWithLections();
            scd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void PersonalAccountForm_Load(object sender, EventArgs e)
        { 
            DBP = new SQLiteConnection("Data source = DB.db; Version = 3");
            string person = MMForm.WhatPerson();
            LName.Text = person;
            
        }
        MainMenuForm MMForm = new MainMenuForm();

        private void PersonalAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            MMForm.Show();
            DBP.Close();
        }

        private void BRecord_Click(object sender, EventArgs e)
        {
            ScheduleForm ScForm = new ScheduleForm();
            ScForm.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BInfo_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
        }
    }
}
