using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empleado miEmpleado = new Empleado(); //instancia de la clase Empleado
        Salario miSalario = new Salario(); //objeto de la clase Salario

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            /*los valores obtenidos en los textbox son pasados a los atributos por medio de sus
            propiedades, note que mandamos a llamar a través de los objetos creados*/
            miEmpleado.Nombre = txtnombre.Text;
            miEmpleado.Identificacion = txtidentificacion.Text;
            miEmpleado.SalarioDiario = Convert.ToDecimal(txtdiario.Text);
            miSalario.DiasLaborados = int.Parse(txtdias.Text);
            MessageBox.Show("Datos ingresados con éxito");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            /*Enviaremos el valor de salario calculado al textbox respectivo, como es un dato
            numérico debemos convertirlo a texto, el cálculo lo hace el método de la clase salario*/
            txtsalario.Text = Convert.ToString(miSalario.CalcularSalario(miSalario.DiasLaborados,
            miEmpleado.SalarioDiario));
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //limpiando todo para ingresar nuevos datos
            txtnombre.Clear();
            txtidentificacion.Clear();
            txtdias.Clear();
            txtdiario.Clear();
            txtsalario.Clear();
            txtnombre.Focus(); //regresa el cursor al textbox del nombre
        }

    }
}
