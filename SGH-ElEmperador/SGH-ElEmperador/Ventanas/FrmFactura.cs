/**
* program: SGH-ElEmperador
* file: FrmFactura.cs
* company: LUANDAPE Software
* author: PEDRO AGUILAR F
* description: Formulario de Factura
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
    public partial class FrmFactura : Form
    {
        int _id;
        int _noFactura;
        FacturasTB _tbDatos;

        public FrmFactura(int id)
        {
            InitializeComponent();
            _id = id;
            _tbDatos = new FacturasTB();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Guardar Factura";
            saveDialog.Filter = "Archivos de texto | *.txt ";
            saveDialog.AddExtension = true;
            saveDialog.DefaultExt = "txt";
            saveDialog.FileName = "Factura_" + _noFactura;

            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(saveDialog.FileName);
                    writer.Write(TxtVistaPrevia.Text);
                    writer.Close();
                    MessageBox.Show("Factura generada correctamente", "FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> datos = _tbDatos.Consulta(_id);

            if (_tbDatos.Error.Length > 0)
            {
                MessageBox.Show(_tbDatos.Error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (datos == null) return;

            string texto = "FACTURA ELECTRONICA \r\n";
            texto += "HOTEL \"EL EMPERADOR\" \r\n";
            texto += "NO. FACTURA: " + datos["NOFACTURA"] + "\r\n";
            texto += "FECHA DE ENTRADA: " + datos["FECHAENTRADA"] + "        FECHA DE SALIDA: " + datos["FECHASALIDA"] + "\r\n";
            texto += "NÚMERO DE HABITACIÓN: " + datos["NUMEROHABITACION"] + "       TIPO: " + datos["TIPO"] + "\r\n";
            texto += "NOMBRE DEL HUÉSPED: " + datos["PERSONAENCARGADO"] + "\r\n";
            texto += "SUBTOTAL: " + Convert.ToSingle(datos["SUBTOTAL"]).ToString("#,###,##0.00") + "\r\n";
            texto += "IVA: " + (Convert.ToSingle(datos["SUBTOTAL"]) * 0.16f).ToString("#,###,##0.00") + "\r\n";
            texto += "TOTAL: " + Convert.ToSingle(datos["TOTAL"]).ToString("#,###,##0.00") + " MXN";

            _noFactura = Convert.ToInt32(datos["NOFACTURA"]);
            TxtVistaPrevia.Text = texto;
            TxtVistaPrevia.Select(0,0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ModuloGeneral.MDI.CerrarForm(this);
        }
    }
}
