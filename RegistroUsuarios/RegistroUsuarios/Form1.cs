using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text; 
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text; 
            string contrasena = txtContrasena.Text;

        }
    }
}
