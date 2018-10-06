using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SGH_ElEmperador.BaseDeDatos
{
    class HuespedesTB: Core.BaseTabla
    {
        public HuespedesTB() : base("huespedes")
        {

        }

        public bool Guardar(ref int id, int idHospedaje, string nombre, string appellidos, string docIdentidad, DateTime fechaNacimiento)
        {
            return true;
        }

        public DataTable ConsultaGeneral(int idHospedaje)
        {
            return null;
        }
    }
}
