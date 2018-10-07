﻿/**
* program: SGH-ElEmperador
* file: HospedajesTB.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Clase de acceso a la tabla hospedajes
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH_ElEmperador.BaseDeDatos
{
    class HospedajesTB: Core.BaseTabla
    {
        public HospedajesTB() : base("hospedajes") {

        }

        public bool RegistrarEntrada(ref int id, string numeroHabitacion, int dias, DateTime fechaEntrada, float subTotal, float total, int idOperador) {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("IDHABITACION", "" + "(SELECT ID FROM habitaciones WHERE NUMERO=" + numeroHabitacion + " LIMIT 1)");
            parametros.Add("DIAS", "" + dias);
            parametros.Add("FECHAENTRADA", "'" + fechaEntrada.ToString("yyyy-MM-dd") + "'");
            parametros.Add("ESTADO", "'A'");
            parametros.Add("SUBTOTAL", "" + subTotal);
            parametros.Add("TOTAL", "" + total);
            parametros.Add("IDOPERADORENTRADA", "" + idOperador);
            Guardar(ref id, parametros);
            return EjecucionExitosa;
        }

        public bool RegistrarSalida(int id, DateTime fechaSalida, int idOperador) {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("FECHASALIDA","'" + fechaSalida.ToString("yyyy-MM-dd") + "'");
            parametros.Add("IDOPERADORSALIDA", "" + idOperador);
            parametros.Add("ESTADO", "'C'");
            Guardar(ref id, parametros);
            return EjecucionExitosa;
        }

        public Dictionary<string, object> ConsultaHospedaje(int numero) {
            return ConsultarDictionary("hospedajes a",
                                       "a.ID, b.NUMERO, a.DIAS, a.TOTAL",
                                       "a.ESTADO='A' AND b.NUMERO=" + numero,
                                       "INNER JOIN habitaciones b ON a.IDHABITACION = b.ID", 
                                       "",
                                       "", 
                                       null);

        }
    }
}
