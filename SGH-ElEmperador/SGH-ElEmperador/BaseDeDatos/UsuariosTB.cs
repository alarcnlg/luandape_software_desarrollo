/**
* program: SGH-ElEmperador
* file: UsuariosTB.cs
* company: LUANDAPE Software
* author: Luis Alarcón
* description: Clase de acceso a la tabla usuarios
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGH_ElEmperador.BaseDeDatos
{
    class UsuariosTB: Core.BaseTabla
    {
        public UsuariosTB() : base("usuarios") {

        }

        /* 
        * ValidarLogin
        * string usuario: Nombre de usuario
        * string password: Password del usuario
        * Valida si el usuario y contraseña son correctos
        */
        public Dictionary<string, object> ValidarLogin(string usuario, string password) {
            Dictionary<string, object> resultado = new Dictionary<string, object>();

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@USUARIO", usuario);
            parametros.Add("@PASSWORD", password);

            resultado = ConsultarDictionary("", 
                "ID, (CASE WHEN TIPO = 'A' THEN 1 ELSE 0 END) AS ADMINISTRADOR",
                "USUARIO = @USUARIO AND PASSWORD = @PASSWORD",
                "",
                "",
                "",
                parametros);

            return resultado;
        }

    }
}
