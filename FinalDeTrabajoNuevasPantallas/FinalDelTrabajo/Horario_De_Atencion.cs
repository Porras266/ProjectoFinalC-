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
    public partial class Horario_De_Atencion : Form
    {
        public Horario_De_Atencion()
        {
            InitializeComponent();
        }

        private void Horario_De_Atencion_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora1.Text = DateTime.Now.ToShortTimeString();
            lblFecha2.Text = DateTime.Now.ToShortDateString();
        }
    }
}
