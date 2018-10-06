namespace SGH_ElEmperador.Ventanas
{
    partial class FrmListadoFactura
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
            this.DtgvListado = new System.Windows.Forms.DataGridView();
            this.BtnAsignar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvListado
            // 
            this.DtgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvListado.Location = new System.Drawing.Point(59, 24);
            this.DtgvListado.Name = "DtgvListado";
            this.DtgvListado.Size = new System.Drawing.Size(662, 175);
            this.DtgvListado.TabIndex = 0;
            this.DtgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvListado_CellContentClick);
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.Location = new System.Drawing.Point(175, 241);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(102, 23);
            this.BtnAsignar.TabIndex = 1;
            this.BtnAsignar.Text = "Asignar";
            this.BtnAsignar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(539, 241);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(101, 23);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmListadoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.DtgvListado);
            this.Name = "FrmListadoFactura";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmListadoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvListado;
        private System.Windows.Forms.Button BtnAsignar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}