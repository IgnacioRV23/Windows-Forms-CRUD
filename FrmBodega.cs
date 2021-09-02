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
    public partial class FrmBodega : Form
    {
        public FrmBodega()
        {
            InitializeComponent();
        }

        private void btnCerrarBodega_Click(object sender, EventArgs e)
        {
            //Llamado del menú principal para que la aplicación no se caiga al cerrar el formulario bodega.

            FrmMenuPrincipal fmp = new FrmMenuPrincipal();

            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir del manejo de bodega?", "Advertencia", MessageBoxButtons.YesNo);

            //Condicion que cierra el formulario de bodega y abre nuevamente el menú principal.
            if (opcion == DialogResult.Yes) {
                this.Dispose();
                fmp.Visible = true;
            }
        }
    }
}
