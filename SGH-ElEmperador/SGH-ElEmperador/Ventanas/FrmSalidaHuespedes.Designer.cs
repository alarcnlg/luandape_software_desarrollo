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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnRegistrarSalida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblFechaDeSalida = new System.Windows.Forms.Label();
            this.LblDiasDeAlojamiento = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(284, 353);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 50);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnRegistrarSalida
            // 
            this.BtnRegistrarSalida.BackColor = System.Drawing.Color.White;
            this.BtnRegistrarSalida.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnRegistrarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarSalida.Location = new System.Drawing.Point(394, 353);
            this.BtnRegistrarSalida.Name = "BtnRegistrarSalida";
            this.BtnRegistrarSalida.Size = new System.Drawing.Size(104, 50);
            this.BtnRegistrarSalida.TabIndex = 1;
            this.BtnRegistrarSalida.Text = "Registrar Salida";
            this.BtnRegistrarSalida.UseVisualStyleBackColor = false;
            this.BtnRegistrarSalida.Click += new System.EventHandler(this.BtnRegistrarSalida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de habitación :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de salida :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Días de alojamiento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL :";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(316, 110);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(50, 26);
            this.TxtNumero.TabIndex = 8;
            this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // LblFechaDeSalida
            // 
            this.LblFechaDeSalida.AutoSize = true;
            this.LblFechaDeSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaDeSalida.Location = new System.Drawing.Point(316, 169);
            this.LblFechaDeSalida.Name = "LblFechaDeSalida";
            this.LblFechaDeSalida.Size = new System.Drawing.Size(0, 20);
            this.LblFechaDeSalida.TabIndex = 12;
            this.LblFechaDeSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDiasDeAlojamiento
            // 
            this.LblDiasDeAlojamiento.AutoSize = true;
            this.LblDiasDeAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiasDeAlojamiento.Location = new System.Drawing.Point(316, 225);
            this.LblDiasDeAlojamiento.Name = "LblDiasDeAlojamiento";
            this.LblDiasDeAlojamiento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblDiasDeAlojamiento.Size = new System.Drawing.Size(0, 20);
            this.LblDiasDeAlojamiento.TabIndex = 13;
            this.LblDiasDeAlojamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(318, 281);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(0, 20);
            this.LblTotal.TabIndex = 14;
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(54, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "Salida de Huespedes";
            // 
            // FrmSalidaHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblDiasDeAlojamiento);
            this.Controls.Add(this.LblFechaDeSalida);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegistrarSalida);
            this.Controls.Add(this.BtnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalidaHuespedes";
            this.Text = "Registro de Salidas";
            this.Load += new System.EventHandler(this.FrmSalidaHuespedes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnRegistrarSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblFechaDeSalida;
        private System.Windows.Forms.Label LblDiasDeAlojamiento;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label5;
    }
}