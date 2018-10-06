namespace SGH_ElEmperador.Ventanas
{
    partial class FrmSalidaHuespedes
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrarSalida = new System.Windows.Forms.Button();
            this.BtnGenerarFactura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblFechaDeSalida = new System.Windows.Forms.Label();
            this.LblDiasDeAlojamiento = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnCancelar.Location = new System.Drawing.Point(69, 260);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(128, 37);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrarSalida
            // 
            this.BtnRegistrarSalida.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnRegistrarSalida.Location = new System.Drawing.Point(349, 260);
            this.BtnRegistrarSalida.Name = "BtnRegistrarSalida";
            this.BtnRegistrarSalida.Size = new System.Drawing.Size(134, 37);
            this.BtnRegistrarSalida.TabIndex = 1;
            this.BtnRegistrarSalida.Text = "REGISTRAR SALIDA";
            this.BtnRegistrarSalida.UseVisualStyleBackColor = false;
            this.BtnRegistrarSalida.Click += new System.EventHandler(this.BtnRegistrarSalida_Click);
            // 
            // BtnGenerarFactura
            // 
            this.BtnGenerarFactura.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnGenerarFactura.Location = new System.Drawing.Point(607, 260);
            this.BtnGenerarFactura.Name = "BtnGenerarFactura";
            this.BtnGenerarFactura.Size = new System.Drawing.Size(134, 37);
            this.BtnGenerarFactura.TabIndex = 2;
            this.BtnGenerarFactura.Text = "GENERAR FACTURA";
            this.BtnGenerarFactura.UseVisualStyleBackColor = false;
            this.BtnGenerarFactura.Click += new System.EventHandler(this.BtnGenerarFactura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de habitación :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de salida :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Días de alojamiento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL :";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(183, 51);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(50, 20);
            this.TxtNumero.TabIndex = 8;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            this.TxtNumero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumero_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 11;
            // 
            // LblFechaDeSalida
            // 
            this.LblFechaDeSalida.AutoSize = true;
            this.LblFechaDeSalida.Location = new System.Drawing.Point(180, 93);
            this.LblFechaDeSalida.Name = "LblFechaDeSalida";
            this.LblFechaDeSalida.Size = new System.Drawing.Size(0, 13);
            this.LblFechaDeSalida.TabIndex = 12;
            // 
            // LblDiasDeAlojamiento
            // 
            this.LblDiasDeAlojamiento.AutoSize = true;
            this.LblDiasDeAlojamiento.Location = new System.Drawing.Point(180, 134);
            this.LblDiasDeAlojamiento.Name = "LblDiasDeAlojamiento";
            this.LblDiasDeAlojamiento.Size = new System.Drawing.Size(0, 13);
            this.LblDiasDeAlojamiento.TabIndex = 13;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(180, 170);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(0, 13);
            this.LblTotal.TabIndex = 14;
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // FrmSalidaHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblDiasDeAlojamiento);
            this.Controls.Add(this.LblFechaDeSalida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerarFactura);
            this.Controls.Add(this.BtnRegistrarSalida);
            this.Controls.Add(this.BtnCancelar);
            this.Name = "FrmSalidaHuespedes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSalidaHuespedes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrarSalida;
        private System.Windows.Forms.Button BtnGenerarFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblFechaDeSalida;
        private System.Windows.Forms.Label LblDiasDeAlojamiento;
        private System.Windows.Forms.Label LblTotal;
    }
}