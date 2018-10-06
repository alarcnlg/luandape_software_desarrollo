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
    public partial class FrmConsultaHabitaciones : Form
    {
        HabitacionTB _tbDatos;
        public FrmConsultaHabitaciones()
        {
            InitializeComponent();
            _tbDatos = new HabitacionTB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaHabitaciones_Load(object sender, EventArgs e)
        {
            DtgvListadoHabitacion.DataSource = _tbDatos.ConsultaResumen();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
