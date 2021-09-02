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
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
        }

        //Se crea el objeto menú principal y se inicializa a nivel de instancia para que pueda ser utilizado en distintos métodos.
        FrmMenuPrincipal fmp = new FrmMenuPrincipal();

        /****Se codificarán todos los botones del formulario encargados de devolverse al menú principal.*****/
        private void btnRegresarRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir de la ventana colaboradores?", "Advertencia", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes) {
                this.Dispose();
                fmp.Visible = true;
            }
        }

        private void btnRegresarConsultar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir de la ventana colaboradores?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes) {
                this.Dispose();
                fmp.Visible = true;
            }
        }

        private void btnRegresarModificar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir de la ventana colaboradores?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes){
                this.Dispose();
                fmp.Visible = true;

            }
        }

        private void btnRegresarEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir de la ventana colaboradores?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes) {
                this.Dispose();
                fmp.Visible = true;
            }
        }
        /*****Finalización del codigo de los botones encargados de volver al menú principal*****/
    }
}
