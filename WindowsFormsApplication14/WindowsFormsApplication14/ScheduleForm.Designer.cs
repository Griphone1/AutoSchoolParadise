namespace WindowsFormsApplication14
{
    partial class ScheduleForm
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
            this.components = new System.ComponentModel.Container();
            this.DGVScedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BEnd = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVScedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVScedule
            // 
            this.DGVScedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVScedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.txtMonday,
            this.txtTuesday,
            this.txtWednesday,
            this.txtThursday,
            this.txtFriday});
            this.DGVScedule.Location = new System.Drawing.Point(29, 26);
            this.DGVScedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVScedule.Name = "DGVScedule";
            this.DGVScedule.RowTemplate.Height = 24;
            this.DGVScedule.Size = new System.Drawing.Size(894, 201);
            this.DGVScedule.TabIndex = 2;
            this.DGVScedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.DGVScedule.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVScedule_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Для того, чтобы произвести запись к инструктору, следует выбрать инструктора и де" +
    "нь недели,\r\nзаписать свою фамилию, затем нажать кнопку \"Записаться\".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BEnd
            // 
            this.BEnd.Location = new System.Drawing.Point(752, 256);
            this.BEnd.Margin = new System.Windows.Forms.Padding(4);
            this.BEnd.Name = "BEnd";
            this.BEnd.Size = new System.Drawing.Size(171, 40);
            this.BEnd.TabIndex = 4;
            this.BEnd.Text = "Записаться";
            this.BEnd.UseVisualStyleBackColor = true;
            this.BEnd.Click += new System.EventHandler(this.BEnd_Click);
            // 
            // scheduleFormBindingSource
            // 
            this.scheduleFormBindingSource.DataSource = typeof(WindowsFormsApplication14.ScheduleForm);
            // 
            // txtName
            // 
            this.txtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMonday
            // 
            this.txtMonday.DataPropertyName = "Monday";
            this.txtMonday.HeaderText = "Monday";
            this.txtMonday.Name = "txtMonday";
            // 
            // txtTuesday
            // 
            this.txtTuesday.DataPropertyName = "Tuesday";
            this.txtTuesday.HeaderText = "Tuesday";
            this.txtTuesday.Name = "txtTuesday";
            // 
            // txtWednesday
            // 
            this.txtWednesday.DataPropertyName = "Wednesday";
            this.txtWednesday.HeaderText = "Wednesday";
            this.txtWednesday.Name = "txtWednesday";
            // 
            // txtThursday
            // 
            this.txtThursday.DataPropertyName = "Thursday";
            this.txtThursday.HeaderText = "Thursday";
            this.txtThursday.Name = "txtThursday";
            // 
            // txtFriday
            // 
            this.txtFriday.DataPropertyName = "Friday";
            this.txtFriday.HeaderText = "Friday";
            this.txtFriday.Name = "txtFriday";
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 320);
            this.Controls.Add(this.BEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVScedule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScheduleForm";
            this.Text = "Запись к инструктору";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScheduleForm_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVScedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVScedule;
        private System.Windows.Forms.BindingSource scheduleFormBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFriday;
    }
}