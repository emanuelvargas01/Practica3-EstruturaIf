namespace Practica3_EstruturaIf
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.rbnSuma = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(25, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingresa los valores y selecciona una opcion";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(155, 78);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(10, 16);
            this.lblOperacion.TabIndex = 1;
            this.lblOperacion.Text = ".";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(324, 78);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(14, 16);
            this.lblIgual.TabIndex = 2;
            this.lblIgual.Text = "=";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(28, 72);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(194, 72);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 22);
            this.txt2.TabIndex = 4;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(358, 75);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDivision);
            this.groupBox1.Controls.Add(this.rbtnMultiplicacion);
            this.groupBox1.Controls.Add(this.rbtnResta);
            this.groupBox1.Controls.Add(this.rbnSuma);
            this.groupBox1.Location = new System.Drawing.Point(28, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 233);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(15, 181);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(76, 20);
            this.rbtnDivision.TabIndex = 10;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "Division";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            this.rbtnDivision.CheckedChanged += new System.EventHandler(this.rbtnDivision_CheckedChanged);
            // 
            // rbtnMultiplicacion
            // 
            this.rbtnMultiplicacion.AutoSize = true;
            this.rbtnMultiplicacion.Location = new System.Drawing.Point(15, 137);
            this.rbtnMultiplicacion.Name = "rbtnMultiplicacion";
            this.rbtnMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rbtnMultiplicacion.TabIndex = 9;
            this.rbtnMultiplicacion.TabStop = true;
            this.rbtnMultiplicacion.Text = "Multiplicacion";
            this.rbtnMultiplicacion.UseVisualStyleBackColor = true;
            this.rbtnMultiplicacion.CheckedChanged += new System.EventHandler(this.rbtnMultiplicacion_CheckedChanged);
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(15, 96);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(64, 20);
            this.rbtnResta.TabIndex = 8;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "Resta";
            this.rbtnResta.UseVisualStyleBackColor = true;
            this.rbtnResta.CheckedChanged += new System.EventHandler(this.rbtnResta_CheckedChanged);
            // 
            // rbnSuma
            // 
            this.rbnSuma.AutoSize = true;
            this.rbnSuma.Location = new System.Drawing.Point(15, 48);
            this.rbnSuma.Name = "rbnSuma";
            this.rbnSuma.Size = new System.Drawing.Size(63, 20);
            this.rbnSuma.TabIndex = 7;
            this.rbnSuma.TabStop = true;
            this.rbnSuma.Text = "Suma";
            this.rbnSuma.UseVisualStyleBackColor = true;
            this.rbnSuma.CheckedChanged += new System.EventHandler(this.rbnSuma_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Practica3Ifs- Programado por Emanuel Vargas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.RadioButton rbtnMultiplicacion;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.RadioButton rbnSuma;
    }
}

