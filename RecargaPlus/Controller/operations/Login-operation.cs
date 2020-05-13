using Controller.cache;
using Controller.tools;
using Controller.webService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.operations
{
    public class Login_operation
    {
        public bool login(String usuario, String clave)
        {
            Consultas consulta = new Consultas();
            String respuesta = consulta.login(usuario, clave);
            if (!respuesta.Equals(""))
            {
                var datos = respuesta.Split(',');
                Usuario_cache.IdPersona = int.Parse(datos[0]);
                Usuario_cache.Nombre = datos[1];
                Usuario_cache.Apepat = datos[2];
                Usuario_cache.Apemat = datos[3];
                Usuario_cache.Usuario = datos[4];
                Usuario_cache.Clave = datos[5];
                Usuario_cache.Tipo = byte.Parse(datos[6]) == 0 ? Strings.ADMINISTRADOR : Strings.COLABORADOR;
                return true;
            }
            return false;
        }
    }
}
