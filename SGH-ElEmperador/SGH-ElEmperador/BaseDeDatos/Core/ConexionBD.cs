/**
* program: SGH-ElEmperador
* file: ConexionBD.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Clase de conexión
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
    class ConexionBD
    {
        private SQLiteConnection _conexion;

        private static ConexionBD _instancia;
        public static ConexionBD Instancia {
            get {
                if (_instancia == null) {
                    _instancia = new ConexionBD(@"Data Source=C:\Users\alarc\UDID\ITSZN\Gestión de Proyectos de Software\Proyecto Hotel El Emperador\luandape_software_desarrollo\SGH-ElEmperador\SGH-ElEmperador\General\Data\DB-SGH-ElEmperador.db");
                }
                return _instancia;
            }
        }
        
        public bool DesconexionAutomatica{
            get;
            set;
        }

        /* 
        * Constructor
        * string stringConexion:Dato para empezar a calcular 
        * Constructor de la clase
        */
        private ConexionBD(string stringConexion) {
            _conexion = new SQLiteConnection(stringConexion);
            DesconexionAutomatica = true;
        }

        /* 
        * Conectar
        * Abre la conexión
        */
        public void Conectar() {
            try
            {
                _conexion.Open();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        /* 
        * Desconectar
        * Cierra la conexión
        */
        public void Desconectar()
        {
            try
            {
                _conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* 
        * EjecutarComando
        * SQLiteCommand cmd: Comando a ejecutar
        * Ejecuta un comando SQLite
        */
        public bool EjecutarComando(SQLiteCommand cmd)
        {
            try
            {
                Conectar();
                cmd.Connection = _conexion;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally {
                Desconectar();
            }         
        }

        /* 
        * EjecutarComandoConsultaDT
        * SQLiteCommand cmd: Comando a ejecutar
        * DataTable dataTable: DataTable a llenar
        * Ejecuta un comando SQLite de consulta y llena un DataTable con el resultado
        */
        public bool EjecutarComandoConsultaDT(SQLiteCommand cmd,DataTable dataTable)
        {
            try
            {
                Conectar();
                SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                cmd.Connection = _conexion;
                sda.Fill(dataTable);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        /* 
        * EjecutarComandoConsultaDR
        * SQLiteCommand cmd: Comando a ejecutar
        * SQLiteDataReader dataReader: DataReader a llenar
        * Ejecuta un comando SQLite de consulta y activa un DataReader con el resultado
        */
        public bool EjecutarComandoConsultaDR(SQLiteCommand cmd, ref SQLiteDataReader dataReader)
        {
            try
            {
                Conectar();
                cmd.Connection = _conexion;
                dataReader = cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
