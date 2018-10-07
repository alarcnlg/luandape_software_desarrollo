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
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvListado
            // 
            this.DtgvListado.AllowUserToAddRows = false;
            this.DtgvListado.AllowUserToDeleteRows = false;
            this.DtgvListado.AllowUserToOrderColumns = true;
            this.DtgvListado.AllowUserToResizeColumns = false;
            this.DtgvListado.AllowUserToResizeRows = false;
            this.DtgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DtgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvListado.Location = new System.Drawing.Point(59, 107);
            this.DtgvListado.MultiSelect = false;
            this.DtgvListado.Name = "DtgvListado";
            this.DtgvListado.ReadOnly = true;
            this.DtgvListado.RowHeadersVisible = false;
            this.DtgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgvListado.Size = new System.Drawing.Size(728, 375);
            this.DtgvListado.TabIndex = 0;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerar.BackColor = System.Drawing.Color.White;
            this.BtnGenerar.FlatAppearance.BorderSize = 0;
            this.BtnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Location = new System.Drawing.Point(677, 503);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(110, 50);
            this.BtnGenerar.TabIndex = 1;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(570, 503);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 50);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(52, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Listado de Facturas";
            // 
            // FrmListadoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.DtgvListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoFactura";
            this.Text = "Listado de Facturas";
            this.Load += new System.EventHandler(this.FrmListadoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvListado;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label5;
    }
}