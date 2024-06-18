using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EXPEDIENTE_MEDICO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Clase publica para que las variables sean globales
        //Todas siendo de tipo cadena 
        public static class VariablesGlobales
        {
            public static String Identidad="";
            public static String Nombres="";
            public static String Apellidos="";
            public static String Telefono="";
            public static String Telefono2="";
            public static String Email="";
            public static String FechaNacimiento="";
            public static String Sexo="";
            public static String EstadoCivil="";
            public static String Departamento="";
            public static String Ciudad = "";
            public static String Direccion="";
            public static String Procedencia = "";
            public static String Ocupacion = "";
            public static String FechaExpediente="";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Boton crear o insertar datos
        private void btncrear_Click(object sender, EventArgs e)
        {
            

            //Funcion si en los campos
            if (txtidentidad.Text == "")//Si identidad esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su identidad!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtnombres.Text == "")//Si nombres esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese sus nombres!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtapellidos.Text == "")//Si apellidos esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese sus apellidos!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttelefono.Text == "")//Si telefono esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su primer telefono!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttelefono2.Text == "")//Si telefono 2 esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su segundo telefono!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtemail.Text == "")//Si email esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su email!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbestadocivil.Text == "")//Si estado civil esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su estado civil!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbdepartamento.Text == "")//Si departamento esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese el departamento donde reside!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtciudad.Text == "")//Si ciudad esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese la ciudad donde reside!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdireccion.Text == "")//Si direccion esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su direccion!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtprocedencia.Text == "")//Si procedencia esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su procedencia!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtocupacion.Text == "")//Si ocupacion esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su ocupacion!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Declaracion para la variable sexo
            if (rbmasculino.Checked)//Si el radio boton masculino es seleccionado entonces
            {
                VariablesGlobales.Sexo = "Maculino"; //Masculino se almacena en la variable
            }
            else if (rbfemenino.Checked)
            {// Si el radio boton femenino es seleccionada entonces

                VariablesGlobales.Sexo = "Femenino";//Femenino se almacena en la variable

            }
            else
            {
                MessageBox.Show("Porfavor, seleccione su sexo!", "Expediente del Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Declaracion de variables
            VariablesGlobales.Identidad = txtidentidad.Text;
            VariablesGlobales.Nombres = txtnombres.Text;
            VariablesGlobales.Apellidos = txtapellidos.Text;
            VariablesGlobales.Telefono = txttelefono.Text;
            VariablesGlobales.Telefono2 = txttelefono2.Text;
            VariablesGlobales.Email = txtemail.Text;
            VariablesGlobales.FechaNacimiento = dtpfechaN.Text;
            VariablesGlobales.EstadoCivil = cmbestadocivil.Text;
            VariablesGlobales.Departamento = cmbdepartamento.Text;
            VariablesGlobales.Ciudad = txtciudad.Text;
            VariablesGlobales.Direccion = txtdireccion.Text;
            VariablesGlobales.Procedencia = txtprocedencia.Text;
            VariablesGlobales.Ocupacion = txtocupacion.Text;
            VariablesGlobales.FechaExpediente = dtpfechaexpediente.Text;


            //Crear/Insertar datos al datagridview de acuerdo al orden de las filas
            dgvinfo.Rows.Add(VariablesGlobales.Identidad, VariablesGlobales.Nombres, 
                VariablesGlobales.Apellidos, VariablesGlobales.Telefono, 
                VariablesGlobales.Telefono2, VariablesGlobales.Email,
                VariablesGlobales.FechaNacimiento, 
                VariablesGlobales.Sexo, VariablesGlobales.EstadoCivil, 
                VariablesGlobales.Departamento, VariablesGlobales.Ciudad, 
                VariablesGlobales.Direccion, VariablesGlobales.Procedencia, 
                VariablesGlobales.Ocupacion, VariablesGlobales.FechaExpediente);

            //Indica al usuario que se crearon los datos
            MessageBox.Show("Se han creado los datos correctamente!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Boton actualizar datos
        private void btnactualizar_Click(object sender, EventArgs e)
        {

            //Funcion si en los campos
            if (txtidentidad.Text == "")//Si identidad esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su identidad!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtnombres.Text == "")//Si nombres esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese sus nombres!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtapellidos.Text == "")//Si apellidos esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese sus apellidos!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttelefono.Text == "")//Si telefono esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su primer telefono!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttelefono2.Text == "")//Si telefono 2 esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su segundo telefono!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtemail.Text == "")//Si email esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su email!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbestadocivil.Text == "")//Si estado civil esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su estado civil!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbdepartamento.Text == "")//Si departamento esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese el departamento donde reside!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtciudad.Text == "")//Si ciudad esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese la ciudad donde reside!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdireccion.Text == "")//Si direccion esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su direccion!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtprocedencia.Text == "")//Si procedencia esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su procedencia!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtocupacion.Text == "")//Si ocupacion esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su ocupacion!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Declaracion para la variable sexo
            if (rbmasculino.Checked)//Si el radio boton masculino es seleccionado entonces
            {
                VariablesGlobales.Sexo = "Masculino"; //Masculino se almacena en la variable
            }
            else if (rbfemenino.Checked)
            {// Si el radio boton femenino es seleccionada entonces

                VariablesGlobales.Sexo = "Femenino";//Femenino se almacena en la variable

            }
            else
            {
                MessageBox.Show("Porfavor, seleccione su sexo!", "Expediente del Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Declaracion de variables
            VariablesGlobales.Identidad = txtidentidad.Text;
            VariablesGlobales.Nombres = txtnombres.Text;
            VariablesGlobales.Apellidos = txtapellidos.Text;
            VariablesGlobales.Telefono = txttelefono.Text;
            VariablesGlobales.Telefono2 = txttelefono2.Text;
            VariablesGlobales.Email = txtemail.Text;
            VariablesGlobales.FechaNacimiento = dtpfechaN.Text;
            VariablesGlobales.EstadoCivil = cmbestadocivil.Text;
            VariablesGlobales.Departamento = cmbdepartamento.Text;
            VariablesGlobales.Ciudad = txtciudad.Text;
            VariablesGlobales.Direccion = txtdireccion.Text;
            VariablesGlobales.Procedencia = txtprocedencia.Text;
            VariablesGlobales.Ocupacion = txtocupacion.Text;
            VariablesGlobales.FechaExpediente = dtpfechaexpediente.Text;

            //Actualizar datos 
            //Para actualizar datos es necesario ir al evento "Mouseclicked" del dgv
            // Actualizar una nueva fila con los datos del paciente
          if(dgvinfo.SelectedRows.Count > 0)
            {
                DataGridViewRow seleccion = dgvinfo.SelectedRows[0];
                seleccion.Cells[0].Value = VariablesGlobales.Identidad;
                seleccion.Cells[1].Value = VariablesGlobales.Nombres;
                seleccion.Cells[2].Value = VariablesGlobales.Apellidos;
                seleccion.Cells[3].Value = VariablesGlobales.Telefono;
                seleccion.Cells[4].Value = VariablesGlobales.Telefono2;
                seleccion.Cells[5].Value = VariablesGlobales.Email;
                seleccion.Cells[6].Value = VariablesGlobales.FechaNacimiento;
                seleccion.Cells[7].Value = VariablesGlobales.Sexo;
                seleccion.Cells[8].Value = VariablesGlobales.EstadoCivil;
                seleccion.Cells[9].Value = VariablesGlobales.Departamento;
                seleccion.Cells[10].Value = VariablesGlobales.Ciudad;
                seleccion.Cells[11].Value = VariablesGlobales.Direccion;
                seleccion.Cells[12].Value = VariablesGlobales.Procedencia;
                seleccion.Cells[13].Value = VariablesGlobales.Ocupacion;
                seleccion.Cells[14].Value = VariablesGlobales.FechaExpediente;


            }

            //Indica al usuario que se actualizaron los datos
            MessageBox.Show("Se han actualizado los datos correctamente!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Refrescar la tabla para ver los nuevos datos
            dgvinfo.Refresh();
        }

        //Boton eliminar datos
        private void btneliminar_Click(object sender, EventArgs e)
        {
            //Funcion si en los campos
            if (txtidentidad.Text == "")//Si identidad esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su identidad!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtnombres.Text == "")//Si nombres esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese sus nombres!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtapellidos.Text == "")//Si apellidos esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese sus apellidos!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttelefono.Text == "")//Si telefono esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su primer telefono!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttelefono2.Text == "")//Si telefono 2 esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su segundo telefono!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtemail.Text == "")//Si email esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su email!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbestadocivil.Text == "")//Si estado civil esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su estado civil!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbdepartamento.Text == "")//Si departamento esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese el departamento donde reside!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtciudad.Text == "")//Si ciudad esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese la ciudad donde reside!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdireccion.Text == "")//Si direccion esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su direccion!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtprocedencia.Text == "")//Si procedencia esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su procedencia!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtocupacion.Text == "")//Si ocupacion esta vacio, se le notifica la usuario de llenar el campo
            {
                MessageBox.Show("Porfavor, ingrese su ocupacion!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Declaracion para la variable sexo
            if (rbmasculino.Checked)//Si el radio boton masculino es seleccionado entonces
            {
                VariablesGlobales.Sexo = "Masculino"; //Masculino se almacena en la variable
            }
            else if (rbfemenino.Checked)
            {// Si el radio boton femenino es seleccionada entonces

                VariablesGlobales.Sexo = "Femenino";//Femenino se almacena en la variable

            }
            else
            {
                MessageBox.Show("Porfavor, seleccione su sexo!", "Expediente del Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Declaracion de variables
            VariablesGlobales.Identidad = txtidentidad.Text;
            VariablesGlobales.Nombres = txtnombres.Text;
            VariablesGlobales.Apellidos = txtapellidos.Text;
            VariablesGlobales.Telefono = txttelefono.Text;
            VariablesGlobales.Telefono2 = txttelefono2.Text;
            VariablesGlobales.Email = txtemail.Text;
            VariablesGlobales.FechaNacimiento = dtpfechaN.Text;
            VariablesGlobales.EstadoCivil = cmbestadocivil.Text;
            VariablesGlobales.Departamento = cmbdepartamento.Text;
            VariablesGlobales.Ciudad = txtciudad.Text;
            VariablesGlobales.Direccion = txtdireccion.Text;
            VariablesGlobales.Procedencia = txtprocedencia.Text;
            VariablesGlobales.Ocupacion = txtocupacion.Text;
            VariablesGlobales.FechaExpediente = dtpfechaexpediente.Text;

            //Eliminar datos
            //Al darle clic a una fila se podra eliminar
            if (dgvinfo.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvinfo.SelectedRows[0];
                dgvinfo.Rows.Remove(fila);
                MessageBox.Show("Se han eliminado los datos correctamente!", "Expediente del paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Porfavor, seleccionar la fila que quiere eliminar!", "Expediente del paciente", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //Boton limpiar datos
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtidentidad.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txttelefono.Text = "";
            txttelefono2.Text = "";
            txtemail.Text = "";
            rbmasculino.Checked = false;
            rbfemenino.Checked = false;
            cmbestadocivil.Text = null;
            cmbdepartamento.Text = null;
            txtciudad.Text = "";
            txtdireccion.Text = "";
            txtprocedencia.Text = "";
            txtocupacion.Text = "";


        }

        //Metodo para validacion de solo letras y espacios
        private void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Metodo para validacion de solo numeros
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Validaciones en las cajas de texto

        //Identidad
        private void txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);//Validacion para solo numeros
        }

        //Nombres
        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);//Validacion para letras
        }

        //Apellidos
        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);//Validacion para letras
        }

        //Telefono
        private void txttelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);//Validacion para solo numeros
        }

        //Telefono 2
        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No hay validacion
        }

        //Edad
        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);//Validacion para solo numeros
        }

        //Ciudad
        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);//Validacion para solo letras
        }

        //Direccion
        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No hay validacion
        }

        //Procedencia
        private void txtprocedencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);//Validacion para solo letras
        }

        //Ocupacion
        private void txtocupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);//Validacion para solo letras
        }

        //Telefono
        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);//Validacion para solo numeros
        }

        //Evento CellMouseClick del datagridview (Para actualizar y elimianr datos)
        //Para que el usuario pueda seleccionar el dato de una fila
        private void dgvinfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgvinfo.Rows.Count)
            {
                DataGridViewRow seleccionfila = dgvinfo.Rows[e.RowIndex];
                txtidentidad.Text = seleccionfila.Cells[0].Value.ToString();
                txtnombres.Text = seleccionfila.Cells[1].Value.ToString();
                txtapellidos.Text = seleccionfila.Cells[2].Value.ToString();
                txttelefono.Text = seleccionfila.Cells[3].Value.ToString();
                txttelefono2.Text = seleccionfila.Cells[4].Value.ToString();
                txtemail.Text = seleccionfila.Cells[5].Value.ToString();
                dtpfechaN.Text = seleccionfila.Cells[6].Value.ToString();
                String S = seleccionfila.Cells[7].Value.ToString();
                if(S == "Masculino")
                {
                    rbmasculino.Checked = true;
                }
                else
                {
                    rbfemenino.Checked = true;
                }
                cmbestadocivil.Text = seleccionfila.Cells[8].Value.ToString();
                cmbdepartamento.Text = seleccionfila.Cells[9].Value.ToString();
                txtciudad.Text = seleccionfila.Cells[10].Value.ToString();
                txtdireccion.Text = seleccionfila.Cells[11].Value.ToString();
                txtprocedencia.Text = seleccionfila.Cells[12].Value.ToString();
                txtocupacion.Text = seleccionfila.Cells[13].Value.ToString();
                dtpfechaexpediente.Text = seleccionfila.Cells[14].Value.ToString();


            }
        }
    }
}
