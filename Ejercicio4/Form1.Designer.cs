namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOperacion = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperacion
            // 
            this.btnOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOperacion.Location = new System.Drawing.Point(483, 60);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(75, 31);
            this.btnOperacion.TabIndex = 0;
            this.btnOperacion.Text = "=";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNum1.Location = new System.Drawing.Point(81, 60);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(132, 29);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNum2.Location = new System.Drawing.Point(316, 60);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(132, 29);
            this.txtNum2.TabIndex = 2;
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSuma.Location = new System.Drawing.Point(47, 124);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(69, 24);
            this.rbSuma.TabIndex = 3;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            this.rbSuma.Click += new System.EventHandler(this.pulsarRadioButton);
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbResta.Location = new System.Drawing.Point(46, 170);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(70, 24);
            this.rbResta.TabIndex = 4;
            this.rbResta.TabStop = true;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            this.rbResta.Click += new System.EventHandler(this.pulsarRadioButton);
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMultiplicacion.Location = new System.Drawing.Point(143, 124);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(121, 24);
            this.rbMultiplicacion.TabIndex = 5;
            this.rbMultiplicacion.TabStop = true;
            this.rbMultiplicacion.Text = "Multiplicación";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            this.rbMultiplicacion.Click += new System.EventHandler(this.pulsarRadioButton);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbDivision.Location = new System.Drawing.Point(143, 170);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(81, 24);
            this.rbDivision.TabIndex = 6;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "División";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.Click += new System.EventHandler(this.pulsarRadioButton);
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSigno.Location = new System.Drawing.Point(251, 63);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(59, 24);
            this.lblSigno.TabIndex = 7;
            this.lblSigno.Text = "Signo";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblResultado.Location = new System.Drawing.Point(597, 63);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(94, 24);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 225);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.rbMultiplicacion);
            this.Controls.Add(this.rbResta);
            this.Controls.Add(this.rbSuma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnOperacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblResultado;
    }
}

