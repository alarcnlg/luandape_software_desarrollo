/**
* program: SGH-ElEmperador
* file: FrmMDI.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Formulario MDI
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
using SGH_ElEmperador.Ventanas;

namespace SGH_ElEmperador
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();        
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir? \n Los datos no gurdados se perderan.", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BtnRegistroHospedaje_Click(object sender, EventArgs e)
        {
            CargarForm(new FrmRegistroHospedaje());
        }


        private void CargarForm(Form frm)
        {
            LblTitulo.Text = frm.Text;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void BtnSalidaHospedaje_Click(object sender, EventArgs e)
        {
            CargarForm(new FrmSalidaHuespedes());
        }
    }
}
