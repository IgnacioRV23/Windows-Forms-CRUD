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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        
        //Este método se encargara de mostrar el login cuando se ejecute la aplicación.
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Visible = true;

            FrmLogin fl = new FrmLogin();

            //Se valida que el usuario aun no se registrado o no y luego se muestra el login si se cumple la condicion.
            if (FrmLogin.validacion == false) {
                fl.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Se utiliza dialogResult, asignandole el nombre opcion para capturar la decision del usuario y poder realizar una validacion.
            DialogResult opcion = MessageBox.Show("¿Seguro que desea de cerrar la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Se crea e inicializa el objeto que contiene el metodo que muestra el progressBar.
        FrmProcesoConexion pc = new FrmProcesoConexion();

        private void btnBodega_Click(object sender, EventArgs e)
        {
            //Creacion del objeto formulario bodega, para realizar su llamado y mostrarlo.
            FrmBodega fb = new FrmBodega();

            pc.mostrarProgreso();
            this.Visible = false;
            fb.Show();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            //Se muestra el formulario de colaboradores.
            FrmColaboradores fc = new FrmColaboradores();

            pc.mostrarProgreso();
            this.Visible = false;
            fc.Show();
        }
    }
}
