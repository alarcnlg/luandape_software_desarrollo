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

        private void DtgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListadoFactura_Load(object sender, EventArgs e)
        {
            DtgvListado.DataSource = _tbDatos.ConsultaGeneral();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
