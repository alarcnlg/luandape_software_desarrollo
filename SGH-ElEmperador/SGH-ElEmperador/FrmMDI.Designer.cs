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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnImprimirFactura = new System.Windows.Forms.Button();
            this.BtnSalidaHospedaje = new System.Windows.Forms.Button();
            this.BtnRegistroHospedaje = new System.Windows.Forms.Button();
            this.BtnConsultaHabitaciones = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PnlBarraInformacion = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PbAcercaDe = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PnlBarraInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAcercaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.White;
            this.PnlMenu.Controls.Add(this.BtnSalir);
            this.PnlMenu.Controls.Add(this.BtnImprimirFactura);
            this.PnlMenu.Controls.Add(this.BtnSalidaHospedaje);
            this.PnlMenu.Controls.Add(this.BtnRegistroHospedaje);
            this.PnlMenu.Controls.Add(this.BtnConsultaHabitaciones);
            this.PnlMenu.Controls.Add(this.PbLogo);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(104, 450);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(0, 404);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(104, 46);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnImprimirFactura
            // 
            this.BtnImprimirFactura.BackColor = System.Drawing.Color.White;
            this.BtnImprimirFactura.FlatAppearance.BorderSize = 0;
            this.BtnImprimirFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimirFactura.Location = new System.Drawing.Point(0, 241);
            this.BtnImprimirFactura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnImprimirFactura.Name = "BtnImprimirFactura";
            this.BtnImprimirFactura.Size = new System.Drawing.Size(104, 50);
            this.BtnImprimirFactura.TabIndex = 4;
            this.BtnImprimirFactura.Text = "Imprimir Factura";
            this.BtnImprimirFactura.UseVisualStyleBackColor = false;
            this.BtnImprimirFactura.Click += new System.EventHandler(this.BtnImprimirFactura_Click);
            // 
            // BtnSalidaHospedaje
            // 
            this.BtnSalidaHospedaje.BackColor = System.Drawing.Color.White;
            this.BtnSalidaHospedaje.FlatAppearance.BorderSize = 0;
            this.BtnSalidaHospedaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSalidaHospedaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaHospedaje.Location = new System.Drawing.Point(0, 191);
            this.BtnSalidaHospedaje.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSalidaHospedaje.Name = "BtnSalidaHospedaje";
            this.BtnSalidaHospedaje.Size = new System.Drawing.Size(104, 50);
            this.BtnSalidaHospedaje.TabIndex = 3;
            this.BtnSalidaHospedaje.Text = "Registrar Salida";
            this.BtnSalidaHospedaje.UseVisualStyleBackColor = false;
            this.BtnSalidaHospedaje.Click += new System.EventHandler(this.BtnSalidaHospedaje_Click);
            // 
            // BtnRegistroHospedaje
            // 
            this.BtnRegistroHospedaje.BackColor = System.Drawing.Color.White;
            this.BtnRegistroHospedaje.FlatAppearance.BorderSize = 0;
            this.BtnRegistroHospedaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnRegistroHospedaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroHospedaje.Location = new System.Drawing.Point(0, 141);
            this.BtnRegistroHospedaje.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRegistroHospedaje.Name = "BtnRegistroHospedaje";
            this.BtnRegistroHospedaje.Size = new System.Drawing.Size(104, 50);
            this.BtnRegistroHospedaje.TabIndex = 2;
            this.BtnRegistroHospedaje.Text = "Registrar Hospedaje";
            this.BtnRegistroHospedaje.UseVisualStyleBackColor = false;
            this.BtnRegistroHospedaje.Click += new System.EventHandler(this.BtnRegistroHospedaje_Click);
            // 
            // BtnConsultaHabitaciones
            // 
            this.BtnConsultaHabitaciones.BackColor = System.Drawing.Color.White;
            this.BtnConsultaHabitaciones.FlatAppearance.BorderSize = 0;
            this.BtnConsultaHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnConsultaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaHabitaciones.Location = new System.Drawing.Point(0, 91);
            this.BtnConsultaHabitaciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnConsultaHabitaciones.Name = "BtnConsultaHabitaciones";
            this.BtnConsultaHabitaciones.Size = new System.Drawing.Size(104, 50);
            this.BtnConsultaHabitaciones.TabIndex = 1;
            this.BtnConsultaHabitaciones.Text = "Consulta de habitaciones";
            this.BtnConsultaHabitaciones.UseVisualStyleBackColor = false;
            this.BtnConsultaHabitaciones.Click += new System.EventHandler(this.BtnConsultaHabitaciones_Click);
            // 
            // PbLogo
            // 
            this.PbLogo.BackColor = System.Drawing.Color.White;
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbLogo.Image = global::SGH_ElEmperador.Properties.Resources.logo;
            this.PbLogo.Location = new System.Drawing.Point(0, 0);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(104, 91);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // PnlBarraInformacion
            // 
            this.PnlBarraInformacion.Controls.Add(this.LblUsuario);
            this.PnlBarraInformacion.Controls.Add(this.PbAcercaDe);
            this.PnlBarraInformacion.Controls.Add(this.LblTitulo);
            this.PnlBarraInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraInformacion.Location = new System.Drawing.Point(104, 0);
            this.PnlBarraInformacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlBarraInformacion.Name = "PnlBarraInformacion";
            this.PnlBarraInformacion.Size = new System.Drawing.Size(696, 22);
            this.PnlBarraInformacion.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.White;
            this.LblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(543, 0);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(113, 22);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario";
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUsuario.Click += new System.EventHandler(this.LblUsuario_Click);
            // 
            // PbAcercaDe
            // 
            this.PbAcercaDe.BackColor = System.Drawing.Color.White;
            this.PbAcercaDe.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbAcercaDe.Image = global::SGH_ElEmperador.Properties.Resources.acercade;
            this.PbAcercaDe.Location = new System.Drawing.Point(656, 0);
            this.PbAcercaDe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PbAcercaDe.Name = "PbAcercaDe";
            this.PbAcercaDe.Size = new System.Drawing.Size(40, 22);
            this.PbAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAcercaDe.TabIndex = 1;
            this.PbAcercaDe.TabStop = false;
            this.PbAcercaDe.Click += new System.EventHandler(this.PbAcercaDe_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(696, 22);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Hotel \"El Emperador\"";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlBarraInformacion);
            this.Controls.Add(this.PnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmMDI";
            this.Text = "Sistema de Gestión del Hotel \"El Emperador\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PnlBarraInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbAcercaDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnImprimirFactura;
        private System.Windows.Forms.Button BtnSalidaHospedaje;
        private System.Windows.Forms.Button BtnRegistroHospedaje;
        private System.Windows.Forms.Button BtnConsultaHabitaciones;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Panel PnlBarraInformacion;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PbAcercaDe;
        private System.Windows.Forms.Label LblUsuario;
    }
}