namespace CalcularCapitalFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.Periodo = new System.Windows.Forms.TextBox();
            this.Tasa = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(198, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de capital final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(104, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa de interes Anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(181, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(34, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Periodo de inversion en años ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(445, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capital final ";
            // 
            // Monto
            // 
            this.Monto.BackColor = System.Drawing.SystemColors.InfoText;
            this.Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto.ForeColor = System.Drawing.Color.Cyan;
            this.Monto.Location = new System.Drawing.Point(464, 109);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(155, 38);
            this.Monto.TabIndex = 5;
            // 
            // Periodo
            // 
            this.Periodo.BackColor = System.Drawing.SystemColors.InfoText;
            this.Periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periodo.ForeColor = System.Drawing.Color.Cyan;
            this.Periodo.Location = new System.Drawing.Point(464, 223);
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(155, 38);
            this.Periodo.TabIndex = 6;
            // 
            // Tasa
            // 
            this.Tasa.BackColor = System.Drawing.SystemColors.InfoText;
            this.Tasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasa.ForeColor = System.Drawing.Color.Cyan;
            this.Tasa.Location = new System.Drawing.Point(464, 169);
            this.Tasa.Name = "Tasa";
            this.Tasa.Size = new System.Drawing.Size(155, 38);
            this.Tasa.TabIndex = 7;
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.InfoText;
            this.Resultado.Enabled = false;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.Color.Cyan;
            this.Resultado.Location = new System.Drawing.Point(464, 336);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(155, 38);
            this.Resultado.TabIndex = 8;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.Color.Lime;
            this.Calcular.Location = new System.Drawing.Point(187, 301);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(181, 73);
            this.Calcular.TabIndex = 9;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Tasa);
            this.Controls.Add(this.Periodo);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.TextBox Periodo;
        private System.Windows.Forms.TextBox Tasa;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button Calcular;
    }
}

