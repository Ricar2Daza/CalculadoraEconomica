namespace Presentacion
{
    partial class Gradiente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gradiente));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCalcular = new System.Windows.Forms.ComboBox();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtVariacionPorcentual = new System.Windows.Forms.TextBox();
            this.lblTEA = new System.Windows.Forms.Label();
            this.txtTEA = new System.Windows.Forms.TextBox();
            this.lblVariacionPorcentual = new System.Windows.Forms.Label();
            this.txtConstante = new System.Windows.Forms.TextBox();
            this.lblDolarCF = new System.Windows.Forms.Label();
            this.lblCapitalFinal = new System.Windows.Forms.Label();
            this.lblDolarCI = new System.Windows.Forms.Label();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.txtTipoInteres = new System.Windows.Forms.TextBox();
            this.lblPorcentajeTI = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtPrimeraCuota = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTipoInteres = new System.Windows.Forms.Label();
            this.lblCapitalInicial = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineCF = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineTiempo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineTI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineCI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelFormula = new System.Windows.Forms.Panel();
            this.lblResultFormula = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lineShapeVariacionPorcentual = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShapeTEA = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblResultadoFormula = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelFormula.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbCalcular);
            this.panel2.Controls.Add(this.lblCalcular);
            this.panel2.Location = new System.Drawing.Point(186, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 68);
            this.panel2.TabIndex = 38;
            // 
            // cmbCalcular
            // 
            this.cmbCalcular.BackColor = System.Drawing.Color.Navy;
            this.cmbCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCalcular.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmbCalcular.FormattingEnabled = true;
            this.cmbCalcular.Items.AddRange(new object[] {
            "Gradiente Lineal Creciente",
            "Gradiente Lineal Decreciente",
            "Gradiente Geometrico Creciente",
            "Gradiente Geometrico Decreciente",
            "Gradiente Escalonado o en Escalera"});
            this.cmbCalcular.Location = new System.Drawing.Point(165, 19);
            this.cmbCalcular.Name = "cmbCalcular";
            this.cmbCalcular.Size = new System.Drawing.Size(222, 28);
            this.cmbCalcular.TabIndex = 33;
            this.cmbCalcular.Text = "Seleccionar";
            this.cmbCalcular.SelectedIndexChanged += new System.EventHandler(this.cmbCalcular_SelectedIndexChanged);
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcular.ForeColor = System.Drawing.Color.Navy;
            this.lblCalcular.Location = new System.Drawing.Point(12, 24);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(137, 20);
            this.lblCalcular.TabIndex = 32;
            this.lblCalcular.Text = "Quiero Calcular:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(186, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 49);
            this.panel1.TabIndex = 61;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(101, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "GRADIENTES";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTEA);
            this.panel4.Controls.Add(this.txtVariacionPorcentual);
            this.panel4.Controls.Add(this.txtTEA);
            this.panel4.Controls.Add(this.lblVariacionPorcentual);
            this.panel4.Controls.Add(this.txtConstante);
            this.panel4.Controls.Add(this.lblDolarCF);
            this.panel4.Controls.Add(this.lblCapitalFinal);
            this.panel4.Controls.Add(this.lblDolarCI);
            this.panel4.Controls.Add(this.cmbTiempo);
            this.panel4.Controls.Add(this.txtTipoInteres);
            this.panel4.Controls.Add(this.lblPorcentajeTI);
            this.panel4.Controls.Add(this.txtIngresos);
            this.panel4.Controls.Add(this.txtPrimeraCuota);
            this.panel4.Controls.Add(this.lblTiempo);
            this.panel4.Controls.Add(this.lblTipoInteres);
            this.panel4.Controls.Add(this.lblCapitalInicial);
            this.panel4.Controls.Add(this.shapeContainer3);
            this.panel4.Location = new System.Drawing.Point(185, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 218);
            this.panel4.TabIndex = 66;
            // 
            // txtVariacionPorcentual
            // 
            this.txtVariacionPorcentual.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtVariacionPorcentual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVariacionPorcentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariacionPorcentual.ForeColor = System.Drawing.Color.Navy;
            this.txtVariacionPorcentual.Location = new System.Drawing.Point(228, 174);
            this.txtVariacionPorcentual.Name = "txtVariacionPorcentual";
            this.txtVariacionPorcentual.Size = new System.Drawing.Size(154, 19);
            this.txtVariacionPorcentual.TabIndex = 41;
            this.txtVariacionPorcentual.Text = "0";
            // 
            // lblTEA
            // 
            this.lblTEA.AutoSize = true;
            this.lblTEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEA.ForeColor = System.Drawing.Color.Navy;
            this.lblTEA.Location = new System.Drawing.Point(16, 174);
            this.lblTEA.Name = "lblTEA";
            this.lblTEA.Size = new System.Drawing.Size(48, 20);
            this.lblTEA.TabIndex = 40;
            this.lblTEA.Text = "TEA:";
            // 
            // txtTEA
            // 
            this.txtTEA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEA.ForeColor = System.Drawing.Color.Navy;
            this.txtTEA.Location = new System.Drawing.Point(168, 174);
            this.txtTEA.Name = "txtTEA";
            this.txtTEA.Size = new System.Drawing.Size(214, 19);
            this.txtTEA.TabIndex = 39;
            this.txtTEA.Text = "0";
            // 
            // lblVariacionPorcentual
            // 
            this.lblVariacionPorcentual.AutoSize = true;
            this.lblVariacionPorcentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariacionPorcentual.ForeColor = System.Drawing.Color.Navy;
            this.lblVariacionPorcentual.Location = new System.Drawing.Point(16, 177);
            this.lblVariacionPorcentual.Name = "lblVariacionPorcentual";
            this.lblVariacionPorcentual.Size = new System.Drawing.Size(201, 20);
            this.lblVariacionPorcentual.TabIndex = 38;
            this.lblVariacionPorcentual.Text = "Variacion Porcentual (j):";
            // 
            // txtConstante
            // 
            this.txtConstante.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtConstante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstante.ForeColor = System.Drawing.Color.Navy;
            this.txtConstante.Location = new System.Drawing.Point(203, 138);
            this.txtConstante.Name = "txtConstante";
            this.txtConstante.Size = new System.Drawing.Size(182, 19);
            this.txtConstante.TabIndex = 36;
            this.txtConstante.Text = "0";
            // 
            // lblDolarCF
            // 
            this.lblDolarCF.AutoSize = true;
            this.lblDolarCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarCF.ForeColor = System.Drawing.Color.Navy;
            this.lblDolarCF.Location = new System.Drawing.Point(178, 137);
            this.lblDolarCF.Name = "lblDolarCF";
            this.lblDolarCF.Size = new System.Drawing.Size(19, 20);
            this.lblDolarCF.TabIndex = 35;
            this.lblDolarCF.Text = "$";
            // 
            // lblCapitalFinal
            // 
            this.lblCapitalFinal.AutoSize = true;
            this.lblCapitalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalFinal.ForeColor = System.Drawing.Color.Navy;
            this.lblCapitalFinal.Location = new System.Drawing.Point(16, 138);
            this.lblCapitalFinal.Name = "lblCapitalFinal";
            this.lblCapitalFinal.Size = new System.Drawing.Size(128, 20);
            this.lblCapitalFinal.TabIndex = 34;
            this.lblCapitalFinal.Text = "Constante (G):";
            // 
            // lblDolarCI
            // 
            this.lblDolarCI.AutoSize = true;
            this.lblDolarCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarCI.ForeColor = System.Drawing.Color.Navy;
            this.lblDolarCI.Location = new System.Drawing.Point(178, 13);
            this.lblDolarCI.Name = "lblDolarCI";
            this.lblDolarCI.Size = new System.Drawing.Size(19, 20);
            this.lblDolarCI.TabIndex = 27;
            this.lblDolarCI.Text = "$";
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbTiempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTiempo.ForeColor = System.Drawing.Color.Navy;
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Items.AddRange(new object[] {
            "Dias",
            "Meses",
            "Trimestres",
            "Semestres",
            "Años"});
            this.cmbTiempo.Location = new System.Drawing.Point(220, 91);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(166, 28);
            this.cmbTiempo.TabIndex = 26;
            this.cmbTiempo.Text = "Seleccionar";
            // 
            // txtTipoInteres
            // 
            this.txtTipoInteres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTipoInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.txtTipoInteres.Location = new System.Drawing.Point(181, 57);
            this.txtTipoInteres.Name = "txtTipoInteres";
            this.txtTipoInteres.Size = new System.Drawing.Size(30, 19);
            this.txtTipoInteres.TabIndex = 25;
            this.txtTipoInteres.Text = "0";
            // 
            // lblPorcentajeTI
            // 
            this.lblPorcentajeTI.AutoSize = true;
            this.lblPorcentajeTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeTI.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeTI.Location = new System.Drawing.Point(216, 57);
            this.lblPorcentajeTI.Name = "lblPorcentajeTI";
            this.lblPorcentajeTI.Size = new System.Drawing.Size(24, 20);
            this.lblPorcentajeTI.TabIndex = 19;
            this.lblPorcentajeTI.Text = "%";
            // 
            // txtIngresos
            // 
            this.txtIngresos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresos.ForeColor = System.Drawing.Color.Navy;
            this.txtIngresos.Location = new System.Drawing.Point(181, 96);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(36, 19);
            this.txtIngresos.TabIndex = 17;
            this.txtIngresos.Text = "0";
            // 
            // txtPrimeraCuota
            // 
            this.txtPrimeraCuota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrimeraCuota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimeraCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeraCuota.ForeColor = System.Drawing.Color.Navy;
            this.txtPrimeraCuota.Location = new System.Drawing.Point(203, 13);
            this.txtPrimeraCuota.Name = "txtPrimeraCuota";
            this.txtPrimeraCuota.Size = new System.Drawing.Size(183, 19);
            this.txtPrimeraCuota.TabIndex = 16;
            this.txtPrimeraCuota.Text = "0";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Navy;
            this.lblTiempo.Location = new System.Drawing.Point(15, 97);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(111, 20);
            this.lblTiempo.TabIndex = 11;
            this.lblTiempo.Text = "Ingresos (n):";
            // 
            // lblTipoInteres
            // 
            this.lblTipoInteres.AutoSize = true;
            this.lblTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoInteres.Location = new System.Drawing.Point(15, 57);
            this.lblTipoInteres.Name = "lblTipoInteres";
            this.lblTipoInteres.Size = new System.Drawing.Size(161, 20);
            this.lblTipoInteres.TabIndex = 10;
            this.lblTipoInteres.Text = "Tasa de Interes (i):";
            // 
            // lblCapitalInicial
            // 
            this.lblCapitalInicial.AutoSize = true;
            this.lblCapitalInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalInicial.ForeColor = System.Drawing.Color.Navy;
            this.lblCapitalInicial.Location = new System.Drawing.Point(15, 12);
            this.lblCapitalInicial.Name = "lblCapitalInicial";
            this.lblCapitalInicial.Size = new System.Drawing.Size(157, 20);
            this.lblCapitalInicial.TabIndex = 8;
            this.lblCapitalInicial.Text = "Primera Cuota (A):";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShapeTEA,
            this.lineShapeVariacionPorcentual,
            this.lineCF,
            this.lineTiempo,
            this.lineTI,
            this.lineCI});
            this.shapeContainer3.Size = new System.Drawing.Size(412, 216);
            this.shapeContainer3.TabIndex = 37;
            this.shapeContainer3.TabStop = false;
            // 
            // lineCF
            // 
            this.lineCF.BorderColor = System.Drawing.Color.Navy;
            this.lineCF.Name = "lineCF";
            this.lineCF.X1 = 203;
            this.lineCF.X2 = 382;
            this.lineCF.Y1 = 160;
            this.lineCF.Y2 = 160;
            // 
            // lineTiempo
            // 
            this.lineTiempo.BorderColor = System.Drawing.Color.Navy;
            this.lineTiempo.Name = "lineTiempo";
            this.lineTiempo.X1 = 178;
            this.lineTiempo.X2 = 219;
            this.lineTiempo.Y1 = 119;
            this.lineTiempo.Y2 = 119;
            // 
            // lineTI
            // 
            this.lineTI.BorderColor = System.Drawing.Color.Navy;
            this.lineTI.Name = "lineTI";
            this.lineTI.X1 = 178;
            this.lineTI.X2 = 212;
            this.lineTI.Y1 = 79;
            this.lineTI.Y2 = 79;
            // 
            // lineCI
            // 
            this.lineCI.BorderColor = System.Drawing.Color.Navy;
            this.lineCI.Name = "lineCI";
            this.lineCI.X1 = 203;
            this.lineCI.X2 = 383;
            this.lineCI.Y1 = 34;
            this.lineCI.Y2 = 34;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Controls.Add(this.txtResultado);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Location = new System.Drawing.Point(186, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 68);
            this.panel3.TabIndex = 65;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Navy;
            this.lblResultado.Location = new System.Drawing.Point(15, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 20);
            this.lblResultado.TabIndex = 29;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Navy;
            this.txtResultado.Location = new System.Drawing.Point(165, 19);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(217, 19);
            this.txtResultado.TabIndex = 30;
            this.txtResultado.Text = "0";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5});
            this.shapeContainer2.Size = new System.Drawing.Size(411, 66);
            this.shapeContainer2.TabIndex = 32;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.Navy;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 164;
            this.lineShape5.X2 = 384;
            this.lineShape5.Y1 = 41;
            this.lineShape5.Y2 = 41;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(186, 645);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(412, 47);
            this.btnReset.TabIndex = 64;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(186, 575);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(412, 47);
            this.btnCalcular.TabIndex = 63;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelFormula
            // 
            this.panelFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormula.Controls.Add(this.lblResultadoFormula);
            this.panelFormula.Controls.Add(this.lblResultFormula);
            this.panelFormula.Controls.Add(this.lblFormula);
            this.panelFormula.Location = new System.Drawing.Point(186, 410);
            this.panelFormula.Name = "panelFormula";
            this.panelFormula.Size = new System.Drawing.Size(414, 60);
            this.panelFormula.TabIndex = 67;
            // 
            // lblResultFormula
            // 
            this.lblResultFormula.AutoSize = true;
            this.lblResultFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFormula.ForeColor = System.Drawing.Color.Navy;
            this.lblResultFormula.Location = new System.Drawing.Point(100, 19);
            this.lblResultFormula.Name = "lblResultFormula";
            this.lblResultFormula.Size = new System.Drawing.Size(0, 20);
            this.lblResultFormula.TabIndex = 34;
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.ForeColor = System.Drawing.Color.Navy;
            this.lblFormula.Location = new System.Drawing.Point(15, 19);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(79, 20);
            this.lblFormula.TabIndex = 33;
            this.lblFormula.Text = "Formula:";
            // 
            // lineShapeVariacionPorcentual
            // 
            this.lineShapeVariacionPorcentual.BorderColor = System.Drawing.Color.Navy;
            this.lineShapeVariacionPorcentual.Name = "lineShapeVariacionPorcentual";
            this.lineShapeVariacionPorcentual.X1 = 229;
            this.lineShapeVariacionPorcentual.X2 = 381;
            this.lineShapeVariacionPorcentual.Y1 = 195;
            this.lineShapeVariacionPorcentual.Y2 = 195;
            // 
            // lineShapeTEA
            // 
            this.lineShapeTEA.BorderColor = System.Drawing.Color.Navy;
            this.lineShapeTEA.Name = "lineShapeTEA";
            this.lineShapeTEA.X1 = 167;
            this.lineShapeTEA.X2 = 381;
            this.lineShapeTEA.Y1 = 196;
            this.lineShapeTEA.Y2 = 196;
            // 
            // lblResultadoFormula
            // 
            this.lblResultadoFormula.AutoSize = true;
            this.lblResultadoFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoFormula.ForeColor = System.Drawing.Color.Navy;
            this.lblResultadoFormula.Location = new System.Drawing.Point(104, 19);
            this.lblResultadoFormula.Name = "lblResultadoFormula";
            this.lblResultadoFormula.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoFormula.TabIndex = 35;
            // 
            // Gradiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 720);
            this.Controls.Add(this.panelFormula);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gradiente";
            this.Text = "Gradiente";
            this.Load += new System.EventHandler(this.Gradiente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelFormula.ResumeLayout(false);
            this.panelFormula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCalcular;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtConstante;
        private System.Windows.Forms.Label lblDolarCF;
        private System.Windows.Forms.Label lblCapitalFinal;
        private System.Windows.Forms.Label lblDolarCI;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.TextBox txtTipoInteres;
        private System.Windows.Forms.Label lblPorcentajeTI;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtPrimeraCuota;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTipoInteres;
        private System.Windows.Forms.Label lblCapitalInicial;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCF;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTiempo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTI;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCI;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelFormula;
        private System.Windows.Forms.Label lblResultFormula;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblTEA;
        private System.Windows.Forms.TextBox txtTEA;
        private System.Windows.Forms.Label lblVariacionPorcentual;
        private System.Windows.Forms.TextBox txtVariacionPorcentual;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeVariacionPorcentual;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeTEA;
        private System.Windows.Forms.Label lblResultadoFormula;
    }
}