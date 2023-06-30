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
    public partial class Simple : Form
    {
        public Simple()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCapitalInicial.Text = "0";
            txtTipoInteres.Text = "0";
            txtTiempo.Text = "0";
            txtCapitalFinal.Text = "0";
            txtResultado.Text = "0";
            lblResultFormula.Text = "";
            cmbTiempo.Text = "Seleccionar";
            cmbCalcular.Text = "Seleccionar";

            lblCapitalInicial.Visible = true;
            btnPreguntaCapitalInicial.Visible = true;
            lblDolarCI.Visible = true;
            lineCI.Visible = true;
            txtCapitalInicial.Visible = true;
            lblTipoInteres.Visible = true;
            btnPreguntaTipoInteres.Visible = true;
            lineTI.Visible = true;
            txtTipoInteres.Visible = true;
            lblPorcentajeTI.Visible = true;
            lblTiempo.Visible = true;
            btnPreguntaTiempo.Visible = true;
            lineTiempo.Visible = true;
            txtTiempo.Visible = true;
            cmbTiempo.Visible = true;
            lblCapitalFinal.Visible = true;
            btnPreguntaCapitalFinal.Visible = true;
            lblDolarCF.Visible = true;
            lineCF.Visible = true;
            txtCapitalFinal.Visible = true;

            cmbCalcular.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Seleccionar":
                    MessageWarning("Seleccionar una de las opciones que quiera calcular...");
                    break;
                case "Interes Simple":
                    if (txtCapitalInicial.Text == "" || txtTipoInteres.Text == "" || txtTiempo.Text == "" || cmbTiempo.Text == "Seleccionar")
                    {
                        MessageWarning("Un campo se encuentra vacio");
                    }
                    else
                    {
                        if (validarInputSimpleInteres(txtCapitalInicial.Text, txtTipoInteres.Text, txtTiempo.Text))
                        {
                            calcular_interes_simple();
                        }
                    }
                    break;
                case "Capital Final":
                    if (txtCapitalInicial.Text == "" || txtTipoInteres.Text == "" || txtTiempo.Text == "" || cmbTiempo.Text == "Seleccionar")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        if (validarInputSimpleInteres(txtTipoInteres.Text, txtTiempo.Text, txtCapitalInicial.Text))
                        {
                            calcular_valor_futuro_interes_simple();
                        }
                    }
                    break;
                case "Capital Inicial":
                    if (txtCapitalFinal.Text == "" || txtTipoInteres.Text == "" || txtTiempo.Text == "" || cmbTiempo.Text == "Seleccionar")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        if (validarInputSimpleInteres(txtTipoInteres.Text, txtTiempo.Text, txtCapitalFinal.Text))
                        {
                            calcular_valor_presente_interes_simple();
                        }
                    }
                    break;
                case "Tasa de Interes":
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
                    break;
                case "Tiempo de Negociacion":
                    if (txtCapitalInicial.Text == "" || txtTipoInteres.Text == "" || txtCapitalFinal.Text == "" || cmbTiempo.Text == "Seleccionar")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        if (validarInputSimpleInteres(txtTipoInteres.Text, txtCapitalFinal.Text, txtCapitalInicial.Text))
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

        private void MessageWarning(string str)
        {
            MessageBox.Show(str, "Interes Simple", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageInfo(string str)
        {
            MessageBox.Show(str, "Interes Simple", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {

        }

        private void lblCodVuelo_Click(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private bool validarInputSimpleInteres(string c, string r, string t)
        {

            if (validateCapitalInicial(c)) return false;
            if (validateTasaInteres(r)) return false;
            if (validateTiempo(t, cmbTiempo.Text)) return false;

            return true;
        }

        private bool validarInputSimpleCapital(string tipo_interes, string tiempo, string capital_final)
        {
            if (validateTasaInteres(tipo_interes)) return false;
            if (validateTiempo(tiempo, cmbTiempo.Text)) return false;
            if (validateCapitalFinal(capital_final)) return false;

            return true;
        }

        private bool validarInputSimpleTasa(string c, string t, string i)
        {
            if (validateCapitalInicial(c)) return false;
            if (validateTiempo(t, cmbTiempo.Text)) return false;
            if (validateIntereses(i)) return false;

            return true;
        }

        private bool validarInputSimpleTiempo(string capital_inicial, string tipo_interes, string capital_final)
        {
            if (validateCapitalInicial(capital_inicial)) return false;
            if (validateTasaInteres(tipo_interes)) return false;
            if (validateCapitalFinal(capital_final)) return false;

            return true;
        }

        private bool validateIntereses(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("El capital inicial solo permite numeros decimales");
                    return true;
                }
            }

            double cp = double.Parse(str);
            if (cp == 0)
            {
                MessageWarning("El interes no puede ser 0");
                return true;
            }

            return false;
        }

        private bool validateCapitalInicial( string str )
        {

            for( int i = 0; i < str.Length; i++ )
            {
                if (str[i] != ',' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9' )
                {
                    MessageWarning( "El capital inicial solo permite numeros decimales" );
                    return true;
                }
            }

            double cp = double.Parse(str);
            if ( cp == 0 )
            {
                MessageWarning( "El capital inicial no puede ser 0" );
                return true;
            }

            return false;
        }

        private bool validateCapitalFinal(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ',' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                {
                    MessageWarning("El capital final solo permite numeros decimales");
                    return true;
                }
            }

            double cp = double.Parse(str);
            if (cp == 0)
            {
                MessageWarning("El capital final no puede ser 0");
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


        private bool validateTiempo( string str, string tiStr )
        {
            for ( int i = 0; i < str.Length; i++ )
            {
                if (str[i] != '.' && str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9' )
                {
                    MessageWarning("El tiempo de negociacion solo permite numeros decimales");
                    return true;
                }
            }

            double tiempo = double.Parse(str);
            if (tiempo == 0 )
            {
                MessageWarning("El tiempo de negociacion no puede ser 0");
                return true;
            }
            if ( tiempo > 365 && tiStr == "Dias" )
            {
                MessageWarning("El tiempo de negociacion no puede ser mayor a 365 días");
                return true;
            }
           
            return false;
        }

        private bool validateInteres( string str )
        {

            for ( int i = 0; i < str.Length; i++ )
            {
                if ( str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9' )
                {
                    MessageWarning( "El interes solo permite numeros naturales" );
                    return true;
                }
            }

            int cp = Int32.Parse(str);
            if (cp == 0)
            {
                MessageWarning( "El interes no puede ser 0" );
                return true;
            }

            return false;
        }

        private void txtTasaInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Simple_Load(object sender, EventArgs e)
        {

        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTasaInteres_Click(object sender, EventArgs e)
        {

        }

        private void txtCapitalInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDolar_Click(object sender, EventArgs e)
        {

        }

        private void lblPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void cmbCalcular_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cmbCalcular.Text)
            {
                case "Interes Simple":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;
                    btnPreguntaCapitalInicial.Visible = true;

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTipoInteres.Visible = true;
                    txtTipoInteres.Text = "0";
                    lineTI.Visible = true;
                    btnPreguntaTipoInteres.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    txtTiempo.Text = "0";
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";
                    btnPreguntaTiempo.Visible = true;

                    lblCapitalFinal.Visible = false;
                    lblDolarCF.Visible = false;
                    txtCapitalFinal.Visible = false;
                    lineCF.Visible = false;
                    btnPreguntaCapitalFinal.Visible = false;

                    lblResultFormula.Text = "I = P * i * t";
                    break;
                case "Capital Final":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;
                    btnPreguntaCapitalInicial.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    txtTiempo.Text = "0";
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";
                    btnPreguntaTiempo.Visible = true;

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTipoInteres.Visible = true;
                    lineTI.Visible = true;

                    lblCapitalFinal.Visible = false;
                    lblDolarCF.Visible = false;
                    txtCapitalFinal.Visible = false;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = false;
                    btnPreguntaCapitalFinal.Visible = false;

                    lblResultFormula.Text = "CF = P / (1 + i * t)";
                    break;
                case "Capital Inicial":
                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;
                    btnPreguntaCapitalFinal.Visible = true;

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTipoInteres.Visible = true;
                    txtTipoInteres.Text = "0";
                    lineTI.Visible = true;
                    btnPreguntaTipoInteres.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    txtTiempo.Text = "0";
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";
                    btnPreguntaTiempo.Visible = true;

                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;
                    btnPreguntaCapitalFinal.Visible = true;

                    lblCapitalInicial.Visible = false;
                    lblDolarCI.Visible = false;
                    txtCapitalInicial.Visible = false;
                    lineCI.Visible = false;
                    btnPreguntaCapitalInicial.Visible = false;

                    lblResultFormula.Text = "P = CF / (1 + i * t)";
                    break;
                case "Tasa de Interes":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;
                    btnPreguntaCapitalInicial.Visible = true;

                    lblTipoInteres.Visible = false;
                    lblPorcentajeTI.Visible = false;
                    txtTipoInteres.Visible = false;
                    lineTI.Visible = false;
                    btnPreguntaTipoInteres.Visible = false;

                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;
                    btnPreguntaCapitalFinal.Visible = true;

                    lblTiempo.Visible = true;
                    txtTiempo.Visible = true;
                    lineTiempo.Visible = true;
                    cmbTiempo.Visible = true;
                    cmbTiempo.Text = "Seleccionar";
                    btnPreguntaTiempo.Visible = true;

                    lblResultFormula.Text = "i = ( 1 / t * (( CF / P ) - 1 )";
                    break;
                case "Tiempo de Negociacion":
                    lblCapitalInicial.Visible = true;
                    lblDolarCI.Visible = true;
                    txtCapitalInicial.Visible = true;
                    txtCapitalInicial.Text = "0";
                    lineCI.Visible = true;
                    btnPreguntaCapitalInicial.Visible = true;

                    lblTipoInteres.Visible = true;
                    lblPorcentajeTI.Visible = true;
                    txtTipoInteres.Visible = true;
                    txtTipoInteres.Text = "0";
                    lineTI.Visible = true;
                    btnPreguntaTipoInteres.Visible = true;

                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtCapitalFinal.Visible = true;
                    txtCapitalFinal.Text = "0";
                    lineCF.Visible = true;
                    btnPreguntaCapitalFinal.Visible = true;

                    lblTiempo.Visible = false;
                    txtTiempo.Visible = false;
                    lineTiempo.Visible = false;
                    cmbTiempo.Visible = false;
                    btnPreguntaTiempo.Visible = false;

                    lblResultFormula.Text = "t = ( 1 / t * (( CF / P ) - 1 )";
                    break;
            }
        }

        private void cmbCalcular_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCalcular.Text == "Interes Simple")
            {
                lblCapitalInicial.Visible = true;
                lblDolarCI.Visible = true;
                txtCapitalInicial.Visible = true;
                txtCapitalInicial.Text = "0";
                lineCI.Visible = true;

                lblTipoInteres.Visible = true;
                lblPorcentajeTI.Visible = true;
                txtTipoInteres.Visible = true;
                txtTipoInteres.Text = "0";
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


            }
            else if (cmbCalcular.Text == "Valor Futuro a Interes simple")
            {
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
                txtTipoInteres.Visible = true;
                lineTI.Visible = true;

                lblCapitalFinal.Visible = false;
                lblDolarCF.Visible = false;
                txtCapitalFinal.Visible = false;
                txtCapitalFinal.Text = "0";
                lineCF.Visible = false;
            }
            else if (cmbCalcular.Text == "Valor presente a interes simple")
            {
                lblCapitalFinal.Visible = true;
                lblDolarCF.Visible = true;
                txtCapitalFinal.Visible = true;
                txtCapitalFinal.Text = "0";
                lineCF.Visible = true;

                lblTipoInteres.Visible = true;
                lblPorcentajeTI.Visible = true;
                txtTipoInteres.Visible = true;
                txtTipoInteres.Text = "0";
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
            }

            else if (cmbCalcular.Text == "Tasa de Interes")
            {
                lblCapitalInicial.Visible = true;
                lblDolarCI.Visible = true;
                txtCapitalInicial.Visible = true;
                txtCapitalInicial.Text = "0";
                lineCI.Visible = true;

                lblTipoInteres.Visible = false;
                lblPorcentajeTI.Visible = false;
                txtTipoInteres.Visible = false;
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
            }

            else if (cmbCalcular.Text == "Tiempo de Negociacion")
            {
                lblCapitalInicial.Visible = true;
                lblDolarCI.Visible = true;
                txtCapitalInicial.Visible = true;
                txtCapitalInicial.Text = "0";
                lineCI.Visible = true;

                lblTipoInteres.Visible = true;
                lblPorcentajeTI.Visible = true;
                txtTipoInteres.Visible = true;
                txtTipoInteres.Text = "0";
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
            }
         
        }

        private void calcular_interes_simple()
        {
            double capital_inicial = double.Parse(txtCapitalInicial.Text);
            double tipo_interes = double.Parse(txtTipoInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text);

            double interes_total = capital_inicial * tipo_interes;
            //tener en cuenta 
            double interes_totals = interes_total / tiempo;
            txtResultado.Text = interes_totals.ToString("N2");
        }

        private void calcular_valor_futuro_interes_simple()
        {
            double capital_inicial = double.Parse(txtCapitalInicial.Text);
            double tipo_interes = double.Parse(txtTipoInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text);

            double valor_futuro = capital_inicial * (1 + tipo_interes * tiempo);
            txtResultado.Text = valor_futuro.ToString("N2");
        }

        private void calcular_valor_presente_interes_simple()
        {
            double valor_futuro = double.Parse(txtCapitalFinal.Text);
            double tipo_interes = double.Parse(txtTipoInteres.Text) / 100;
            double tiempo = double.Parse(txtTiempo.Text);

            double valor_presente = valor_futuro / (1 + tipo_interes * tiempo);
            txtResultado.Text = valor_presente.ToString("N2");
        }

        private void calcular_tasa_de_interes()
        {
            double capital_inicial = double.Parse(txtCapitalInicial.Text);
            double capital_final = double.Parse(txtCapitalFinal.Text);
            double tiempo = double.Parse(txtTiempo.Text);

            if (cmbTiempo.Text == "Días") tiempo = double.Parse(txtTiempo.Text) / 365;
            else if (cmbTiempo.Text == "Meses") tiempo = double.Parse(txtTiempo.Text) / 12;

            double tasa_interes = 1 / tiempo * ((capital_final / capital_inicial) - 1);
            txtResultado.Text = $"{tasa_interes.ToString("N2")}%";
        }

        private void calcular_tiempo_de_negociacion()
        {
            double capital_inicial = double.Parse(txtCapitalInicial.Text);
            double capital_final = double.Parse(txtCapitalFinal.Text);
            double tipo_interes = double.Parse(txtTipoInteres.Text) / 100;

            double tiempo = 1 / tipo_interes * (capital_final / capital_inicial - 1);

            if (cmbTiempo.Text == "Días") tiempo *= 365;
            else if (cmbTiempo.Text == "Meses") tiempo *= 12;

            int tiempo_entero = (int)Math.Round(tiempo);
            txtResultado.Text = $"{tiempo.ToString("N2")} {cmbTiempo.Text}";
        }

        private void btnPreguntaCapitalInicial_Click(object sender, EventArgs e)
        {
            MessageInfo("\t\tCapital inicial\n\nEs la cantidad que se presta durante un tiempo determinado para producir un interés.\n\nSe respresenta con la letra P = capital inicial.");
        }

        private void btnPreguntaTipoInteres_Click(object sender, EventArgs e)
        {
            MessageInfo("\t\tTasa de Interes\n\nEs el precio del dinero, esto es, lo que se paga por emplear una cantidad de dinero durante un plazo determinado.\n\nSe respresenta con la letra i = tasa de interes.");
        }

        private void btnPreguntaTiempo_Click(object sender, EventArgs e)
        {
            MessageInfo("\t\tPlazo de Pago\n\nRepresenta el periodo que los clientes tienen para pagar un producto de pedido facturado..\n\nSe respresenta con la letra t = plazo de pago.");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPreguntaCapitalFinal_Click(object sender, EventArgs e)
        {
            MessageInfo("\t\tCapital Final\n\nEs el resultado de sumar al capital inicial los intereses que éste genera periódicamente.\n\nSe respresenta con la letra CF = CP + I = capital inicial + intereses.");
        }
    }
    }


