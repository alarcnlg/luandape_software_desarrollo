namespace SGH_ElEmperador.Ventanas
{
    partial class FrmRegistroHospedaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumeroPersonas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.DtgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.LblHabitacion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblPrecioHabitacion = new System.Windows.Forms.Label();
            this.LblIVA = new System.Windows.Forms.Label();
            this.TbPage1 = new System.Windows.Forms.TabPage();
            this.TxtDocIdentidad = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblDocIdentidad = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TbCrHuespedes = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvHabitaciones)).BeginInit();
            this.TbPage1.SuspendLayout();
            this.TbCrHuespedes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de personas:";
            // 
            // TxtNumeroPersonas
            // 
            this.TxtNumeroPersonas.Location = new System.Drawing.Point(157, 26);
            this.TxtNumeroPersonas.Name = "TxtNumeroPersonas";
            this.TxtNumeroPersonas.Size = new System.Drawing.Size(37, 20);
            this.TxtNumeroPersonas.TabIndex = 1;
            this.TxtNumeroPersonas.TextChanged += new System.EventHandler(this.TxtNumeroPersonas_TextChanged);
            this.TxtNumeroPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroPersonas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Huespedes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal:";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Location = new System.Drawing.Point(110, 376);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(28, 13);
            this.LblSubTotal.TabIndex = 8;
            this.LblSubTotal.Text = "0.00";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(110, 428);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(28, 13);
            this.LblTotal.TabIndex = 9;
            this.LblTotal.Text = "0.00";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(378, 430);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(97, 43);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(584, 430);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(97, 43);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(481, 430);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(97, 43);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // DtgvHabitaciones
            // 
            this.DtgvHabitaciones.AllowUserToAddRows = false;
            this.DtgvHabitaciones.AllowUserToDeleteRows = false;
            this.DtgvHabitaciones.AllowUserToOrderColumns = true;
            this.DtgvHabitaciones.AllowUserToResizeColumns = false;
            this.DtgvHabitaciones.AllowUserToResizeRows = false;
            this.DtgvHabitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvHabitaciones.ColumnHeadersVisible = false;
            this.DtgvHabitaciones.Location = new System.Drawing.Point(46, 63);
            this.DtgvHabitaciones.MultiSelect = false;
            this.DtgvHabitaciones.Name = "DtgvHabitaciones";
            this.DtgvHabitaciones.ReadOnly = true;
            this.DtgvHabitaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgvHabitaciones.RowHeadersVisible = false;
            this.DtgvHabitaciones.Size = new System.Drawing.Size(632, 56);
            this.DtgvHabitaciones.TabIndex = 18;
            this.DtgvHabitaciones.CurrentCellChanged += new System.EventHandler(this.DtgvHabitaciones_CurrentCellChanged);
            // 
            // LblHabitacion
            // 
            this.LblHabitacion.AutoSize = true;
            this.LblHabitacion.Location = new System.Drawing.Point(278, 29);
            this.LblHabitacion.Name = "LblHabitacion";
            this.LblHabitacion.Size = new System.Drawing.Size(112, 13);
            this.LblHabitacion.TabIndex = 19;
            this.LblHabitacion.Text = "Seleccione habitación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Habitación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "IVA 16%:";
            // 
            // LblPrecioHabitacion
            // 
            this.LblPrecioHabitacion.AutoSize = true;
            this.LblPrecioHabitacion.Location = new System.Drawing.Point(110, 353);
            this.LblPrecioHabitacion.Name = "LblPrecioHabitacion";
            this.LblPrecioHabitacion.Size = new System.Drawing.Size(28, 13);
            this.LblPrecioHabitacion.TabIndex = 22;
            this.LblPrecioHabitacion.Text = "0.00";
            // 
            // LblIVA
            // 
            this.LblIVA.AutoSize = true;
            this.LblIVA.Location = new System.Drawing.Point(110, 401);
            this.LblIVA.Name = "LblIVA";
            this.LblIVA.Size = new System.Drawing.Size(28, 13);
            this.LblIVA.TabIndex = 23;
            this.LblIVA.Text = "0.00";
            // 
            // TbPage1
            // 
            this.TbPage1.Controls.Add(this.TxtDocIdentidad);
            this.TbPage1.Controls.Add(this.TxtApellidos);
            this.TbPage1.Controls.Add(this.TxtNombre);
            this.TbPage1.Controls.Add(this.DtpFechaNacimiento);
            this.TbPage1.Controls.Add(this.LblFechaNacimiento);
            this.TbPage1.Controls.Add(this.LblDocIdentidad);
            this.TbPage1.Controls.Add(this.LblApellidos);
            this.TbPage1.Controls.Add(this.LblNombre);
            this.TbPage1.Location = new System.Drawing.Point(4, 22);
            this.TbPage1.Name = "TbPage1";
            this.TbPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TbPage1.Size = new System.Drawing.Size(634, 83);
            this.TbPage1.TabIndex = 0;
            this.TbPage1.Text = "1";
            this.TbPage1.UseVisualStyleBackColor = true;
            // 
            // TxtDocIdentidad
            // 
            this.TxtDocIdentidad.Location = new System.Drawing.Point(503, 12);
            this.TxtDocIdentidad.Name = "TxtDocIdentidad";
            this.TxtDocIdentidad.Size = new System.Drawing.Size(84, 20);
            this.TxtDocIdentidad.TabIndex = 6;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(98, 48);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(205, 20);
            this.TxtApellidos.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(98, 12);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(205, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(503, 48);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(84, 20);
            this.DtpFechaNacimiento.TabIndex = 7;
            this.DtpFechaNacimiento.ValueChanged += new System.EventHandler(this.DtpFechaNacimiento_ValueChanged);
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(386, 51);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.LblFechaNacimiento.TabIndex = 3;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblDocIdentidad
            // 
            this.LblDocIdentidad.AutoSize = true;
            this.LblDocIdentidad.Location = new System.Drawing.Point(386, 15);
            this.LblDocIdentidad.Name = "LblDocIdentidad";
            this.LblDocIdentidad.Size = new System.Drawing.Size(80, 13);
            this.LblDocIdentidad.TabIndex = 2;
            this.LblDocIdentidad.Text = "Doc. Identidad:";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(33, 51);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(52, 13);
            this.LblApellidos.TabIndex = 1;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(33, 15);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // TbCrHuespedes
            // 
            this.TbCrHuespedes.Controls.Add(this.TbPage1);
            this.TbCrHuespedes.Enabled = false;
            this.TbCrHuespedes.Location = new System.Drawing.Point(46, 237);
            this.TbCrHuespedes.Name = "TbCrHuespedes";
            this.TbCrHuespedes.SelectedIndex = 0;
            this.TbCrHuespedes.Size = new System.Drawing.Size(642, 109);
            this.TbCrHuespedes.TabIndex = 4;
            this.TbCrHuespedes.SelectedIndexChanged += new System.EventHandler(this.TbCrHuespedes_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Días a hospedarse:";
            // 
            // TxtDias
            // 
            this.TxtDias.Enabled = false;
            this.TxtDias.Location = new System.Drawing.Point(149, 164);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(37, 20);
            this.TxtDias.TabIndex = 25;
            this.TxtDias.TextChanged += new System.EventHandler(this.TxtDias_TextChanged);
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(606, 26);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.ReadOnly = true;
            this.TxtFecha.Size = new System.Drawing.Size(71, 20);
            this.TxtFecha.TabIndex = 26;
            this.TxtFecha.Text = "06/10/2018";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha:";
            // 
            // FrmRegistroHospedaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 491);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblIVA);
            this.Controls.Add(this.LblPrecioHabitacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblHabitacion);
            this.Controls.Add(this.DtgvHabitaciones);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbCrHuespedes);
            this.Controls.Add(this.TxtNumeroPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroHospedaje";
            this.Text = "Registro de Hospedaje";
            this.Load += new System.EventHandler(this.FrmRegistroHospedaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvHabitaciones)).EndInit();
            this.TbPage1.ResumeLayout(false);
            this.TbPage1.PerformLayout();
            this.TbCrHuespedes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumeroPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView DtgvHabitaciones;
        private System.Windows.Forms.Label LblHabitacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblPrecioHabitacion;
        private System.Windows.Forms.Label LblIVA;
        private System.Windows.Forms.TabPage TbPage1;
        private System.Windows.Forms.TextBox TxtDocIdentidad;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblDocIdentidad;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TabControl TbCrHuespedes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label6;
    }
}