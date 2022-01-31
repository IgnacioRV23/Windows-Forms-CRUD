﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InventarioEmpresa
{
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
        }

        //Metodo que realiza acciones en el instante en que se carga el Form.
        private void FrmColaboradores_Load(object sender, EventArgs e)
        {
            //*****Se comenta esta linea de codigo para poder revisar el diseño sin conectarse a la BD.
            //actualizaDgv();
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


        //Metodo que se encargara de limpiar todos los datos de los textBox.
        private void limpiarDatosRegistro()
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

        private void limpiarDatosModificar()
        {
            txtModificarNombre.Text = "";
            dtpModificarFecha.Value = DateTime.Now;
            txtModificarDireccion.Text = "";
            txtModificarSalario.Text = "";
            txtModificarCedula.Text = "";
            cbGenero.Text = "";
            txtModificarEdad.Text = "";
            txtModificarPuesto.Text = "";
        }

        private void limpiarDatosEliminar()
        {
            txtEliminarNombre.Text = "";
            dtpEliminarFecha.Value = DateTime.Now;
            txtEliminarDireccion.Text = "";
            txtEliminarSalario.Text = "";
            txtEliminarCedula.Text = "";
            txtEliminarGenero.Text = "";
            txtEliminarEdad.Text = "";
            txtEliminarPuesto.Text = "";
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
                limpiarDatosRegistro();
            }
        }

        //Este boton se encarga de limpiar los datos del txt del formulario que modifica los colaboradores.
        private void btnLimpiarModificar_Click(object sender, EventArgs e)
        {
            limpiarDatosModificar();
            btnModificar.Visible = false;
        }

        //Esta variable se encargara de almacenar el id buscado por el usuario.
        int idBuscado;

        //Este metodo se encargara de buscar el id del colaborador y enviarlo a los texbox para poder modificar los datos.
        private void btnConsultarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                idBuscado = int.Parse(txtModificar.Text);

                using (BdAplicacionEmpresa ap = new BdAplicacionEmpresa())
                {
                    Colaboradores c = new Colaboradores();

                    c = ap.Colaboradores.Find(idBuscado);

                    txtModificarNombre.Text = c.Nombre;
                    dtpModificarFecha.Value = c.FechaNacimiento;
                    txtModificarDireccion.Text = c.Direccion;
                    txtModificarSalario.Text = c.Salario.ToString();
                    txtModificarCedula.Text = c.Cedula;
                    cbGenero.Text = c.Genero;
                    txtModificarEdad.Text = c.Edad.ToString();
                    txtModificarPuesto.Text = c.Puesto.ToString();
                }

                btnModificar.Visible = true;
                txtModificar.Text = "";

                MessageBox.Show("Se ha encontrado el colaborador de manera existosa.", "Busqueda correcta", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningún colaborador.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Creacion de una variable booleana que se encarga de realizar validacion para saber si entrar a una condicion o no.
                Boolean validacion = true;

                DialogResult opcion = MessageBox.Show("¿Seguro que desea modificar estos datos?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cbGenero.SelectedIndex == -1)
                {
                    validacion = false;

                    MessageBox.Show("Error ingresando el tipo de género del colaborador.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (opcion == DialogResult.Yes && validacion == true)
                {
                    //Se realiza el parse de las variables que la tabla colaboradores necesita.
                    double salario = double.Parse(txtModificarSalario.Text);
                    int edad = int.Parse(txtModificarEdad.Text);

                    using (BdAplicacionEmpresa ap = new BdAplicacionEmpresa())
                    {
                        Colaboradores c = new Colaboradores();

                        c = ap.Colaboradores.Find(idBuscado);

                        c.Nombre = txtModificarNombre.Text;
                        c.FechaNacimiento = dtpModificarFecha.Value;
                        c.Direccion = txtModificarDireccion.Text;
                        c.Salario = salario;
                        c.Cedula = txtModificarCedula.Text;
                        c.Genero = cbGenero.Text;
                        c.Edad = edad;
                        c.Puesto = txtModificarPuesto.Text;

                        ap.Entry(c).State = System.Data.Entity.EntityState.Modified;

                        ap.SaveChanges();
                    }

                    MessageBox.Show("Se ha modificado el colaborador de manera exitosa.", "Modificación correcta", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    limpiarDatosModificar();
                    actualizaDgv();
                    btnModificar.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron actualizar los datos del colaborador", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        //Metodo encargado de limpiar los txt de la pestaña eliminar.
        private void btnLimpiarEliminar_Click(object sender, EventArgs e)
        {
            limpiarDatosEliminar();
            btnEliminar.Visible = false;
        }

        //Metodo encargado de realizar la busqueda por codigo de los colaboradores y ingresarlos en los txt.
        private void btnConsultarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                idBuscado = int.Parse(txtEliminar.Text);

                using (BdAplicacionEmpresa ap = new BdAplicacionEmpresa())
                {
                    Colaboradores c = new Colaboradores();

                    c = ap.Colaboradores.Find(idBuscado);

                    txtEliminarNombre.Text = c.Nombre;
                    dtpEliminarFecha.Value = c.FechaNacimiento;
                    txtEliminarDireccion.Text = c.Direccion;
                    txtEliminarSalario.Text = c.Salario.ToString();
                    txtEliminarCedula.Text = c.Cedula;
                    txtEliminarGenero.Text = c.Genero;
                    txtEliminarEdad.Text = c.Edad.ToString();
                    txtEliminarPuesto.Text = c.Puesto.ToString();
                }
                txtEliminar.Text = "";
                btnEliminar.Visible = true;

                MessageBox.Show("Se ha encontrado el colaborador de manera exitosa.", "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado ningún colaborador.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = MessageBox.Show("¿Seguro que desea eliminar este colaborador?", "Error", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    using (BdAplicacionEmpresa ap = new BdAplicacionEmpresa())
                    {
                        Colaboradores c = new Colaboradores();

                        c = ap.Colaboradores.Find(idBuscado);

                        ap.Colaboradores.Remove(c);

                        ap.SaveChanges();
                    }

                    btnEliminar.Visible = false;
                    actualizaDgv();
                    limpiarDatosEliminar();

                    MessageBox.Show("Se ha eliminado el colaborador de manera correcta.", "Información", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el colaborador de manera correcta.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
