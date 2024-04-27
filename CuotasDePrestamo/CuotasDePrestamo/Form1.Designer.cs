namespace CuotasDePrestamo
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
            this.Monto = new System.Windows.Forms.TextBox();
            this.Plazos = new System.Windows.Forms.TextBox();
            this.Interes = new System.Windows.Forms.TextBox();
            this.Cuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(143, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuotas de un Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el interes mensual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(73, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto del prestamo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(32, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de plazos a pagar";
            // 
            // Monto
            // 
            this.Monto.BackColor = System.Drawing.SystemColors.InfoText;
            this.Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto.ForeColor = System.Drawing.Color.Cyan;
            this.Monto.Location = new System.Drawing.Point(353, 77);
            this.Monto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(125, 35);
            this.Monto.TabIndex = 4;
            // 
            // Plazos
            // 
            this.Plazos.BackColor = System.Drawing.SystemColors.InfoText;
            this.Plazos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plazos.ForeColor = System.Drawing.Color.Cyan;
            this.Plazos.Location = new System.Drawing.Point(353, 159);
            this.Plazos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Plazos.Name = "Plazos";
            this.Plazos.Size = new System.Drawing.Size(125, 35);
            this.Plazos.TabIndex = 5;
            // 
            // Interes
            // 
            this.Interes.BackColor = System.Drawing.SystemColors.InfoText;
            this.Interes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interes.ForeColor = System.Drawing.Color.Cyan;
            this.Interes.Location = new System.Drawing.Point(353, 119);
            this.Interes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Interes.Name = "Interes";
            this.Interes.Size = new System.Drawing.Size(125, 35);
            this.Interes.TabIndex = 6;
            // 
            // Cuota
            // 
            this.Cuota.BackColor = System.Drawing.SystemColors.InfoText;
            this.Cuota.Enabled = false;
            this.Cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuota.ForeColor = System.Drawing.Color.Cyan;
            this.Cuota.Location = new System.Drawing.Point(437, 272);
            this.Cuota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cuota.Name = "Cuota";
            this.Cuota.Size = new System.Drawing.Size(125, 35);
            this.Cuota.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(243, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cuota Mensual";
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.Color.Cyan;
            this.Calcular.Location = new System.Drawing.Point(78, 214);
            this.Calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(142, 68);
            this.Calcular.TabIndex = 9;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cuota);
            this.Controls.Add(this.Interes);
            this.Controls.Add(this.Plazos);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.TextBox Plazos;
        private System.Windows.Forms.TextBox Interes;
        private System.Windows.Forms.TextBox Cuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calcular;
    }
}

