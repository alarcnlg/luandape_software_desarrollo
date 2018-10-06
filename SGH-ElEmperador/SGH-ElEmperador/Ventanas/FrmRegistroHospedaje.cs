/**
* program: SGH-ElEmperador
* file: FrmRegistroHospedaje.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Formulario de gegistro de hospedaje
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
    public partial class FrmRegistroHospedaje : Form
    {
        private HospedajesTB _tbDatos;

        private String _categoriaHabitacion;
        private String _numeroHabitacion;
        private float _precioHabitacion;

        private List<Dictionary<string, object>> _datosHuespedes;
        private int _ultimoIndexHuespedTab;

        private bool _actualizarPrecios;
        private bool _validarFecha;

        public FrmRegistroHospedaje()
        {
            InitializeComponent();
            _tbDatos = new HospedajesTB();
            _datosHuespedes = new List<Dictionary<string, object>>();
            _ultimoIndexHuespedTab = 0;
            _actualizarPrecios = true;
            _validarFecha = false;
        }

        private void BtnBuscarHabitaciones_Click(object sender, EventArgs e)
        {
            if (TxtNumeroPersonas.Text.Length > 0) {
                HabitacionTB tbHabitaciones = new HabitacionTB();
                DataTable dt = tbHabitaciones.ConsultaHabitacionesLibres(Convert.ToInt32(TxtNumeroPersonas.Text.Length));
                CrearHabitacionesLibres(dt);
                CrearTabsDatosHuespedes();
                TxtDias.Text = "1";
                TbCrHuespedes.Enabled = true;
                TxtDias.Enabled = true;
            }
        }

        private void CrearHabitacionesLibres(DataTable dt)
        {
            
            List<Dictionary<String, string>> datos = new List<Dictionary<string, string>>();
            Dictionary<String, string> row = null;
            string ultTipo = "";

            int idx = 1;
            foreach (DataRow dr in dt.Rows) {
                if (ultTipo != dr["TIPO"].ToString())
                {
                    idx = 1;
                    ultTipo = dr["TIPO"].ToString();
                    row = new Dictionary<string, string>();
                    row.Add("TITULO", ultTipo);
                    datos.Add(row);
                }
                row.Add("NUM" + ultTipo + idx, dr["NUMERO"].ToString());
                idx++;
            }

            int maxNum = Math.Max(datos[0].Count, datos[1].Count);

            DataTable dtHabitaciones = new DataTable();
            dtHabitaciones.Columns.Add("TIPO", typeof(string));
            for (int i = 1; i < maxNum; i++) {
                dtHabitaciones.Columns.Add("NUM" + i, typeof(int));
            }

            DataRow rowHabit = null;
            for (int i = 0; i < datos.Count; i++) {
                rowHabit = dtHabitaciones.NewRow();
                if (datos[i]["TITULO"] == "S") {
                    rowHabit[0] = "SIMPLE/400.00$";
                }
                else if (datos[i]["TITULO"] == "D") {
                    rowHabit[0] = "SIMPLE/800.00$";
                }
                else
                {
                    rowHabit[0] = "SUITE/1200.00$";
                }
                for (int j = 1; j < datos[i].Count; j++) {
                    rowHabit[j] = datos[i]["NUM" + datos[i]["TITULO"] + j];
                }
                dtHabitaciones.Rows.Add(rowHabit);
            }
            
            DtgvHabitaciones.DataSource = dtHabitaciones;
        }

        private void FormatearDataGridView() {
            DtgvHabitaciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 1; i < DtgvHabitaciones.Columns.Count; i++) {
                DtgvHabitaciones.Columns[1].Width = 50;
                DtgvHabitaciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void DtgvHabitaciones_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DtgvHabitaciones.CurrentCell == null) return;
            AplicarDatosHabitación(DtgvHabitaciones.CurrentCell);
        }

        private void AplicarDatosHabitación(DataGridViewCell celda)
        {         
            if (DtgvHabitaciones.CurrentCell.ColumnIndex != 0)
            {
                string info = DtgvHabitaciones.Rows[DtgvHabitaciones.CurrentCell.RowIndex].Cells[0].Value.ToString().Substring(0, 2);

                LblHabitacion.Text = "Habitación ";
                _numeroHabitacion = celda.Value.ToString();
                if (info == "SI")
                {
                    _categoriaHabitacion = "S";
                    _precioHabitacion = 400;
                    LblHabitacion.Text += " Simple" + _numeroHabitacion;
                }
                else if (info == "DO")
                {
                    _categoriaHabitacion = "D";
                    _precioHabitacion = 800;
                    LblHabitacion.Text += " Doble" + _numeroHabitacion;
                }
                else
                {
                    _categoriaHabitacion = "U";
                    _precioHabitacion = 1200;
                    LblHabitacion.Text += " Suite " + _numeroHabitacion;
                }
            }
            else
            {
                _categoriaHabitacion = "N";
                _precioHabitacion = 0;
                LblHabitacion.Text = "Seleccione Habitación";
            }
            _validarFecha = false;
            ActualizarPrecios();
            _validarFecha = true;
        }

        private void TbCrHuespedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _actualizarPrecios = false;
            GuardarDatosHuesped();
            _ultimoIndexHuespedTab = TbCrHuespedes.SelectedIndex;

            TabPage tbPage = TbCrHuespedes.SelectedTab;
            tbPage.Controls.Add(LblNombre);
            tbPage.Controls.Add(LblApellidos);
            tbPage.Controls.Add(LblDocIdentidad);
            tbPage.Controls.Add(LblFechaNacimiento);
            tbPage.Controls.Add(TxtNombre);
            tbPage.Controls.Add(TxtApellidos);
            tbPage.Controls.Add(TxtDocIdentidad);
            tbPage.Controls.Add(DtpFechaNacimiento);

            TxtNombre.Text = _datosHuespedes[_ultimoIndexHuespedTab]["NOMBRE"].ToString();
            TxtApellidos.Text = _datosHuespedes[_ultimoIndexHuespedTab]["APPELLIDOS"].ToString();
            TxtDocIdentidad.Text = _datosHuespedes[_ultimoIndexHuespedTab]["DOCIDENTIDAD"].ToString();
            DtpFechaNacimiento.Value = Convert.ToDateTime(_datosHuespedes[_ultimoIndexHuespedTab]["FECHANACIMIENTO"]);
            _actualizarPrecios = true;
        }

        private void GuardarDatosHuesped()
        {
            _datosHuespedes[_ultimoIndexHuespedTab]["NOMBRE"] = TxtNombre.Text;
            _datosHuespedes[_ultimoIndexHuespedTab]["APPELLIDOS"] = TxtApellidos.Text;
            _datosHuespedes[_ultimoIndexHuespedTab]["DOCIDENTIDAD"] =TxtDocIdentidad.Text;
            _datosHuespedes[_ultimoIndexHuespedTab]["FECHANACIMIENTO"] = DtpFechaNacimiento.Value;

            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            TxtDocIdentidad.Text = "";
            DtpFechaNacimiento.Value = DateTime.Now;
        }

        private void CrearTabsDatosHuespedes() {
            int numPersonas = Convert.ToInt32(TxtNumeroPersonas.Text);
            for (int i = TbCrHuespedes.TabCount - 1; i > 0; i--)
                TbCrHuespedes.TabPages.RemoveAt(i);

            _datosHuespedes.Clear();
            for (int i = 0; i < numPersonas; i++)
            {
                Dictionary<string, object> huesped = new Dictionary<string, object>();
                huesped.Add("NOMBRE", "");
                huesped.Add("APPELLIDOS", "");
                huesped.Add("DOCIDENTIDAD", "");
                huesped.Add("FECHANACIMIENTO", DateTime.Now);
                _datosHuespedes.Add(huesped);
            }

            for (int i = 2; i <= numPersonas; i++) {
                TbCrHuespedes.TabPages.Add("" + i);
            }
        }

        private void ActualizarPrecios() {
            if (!_actualizarPrecios) return;

            float subTotal = 0;
            float IVA = 0;
            float total = 0;
            int numeroPersonas = Convert.ToInt32(TxtNumeroPersonas.Text);
            int numeroDias = (TxtDias.Text.Length > 0?Convert.ToInt32(TxtDias.Text):1);

            int numNinios = 0;
            if (_validarFecha)
            {
                subTotal = _precioHabitacion;
                for (int i = 1; i < numeroPersonas; i++)
                {
                    DateTime nacimiento = (DateTime)_datosHuespedes[i]["FECHANACIMIENTO"];
                    int edad = nacimiento.AddTicks(-DateTime.Today.Ticks).Year - 1;
                    if (_categoriaHabitacion == "D" && edad < 16 && numNinios < 2)
                    {
                        numNinios++;
                    }
                    else
                    {
                        subTotal += _precioHabitacion * 1.5f;
                    }
                }
            }
            else {
                subTotal = _precioHabitacion * numeroPersonas;
            }

            subTotal *= numeroDias;
            IVA = subTotal * 0.16f;
            total = subTotal + IVA;

            LblPrecioHabitacion.Text = _precioHabitacion.ToString("###,##0.00");
            LblSubTotal.Text = subTotal.ToString("###,##0.00");
            LblIVA.Text = IVA.ToString("###,##0.00");
            LblTotal.Text = total.ToString("###,##0.00");

        }

        private void DtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (DtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento debe ser menor a la actual", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DtpFechaNacimiento.Value = DateTime.Now;
                return;
            }

            _datosHuespedes[TbCrHuespedes.SelectedIndex]["FECHANACIMIENTO"] = DtpFechaNacimiento.Value;
            ActualizarPrecios();
        }

        private void TxtDias_TextChanged(object sender, EventArgs e)
        {
            if (TxtDias.Text.Length <= 0) return;
            ActualizarPrecios();
        }

        private void TxtNumeroPersonas_TextChanged(object sender, EventArgs e)
        {
            if (TxtNumeroPersonas.Text.Length <= 0)
            {
                TbCrHuespedes.Enabled = false;
                TxtDias.Enabled = false;
            }
        }

        private bool Validar() {
            GuardarDatosHuesped();

            if (TxtNumeroPersonas.Text.Length <= 0)
            {
                MessageBox.Show("Es necesario el número depersonas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (TxtDias.Text.Length <= 0)
            {
                MessageBox.Show("Es necesario el número de días", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            for (int i = 0; i < TbCrHuespedes.TabCount; i++)
            {
                Dictionary<string, object> huesped = _datosHuespedes[i];
                if (huesped["NOMBRE"].ToString().Length <= 0) {
                    MessageBox.Show("Es necesario el nombre del huesped " + (i+1), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (huesped["APPELLIDOS"].ToString().Length <= 0)
                {
                    MessageBox.Show("Es necesario los apellidos del huesped " + (i + 1), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (huesped["DOCIDENTIDAD"].ToString().Length <= 0)
                {
                    MessageBox.Show("Es necesario el documento de identidad del huesped " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (huesped["FECHANACIMIENTO"].ToString().Length <= 0)
                {
                    MessageBox.Show("Es necesario la fecha de nacimiento del huesped " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }

            return true;
        }

        private void Limipiar() {
            _actualizarPrecios = false;
            TxtNumeroPersonas.Text = "";
            TxtDias.Text = "";

            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            TxtDocIdentidad.Text = "";
            DtpFechaNacimiento.Value = DateTime.Now;

            DtgvHabitaciones.DataSource = null;
            _actualizarPrecios = true;

            LblHabitacion.Text = "Seleccione habitación";
            LblHabitacion.Text = "0.00";
            LblSubTotal.Text = "0.00";
            LblIVA.Text = "0.00";
            LblTotal.Text = "0.00";

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(!Validar()) return;
            int id = 0;
            HuespedesTB tbHuespedes = new HuespedesTB();

            if (_tbDatos.RegistrarEntrada(ref id,
                                    _numeroHabitacion,
                                    Convert.ToInt32(TxtDias.Text),
                                    DateTime.Now,
                                    Convert.ToInt32(LblSubTotal.Text),
                                    Convert.ToInt32(LblTotal.Text),
                                    ModuloGeneral.IDUsuario))

            {
                for (int i = 0; i < _datosHuespedes.Count; i++)
                {
                    if (!_tbDatos.RegistrarEntrada(ref id,
                                       _numeroHabitacion,
                                       Convert.ToInt32(TxtDias.Text),
                                       DateTime.Now,
                                       Convert.ToInt32(LblSubTotal.Text),
                                       Convert.ToInt32(LblTotal.Text),
                                       ModuloGeneral.IDUsuario))
                    {
                        MessageBox.Show(tbHuespedes.Error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else {
                MessageBox.Show(_tbDatos.Error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se limpiaran todos los datos del formulario\n¿Está seguro de continuar", "LIMPIAR",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) != DialogResult.OK) return;
            Limipiar();
        }
    }

}
