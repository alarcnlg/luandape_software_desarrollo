using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SGH_ElEmperador.BaseDeDatos
{
    class FacturasTB: Core.BaseTabla
    {
        public FacturasTB(): base("facturas")
        {
            
        }

        public bool Guardar(ref int id, int idHospedaje)
        {
            return true;
        }

        public DataTable ConsultaGeneral() {
            return null;
        }

        public Dictionary<string,object> Consulta(int id)
        {
            return null;
        }

    }
}
