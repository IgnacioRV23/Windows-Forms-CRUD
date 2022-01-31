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

            } while (pbProceso.Value < 1000000);

            this.Dispose();
        }
    }
}
