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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatearDataGrid() {
            DtgvListado.Columns[0].Visible = false;

            DtgvListado.Columns[1].HeaderText = "No. factura";
            DtgvListado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[2].HeaderText = "Habitación";
            DtgvListado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[3].HeaderText = "Nombre de huesped";
            DtgvListado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DtgvListado.Columns[4].HeaderText = "Fecha Entrada";
            DtgvListado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[5].HeaderText = "Fecha Salida";
            DtgvListado.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            DtgvListado.Columns[6].HeaderText = "Total";
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
