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
        FacturasTB _tbDatos;

        public FrmFactura(int id)
        {
            InitializeComponent();
            _id = id;
            _tbDatos = new FacturasTB();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> datos = _tbDatos.Consulta(_id);
            string texto = "FACTURA ELECTRONICA";
            texto += "HOTEL \"EL EMPERADOR\" ";
            texto += "FECHA DE ENTRADA:" + datos["FECHAENTRADA"] + "FECHA DE SALIDA:" + datos["FECHASALIDA"];
            texto += "NÚMERO DE HABITACIÓN: " + datos["NÚMEROHABITACION"] + "TIPO: " + datos["TIPO"];
            texto += "NOMBRE DEL HUÉSPED: ";
            texto += "SUBTOTAL: ";
            texto += "IVA: ";
            texto += "TOTAL: ";

            TxtVistaPrevia.Text = texto;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
