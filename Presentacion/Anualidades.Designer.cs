namespace Presentacion
{
    partial class Anualidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anualidades));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDolarCI = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lineCI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.txtTipoInteres = new System.Windows.Forms.TextBox();
            this.lblPorcentajeTI = new System.Windows.Forms.Label();
            this.lblTipoInteres = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbNumeroPeriodos = new System.Windows.Forms.ComboBox();
            this.lblNumeroPeriodos = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineTiempo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineTI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.cmbCalcular = new System.Windows.Forms.ComboBox();
            this.cmbValor = new System.Windows.Forms.ComboBox();
            this.cmbInicioPago = new System.Windows.Forms.ComboBox();
            this.panelFormula = new System.Windows.Forms.Panel();
            this.lblResultadoFormula = new System.Windows.Forms.Label();
            this.lblResultFormula = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelFormula.SuspendLayout();
            this.SuspendLayout();
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
            this.btnReset.TabIndex = 58;
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
            this.btnCalcular.Location = new System.Drawing.Point(186, 580);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(412, 47);
            this.btnCalcular.TabIndex = 57;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(187, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 49);
            this.panel1.TabIndex = 60;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(89, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "ANUALIDADES";
            // 
            // lblDolarCI
            // 
            this.lblDolarCI.AutoSize = true;
            this.lblDolarCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarCI.ForeColor = System.Drawing.Color.Navy;
            this.lblDolarCI.Location = new System.Drawing.Point(21, 30);
            this.lblDolarCI.Name = "lblDolarCI";
            this.lblDolarCI.Size = new System.Drawing.Size(19, 20);
            this.lblDolarCI.TabIndex = 64;
            this.lblDolarCI.Text = "$";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Navy;
            this.txtValor.Location = new System.Drawing.Point(42, 30);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(114, 19);
            this.txtValor.TabIndex = 63;
            this.txtValor.Text = "0";
            // 
            // lineCI
            // 
            this.lineCI.BorderColor = System.Drawing.Color.Navy;
            this.lineCI.Name = "lineCI";
            this.lineCI.X1 = 42;
            this.lineCI.X2 = 154;
            this.lineCI.Y1 = 49;
            this.lineCI.Y2 = 49;
            this.lineCI.Click += new System.EventHandler(this.lineCI_Click);
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoPago.Location = new System.Drawing.Point(21, 78);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(119, 20);
            this.lblTipoPago.TabIndex = 66;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // txtTipoInteres
            // 
            this.txtTipoInteres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTipoInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.txtTipoInteres.Location = new System.Drawing.Point(203, 125);
            this.txtTipoInteres.Name = "txtTipoInteres";
            this.txtTipoInteres.Size = new System.Drawing.Size(30, 19);
            this.txtTipoInteres.TabIndex = 73;
            this.txtTipoInteres.Text = "0";
            // 
            // lblPorcentajeTI
            // 
            this.lblPorcentajeTI.AutoSize = true;
            this.lblPorcentajeTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeTI.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeTI.Location = new System.Drawing.Point(238, 125);
            this.lblPorcentajeTI.Name = "lblPorcentajeTI";
            this.lblPorcentajeTI.Size = new System.Drawing.Size(24, 20);
            this.lblPorcentajeTI.TabIndex = 72;
            this.lblPorcentajeTI.Text = "%";
            // 
            // lblTipoInteres
            // 
            this.lblTipoInteres.AutoSize = true;
            this.lblTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInteres.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoInteres.Location = new System.Drawing.Point(21, 124);
            this.lblTipoInteres.Name = "lblTipoInteres";
            this.lblTipoInteres.Size = new System.Drawing.Size(135, 20);
            this.lblTipoInteres.TabIndex = 71;
            this.lblTipoInteres.Text = "Tipo de Interes:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbValor);
            this.panel4.Controls.Add(this.txtValor);
            this.panel4.Controls.Add(this.lblDolarCI);
            this.panel4.Controls.Add(this.cmbInicioPago);
            this.panel4.Controls.Add(this.lblTipoPago);
            this.panel4.Controls.Add(this.cmbNumeroPeriodos);
            this.panel4.Controls.Add(this.lblNumeroPeriodos);
            this.panel4.Controls.Add(this.txtTiempo);
            this.panel4.Controls.Add(this.lblTipoInteres);
            this.panel4.Controls.Add(this.txtTipoInteres);
            this.panel4.Controls.Add(this.lblPorcentajeTI);
            this.panel4.Controls.Add(this.shapeContainer1);
            this.panel4.Location = new System.Drawing.Point(185, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 221);
            this.panel4.TabIndex = 74;
            // 
            // cmbNumeroPeriodos
            // 
            this.cmbNumeroPeriodos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbNumeroPeriodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNumeroPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNumeroPeriodos.ForeColor = System.Drawing.Color.Navy;
            this.cmbNumeroPeriodos.FormattingEnabled = true;
            this.cmbNumeroPeriodos.Items.AddRange(new object[] {
            "Mesual",
            "Trimestral",
            "Anual"});
            this.cmbNumeroPeriodos.Location = new System.Drawing.Point(242, 168);
            this.cmbNumeroPeriodos.Name = "cmbNumeroPeriodos";
            this.cmbNumeroPeriodos.Size = new System.Drawing.Size(149, 28);
            this.cmbNumeroPeriodos.TabIndex = 77;
            this.cmbNumeroPeriodos.Text = "Seleccionar";
            // 
            // lblNumeroPeriodos
            // 
            this.lblNumeroPeriodos.AutoSize = true;
            this.lblNumeroPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPeriodos.ForeColor = System.Drawing.Color.Navy;
            this.lblNumeroPeriodos.Location = new System.Drawing.Point(21, 176);
            this.lblNumeroPeriodos.Name = "lblNumeroPeriodos";
            this.lblNumeroPeriodos.Size = new System.Drawing.Size(176, 20);
            this.lblNumeroPeriodos.TabIndex = 75;
            this.lblNumeroPeriodos.Text = "Número de Periodos:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.ForeColor = System.Drawing.Color.Navy;
            this.txtTiempo.Location = new System.Drawing.Point(206, 173);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(36, 19);
            this.txtTiempo.TabIndex = 76;
            this.txtTiempo.Text = "0";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineCI,
            this.lineTiempo,
            this.lineTI});
            this.shapeContainer1.Size = new System.Drawing.Size(410, 219);
            this.shapeContainer1.TabIndex = 74;
            this.shapeContainer1.TabStop = false;
            // 
            // lineTiempo
            // 
            this.lineTiempo.BorderColor = System.Drawing.Color.Navy;
            this.lineTiempo.Name = "lineTiempo";
            this.lineTiempo.X1 = 202;
            this.lineTiempo.X2 = 241;
            this.lineTiempo.Y1 = 196;
            this.lineTiempo.Y2 = 196;
            // 
            // lineTI
            // 
            this.lineTI.BorderColor = System.Drawing.Color.Navy;
            this.lineTI.Name = "lineTI";
            this.lineTI.X1 = 204;
            this.lineTI.X2 = 233;
            this.lineTI.Y1 = 147;
            this.lineTI.Y2 = 147;
            this.lineTI.Click += new System.EventHandler(this.lineShape3_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblResultado);
            this.panel6.Controls.Add(this.txtResultado);
            this.panel6.Controls.Add(this.shapeContainer4);
            this.panel6.Location = new System.Drawing.Point(186, 490);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(412, 68);
            this.panel6.TabIndex = 76;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Navy;
            this.lblResultado.Location = new System.Drawing.Point(11, 22);
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
            this.txtResultado.Location = new System.Drawing.Point(187, 19);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(199, 19);
            this.txtResultado.TabIndex = 30;
            this.txtResultado.Text = "0";
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5});
            this.shapeContainer4.Size = new System.Drawing.Size(410, 66);
            this.shapeContainer4.TabIndex = 32;
            this.shapeContainer4.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.Navy;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 186;
            this.lineShape5.X2 = 383;
            this.lineShape5.Y1 = 41;
            this.lineShape5.Y2 = 41;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblCalcular);
            this.panel7.Controls.Add(this.cmbCalcular);
            this.panel7.Location = new System.Drawing.Point(186, 83);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(412, 68);
            this.panel7.TabIndex = 77;
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
            "Anualidades Anticipadas",
            "Anualidades Total"});
            this.cmbCalcular.Location = new System.Drawing.Point(172, 19);
            this.cmbCalcular.Name = "cmbCalcular";
            this.cmbCalcular.Size = new System.Drawing.Size(218, 28);
            this.cmbCalcular.TabIndex = 33;
            this.cmbCalcular.Text = "Seleccionar";
            this.cmbCalcular.SelectedIndexChanged += new System.EventHandler(this.cmbCalcular_SelectedIndexChanged);
            // 
            // cmbValor
            // 
            this.cmbValor.BackColor = System.Drawing.Color.Navy;
            this.cmbValor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbValor.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmbValor.FormattingEnabled = true;
            this.cmbValor.Items.AddRange(new object[] {
            "Valor Actual",
            "Valor Futuro"});
            this.cmbValor.Location = new System.Drawing.Point(200, 21);
            this.cmbValor.Name = "cmbValor";
            this.cmbValor.Size = new System.Drawing.Size(191, 28);
            this.cmbValor.TabIndex = 66;
            this.cmbValor.Text = "Seleccionar";
            // 
            // cmbInicioPago
            // 
            this.cmbInicioPago.BackColor = System.Drawing.Color.Navy;
            this.cmbInicioPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbInicioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbInicioPago.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmbInicioPago.FormattingEnabled = true;
            this.cmbInicioPago.Items.AddRange(new object[] {
            "Inicio del Periodo",
            "Final del Periodo"});
            this.cmbInicioPago.Location = new System.Drawing.Point(200, 70);
            this.cmbInicioPago.Name = "cmbInicioPago";
            this.cmbInicioPago.Size = new System.Drawing.Size(191, 28);
            this.cmbInicioPago.TabIndex = 67;
            this.cmbInicioPago.Text = "Seleccionar";
            // 
            // panelFormula
            // 
            this.panelFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormula.Controls.Add(this.label1);
            this.panelFormula.Controls.Add(this.lblResultadoFormula);
            this.panelFormula.Controls.Add(this.lblResultFormula);
            this.panelFormula.Controls.Add(this.lblFormula);
            this.panelFormula.Location = new System.Drawing.Point(183, 411);
            this.panelFormula.Name = "panelFormula";
            this.panelFormula.Size = new System.Drawing.Size(414, 60);
            this.panelFormula.TabIndex = 78;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(256, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Formula:";
            // 
            // Anualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 720);
            this.Controls.Add(this.panelFormula);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anualidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Anualidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelFormula.ResumeLayout(false);
            this.panelFormula.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDolarCI;
        private System.Windows.Forms.TextBox txtValor;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineCI;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.TextBox txtTipoInteres;
        private System.Windows.Forms.Label lblPorcentajeTI;
        private System.Windows.Forms.Label lblTipoInteres;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTI;
        private System.Windows.Forms.Label lblNumeroPeriodos;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ComboBox cmbNumeroPeriodos;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineTiempo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.ComboBox cmbCalcular;
        private System.Windows.Forms.ComboBox cmbValor;
        private System.Windows.Forms.ComboBox cmbInicioPago;
        private System.Windows.Forms.Panel panelFormula;
        private System.Windows.Forms.Label lblResultadoFormula;
        private System.Windows.Forms.Label lblResultFormula;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label1;
    }
}