using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FinalDelTrabajo;
using System.Diagnostics.Eventing.Reader;

namespace TrabajoFinall
{
    public partial class Inicio : Form
    {
        //declaramos registro sobre el login
        private Registro registro1;

        private Registro loginForm;

        public Inicio(Registro registro1)
        {
            InitializeComponent();
            this.registro1 = registro1;
            loginForm = registro1; // Guarda la referencia de Form1
        }

        //creamos el metodo para abrir cualquier form
        private void AbrirForm(object Abrir)
        {
            //preguntamos si existe algun control dentro del panel de ser verdadero lo eliminamos 
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            //creamos un formulario con un nombre "abrirForm"  y deicmos que sea igual al objeto que recibe 
            Form AbrirForm = Abrir as Form;
            //decimos que no es un formulario principal si, no secundario
            AbrirForm.TopLevel = false;
            //esto hara que se completo a todo el panel contenedor 
            AbrirForm.Dock = DockStyle.Fill;
            //agregamos el panel 
            this.PanelContenedor.Controls.Add(AbrirForm);
            //establecemos la instancia como contenedor de datos de nuestro panel 
            this.PanelContenedor.Tag = AbrirForm;
            //mostramos 
            AbrirForm.Show();
        
        }

        //boton para cerrar 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
            btnRestaurar.Visible = true;
        }

        //boton restaurar para volver a poner en ventana el programa
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        
        //boton para minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //cargamos la pantalla de inicio al cargar el Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        //para mover la pagina 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Lparam);

        //mover el panel de arriba del form
        private void PanelArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //abrir forms
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new AgendarCita());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirForm (new Entrada());
        }
        //abrir el panel agendar citas
        private void btnEstadoCitas_Click(object sender, EventArgs e)
        {
            AbrirForm(new HistorialCita());
        }

        //abrir el panel horario de atencion
        private void BtnHorarioAtencion_Click(object sender, EventArgs e)
        {
            AbrirForm (new Horario_De_Atencion());
        }
        //abrir el panel soporte
        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new Soporte());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginForm.Show();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Entrada());
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
    
        }
    }
}
