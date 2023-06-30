using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Anualidades : Form
    {
        public Anualidades()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCalcular.Text = "Seleccionar";
            txtValor.Text = "0";
            cmbValor.Text = "Seleccionar";
            cmbInicioPago.Text = "Seleccionar";
            txtTipoInteres.Text = "0";
            txtTiempo.Text = "0";
            cmbNumeroPeriodos.Text = "Seleccionar";
            lblResultado.Text = "";
            txtResultado.Text = "0";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lineCI_Click(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Seleccionar":
                    MessageWarning("Seleccionar lo que quiera calcular");
                    break;
                case "Anualidades Anticipadas":
                    if (txtValor.Text == "0" || txtTipoInteres.Text == "0" || txtTiempo.Text == "0" || cmbNumeroPeriodos.Text == "Seleccionar" || cmbValor.Text == "Seleccionar" || cmbInicioPago.Text == "Seleccionar")
                    {
                        MessageWarning("Un campo se encuentra vacio");
                    } else if (validateInputs(txtValor.Text, txtTipoInteres.Text, txtTiempo.Text))
                    {
                        CalcularPagoPeriodico();
                    } 
                    break;
                case "Anualidades Total":
                    if (txtValor.Text == "" || txtTipoInteres.Text == "" || txtTiempo.Text == "" || cmbNumeroPeriodos.Text == "Seleccionar" || cmbValor.Text == "Seleccionar" || cmbInicioPago.Text == "Seleccionar")
                    {
                        MessageWarning("Un campo se encuentra vacio");
                    } else if (validateInputs(txtValor.Text, txtTipoInteres.Text, txtTiempo.Text))
                    {
                        CalcularAnualidadTotal();
                    }
                    break;
            }
        }

        private bool validateInputs(string valor, string tipo_interes, string tiempo)
        {
            if (validateValor(valor)) return false;
            if (validateTasaInteres(tipo_interes)) return false;
            if (validateTiempo(tiempo, cmbNumeroPeriodos.Text)) return false;

            return true;
        }

        private bool validateValor(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("El valor solo permite numeros decimales");
                    return true;
                }
            }

            double cp = double.Parse(str);
            if (cp == 0)
            {
                MessageWarning("El valor no puede ser 0");
                return true;
            }

            return false;
        }

        private bool validateTasaInteres(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("La tasa de interes solo permite numeros decimales");
                    return true;
                }
            }

            double tasa_interes = double.Parse(str);
            if (tasa_interes == 0)
            {
                MessageWarning("La tasa de interes no puede ser 0");
                return true;
            }
            if (tasa_interes > 100)
            {
                MessageWarning("La tasa de interes no puede ser mayor a 100%");
                return true;
            }

            return false;
        }

        private bool validateTiempo(string str, string tiStr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("El número de periodos solo permite numeros decimales");
                    return true;
                }
            }

            double tiempo = double.Parse(str);
            if (tiempo == 0)
            {
                MessageWarning("El número de periodos no puede ser 0");
                return true;
            }

            return false;
        }

        private void MessageWarning(string str)
        {
            MessageBox.Show(str, "Anualidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageInfo(string str)
        {
            MessageBox.Show(str, "Anualidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Anualidades_Load(object sender, EventArgs e)
        {
        }

        private void cmbCalcular_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Anualidades Anticipadas":
                    // add formula de Anualidades Anticipadas
                    // lblResultadoFormula.Text = "";
                    break;
                case "Anualidades Total":
                    // add formula de Anualidades Total
                    // lblResultadoFormula.Text = "";
                    break;
            }
        }

        public void CalcularPagoPeriodico()
        {
            int n = 0;
            if (cmbNumeroPeriodos.Text == "Anual") n = 1;
            else if (cmbNumeroPeriodos.Text == "Trimestral") n = 4;
            else if (cmbNumeroPeriodos.Text == "Mensual") n = 12;
            double valor_actual = double.Parse(txtValor.Text);
            double tipo_interes = double.Parse(txtTipoInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text) * n;
            if (cmbValor.Text == "Valor Actual" && cmbInicioPago.Text == "Inicio Periodo")
            {
                tiempo = tiempo - (tiempo * 2);

                double pago_periodico = (valor_actual * tipo_interes) / ((1 + tipo_interes) * (1 - Math.Pow((1 + tipo_interes), tiempo)));

                txtResultado.Text = pago_periodico.ToString("N2");
            }
            else if (cmbValor.Text == "Valor Actual" && cmbInicioPago.Text == "Final Periodo")
            {
                tiempo = tiempo - (tiempo * 2);

                double pago_periodico = (valor_actual * tipo_interes) / (1 - Math.Pow((1 + tipo_interes), tiempo));

                txtResultado.Text = pago_periodico.ToString("N2");
            }
            else if (cmbValor.Text == "Valor Futuro" && cmbInicioPago.Text == "Inicio Periodo")
            {
                double pago_periodico = (valor_actual * tipo_interes) / ((1 + tipo_interes) * (Math.Pow((1 + tipo_interes), tiempo) - 1));

                txtResultado.Text = pago_periodico.ToString("N2");
            }
            else if (cmbValor.Text == "Valor Futuro" && cmbInicioPago.Text == "Final Periodo")
            {
                double pago_periodico = (valor_actual * tipo_interes) / ((Math.Pow((1 + tipo_interes), tiempo) - 1));

                txtResultado.Text = pago_periodico.ToString("N2");
            }
        }

        public void CalcularAnualidadTotal()
        {
            int n = 0;
            if (cmbNumeroPeriodos.Text == "Anual") n = 1;
            else if (cmbNumeroPeriodos.Text == "Trimestral") n = 4;
            else if (cmbNumeroPeriodos.Text == "Mensual") n = 12;
            if (cmbValor.Text == "Valor Actual" && cmbInicioPago.Text == "Inicio Periodo")
            {
                double valor_actual = Convert.ToDouble(txtValor.Text);
                double tipo_interes = Convert.ToDouble(txtTipoInteres.Text) / 100;
                double tiempo = Convert.ToDouble(txtTiempo.Text) * n;
                tiempo = tiempo - (tiempo * 2);

                double pago_periodico = (valor_actual * tipo_interes) / ((1 + tipo_interes) * (1 - Math.Pow((1 + tipo_interes), tiempo)));
                double result = pago_periodico * ((1 - Math.Pow((1 + tipo_interes), tiempo)) / (tipo_interes)) * (1 + tipo_interes);

                txtResultado.Text = result.ToString("N2");
            }
        }

        private void radioBtnFinalPeriodo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
