using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_con_objetos_2019_2
{
    
    public partial class FrmNomina : Form
    {
        //Instanciamos la clases Empleado y Nomina
        Empleado MyEmpleado = new Empleado();
        Nomina MyNomina = new Nomina();
        public FrmNomina()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese un Nombre");
            this.ttMensaje.SetToolTip(this.txtIdentificacion, "Ingrese la identificación");
            this.ttMensaje.SetToolTip(this.txtDiasLaborados, "Ingrese los dias laborados");
            this.ttMensaje.SetToolTip(this.txtSalarioDia, "Ingrese el salario diario");
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Calculamos el total debengado
            {
                double dias = Convert.ToDouble(txtDiasLaborados.Text);
                Decimal valordia = Convert.ToDecimal(txtSalarioDia.Text);

                if (dias < 15 || dias > 25)
                {
                    MessageBox.Show("Valor de dias no valido");
                }
                else

                {
                    txtTotalDevengado.Text = MyNomina.CalcularNomina(MyNomina.DiasLaborados, MyEmpleado.Asignaciondia).ToString();
                }
                if (valordia < 15000 || valordia > 22000)
                {
                    MessageBox.Show("El valor dia es incorrecto ingrese el valor dia entre 15000 y22000");
                    txtSalarioDia.Focus();
                    return;
                }
                else
                {
                    txtTotalDevengado.Text = MyNomina.CalcularNomina(MyNomina.DiasLaborados, MyEmpleado.Asignaciondia).ToString();
                }

                txtTotalDevengado.Text = MyNomina.CalcularNomina(Convert.ToInt32(MyNomina.DiasLaborados),
                Convert.ToDecimal(MyEmpleado.Asignaciondia)).ToString();

            }
        }

        private void FrmNomina_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                error1.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            MyEmpleado.Nombre = txtNombre.Text;
            MyEmpleado.Identificacion = txtIdentificacion.Text;
            MyEmpleado.Asignaciondia = Convert.ToDecimal(txtSalarioDia.Text);
            MyNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("Los Datos se Ingresaron Correctamente");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtDiasLaborados.Clear();
            txtSalarioDia.Clear();
            txtTotalDevengado.Clear();
            txtNombre.Focus();
        }
    }
}
