using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDelTrabajo
{
    public partial class HistorialCita : Form
    {
        public HistorialCita()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void HistorialCita_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Apellido";
            dataGridView1.Columns[2].Name = "Fecha";
            dataGridView1.Columns[3].Name = "Hora";
            dataGridView1.Columns[4].Name = "Motivo";
        }
        public void AddRowToGrid(string nombre, string apellido, string fecha, string Hora,  string motivo)
        {
            dataGridView1.Rows.Add(nombre, fecha, Hora, motivo);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); 
        }
    }
}
