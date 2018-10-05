/**
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
            parametros.Add("IDOPERADORSALIDA", "" + idOperador);
            return EjecucionExitosa;
        }

        public bool RegtistrarSalida(int id, DateTime fechaSalida, int idOperador) {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("FECHASALIDA", "'20180901'");
            parametros.Add("IDOPERADORSALIDA", "" + idOperador);
            Guardar(ref id, parametros);
            return EjecucionExitosa;
        }

        public Dictionary<string, object> ConsultaHospedaje(int numero) {
            return ConsultarDictionary("hospedajes a",
                                       "a.ID, b.NUMERO, a.FECHASALIDA, a.DIAS, a.TOTAL",
                                       "b.NUMERO=" + numero,
                                       "INNER JOIN habitaciones b ON a.IDHABITACION = b.ID", 
                                       "",
                                       "", 
                                       null);

        }
    }
}
