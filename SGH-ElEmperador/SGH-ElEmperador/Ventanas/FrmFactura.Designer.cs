namespace SGH_ElEmperador.Ventanas
{
    partial class FrmFactura
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
            this.TxtVistaPrevia = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtVistaPrevia
            // 
            this.TxtVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVistaPrevia.BackColor = System.Drawing.Color.White;
            this.TxtVistaPrevia.Location = new System.Drawing.Point(35, 84);
            this.TxtVistaPrevia.Multiline = true;
            this.TxtVistaPrevia.Name = "TxtVistaPrevia";
            this.TxtVistaPrevia.ReadOnly = true;
            this.TxtVistaPrevia.Size = new System.Drawing.Size(628, 288);
            this.TxtVistaPrevia.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(563, 390);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 50);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(465, 390);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 50);
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
            this.label5.Location = new System.Drawing.Point(28, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 31;
            this.label5.Text = "Factura";
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtVistaPrevia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFactura";
            this.Text = "Impresión de Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtVistaPrevia;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label5;
    }
}