using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioEmpresa
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Creacion de una variable publica que evita que el formulario login se vuelva a abrir, cuando no se desea.
        public static Boolean validacion = false;

        //Creacion de una variable contador, para que el usuario no exceda el numero de intentos permitidos en la aplicacion.
        int contador = 0;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Se cargan unas variables unas con el texto ingresado por el usuario.
            String usuario = txtUsuario.Text;

            String contrasena = txtContrasena.Text;

            //Codificacion del ingreso de la contraseña y usuario con sus respectivas validaciones.
            if (usuario.Equals("") && contrasena.Equals(""))
            {
                MessageBox.Show("Bienvenido usuario!", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Se define como true la variable para hacer la validacion en el formulario menu principal.
                validacion = true;

                this.Dispose();
            }
            else
            {
                if (contador < 2) //Si contador aun no tiene el valor de 2, puede intentar ingresar la contraseña nuevamente.
                {
                    MessageBox.Show("Su usuario o contraseña son incorrectas, intente nuevamente.", "Error de ingreso",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contador++;
                }
                else //Si supera los intentos permitidos la aplicacion envia un mensaje y se cierra.
                {
                    MessageBox.Show("Se han excedido los intentos permitidos, la aplicación se cerrara.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Application.Exit();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir y cerrar la aplicación?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Metodo encargado de mostrar o ocultar al usuario, la contraseña digitada.
        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked == false)
            {
                txtContrasena.PasswordChar = '*';
            }

            if (cbMostrar.Checked == true)
            {
                txtContrasena.PasswordChar = '\0';
            }
        }
    }
}
