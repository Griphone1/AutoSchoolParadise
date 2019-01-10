namespace WindowsFormsApplication14
{
    partial class SceduleWithLections
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CMonday,
            this.CTuesday,
            this.CWednesday,
            this.CThursday,
            this.CFriday,
            this.CSaturday,
            this.CSunday});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CName
            // 
            this.CName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 74;
            // 
            // CMonday
            // 
            this.CMonday.DataPropertyName = "Monday";
            this.CMonday.HeaderText = "Monday";
            this.CMonday.Name = "CMonday";
            this.CMonday.ReadOnly = true;
            // 
            // CTuesday
            // 
            this.CTuesday.DataPropertyName = "Tuesday";
            this.CTuesday.HeaderText = "Tuesday";
            this.CTuesday.Name = "CTuesday";
            this.CTuesday.ReadOnly = true;
            // 
            // CWednesday
            // 
            this.CWednesday.DataPropertyName = "Wednesday";
            this.CWednesday.HeaderText = "Wednesday";
            this.CWednesday.Name = "CWednesday";
            this.CWednesday.ReadOnly = true;
            // 
            // CThursday
            // 
            this.CThursday.DataPropertyName = "Thursday";
            this.CThursday.HeaderText = "Thursday";
            this.CThursday.Name = "CThursday";
            this.CThursday.ReadOnly = true;
            // 
            // CFriday
            // 
            this.CFriday.DataPropertyName = "Friday";
            this.CFriday.HeaderText = "Friday";
            this.CFriday.Name = "CFriday";
            this.CFriday.ReadOnly = true;
            // 
            // CSaturday
            // 
            this.CSaturday.HeaderText = "Saturday";
            this.CSaturday.Name = "CSaturday";
            this.CSaturday.ReadOnly = true;
            // 
            // CSunday
            // 
            this.CSunday.HeaderText = "Sunday";
            this.CSunday.Name = "CSunday";
            this.CSunday.ReadOnly = true;
            // 
            // SceduleWithLections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 139);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SceduleWithLections";
            this.Text = "Просмотр расписания";
            this.Load += new System.EventHandler(this.SceduleWithLections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSaturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSunday;
    }
}