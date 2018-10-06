﻿using System;
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
    public partial class FrmPruebas : Form
    {
        public FrmPruebas()
        {
            InitializeComponent();
        }

        private void FrmPruebas_Load(object sender, EventArgs e)
        {
            HospedajesTB tbDat = new HospedajesTB();
            Dictionary<string,object> dr = tbDat.ConsultaHospedaje(101);
           
            //DataTable dt = tbDat.ConsultaResumen();
            if (tbDat.Error.Length <= 0)
            {
               // DtgvDatos.DataSource = dt;
            }
            else {
                MessageBox.Show(tbDat.Error);
            }
        }
    }
}
