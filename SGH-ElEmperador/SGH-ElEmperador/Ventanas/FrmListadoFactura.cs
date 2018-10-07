/**
* program: SGH-ElEmperador
* file: FrmListadoFactura.cs
* company: LUANDAPE Software
* author: David Cerda
* description: Formulario de listado de facturas
*/
using SGH_ElEmperador.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGH_ElEmperador.Ventanas
{


    public partial class FrmListadoFactura : Form
    {
        FacturasTB _tbDatos;

        public FrmListadoFactura()
        {
            InitializeComponent();
            _tbDatos = new FacturasTB();
        }

        private void FrmListadoFactura_Load(object sender, EventArgs e)
        {
            DtgvListado.DataSource = _tbDatos.ConsultaGeneral();
            FormatearDataGrid();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatearDataGrid() {
            DtgvListado.Columns[0].Visible = false;

            DtgvListado.Columns[1].HeaderText = "NO. FACTURA";
            DtgvListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[2].HeaderText = "HABITACIÓN";
            DtgvListado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[3].HeaderText = "NOMBRE DE HUESPED";
            DtgvListado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DtgvListado.Columns[4].HeaderText = "FECHA ENTRADA";
            DtgvListado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[5].HeaderText = "FECHA SALIDA";
            DtgvListado.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[6].HeaderText = "TOTAL";
            DtgvListado.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (DtgvListado.SelectedRows.Count != 1) return;
            int id =Convert.ToInt32(DtgvListado.SelectedRows[0].Cells[0].Value);
            ModuloGeneral.MDI.CargarForm(new FrmFactura(id));
        }
    }
}
