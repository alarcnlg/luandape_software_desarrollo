﻿namespace SGH_ElEmperador.Ventanas
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
            this.BtnCancelar = new System.Windows.Forms.Button();
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
            this.DtgvListadoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvListadoHabitacion.Location = new System.Drawing.Point(12, 33);
            this.DtgvListadoHabitacion.Name = "DtgvListadoHabitacion";
            this.DtgvListadoHabitacion.ReadOnly = true;
            this.DtgvListadoHabitacion.RowHeadersVisible = false;
            this.DtgvListadoHabitacion.Size = new System.Drawing.Size(657, 193);
            this.DtgvListadoHabitacion.TabIndex = 0;
            this.DtgvListadoHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(564, 251);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 45);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmConsultaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 308);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DtgvListadoHabitacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaHabitaciones";
            this.Text = "Consulta de Habitaciones";
            this.Load += new System.EventHandler(this.FrmConsultaHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvListadoHabitacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvListadoHabitacion;
        private System.Windows.Forms.Button BtnCancelar;
    }
}