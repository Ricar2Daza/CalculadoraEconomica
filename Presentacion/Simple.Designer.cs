namespace Presentacion
{
    partial class Simple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simple));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCapitalInicial = new System.Windows.Forms.Label();
            this.lblTipoInteres = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lineCI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineCF = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineTiempo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtCapitalInicial = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblPorcentajeTI = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTipoInteres = new System.Windows.Forms.TextBox();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDolarCI = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.cmbCalcular = new System.Windows.Forms.ComboBox();
            this.lblCapitalFinal = new System.Windows.Forms.Label();
            this.lblDolarCF = new System.Windows.Forms.Label();
            this.txtCapitalFinal = new System.Windows.Forms.TextBox();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPreguntaCapitalFinal = new System.Windows.Forms.Button();
            this.btnPreguntaTiempo = new System.Windows.Forms.Button();
            this.btnPreguntaTipoInteres = new System.Windows.Forms.Button();
            this.btnPreguntaCapitalInicial = new System.Windows.Forms.Button();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineTI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelFormula = new System.Windows.Forms.Panel();
            this.lblResultFormula = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelFormula.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "INTERES SIMPLE";
            // 
            // lblCapitalInicial
            // 
            this.lblCapitalInicial.AutoSize = true;
            this.lblCapitalInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalInicial.ForeColor = System.Drawing.Color.Navy;
            this.lblCapitalInicial.Location = new System.Drawing.Point(15, 12);
            this.lblCapitalInicial.Name = "lblCapitalInicial";
            this.lblCapitalInicial.Size = new System.Drawing.Size(122, 20);
            this.lblCapitalInicial.TabIndex = 8;
            this.lblCapitalInicial.Text = "Capital Inicial:";
            this.lblCapitalInicial.Click += new System.EventHandler(this.lblCodVuelo_Click);
            // 
            // lblTipoInteres
            // 
            this.lblTipoInteres.AutoSize = true;
            this.lblTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoInteres.Location = new System.Drawing.Point(15, 57);
            this.lblTipoInteres.Name = "lblTipoInteres";
            this.lblTipoInteres.Size = new System.Drawing.Size(140, 20);
            this.lblTipoInteres.TabIndex = 10;
            this.lblTipoInteres.Text = "Tasa de Interes:";
            this.lblTipoInteres.Click += new System.EventHandler(this.lblTasaInteres_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Navy;
            this.lblTiempo.Location = new System.Drawing.Point(15, 97);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(129, 20);
            this.lblTiempo.TabIndex = 11;
            this.lblTiempo.Text = "Plazo de Pago:";
            this.lblTiempo.Click += new System.EventHandler(this.lblTiempo_Click);
            // 
            // lineCI
            // 
            this.lineCI.BorderColor = System.Drawing.Color.Navy;
            this.lineCI.Name = "lineCI";
            this.lineCI.X1 = 205;
            this.lineCI.X2 = 383;
            this.lineCI.Y1 = 34;
            this.lineCI.Y2 = 34;
            // 
            // lineCF
            // 
            this.lineCF.BorderColor = System.Drawing.Color.Navy;
            this.lineCF.Name = "lineCF";
            this.lineCF.X1 = 207;
            this.lineCF.X2 = 382;
            this.lineCF.Y1 = 160;
            this.lineCF.Y2 = 160;
            // 
            // lineTiempo
            // 
            this.lineTiempo.BorderColor = System.Drawing.Color.Navy;
            this.lineTiempo.Name = "lineTiempo";
            this.lineTiempo.X1 = 186;
            this.lineTiempo.X2 = 224;
            this.lineTiempo.Y1 = 119;
            this.lineTiempo.Y2 = 119;
            // 
            // txtCapitalInicial
            // 
            this.txtCapitalInicial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapitalInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapitalInicial.ForeColor = System.Drawing.Color.Navy;
            this.txtCapitalInicial.Location = new System.Drawing.Point(203, 13);
            this.txtCapitalInicial.Name = "txtCapitalInicial";
            this.txtCapitalInicial.Size = new System.Drawing.Size(183, 19);
            this.txtCapitalInicial.TabIndex = 16;
            this.txtCapitalInicial.Text = "0";
            this.txtCapitalInicial.TextChanged += new System.EventHandler(this.txtCapitalInicial_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.ForeColor = System.Drawing.Color.Navy;
            this.txtTiempo.Location = new System.Drawing.Point(186, 96);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(36, 19);
            this.txtTiempo.TabIndex = 17;
            this.txtTiempo.Text = "0";
            this.txtTiempo.TextChanged += new System.EventHandler(this.txtTiempo_TextChanged);
            // 
            // lblPorcentajeTI
            // 
            this.lblPorcentajeTI.AutoSize = true;
            this.lblPorcentajeTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeTI.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeTI.Location = new System.Drawing.Point(224, 57);
            this.lblPorcentajeTI.Name = "lblPorcentajeTI";
            this.lblPorcentajeTI.Size = new System.Drawing.Size(24, 20);
            this.lblPorcentajeTI.TabIndex = 19;
            this.lblPorcentajeTI.Text = "%";
            this.lblPorcentajeTI.Click += new System.EventHandler(this.lblPorcentaje_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(187, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 49);
            this.panel1.TabIndex = 21;
            // 
            // txtTipoInteres
            // 
            this.txtTipoInteres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTipoInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.txtTipoInteres.Location = new System.Drawing.Point(186, 57);
            this.txtTipoInteres.Name = "txtTipoInteres";
            this.txtTipoInteres.Size = new System.Drawing.Size(30, 19);
            this.txtTipoInteres.TabIndex = 25;
            this.txtTipoInteres.Text = "0";
            this.txtTipoInteres.TextChanged += new System.EventHandler(this.txtTasaInteres_TextChanged);
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
            this.cmbTiempo.Location = new System.Drawing.Point(225, 91);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(161, 28);
            this.cmbTiempo.TabIndex = 26;
            this.cmbTiempo.Text = "Seleccionar";
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
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnReset.Size = new System.Drawing.Size(411, 47);
            this.btnReset.TabIndex = 7;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDolarCI
            // 
            this.lblDolarCI.AutoSize = true;
            this.lblDolarCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarCI.ForeColor = System.Drawing.Color.Navy;
            this.lblDolarCI.Location = new System.Drawing.Point(180, 13);
            this.lblDolarCI.Name = "lblDolarCI";
            this.lblDolarCI.Size = new System.Drawing.Size(19, 20);
            this.lblDolarCI.TabIndex = 27;
            this.lblDolarCI.Text = "$";
            this.lblDolarCI.Click += new System.EventHandler(this.lblDolar_Click);
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
            // cmbCalcular
            // 
            this.cmbCalcular.BackColor = System.Drawing.Color.Navy;
            this.cmbCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCalcular.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmbCalcular.FormattingEnabled = true;
            this.cmbCalcular.Items.AddRange(new object[] {
            "Interes Simple",
            "Capital Final",
            "Capital Inicial",
            "Tasa de Interes",
            "Tiempo de Negociacion"});
            this.cmbCalcular.Location = new System.Drawing.Point(165, 19);
            this.cmbCalcular.Name = "cmbCalcular";
            this.cmbCalcular.Size = new System.Drawing.Size(222, 28);
            this.cmbCalcular.TabIndex = 33;
            this.cmbCalcular.Text = "Seleccionar";
            this.cmbCalcular.SelectedIndexChanged += new System.EventHandler(this.cmbCalcular_SelectedIndexChanged_1);
            this.cmbCalcular.SelectedValueChanged += new System.EventHandler(this.cmbCalcular_SelectedValueChanged);
            // 
            // lblCapitalFinal
            // 
            this.lblCapitalFinal.AutoSize = true;
            this.lblCapitalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalFinal.ForeColor = System.Drawing.Color.Navy;
            this.lblCapitalFinal.Location = new System.Drawing.Point(16, 138);
            this.lblCapitalFinal.Name = "lblCapitalFinal";
            this.lblCapitalFinal.Size = new System.Drawing.Size(114, 20);
            this.lblCapitalFinal.TabIndex = 34;
            this.lblCapitalFinal.Text = "Capital Final:";
            // 
            // lblDolarCF
            // 
            this.lblDolarCF.AutoSize = true;
            this.lblDolarCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarCF.ForeColor = System.Drawing.Color.Navy;
            this.lblDolarCF.Location = new System.Drawing.Point(183, 137);
            this.lblDolarCF.Name = "lblDolarCF";
            this.lblDolarCF.Size = new System.Drawing.Size(19, 20);
            this.lblDolarCF.TabIndex = 35;
            this.lblDolarCF.Text = "$";
            // 
            // txtCapitalFinal
            // 
            this.txtCapitalFinal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapitalFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapitalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapitalFinal.ForeColor = System.Drawing.Color.Navy;
            this.txtCapitalFinal.Location = new System.Drawing.Point(205, 138);
            this.txtCapitalFinal.Name = "txtCapitalFinal";
            this.txtCapitalFinal.Size = new System.Drawing.Size(180, 19);
            this.txtCapitalFinal.TabIndex = 36;
            this.txtCapitalFinal.Text = "0";
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbCalcular);
            this.panel2.Controls.Add(this.lblCalcular);
            this.panel2.Location = new System.Drawing.Point(186, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 68);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Controls.Add(this.txtResultado);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Location = new System.Drawing.Point(186, 473);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 68);
            this.panel3.TabIndex = 38;
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnPreguntaCapitalFinal);
            this.panel4.Controls.Add(this.btnPreguntaTiempo);
            this.panel4.Controls.Add(this.btnPreguntaTipoInteres);
            this.panel4.Controls.Add(this.btnPreguntaCapitalInicial);
            this.panel4.Controls.Add(this.txtCapitalFinal);
            this.panel4.Controls.Add(this.lblDolarCF);
            this.panel4.Controls.Add(this.lblCapitalFinal);
            this.panel4.Controls.Add(this.lblDolarCI);
            this.panel4.Controls.Add(this.cmbTiempo);
            this.panel4.Controls.Add(this.txtTipoInteres);
            this.panel4.Controls.Add(this.lblPorcentajeTI);
            this.panel4.Controls.Add(this.txtTiempo);
            this.panel4.Controls.Add(this.txtCapitalInicial);
            this.panel4.Controls.Add(this.lblTiempo);
            this.panel4.Controls.Add(this.lblTipoInteres);
            this.panel4.Controls.Add(this.lblCapitalInicial);
            this.panel4.Controls.Add(this.shapeContainer3);
            this.panel4.Location = new System.Drawing.Point(186, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 178);
            this.panel4.TabIndex = 39;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnPreguntaCapitalFinal
            // 
            this.btnPreguntaCapitalFinal.BackColor = System.Drawing.Color.Navy;
            this.btnPreguntaCapitalFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreguntaCapitalFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntaCapitalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntaCapitalFinal.ForeColor = System.Drawing.Color.White;
            this.btnPreguntaCapitalFinal.Location = new System.Drawing.Point(152, 133);
            this.btnPreguntaCapitalFinal.Name = "btnPreguntaCapitalFinal";
            this.btnPreguntaCapitalFinal.Size = new System.Drawing.Size(25, 34);
            this.btnPreguntaCapitalFinal.TabIndex = 41;
            this.btnPreguntaCapitalFinal.Text = "?";
            this.btnPreguntaCapitalFinal.UseVisualStyleBackColor = false;
            this.btnPreguntaCapitalFinal.Click += new System.EventHandler(this.btnPreguntaCapitalFinal_Click);
            // 
            // btnPreguntaTiempo
            // 
            this.btnPreguntaTiempo.BackColor = System.Drawing.Color.Navy;
            this.btnPreguntaTiempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreguntaTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntaTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntaTiempo.ForeColor = System.Drawing.Color.White;
            this.btnPreguntaTiempo.Location = new System.Drawing.Point(152, 91);
            this.btnPreguntaTiempo.Name = "btnPreguntaTiempo";
            this.btnPreguntaTiempo.Size = new System.Drawing.Size(25, 34);
            this.btnPreguntaTiempo.TabIndex = 40;
            this.btnPreguntaTiempo.Text = "?";
            this.btnPreguntaTiempo.UseVisualStyleBackColor = false;
            this.btnPreguntaTiempo.Click += new System.EventHandler(this.btnPreguntaTiempo_Click);
            // 
            // btnPreguntaTipoInteres
            // 
            this.btnPreguntaTipoInteres.BackColor = System.Drawing.Color.Navy;
            this.btnPreguntaTipoInteres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreguntaTipoInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntaTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntaTipoInteres.ForeColor = System.Drawing.Color.White;
            this.btnPreguntaTipoInteres.Location = new System.Drawing.Point(152, 49);
            this.btnPreguntaTipoInteres.Name = "btnPreguntaTipoInteres";
            this.btnPreguntaTipoInteres.Size = new System.Drawing.Size(25, 34);
            this.btnPreguntaTipoInteres.TabIndex = 39;
            this.btnPreguntaTipoInteres.Text = "?";
            this.btnPreguntaTipoInteres.UseVisualStyleBackColor = false;
            this.btnPreguntaTipoInteres.Click += new System.EventHandler(this.btnPreguntaTipoInteres_Click);
            // 
            // btnPreguntaCapitalInicial
            // 
            this.btnPreguntaCapitalInicial.BackColor = System.Drawing.Color.Navy;
            this.btnPreguntaCapitalInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreguntaCapitalInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntaCapitalInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntaCapitalInicial.ForeColor = System.Drawing.Color.White;
            this.btnPreguntaCapitalInicial.Location = new System.Drawing.Point(152, 7);
            this.btnPreguntaCapitalInicial.Name = "btnPreguntaCapitalInicial";
            this.btnPreguntaCapitalInicial.Size = new System.Drawing.Size(25, 34);
            this.btnPreguntaCapitalInicial.TabIndex = 38;
            this.btnPreguntaCapitalInicial.Text = "?";
            this.btnPreguntaCapitalInicial.UseVisualStyleBackColor = false;
            this.btnPreguntaCapitalInicial.Click += new System.EventHandler(this.btnPreguntaCapitalInicial_Click);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineCF,
            this.lineTiempo,
            this.lineTI,
            this.lineCI});
            this.shapeContainer3.Size = new System.Drawing.Size(412, 176);
            this.shapeContainer3.TabIndex = 37;
            this.shapeContainer3.TabStop = false;
            // 
            // lineTI
            // 
            this.lineTI.BorderColor = System.Drawing.Color.Navy;
            this.lineTI.Name = "lineTI";
            this.lineTI.X1 = 187;
            this.lineTI.X2 = 221;
            this.lineTI.Y1 = 79;
            this.lineTI.Y2 = 79;
            this.lineTI.Click += new System.EventHandler(this.lineShape3_Click);
            // 
            // panelFormula
            // 
            this.panelFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormula.Controls.Add(this.lblResultFormula);
            this.panelFormula.Controls.Add(this.lblFormula);
            this.panelFormula.Location = new System.Drawing.Point(186, 384);
            this.panelFormula.Name = "panelFormula";
            this.panelFormula.Size = new System.Drawing.Size(414, 60);
            this.panelFormula.TabIndex = 40;
            // 
            // lblResultFormula
            // 
            this.lblResultFormula.AutoSize = true;
            this.lblResultFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFormula.ForeColor = System.Drawing.Color.Navy;
            this.lblResultFormula.Location = new System.Drawing.Point(159, 19);
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
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 720);
            this.Controls.Add(this.panelFormula);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelo";
            this.Load += new System.EventHandler(this.Simple_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelFormula.ResumeLayout(false);
            this.panelFormula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCapitalInicial;
        private System.Windows.Forms.Label lblTipoInteres;
        private System.Windows.Forms.Label lblTiempo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCI;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTiempo;
        private System.Windows.Forms.TextBox txtCapitalInicial;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblPorcentajeTI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTipoInteres;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDolarCI;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCF;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.ComboBox cmbCalcular;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label lblCapitalFinal;
        private System.Windows.Forms.Label lblDolarCF;
        private System.Windows.Forms.TextBox txtCapitalFinal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Label lblDolarIn;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTI;
        private System.Windows.Forms.Button btnPreguntaCapitalInicial;
        private System.Windows.Forms.Button btnPreguntaTipoInteres;
        private System.Windows.Forms.Button btnPreguntaTiempo;
        private System.Windows.Forms.Button btnPreguntaCapitalFinal;
        private System.Windows.Forms.Panel panelFormula;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblResultFormula;
    }
}