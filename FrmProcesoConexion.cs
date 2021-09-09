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
    public partial class FrmProcesoConexion : Form
    {
        public FrmProcesoConexion()
        {
            InitializeComponent();
        }

        public void mostrarProgreso()
        {
            this.Show();

            do
            {
                pbProceso.Value++;

            } while (pbProceso.Value < 10000);

            this.Dispose();
        }
    }
}
