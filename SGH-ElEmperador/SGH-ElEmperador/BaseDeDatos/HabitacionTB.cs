using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SGH_ElEmperador.BaseDeDatos
{
    class HabitacionTB: Core.BaseTabla
    {
        public HabitacionTB() : base("habitaciones") {

        }

        public bool ActualizarEstado(int id,char estado) {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("ESTADO", "'" + estado + "'");
            Actualizar(ref id, parametros);
            return EjecucionExitosa;
        }

        public int ConsultaId(int numeroHabitacion) {
            int id = 0;
            Dictionary<string, object> datos = ConsultarDictionary("", "ID", "NUMERO=" + numeroHabitacion, "", "", "", null);
            if (datos != null) {
                id = Convert.ToInt32(datos["ID"]);
            }
            return id;
        }

        public DataTable ConsultaResumen() {
            DataTable dtResult = new DataTable();
            DataTable dt =  ConsultarDT("",
                                      "TIPO, ESTADO,COUNT(*) AS CANTIDAD", 
                                      "",
                                      "",
                                      "TIPO DESC", 
                                      "TIPO, ESTADO", 
                                      null);
            if (dt == null) return null;

            dtResult.Columns.Add("TIPO", typeof(string));
            dtResult.Columns.Add("LIBRE", typeof(string));
            dtResult.Columns.Add("OCUPADO", typeof(string));
            dtResult.Columns.Add("RESERVADO", typeof(string));

            DataRow row = null;
            string ultTipo = "";
            foreach (DataRow rowDat in dt.Rows) {

                if (ultTipo != rowDat["TIPO"].ToString())
                {
                    if (row != null) {
                        dtResult.Rows.Add(row);
                    }
                    row = dtResult.NewRow();
                    ultTipo = rowDat["TIPO"].ToString();

                    if (rowDat["TIPO"].ToString() == "S")
                        row["TIPO"] = "Simple";
                    else if (rowDat["TIPO"].ToString() == "D")
                        row["TIPO"] = "Doble";
                    else if (rowDat["TIPO"].ToString() == "U")
                        row["TIPO"] = "Suite";
                }

                if (rowDat["ESTADO"].ToString() == "L")
                    row["LIBRE"] = rowDat["CANTIDAD"];
                else if (rowDat["ESTADO"].ToString() == "O")
                    row["OCUPADO"] = rowDat["CANTIDAD"];
                else if (rowDat["ESTADO"].ToString() == "R")
                    row["RESERVADO"] = rowDat["CANTIDAD"];
            }
            dtResult.Rows.Add(row);

            return dtResult;
        }

        public DataTable ConsultaHabitacionesLibres(int numPersonas) {
            string criterios = "";

            if (numPersonas == 1)
            {
                criterios = "(TIPO='S' OR TIPO='U')";
            }
            else
            {
                criterios = "(TIPO='D' OR TIPO='U')";
            }
            criterios += " AND ESTADO='L'";

            return ConsultarDT("", 
                    "NUMERO, TIPO",
                    criterios, 
                    "", 
                    "TIPO, NUMERO ASC",
                    "", 
                    null);

        }
    }
}
