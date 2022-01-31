using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioEmpresa
{
    public class Controlador
    {
        public static void Formularios(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    FrmLogin fl = new FrmLogin();
                    fl.Visible = true;
                    break;
                case 2:
                    FrmMenuPrincipal mp = new FrmMenuPrincipal();
                    mp.Visible = true;
                    break;
                case 3:
                    FrmBodega fb = new FrmBodega();
                    fb.Visible = true;
                    break;
                case 4:
                    FrmColaboradores fc = new FrmColaboradores();
                    fc.Visible = true;
                    break;
            }
        }
    }
}
