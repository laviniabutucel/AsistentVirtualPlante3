namespace InterfataUtilizator_WindowsForms
{
    partial class Form2
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
            btnAgauga = new Button();
            dataGridView1 = new DataGridView();
            Nume = new DataGridViewTextBoxColumn();
            NevoieApa = new DataGridViewTextBoxColumn();
            Nevoielumina = new DataGridViewTextBoxColumn();
            Tipsol = new DataGridViewTextBoxColumn();
            Caracteristici = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgauga
            // 
            btnAgauga.Location = new Point(12, 387);
            btnAgauga.Name = "btnAgauga";
            btnAgauga.Size = new Size(94, 29);
            btnAgauga.TabIndex = 0;
            btnAgauga.Text = "Adaugă";
            btnAgauga.UseVisualStyleBackColor = true;
            btnAgauga.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nume, NevoieApa, Nevoielumina, Tipsol, Caracteristici });
            dataGridView1.GridColor = Color.DarkSeaGreen;
            dataGridView1.Location = new Point(22, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.MinimumWidth = 6;
            Nume.Name = "Nume";
            Nume.Width = 125;
            // 
            // NevoieApa
            // 
            NevoieApa.HeaderText = "Nevoie de apă";
            NevoieApa.MinimumWidth = 6;
            NevoieApa.Name = "NevoieApa";
            NevoieApa.Width = 125;
            // 
            // Nevoielumina
            // 
            Nevoielumina.HeaderText = "Nevoie de lumină";
            Nevoielumina.MinimumWidth = 6;
            Nevoielumina.Name = "Nevoielumina";
            Nevoielumina.Width = 125;
            // 
            // Tipsol
            // 
            Tipsol.HeaderText = "Tip sol";
            Tipsol.MinimumWidth = 6;
            Tipsol.Name = "Tipsol";
            Tipsol.Width = 125;
            // 
            // Caracteristici
            // 
            Caracteristici.HeaderText = "Caracteristici";
            Caracteristici.MinimumWidth = 6;
            Caracteristici.Name = "Caracteristici";
            Caracteristici.Width = 125;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgauga);
            ForeColor = Color.DarkGreen;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        #endregion

        private Button btnAgauga;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn NevoieApa;
        private DataGridViewTextBoxColumn Nevoielumina;
        private DataGridViewTextBoxColumn Tipsol;
        private DataGridViewTextBoxColumn Caracteristici;
    }
}