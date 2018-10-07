/**
* program: SGH-ElEmperador
* file:Form1.cs
* company: LUANDAPE Software
* author: Antonio Castillo
* description: diseño de la ventana salida de huespedes
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH_ElEmperador.BaseDeDatos;

namespace SGH_ElEmperador.Ventanas
{
    public partial class FrmSalidaHuespedes : Form
    {
        int _id;
        HospedajesTB _tbDatos;
        int _numeroHabitacion;

        public FrmSalidaHuespedes()
        {
            InitializeComponent();
            _tbDatos = new HospedajesTB();
        }

        private void FrmSalidaHuespedes_Load(object sender, EventArgs e)
        {
            _numeroHabitacion = 0;
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Dictionary<string, object> datos = _tbDatos.ConsultaHospedaje(Convert.ToInt32(TxtNumero.Text));
                if (_tbDatos.Error.Length > 0)
                {
                    MessageBox.Show(_tbDatos.Error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (datos == null)
                {
                    MessageBox.Show("No se encontraron datos en esta habitacion", "NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _numeroHabitacion = Convert.ToInt32(TxtNumero.Text);
                _id = Convert.ToInt32(datos["ID"]);
                LblFechaDeSalida.Text = DateTime.Now.ToString("dd/MM/yyyy");
                LblDiasDeAlojamiento.Text = datos["DIAS"].ToString();
                LblTotal.Text = Convert.ToSingle(datos["TOTAL"].ToString()).ToString("#,###,##0.00");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ModuloGeneral.MDI.CerrarForm(this);
        }

        private void BtnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (_numeroHabitacion <= 0) return;
            HabitacionTB tbHabitaciones = new HabitacionTB();
            FacturasTB tbFacturas = new FacturasTB();
            int idFactura = 0;

            _tbDatos.RegistrarSalida(_id, DateTime.Now,ModuloGeneral.IDUsuario);

            if (_tbDatos.Error.Length > 0)
            {
                MessageBox.Show("ERROR", _tbDatos.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!tbHabitaciones.ActualizarEstado(tbHabitaciones.ConsultaId(Convert.ToInt32(_numeroHabitacion)), 'L'))
            {
                MessageBox.Show(tbHabitaciones.Error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!tbFacturas.Guardar(ref idFactura, _id))
            {
                MessageBox.Show(tbHabitaciones.Error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Salida registrada correctamente","GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtNumero.Text = "";
            LblDiasDeAlojamiento.Text = "";
            LblFechaDeSalida.Text = "";
            LblTotal.Text = "";
            _id = 0;
        }

    }
}
