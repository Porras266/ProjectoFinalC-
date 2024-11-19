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
using TrabajoFinall;

namespace FinalDelTrabajo
{
    public partial class Registro : Form
    {
        //creamos la pagina inicio
        Inicio Ventana;
        public Registro()
        {
            InitializeComponent();
            Ventana = new Inicio(this);
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btmCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }      

        //si el mouse esta dentro de usuario cambiara a verde 
        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGreen;
            }
        }

        //si el mouse esta fuera de usuario volvera a ser usuario y sera griz
        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        //si el mouse esta dentro de contraseña cambiara a verde
        private void txtContraseña_Enter_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                //Para ocultar lo que ingreses en el cuadro de contraseña
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        //si el mouse esta fuera de usuario volvera a ser contraseña y sera griz
        private void txtContraseña_Leave_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                //se quita el ocultar contraseña 
                txtContraseña.UseSystemPasswordChar = false;

            }
        }
        
        // si el moiuse se mueve en toda la pantalla 
        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //si el mouse se mueve en el panel 
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //para mover la pagina 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Lparam);

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Andres Porras" && txtContraseña.Text == "Porras")
            {
                Ventana.Visible = true;
                txtUsuario.Text = "USUARIO";
                txtContraseña.Text = "CONTRASEÑA";
                this.Visible = false;                  
            }
            else
            {
                MessageBox.Show("el usuario o contraseña son incorrectos");
            }
        }
    }
}
