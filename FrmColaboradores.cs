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

            if (opcion == DialogResult.Yes)
            {
                this.Dispose();
                fmp.Visible = true;
            }
        }

        private void btnRegresarConsultar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir de la ventana colaboradores?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                this.Dispose();
                fmp.Visible = true;
            }
        }

        private void btnRegresarModificar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir de la ventana colaboradores?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                this.Dispose();
                fmp.Visible = true;

            }
        }

        private void btnRegresarEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que desea salir de la ventana colaboradores?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                this.Dispose();
                fmp.Visible = true;
            }
        }/*****Finalización del codigo de los botones encargados de volver al menú principal*****/

        //Metodo que realiza acciones en el instante en que se carga el Form.
        private void FrmColaboradores_Load(object sender, EventArgs e)
        {
            actualizaDgv();
        }

        //Metodo que se encargara de limpiar todos los datos de los textBox.
        private void limpiarDatos()
        {
            txtRegistrarCedula.Text = "";
            txtRegistrarNombre.Text = "";
            txtRegistrarPuesto.Text = "";
            cbRegistrarProvincia.Text = "";
            txtRegistrarCanton.Text = "";
            txtRegistrarDistrito.Text = "";

            txtRegistrarEdad.Text = "";
            txtRegistrarSalario.Text = "";
            dtpFecha.Value = DateTime.Now;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            rbOtro.Checked = false;
        }

        //Creacion del metodo privado encargado de actualizar los datos del dgv.
        private void actualizaDgv()
        {
            using (BdAplicacionEmpresa ap = new BdAplicacionEmpresa())
            {
                var listaColaboradores = from colaborador in ap.Colaboradores select colaborador;

                dgvColaboradores.DataSource = listaColaboradores.ToList();
            }
        }

        //Este es el metodo del boton encargado de realizar el create del CRUD colaboradores.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Variable que cargara el tipo de genero escogido por el usuario.
            string genero = "";

            //Se valida el genero que ingreso el usuario, antes de entrar a la validacion den los espacios vacios.
            if (rbMasculino.Checked == true)
            {
                genero = "Masculino";
            }

            if (rbFemenino.Checked == true)
            {
                genero = "Femenino";
            }
            if (rbOtro.Checked == true)
            {
                genero = "Otro";
            }

            //Creacion de las variables de tipo string.
            string cedula = txtRegistrarCedula.Text;
            string nombre = txtRegistrarNombre.Text;
            string puesto = txtRegistrarPuesto.Text;
            string canton = txtRegistrarCanton.Text;
            string distrito = txtRegistrarDistrito.Text;
            string provincia = cbRegistrarProvincia.Text;

            //Cracion de variables que no son de tipo string.
            DateTime FechaNacimiento = dtpFecha.Value;
            string direccion = cbRegistrarProvincia.Text + " " + txtRegistrarCanton.Text + " " + txtRegistrarDistrito.Text;

            /*Validacion encargada de que ninguno de los datos queden vacios, debido a 
             que ninguno de los atributos de la tabla de la base de datos acepta nulos.*/
            if (cedula.Equals("") || nombre.Equals("") || puesto.Equals("")
                || canton.Equals("") || distrito.Equals("") || provincia.Equals("") ||
                genero.Equals("") || txtRegistrarEdad.Equals("") || txtRegistrarSalario.Equals("") || dtpFecha.Value == DateTime.Now)
            {
                MessageBox.Show("Faltan datos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Se realiza el parseo de los datos de tipo int y float despues de hacer la validacion para evitar una exception.
                int edad = int.Parse(txtRegistrarEdad.Text);
                double salario = float.Parse(txtRegistrarSalario.Text);

                using (BdAplicacionEmpresa ap = new BdAplicacionEmpresa())
                {
                    Colaboradores c = new Colaboradores();

                    c.Cedula = cedula;
                    c.Nombre = nombre;
                    c.Edad = edad;
                    c.FechaNacimiento = FechaNacimiento;
                    c.Genero = genero;
                    c.Direccion = direccion;
                    c.Puesto = puesto;
                    c.Salario = salario;

                    ap.Colaboradores.Add(c);

                    ap.SaveChanges();
                }

                MessageBox.Show("Se ha creado un colaborador de manera exitosa", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                actualizaDgv();
                limpiarDatos();
            }
        }   
    }
}
