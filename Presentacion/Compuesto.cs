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
    public partial class Compuesto : Form
    {
        public Compuesto()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCapitalInicial.Text = "";
            txtTasaInteres.Text = "";
            cmbTipoInteres.Text = "Seleccionar";
            txtTiempo.Text = "";
            cmbTiempo.Text = "Seleccionar";
            MessageBox.Show("Los campos se han reseteado", "Interes Simple", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool validateCapitalInicial(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageBox.Show("El capital inicial solo permite numeros naturales", "Interes Simple", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            int cp = Int32.Parse(str);
            if (cp == 0)
            {
                MessageBox.Show("El capital inicial no puede ser 0", "Interes Simple", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void MessageWarning(string str)
        {
            MessageBox.Show(str, "Interes Compuesto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageInfo(string str)
        {
            MessageBox.Show(str, "Interes Compuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool validateValorInicial(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("El valor inicial solo permite numeros decimales");
                    return true;
                }
            }

            double cp = double.Parse(str);
            if (cp == 0)
            {
                MessageWarning("El valor inicial no puede ser 0");
                return true;
            }

            return false;
        }

        private bool validateValorFinal(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("El valor final solo permite numeros decimales");
                    return true;
                }
            }

            double cp = double.Parse(str);
            if (cp == 0)
            {
                MessageWarning("El valor final no puede ser 0");
                return true;
            }

            return false;
        }

        private bool validateTasaInteres(string str)
        {
            // Reemplazar la coma por un punto
            str = str.Replace(',', '.');

            // Verificar si se puede convertir el valor de entrada a un número decimal
            if (!float.TryParse(str, out float tasa_interes))
            {
                MessageWarning("La tasa de interes solo permite numeros decimales");
                return true;
            }

            if (tasa_interes == 0)
            {
                MessageWarning("La tasa de interes no puede ser 0");
                return true;
            }

            return false;
        }

        private bool validateTiempo(string str, string tiStr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '.' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("El tiempo de negociacion solo permite numeros decimales");
                    return true;
                }
            }

            double tiempo = double.Parse(str);
            if (tiempo == 0)
            {
                MessageWarning("El tiempo de negociacion no puede ser 0");
                return true;
            }
            if (tiempo > 365 && tiStr == "Dias")
            {
                MessageWarning("El tiempo de negociacion no puede ser mayor a 365 días");
                return true;
            }

            return false;
        }

        private bool validarInputCompuestoInteres(string c, string r, string t)
        {

            if (validateValorInicial(c)) return false;
            if (validateTasaInteres(r)) return false;
            if (validateTiempo(t, cmbTiempo.Text)) return false;

            return true;
        }

        private void calcular_interes_compuesto()
        {
            double valor_inicial = double.Parse(txtCapitalInicial.Text);
            double tipo_interes = double.Parse(txtTasaInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text);

            MessageInfo("Calculo completado");

            double interes_total = valor_inicial * tipo_interes;
            //tener en cuenta 
            double interes_totals = interes_total / tiempo;
            txtResultado.Text = interes_totals.ToString("N2");
        }

        private void calcular_valor_futuro_interes_compuesto()
        {
            double valor_presente = double.Parse(txtCapitalInicial.Text);
            double tipo_interes = double.Parse(txtTasaInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text);

            int n = 0;
            if (cmbTipoInteres.Text == "Mensual")
            {
                n = 12;
            } else if (cmbTipoInteres.Text=="Bimensual")
            {
                n = 6;
            }

            double valor_futuro = valor_presente * Math.Pow((1 + tipo_interes), n);
            txtResultado.Text = valor_futuro.ToString("N2");
        }

        private void calcular_valor_presente_interes_compuesto()
        {
            double valor_futuro = double.Parse(txtCapitalFinal.Text);
            double tipo_interes = double.Parse(txtTasaInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text);

            double valor_presente = valor_futuro * Math.Pow((1 + tipo_interes), tiempo);
            txtResultado.Text = valor_presente.ToString("N2");
        }

        private void calcular_tiempo_de_negociacion()
        {
            double valor_futuro = double.Parse(txtCapitalFinal.Text);
            double tipo_interes = double.Parse(txtTasaInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text);

            double valor_presente = valor_futuro * Math.Pow((1 + tipo_interes), tiempo);
            txtResultado.Text = valor_presente.ToString("N2");
        }


        private void Compuesto_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Seleccionar":
                    MessageWarning("Seleccionar una de las opciones que quiera calcular...");
                    break;
                case "Valor Futuro":
                    if (txtCapitalInicial.Text == "" || txtTasaInteres.Text == "" || txtTiempo.Text == "" || cmbTiempo.Text == "Seleccionar" || cmbTipoInteres.Text == "Seleccionar" )
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        if (validarInputCompuestoInteres(txtTasaInteres.Text, txtTiempo.Text, txtCapitalInicial.Text))
                        {
                            calcular_valor_futuro_interes_compuesto();
                        }
                    }
                    break;
                case "Valor Presente":
                    if (txtCapitalFinal.Text == "" || txtTasaInteres.Text == "" || txtTiempo.Text == "" || cmbTiempo.Text == "Seleccionar" || cmbTipoInteres.Text == "Seleccionar" )
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        if (validarInputCompuestoInteres(txtTasaInteres.Text, txtTiempo.Text, txtCapitalFinal.Text))
                        {
                            calcular_valor_presente_interes_compuesto();
                        }
                    }
                    break;
                /*case "Tasa de Interes":
                    if (txtCapitalInicial.Text == "" || txtTipoInteres.Text == "" || txtTiempo.Text == "" || cmbTiempo.Text == "Seleccionar")

                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        if (validarInputSimpleTasa(txtCapitalInicial.Text, txtTiempo.Text, txtCapitalFinal.Text))
                        {
                            calcular_tasa_de_interes();
                        }
                    }
                    break;*/
                case "Tiempo de Negociacion":
                    if (txtCapitalInicial.Text == "" || txtTasaInteres.Text == "" || txtCapitalFinal.Text == "" || cmbTiempo.Text == "Seleccionar" || cmbTipoInteres.Text == "Seleccionar" )
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        if (validarInputCompuestoInteres(txtTasaInteres.Text, txtCapitalFinal.Text, txtCapitalInicial.Text))
                        {
                            calcular_tiempo_de_negociacion();
                        }
                    }
                    break;
                default:
                    MessageWarning("Seleccionar una opcion valida...!");
                    cmbCalcular.Text = "Seleccionar";
                    break;
            }
        }

        private void cmbCalcular_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Interes Compuesto":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTasaInteres.Visible = true;
                    txtTasaInteres.Text = "0";
                    cmbTipoInteres.Visible = true;
                    cmbTipoInteres.Text = "Seleccionar";
                    lineTI.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    txtTiempo.Text = "0";
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";

                    lblCapitalFinal.Visible = false;
                    lblDolarCF.Visible = false;
                    txtCapitalFinal.Visible = false;
                    lineCF.Visible = false;

                    lblResultFormula.Text = "";
                    break;
                case "Valor Futuro":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    txtTiempo.Text = "0";
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTasaInteres.Visible = true;
                    cmbTipoInteres.Visible = true;
                    cmbTipoInteres.Text = "Seleccionar";
                    lineTI.Visible = true;

                    lblCapitalFinal.Visible = false;
                    lblDolarCF.Visible = false;
                    txtCapitalFinal.Visible = false;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = false;

                    lblResultFormula.Text = "VF = VP / (1 + i)^n";
                    break;
                case "Valor Presente":
                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTasaInteres.Visible = true;
                    txtTasaInteres.Text = "0";
                    cmbTipoInteres.Visible = true;
                    cmbTipoInteres.Text = "Seleccionar";
                    lineTI.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    txtTiempo.Text = "0";
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";

                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;

                    lblCapitalInicial.Visible = false;
                    lblDolarCI.Visible = false;
                    txtCapitalInicial.Visible = false;
                    lineCI.Visible = false;

                    lblResultFormula.Text = "VP = VF / (1 + i)^n";
                    break;
                case "Tasa de Interes":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;

                    lblTipoInteres.Visible = false;
                    lblPorcentajeTI.Visible = false;
                    txtTasaInteres.Visible = false;
                    cmbTipoInteres.Visible = false;
                    lineTI.Visible = false;

                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";

                    lblResultFormula.Text = "i = ?";
                    break;
                case "Tiempo de Negociacion":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTasaInteres.Visible = true;
                    txtTasaInteres.Text = "0";
                    cmbTipoInteres.Visible = true;
                    cmbTipoInteres.Text = "Seleccionar";
                    lineTI.Visible = true;

                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;

                    lblTiempo.Visible = false;
                    txtTiempo.Visible = false;
                    lineTiempo.Visible = false;
                    cmbTiempo.Visible = false;

                    lblResultFormula.Text = "t = (Ln(VF/VP))/(Ln(1+i))";
                    break;
            }
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtCapitalInicial.Text = "0";
            txtTasaInteres.Text = "0";
            txtTiempo.Text = "0";
            txtCapitalFinal.Text = "0";
            txtResultado.Text = "0";
            lblResultFormula.Text = "";
            cmbTiempo.Text = "Seleccionar";
            cmbCalcular.Text = "Seleccionar";

            lblCapitalInicial.Visible = true;
            btnPreguntaValorPresente.Visible = true;
            lblDolarCI.Visible = true;
            lineCI.Visible = true;
            txtCapitalInicial.Visible = true;
            lblTipoInteres.Visible = true;
            btnPreguntaTipoInteres.Visible = true;
            lineTI.Visible = true;
            txtTasaInteres.Visible = true;
            lblPorcentajeTI.Visible = true;
            lblTiempo.Visible = true;
            btnPreguntaTiempo.Visible = true;
            lineTiempo.Visible = true;
            txtTiempo.Visible = true;
            cmbTiempo.Visible = true;
            lblCapitalFinal.Visible = true;
            btnPreguntaValorFuturo.Visible = true;
            lblDolarCF.Visible = true;
            lineCF.Visible = true;
            txtCapitalFinal.Visible = true;

            cmbCalcular.Focus();
        }
    }
}