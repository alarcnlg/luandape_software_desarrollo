namespace SGH_ElEmperador
{
    partial class FrmMDI
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnImprimirFactura = new System.Windows.Forms.Button();
            this.BtnSalidaHospedaje = new System.Windows.Forms.Button();
            this.BtnRegistroHospedaje = new System.Windows.Forms.Button();
            this.BtnConsultaHabitaciones = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlBarraInformacion = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlBarraInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.BtnSalir);
            this.PnlMenu.Controls.Add(this.BtnImprimirFactura);
            this.PnlMenu.Controls.Add(this.BtnSalidaHospedaje);
            this.PnlMenu.Controls.Add(this.BtnRegistroHospedaje);
            this.PnlMenu.Controls.Add(this.BtnConsultaHabitaciones);
            this.PnlMenu.Controls.Add(this.pictureBox1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(105, 450);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.Location = new System.Drawing.Point(0, 404);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 46);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnImprimirFactura
            // 
            this.BtnImprimirFactura.Location = new System.Drawing.Point(0, 268);
            this.BtnImprimirFactura.Name = "BtnImprimirFactura";
            this.BtnImprimirFactura.Size = new System.Drawing.Size(105, 46);
            this.BtnImprimirFactura.TabIndex = 4;
            this.BtnImprimirFactura.Text = "Imprimir Factura";
            this.BtnImprimirFactura.UseVisualStyleBackColor = true;
            // 
            // BtnSalidaHospedaje
            // 
            this.BtnSalidaHospedaje.Location = new System.Drawing.Point(0, 211);
            this.BtnSalidaHospedaje.Name = "BtnSalidaHospedaje";
            this.BtnSalidaHospedaje.Size = new System.Drawing.Size(105, 46);
            this.BtnSalidaHospedaje.TabIndex = 3;
            this.BtnSalidaHospedaje.Text = "Registrar Salida";
            this.BtnSalidaHospedaje.UseVisualStyleBackColor = true;
            // 
            // BtnRegistroHospedaje
            // 
            this.BtnRegistroHospedaje.Location = new System.Drawing.Point(0, 154);
            this.BtnRegistroHospedaje.Name = "BtnRegistroHospedaje";
            this.BtnRegistroHospedaje.Size = new System.Drawing.Size(105, 46);
            this.BtnRegistroHospedaje.TabIndex = 2;
            this.BtnRegistroHospedaje.Text = "Registrar Hospedaje";
            this.BtnRegistroHospedaje.UseVisualStyleBackColor = true;
            this.BtnRegistroHospedaje.Click += new System.EventHandler(this.BtnRegistroHospedaje_Click);
            // 
            // BtnConsultaHabitaciones
            // 
            this.BtnConsultaHabitaciones.Location = new System.Drawing.Point(0, 97);
            this.BtnConsultaHabitaciones.Name = "BtnConsultaHabitaciones";
            this.BtnConsultaHabitaciones.Size = new System.Drawing.Size(105, 46);
            this.BtnConsultaHabitaciones.TabIndex = 1;
            this.BtnConsultaHabitaciones.Text = "Consulta de habitaciones";
            this.BtnConsultaHabitaciones.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlBarraInformacion
            // 
            this.PnlBarraInformacion.Controls.Add(this.pictureBox2);
            this.PnlBarraInformacion.Controls.Add(this.LblTitulo);
            this.PnlBarraInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraInformacion.Location = new System.Drawing.Point(105, 0);
            this.PnlBarraInformacion.Name = "PnlBarraInformacion";
            this.PnlBarraInformacion.Size = new System.Drawing.Size(695, 22);
            this.PnlBarraInformacion.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(655, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 22);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(503, 29);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Hotel \"El Emperador\"";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlBarraInformacion);
            this.Controls.Add(this.PnlMenu);
            this.IsMdiContainer = true;
            this.Name = "FrmMDI";
            this.Text = "Sistema de Gestión para el Hotel \"El Emperador\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlBarraInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnImprimirFactura;
        private System.Windows.Forms.Button BtnSalidaHospedaje;
        private System.Windows.Forms.Button BtnRegistroHospedaje;
        private System.Windows.Forms.Button BtnConsultaHabitaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlBarraInformacion;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}