﻿using System;
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
    public partial class AgendarCita : Form
    {
        public AgendarCita()
        {
            InitializeComponent();
        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora1.Text = DateTime.Now.ToShortTimeString();
            lblFecha2.Text = DateTime.Now.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            HistorialCita historialCita = new HistorialCita();
            historialCita.AddRowToGrid(txtUsuario.Text, txtApellido.Text, dateTimePicker1.Text, maskedTextBox2.Text, txtConsulta.Text);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
