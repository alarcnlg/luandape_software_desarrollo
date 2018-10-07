namespace SGH_ElEmperador.Ventanas
{
    partial class FrmConsultaHabitaciones
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
            this.DtgvListadoHabitacion = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvListadoHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvListadoHabitacion
            // 
            this.DtgvListadoHabitacion.AllowUserToAddRows = false;
            this.DtgvListadoHabitacion.AllowUserToDeleteRows = false;
            this.DtgvListadoHabitacion.AllowUserToResizeColumns = false;
            this.DtgvListadoHabitacion.AllowUserToResizeRows = false;
            this.DtgvListadoHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgvListadoHabitacion.BackgroundColor = System.Drawing.Color.White;
            this.DtgvListadoHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgvListadoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvListadoHabitacion.Location = new System.Drawing.Point(12, 97);
            this.DtgvListadoHabitacion.Name = "DtgvListadoHabitacion";
            this.DtgvListadoHabitacion.ReadOnly = true;
            this.DtgvListadoHabitacion.RowHeadersVisible = false;
            this.DtgvListadoHabitacion.Size = new System.Drawing.Size(657, 193);
            this.DtgvListadoHabitacion.TabIndex = 0;
            this.DtgvListadoHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(559, 305);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 50);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Habitaciones";
            // 
            // FrmConsultaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DtgvListadoHabitacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaHabitaciones";
            this.Text = "Consulta de Habitaciones";
            this.Load += new System.EventHandler(this.FrmConsultaHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvListadoHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvListadoHabitacion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
    }
}