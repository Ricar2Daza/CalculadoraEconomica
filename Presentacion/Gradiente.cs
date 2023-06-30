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
    public partial class Gradiente : Form
    {
        public Gradiente()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Seleccionar":
                    MessageWarning("Seleccionar una de las opciones que quiera calcular...");
                    break;
                case "Gradiente Lineal Creciente":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0" || txtConstante.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularGradienteLinealCreciente();

                    }
                    break;
                case "Gradiente Lineal Decreciente":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0" || txtConstante.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularGradienteLinealDecreciente();

                    }
                    break;
                case "Gradiente Geometrico Creciente":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0" || txtConstante.Text == "0" || txtVariacionPorcentual.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularGradienteGeometricoCreciente();
                    }
                    break;
                case "Gradiente Geometrico Decreciente":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0" || txtConstante.Text == "0" || txtVariacionPorcentual.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularGradienteGeometricoDecreciente();
                    }
                    break;
                case "Gradiente Escalonado o en Escalera":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0" || txtConstante.Text == "0" || txtTEA.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularGradienteEscalonadooEscalera();
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
            MessageBox.Show(str, "Interes Compuesto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtConstante.Text = "0";
            txtIngresos.Text = "0";
            txtPrimeraCuota.Text = "0";
            txtResultado.Text = "0";
            txtTipoInteres.Text = "0";
            cmbCalcular.Text = "Seleccionar";
            cmbTiempo.Text = "Seleccionar";
            lblResultFormula.Text = "";
        }

        private void cmbCalcular_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Gradiente Lineal Creciente":
                    lblVariacionPorcentual.Visible = false;
                    txtVariacionPorcentual.Visible = false;
                    lineShapeVariacionPorcentual.Visible = false;
                    lblTEA.Visible = false;
                    txtTEA.Visible = false;
                    lineShapeTEA.Visible = false;
                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtConstante.Visible = true;
                    lineCF.Visible = true;

                    lblResultadoFormula.Text = "P = A * ((1+i)^n-1 / i*(1+i)^n) + (g/i) ....";
                    break;
                case "Gradiente Lineal Decreciente":
                    lblVariacionPorcentual.Visible = false;
                    txtVariacionPorcentual.Visible = false;
                    lineShapeVariacionPorcentual.Visible = false;
                    lblTEA.Visible = false;
                    txtTEA.Visible = false;
                    lineShapeTEA.Visible = false;
                    lblCapitalFinal.Visible = true;
                    lblDolarCF.Visible = true;
                    txtConstante.Visible = true;
                    lineCF.Visible = true;

                    lblResultadoFormula.Text = "P = A * ((1+i)^n-1 / i*(1+i)^n) - (g/i) ....";
                    break;
                case "Gradiente Geometrico Creciente":
                    lblVariacionPorcentual.Visible = true;
                    txtVariacionPorcentual.Visible = true;
                    lineShapeVariacionPorcentual.Visible = true;
                    lblTEA.Visible = false;
                    txtTEA.Visible = false;
                    lineShapeTEA.Visible = false;
                    lblCapitalFinal.Visible = false;
                    lblDolarCF.Visible = false;
                    txtConstante.Visible = false;
                    lineCF.Visible = false;

                    lblResultadoFormula.Text = "P = A*(((1+j)^n-(1+i)^n)/(j-i)*(1+i)^n)";
                    break;
                case "Gradiente Geometrico Decreciente":
                    lblVariacionPorcentual.Visible = true;
                    txtVariacionPorcentual.Visible = true;
                    lineShapeVariacionPorcentual.Visible = true;
                    lblTEA.Visible = false;
                    txtTEA.Visible = false;
                    lineShapeTEA.Visible = false;
                    lblCapitalFinal.Visible = false;
                    lblDolarCF.Visible = false;
                    txtConstante.Visible = false;
                    lineCF.Visible = false;

                    lblResultadoFormula.Text = "P = A*(((1+i)^n-(1-j)^n)/(j+i)*(1+i)^n)";
                    break;
                case "Gradiente Escalonado o en Escalera":
                    lblVariacionPorcentual.Visible = false;
                    txtVariacionPorcentual.Visible = false;
                    lineShapeVariacionPorcentual.Visible = false;
                    lblTEA.Visible = true;
                    txtTEA.Visible = true;
                    lineShapeTEA.Visible = true;
                    lblCapitalFinal.Visible = false;
                    lblDolarCF.Visible = false;
                    txtConstante.Visible = false;
                    lineCF.Visible = false;
                    break;
            }
        }

        private void Gradiente_Load(object sender, EventArgs e)
        {

            lblVariacionPorcentual.Visible = false;
            lblTEA.Visible = false;
            txtVariacionPorcentual.Visible = false;
            txtTEA.Visible = false;
            lineShapeTEA.Visible = false;
            lineShapeVariacionPorcentual.Visible = false;
        }

        public void CalcularGradienteLinealCreciente()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);
            double g = double.Parse(txtConstante.Text);

            double p = a * ((Math.Pow(1 + i, n) - 1) / (i * Math.Pow(1 + i, n))) + (g / i) * (((Math.Pow(1 + i, n) - 1) / (i * Math.Pow(1 + i, n))) - ((n) / (Math.Pow(1 + i, n))));
            txtResultado.Text = p.ToString("N2");
        }

        public void CalcularGradienteLinealDecreciente()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);
            double g = double.Parse(txtConstante.Text);

            double p = a * ((Math.Pow(1 + i, n) - 1) / (i * Math.Pow(1 + i, n))) + (g / i) * (((Math.Pow(1 + i, n) - 1) / (i * Math.Pow(1 + i, n))) - ((n) / (Math.Pow(1 + i, n))));
            txtResultado.Text = p.ToString("N2");
        }

        public void CalcularGradienteGeometricoCreciente()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);
            double j = double.Parse(txtVariacionPorcentual.Text);

            // formula cambiarla en un ciclo
            // double p = a * (Math.Pow(1 + j, n) - Math.Pow(1 + i, n) / (j-i)* Math.Pow(1 + i, n));
            //txtResultado.Text = p.ToString("N2");
        }

        public void CalcularGradienteGeometricoDecreciente()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);
            double j = double.Parse(txtVariacionPorcentual.Text);

            // formula cambiarla en un ciclo
        }

        public void CalcularGradienteEscalonadooEscalera()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);
            double TEA = double.Parse(txtTEA.Text);

            // formula cambiarla en un ciclo
            // add mas campos
        }
    }
}