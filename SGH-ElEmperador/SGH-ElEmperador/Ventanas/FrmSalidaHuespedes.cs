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
        public FrmSalidaHuespedes()
        {
            InitializeComponent();
            _tbDatos = new HospedajesTB();
        }

        private void FrmSalidaHuespedes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumero_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Dictionary<string, object> datos = _tbDatos.ConsultaHospedaje(Convert.ToInt32(TxtNumero.Text));
                if (_tbDatos.Error.Length > 0)
                {
                    MessageBox.Show("ERROR", _tbDatos.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(datos == null)
                {
                    MessageBox.Show("No se encontraron datos en esta habitacion","NO ENCONTRADO",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _id = Convert.ToInt32(datos["ID"]);
                LblFechaDeSalida.Text = datos["FECHASALIDA"].ToString();
                LblDiasDeAlojamiento.Text = datos["DIAS"].ToString();
                LblTotal.Text = datos["TOTAL"].ToString();
            }
        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarSalida_Click(object sender, EventArgs e)
        {
            _tbDatos.RegtistrarSalida(_id, DateTime.Now,ModuloGeneral.IDUsuario);

            if (_tbDatos.Error.Length > 0)
            {
                MessageBox.Show("errror", _tbDatos.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("salida registrada correctamente","guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtNumero.Text = "";
            LblDiasDeAlojamiento.Text = "";
            LblFechaDeSalida.Text = "";
            LblTotal.Text = "";
            _id = 0;
        }
    }
}
