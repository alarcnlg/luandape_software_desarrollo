/**
* program: SGH-ElEmperador
* file: BaseTabla.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Clase base para las calse de acceso a la base de datos
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SGH_ElEmperador.BaseDeDatos.Core
{
    class BaseTabla
    {
        public string NombreTabla { get; private set; }
        public string Error { get; private set; }
        protected bool EjecucionExitosa { get; set; }
        protected SQLiteDataReader DataReader;

        /* 
        * Constructor
        * string nombreTabla: Nombre de la tabla a administrar
        * Constructor de la clase
        */
        public BaseTabla(string nombreTabla) {
            NombreTabla = nombreTabla;
        }

        /* 
        * ConsultarDT
        * string nombreTabla: Nombre de la tabla a administrar, string campos: Campos a consultar
        * string criterio: Criterio de la consulta ,string join:  JOIN de la consulta
        * string ordenado: Campos por el cual ordenar, string group: Campos por el cual agrupar, 
        * Dictionary<string, object> parametros: Parametros que se usan en la consulta
        * Permite ejecutar una consulta y guardar el resultado en el DataTable que retorna.
        * Si no se usa un campo, se debe dejar vacio.
        */
        protected DataTable ConsultarDT(string nombreTabla, string campos, string criterio, string join, string ordenado, string group, Dictionary<string, object> parametros) {
            DataTable dt = new DataTable();
            EjecucionExitosa = false;
            Error = "";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                string cmdString = "";

                cmdString = "SELECT " + (campos.Length>0?campos:"*");
                cmdString += " FROM " + (nombreTabla.Length > 0 ? nombreTabla : NombreTabla) + " ";
                cmdString += join;
                cmdString += (criterio.Length > 0 ? " WHERE " + criterio : "");
                cmdString += (group.Length > 0 ? " GROUP BY " + group : "");
                cmdString += (ordenado.Length > 0 ? " ORDER BY " + ordenado : "");

                if (parametros != null)
                {
                    foreach (var key in parametros.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, parametros[key]);
                    }
                }

                cmd.CommandText = cmdString;
                if (!ConexionBD.Instancia.EjecutarComandoConsultaDT(cmd,dt))
                {
                    throw new Exception("Error al consultar DataTable \n Tabla=" + NombreTabla);
                }
                EjecucionExitosa = true ;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }

            return dt;
        }

        /* 
        * ConsultarDR
        * string nombreTabla: Nombre de la tabla a administrar, string campos: Campos a consultar
        * string criterio: Criterio de la consulta ,string join:  JOIN de la consulta
        * string ordenado: Campos por el cual ordenar, string group: Campos por el cual agrupar, 
        * Dictionary<string, object> parametros: Parametros que se usan en la consulta
        * Permite ejecutar una consulta y guardar el resultado en un DataReader que retorna.
        * Si no se usa un campo, se debe dejar vacio.
        */
        protected void ConsultarDR(string nombreTabla, string campos, string criterio, string join, string ordenado, string group, Dictionary<string, object> parametros)
        {
            EjecucionExitosa = false;
            Error = "";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                string cmdString = "";

                cmdString = "SELECT " + (campos.Length > 0 ? campos : "*");
                cmdString += " FROM " + (nombreTabla.Length > 0 ? nombreTabla : NombreTabla) + " ";
                cmdString += join;
                cmdString += (criterio.Length > 0 ? " WHERE " + criterio : "");
                cmdString += (group.Length > 0 ? " GROUB BY " + group : "");
                cmdString += (ordenado.Length > 0 ? " ORDER BY " + ordenado : "");

                if (parametros != null)
                {
                    foreach (var key in parametros.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, parametros[key]);
                    }
                }
                cmd.CommandText = cmdString;
                if (!ConexionBD.Instancia.EjecutarComandoConsultaDR(cmd, ref DataReader))
                {
                    throw new Exception("Error al consultar DataReader \n Tabla=" + NombreTabla);
                }
                EjecucionExitosa = true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }

        /* 
        * ConsultarDictionary
        * string nombreTabla: Nombre de la tabla a administrar, string campos: Campos a consultar
        * string criterio: Criterio de la consulta ,string join:  JOIN de la consulta
        * string ordenado: Campos por el cual ordenar, string group: Campos por el cual agrupar, 
        * Dictionary<string, object> parametros: Parametros que se usan en la consulta
        * Permite ejecutar una consulta y guardar el resultado en un dictionary que retorna.
        * Si no se usa un campo, se debe dejar vacio.
        */
        protected Dictionary<string, object> ConsultarDictionary(string nombreTabla, string campos, string criterio, string join, string ordenado, string group, Dictionary<string, object> parametros)
        {
            EjecucionExitosa = false;
            Error = "";
            Dictionary<string, object> datos = null;
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                string cmdString = "";

                cmdString = "SELECT " + (campos.Length > 0 ? campos : "*");
                cmdString += " FROM " + (nombreTabla.Length > 0 ? nombreTabla : NombreTabla) + " ";
                cmdString += " " + join;
                cmdString += (criterio.Length > 0 ? " WHERE " + criterio : "");
                cmdString += (group.Length > 0 ? " GROUB BY " + group : "");
                cmdString += (ordenado.Length > 0 ? " ORDER BY " + ordenado : "");

                if (parametros != null)
                {
                    foreach (var key in parametros.Keys)
                    {
                        cmd.Parameters.AddWithValue(key, parametros[key]);
                    }
                }

                cmd.CommandText = cmdString;
                if (!ConexionBD.Instancia.EjecutarComandoConsultaDR(cmd, ref DataReader))
                {
                    throw new Exception("Error al consultar DataTable \n Tabla=" + NombreTabla);
                }

                if (DataReader != null)
                {
                    if (DataReader.HasRows)
                    {
                        datos = new Dictionary<string, object>();
                        DataReader.Read();
                        for (int i = 0; i < DataReader.FieldCount; i++)
                        {
                            datos.Add(DataReader.GetName(i), DataReader.GetValue(i));
                        }
                    }
                }
                EjecucionExitosa = true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            finally {
                if(DataReader != null)
                    DataReader.Close();
                ConexionBD.Instancia.Desconectar();
            }

            return datos;
        }

        /* 
        * Guardar
        * int id: Id unico, si es un nuevo registro en esta variable se guardar el ID del nuevo registro
        * Dictionary<string, object> parametros: Valores que se van a insertan
        * Inserta o actualiza dependiendo del Id
        */
        protected void Guardar(ref int id, Dictionary<string, object> parametros) {
            if (parametros == null) return;

            if (id == 0)
            {
                Insertar(ref id, parametros);
            }
            else
            {
                Actualizar(ref id, parametros);
            }
           
        }

        /* 
        * Guardar
        * int id: Id unico, si es un nuevo registro en esta variable se guardar el ID del nuevo registro
        * Dictionary<string, object> parametros: Valores que se van a insertan
        * Inserta un nuevo registro
        */
        protected void Insertar(ref int id, Dictionary<string, object> parametros)
        {
            EjecucionExitosa = false;
            Error = "";
            if (parametros.Count == 0) return;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                string cmdString = "";
                bool mostrarComa = false;

                cmdString = "INSERT INTO " + NombreTabla + "(";
                foreach (string key in parametros.Keys)
                {
                    cmdString += (mostrarComa ? ",": "") + key;
                    mostrarComa = true;
                }

                mostrarComa = false;
                cmdString += ") VALUES(";
                foreach (var key in parametros.Keys)
                {
                    cmdString += (mostrarComa ? "," : "") + parametros[key].ToString();
                    mostrarComa = true;
                }
                cmdString += ")";

                cmd.CommandText = cmdString;
                if (!ConexionBD.Instancia.EjecutarComando(cmd))
                {
                    throw new Exception("Error al insertar \n Tabla=" + NombreTabla + "\nID=" + id);
                }

                var dato = ConsultarDictionary("", "ID", "", "", "ID DESC LIMIT 1", "", null);
                id = Convert.ToInt32(dato["ID"]);
                EjecucionExitosa = true;
            }
            catch (Exception ex) {
                Error = ex.Message;
            }
        }

        /* 
        * Actualizar
        * int id: Id unico, si es un nuevo registro en esta variable se guardar el ID del nuevo registro
        * Dictionary<string, object> parametros: Valores que se van a insertan
        * Actualiza un registro existente
        */
        protected void Actualizar(ref int id, Dictionary<string, object> parametros)
        {
            EjecucionExitosa = false;
            Error = "";
            if (parametros.Count == 0) return;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                string cmdString = "";
                bool mostrarComa = false;

                cmdString = "UPDATE " + NombreTabla + " SET ";
                foreach (string key in parametros.Keys)
                {
                    cmdString += (mostrarComa ? ", " : "") + key + " = " + parametros[key].ToString();
                    mostrarComa = true;
                }
                cmdString += " WHERE ID=" + id;

                cmd.CommandText = cmdString;
                if (!ConexionBD.Instancia.EjecutarComando(cmd))
                {
                    throw new Exception("Error al actualizar \n Tabla=" + NombreTabla + "\nID=" + id);
                }
                EjecucionExitosa = true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }

        /* 
        * Eliminar
        * int id: Id unico, si es un nuevo registro en esta variable se guardar el ID del nuevo registro
        * Dictionary<string, object> parametros: Valores que se van a insertan
        * Elimina un registro
        */
        protected void Eliminar(ref int id)
        {
            EjecucionExitosa = false;
            Error = "";
            if (id == 0) return;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM " + NombreTabla + " WHERE ID=" + id);
                if (!ConexionBD.Instancia.EjecutarComando(cmd))
                {
                    throw new Exception("Error al eliminar \n Tabla=" +NombreTabla + "\nID=" + id);
                }
                EjecucionExitosa = true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
        }

    }
}
