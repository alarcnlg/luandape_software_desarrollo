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

        bool RegistrarEntrada(int id, string numeroHabitacion, int dias, DateTime fechaEntrada, float subTotal, float total, int idOperador) {
            return true;
        }

        bool RegtistrarSalida(int id, DateTime fechaSalida, int idOperador) {
            return true;
        }

        Dictionary<string, object> ConsultaHospedaje(string numero) {
            return null;
        }
    }
}
