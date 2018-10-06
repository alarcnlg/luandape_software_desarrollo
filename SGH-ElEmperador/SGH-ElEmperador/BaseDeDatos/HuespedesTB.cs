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

        public bool Guardar(ref int id, int idHospedaje, string nombre, string apellidos, string docIdentidad, DateTime fechaNacimiento)
        {
            Dictionary<String, object> parametros = new Dictionary<string, object>();
            parametros.Add("IDHOSPEDAJE", idHospedaje);
            parametros.Add("NOMBRE", nombre);
            parametros.Add("APELLIDOS", apellidos);
            parametros.Add("DOCIDENTIDAD", docIdentidad);
            parametros.Add("FECHANACIMIENTO", fechaNacimiento.ToString("yyyyMMdd"));
            Guardar(ref id, parametros);

            return EjecucionExitosa;
        }

        public DataTable ConsultaGeneral(int idHospedaje)
        {
            return ConsultarDT("", "", "IDHOSPEDAJE="+idHospedaje, "", "", "", null);
        }
    }
}
