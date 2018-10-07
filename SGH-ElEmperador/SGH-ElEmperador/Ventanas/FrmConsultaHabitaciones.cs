/**
* program: SGH-ElEmperador
* file: FrmConsultaHabitaciones.cs
* company: LUANDAPE Software
* author: David Cerda
* description: Formulario de consulta de habitaciones
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
            FormatearDataGrid();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ModuloGeneral.MDI.CerrarForm(this);
        }
        private void FormatearDataGrid() {
            DtgvListadoHabitacion.Columns[0].HeaderText = "TIPO DE HABITACIÓN";
            DtgvListadoHabitacion.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DtgvListadoHabitacion.Columns[1].HeaderText = "TOTAL LIBRE";
            DtgvListadoHabitacion.Columns[1].Width = (DtgvListadoHabitacion.Width / 4);

            DtgvListadoHabitacion.Columns[2].HeaderText = "TOTAL OCUPADAS";
            DtgvListadoHabitacion.Columns[2].Width = (DtgvListadoHabitacion.Width / 4);

            DtgvListadoHabitacion.Columns[3].HeaderText = "TOTAL RESERVADAS";
            DtgvListadoHabitacion.Columns[3].Width = (DtgvListadoHabitacion.Width / 4);
        }
    }
}
