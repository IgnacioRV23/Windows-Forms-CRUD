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

        //Creacion de variables a nivel de instancia para realizar un Parse para poder pasar los datos a la base de datos Bodega.
        int cantidad;
        float precio;

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
                cantidad = int.Parse(txtCantidadProducto.Text);
                precio = float.Parse(txtPrecioProducto.Text);

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

        //Se crea el metodo que se encargara de modificar los datos existentes.
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            //Se debe de crear una variable donde cargara el atributo ID del dgv para poder realizar busquedas por ID.
            int id = int.Parse(dgvBodega.Rows[dgvBodega.CurrentRow.Index].Cells["ID"].Value.ToString());

            //Se realiza el parseo de los texBox al tipo de dato, de la tabla bodega.
            cantidad = int.Parse(txtCantidadProducto.Text);
            precio = float.Parse(txtPrecioProducto.Text);

            using (BdAplicacionEmpresa ae = new BdAplicacionEmpresa())
            {
                Bodega producto = new Bodega();

                producto = ae.Bodega.Find(id);

                producto.Nombre = txtNombreProducto.Text;
                producto.Precio = precio;
                producto.Cantidad = cantidad;

                ae.Entry(producto).State = System.Data.Entity.EntityState.Modified;

                ae.SaveChanges();
            }

            MessageBox.Show("Se han modificado los datos del producto de manera exitosa", "Modificación realizada", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            limpiarDatos();
            actualizaDgv();
        }

        //Creacion del metodo encargado de eliminar los datos existentes.
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //Se crea una variable que se utilizara para buscar el id correspondiente en la base de datos.
            int? id = int.Parse(dgvBodega.Rows[dgvBodega.CurrentRow.Index].Cells["ID"].Value.ToString());

            if (id != null)
            {
                DialogResult opcion = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Advertencia", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (opcion == DialogResult.Yes)
                {
                    using (BdAplicacionEmpresa ae = new BdAplicacionEmpresa())
                    {
                        Bodega producto = ae.Bodega.Find(id);

                        ae.Bodega.Remove(producto);

                        ae.SaveChanges();
                    }

                    MessageBox.Show("Se ha eliminado el producto de manera correcta.", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    actualizaDgv();
                    limpiarDatos();
                }
            }
        }

        //Este metodo se encarga de limpiar los datos de los texbox mediante su correspondiente boton.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
    }
}
