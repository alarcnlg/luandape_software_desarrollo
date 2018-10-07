/**
* program: SGH-ElEmperador
* file: FrmAcercaDe.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Formulario de infromación del sofwtare
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

namespace SGH_ElEmperador.Ventanas
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ModuloGeneral.MDI.CerrarForm(this);
        }
    }
}
