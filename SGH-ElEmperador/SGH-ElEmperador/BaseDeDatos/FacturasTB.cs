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
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("IDHOSPEDAJE", idHospedaje);
            Guardar(ref id, parametros);
            return EjecucionExitosa;
        }

        public DataTable ConsultaGeneral() {
            string campos = "";
            campos = "f.NOFACTURA, h.FECHAENTRADA, h.FECHASALIDA, a.NUMERO AS NUMEROHABITACION, ";
            campos += "CASE WHEN a.TIPO = 'S' THEN 'Simple' ELSE ";
            campos += "CASE WHEN a.TIPO = 'D' THEN 'Doble' ELSE 'Suite' END END AS TIPO, ";
            campos += "(SELECT NOMBRE || ' ' || APELLIDOS FROM huespedes WHERE IDHOSPEDAJE = f.IDHOSPEDAJE ORDER BY ID ASC LIMIT 1) AS PERSONAENCARGADO";

            string join = "INNER JOIN hospedajes h ON f.IDHOSPEDAJE=h.ID ";
            join += "INNER JOIN habitaciones a ON a.ID=h.IDHABITACION ";

            return ConsultarDT("facturas f", campos, "", join, "FECHASALIDA DESC", "", null);
        }

        public Dictionary<string,object> Consulta(int id)
        {
            string campos = "";
            campos = "f.NOFACTURA, h.FECHAENTRADA, h.FECHASALIDA, a.NUMERO AS NUMEROHABITACION, ";
            campos += "CASE WHEN a.TIPO = 'S' THEN 'Simple' ELSE ";
            campos += "CASE WHEN a.TIPO = 'D' THEN 'Doble' ELSE 'Suite' END END AS TIPO, ";
            campos += "(SELECT NOMBRE || ' ' || APELLIDOS FROM huespedes WHERE IDHOSPEDAJE = f.IDHOSPEDAJE ORDER BY ID ASC LIMIT 1) AS PERSONAENCARGADO, ";
            campos += "(SELECT COUNT(*) FROM huespedes WHERE IDHOSPEDAJE = f.IDHOSPEDAJE) AS NUMEROPERSONAS, ";
            campos += "h.SUBTOTAL, (h.SUBTOTAL* .16) as IVA, h.TOTAL || ' MXN' AS TOTAL ";

            string join = "INNER JOIN hospedajes h ON f.IDHOSPEDAJE=h.ID ";
            join += "INNER JOIN habitaciones a ON a.ID=h.IDHABITACION ";

            return ConsultarDictionary("facturas f", campos, "f.ID=1", join, "", "", null);
        }

    }
}
