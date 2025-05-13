using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Setează coloanele tabelului
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Nume";
            dataGridView1.Columns[1].Name = "Nevoie de Apă";
            dataGridView1.Columns[2].Name = "Nevoie de Lumină";
            dataGridView1.Columns[3].Name = "Tip Sol";
            dataGridView1.Columns[4].Name = "Caracteristici";

            // Citește datele din fișier
            string caleFisier = "plante.txt"; // Calea fișierului
            if (File.Exists(caleFisier))
            {
                using (StreamReader sr = new StreamReader(caleFisier))
                {
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        // Împarte linia în câmpuri folosind separatorul virgulă
                        string[] valori = linie.Split(',');

                        // Asigură-te că numărul de valori este egal cu numărul de coloane
                        if (valori.Length == dataGridView1.ColumnCount)
                        {
                            // Adaugă valorile ca rând în DataGridView
                            dataGridView1.Rows.Add(valori);
                        }
                        else
                        {
                            MessageBox.Show("Fișierul conține linii incorecte:\n" + linie);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fișierul plante.txt nu a fost găsit!");
            }
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
