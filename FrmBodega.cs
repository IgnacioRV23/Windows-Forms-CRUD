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

        //Cuando se cargue nuevamente el formulario, este metodo refrescara el dgv para mostrar los datos al dia.
        private void FrmBodega_Load(object sender, EventArgs e)
        {
            actualizaDgv();
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

        /*Creacion de un metodo privado que se encargara de actualizar la informacion del dgv cuando se cargue el formulario,
        este metodo se considera el read del CRUD, debido a que es el encargado de mostrar los datos para poder leerlos.*/
        private void actualizaDgv(){ 
            //Se utiliza el using para realizar la interaccion con la base de datos.
            using (BdAplicacionEmpresa ae = new BdAplicacionEmpresa())
            {
                var listaProducto = from producto in ae.Bodega select producto;

                dgvBodega.DataSource = listaProducto.ToList();
            }
        }

        //Creacion de un metodo privado que se encargara de limpiar los datos del formulario para que sea mas limpio y agradable.
        private void limpiarDatos()
        {
            txtNombreProducto.Text = "";
            txtCantidadProducto.Text = "";
            txtPrecioProducto.Text = "";
        }

        //Este metodo cumplicara la funcion de que cuando se selecciones celdas del dgv, se muestren en pantalla.
        private void dgvBodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBodega.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtNombreProducto.Text = dgvBodega.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtPrecioProducto.Text = dgvBodega.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtCantidadProducto.Text = dgvBodega.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        //Creacion del metodo encargado de crear los datos del CRUD, registrando productos en bodega.
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            /*Se crea una condicion if para validar que no se ingrese ninguno de los campos vacios, debido a que la tabla
             creada en la base de datos no aceptados datos nulos.*/
            if (txtPrecioProducto.Text.Equals("") || txtCantidadProducto.Text.Equals("") || txtPrecioProducto.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por ingresar, intente nuevamente.", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            } else
            {
                int cantidad = int.Parse(txtCantidadProducto.Text);
                float precio = float.Parse(txtPrecioProducto.Text);

                using (BdAplicacionEmpresa ae = new BdAplicacionEmpresa())
                {
                    Bodega producto = new Bodega();

                    producto.Nombre = txtNombreProducto.Text;
                    producto.Cantidad = cantidad;
                    producto.Precio = precio;

                    /*Una vez cargados los atributos con los datos, se realiza el create con el metodo Add.*/
                    ae.Bodega.Add(producto);

                    //Es totalmente necesario guardar los cambios que se estan haciendo en la tabla para finalizar correctamente.
                    ae.SaveChanges();
                }

                MessageBox.Show("Se ha creado el producto de manera exitosa.", "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Se realizan los llamados a los metodos para que se actualice el dgv y para limpiar los texbox.
                actualizaDgv();
                limpiarDatos();
            }
        }
    }
}
