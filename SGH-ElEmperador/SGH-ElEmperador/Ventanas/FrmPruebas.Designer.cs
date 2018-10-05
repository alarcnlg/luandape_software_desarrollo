namespace SGH_ElEmperador.Ventanas
{
    partial class FrmPruebas
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
            this.DtgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvDatos
            // 
            this.DtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDatos.Location = new System.Drawing.Point(122, 173);
            this.DtgvDatos.Name = "DtgvDatos";
            this.DtgvDatos.Size = new System.Drawing.Size(556, 150);
            this.DtgvDatos.TabIndex = 0;
            // 
            // FrmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgvDatos);
            this.Name = "FrmPruebas";
            this.Text = "FrmPruebas";
            this.Load += new System.EventHandler(this.FrmPruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvDatos;
    }
}