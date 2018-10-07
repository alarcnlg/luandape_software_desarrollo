/**
* program: SGH-ElEmperador
* file: FrmLogin.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Formulario de Login
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

namespace SGH_ElEmperador
{
    public partial class FrmLogin : Form
    {
        private UsuariosTB _tbDatos;

        public FrmLogin()
        {
            InitializeComponent();
            _tbDatos = new UsuariosTB();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidarDatos() {
            if (TxtUsuario.Text.Trim().Length == 0) { 
                MessageBox.Show("Introduzca el Usuario", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }

            if (TxtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Introduzca el Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r') return;
            Ingresar();
        }

        private void Ingresar() {
            if (!ValidarDatos()) return;
            Dictionary<string, object> result = _tbDatos.ValidarLogin(TxtUsuario.Text, TxtPassword.Text);
            if (result == null)
            {
                if (_tbDatos.Error.Length == 0)
                {
                    MessageBox.Show("Usuario o Contraseña no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(_tbDatos.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ModuloGeneral.IDUsuario = Convert.ToInt32(result["ID"]);
                ModuloGeneral.UsuarioActivo = TxtUsuario.Text;
                ModuloGeneral.Administrador = Convert.ToBoolean(result["ADMINISTRADOR"]);

                FrmMDI frmMDI = new FrmMDI();
                frmMDI.Show();
                Hide();

                ModuloGeneral.MDI = frmMDI;
            }
        }

    }
}
