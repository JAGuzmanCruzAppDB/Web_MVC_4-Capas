using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objCapadatos = new CD_Usuarios();
        
        public List<Usuario> Listar()
        {
            return objCapadatos.Listar();
        }
        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.nombreusuario) || string.IsNullOrWhiteSpace(obj.nombreusuario))
            {
                Mensaje = "El nombre del usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.nombrecompleto) || string.IsNullOrWhiteSpace(obj.nombrecompleto))
            {
                Mensaje = "Es necesario ingresar el nombre completo";
            }
            else if (string.IsNullOrEmpty(obj.correo) || string.IsNullOrWhiteSpace(obj.correo))
            {
                Mensaje = "El correo del usuario no puede se vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {
                //    //string clave = "test123";
                //    string clave = CN_Recursos.GenerarClave();

                //    string asunto = "Creacion de cuenta";
                //    string mensaje_correo = "<h3>Su cuenta fue creada correctamente</h3></br><p>Su contraseña para acceder es: ¡clave!</p>";
                //    mensaje_correo = mensaje_correo.Replace("¡clave!", clave);

                //    bool respuesta = CN_Recursos.EnviarCorreo(obj.correo, asunto, mensaje_correo);
                //    if (respuesta)
                //    {
                //        obj.clave = CN_Recursos.ConvertirSha256(clave);
                //        return objCapadatos.Registrar(obj, out Mensaje);
                //    }
                //    else
                //    {
                //        Mensaje = "No se puede enviar el correo";
                //        return 0;
                //    }

                string clave = CN_Recursos.GenerarClave();
                obj.clave = CN_Recursos.ConvertirSha256(clave);
                return objCapadatos.Registrar(obj, out Mensaje);

            }
            else
            {
               return 0;
            }

        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.nombreusuario) || string.IsNullOrWhiteSpace(obj.nombreusuario))
            {
                Mensaje = "El nombre del usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.nombrecompleto) || string.IsNullOrWhiteSpace(obj.nombrecompleto))
            {
                Mensaje = "Es necesario ingresar el nombre completo";
            }
            else if (string.IsNullOrEmpty(obj.correo) || string.IsNullOrWhiteSpace(obj.correo))
            {
                Mensaje = "El correo del usuario no puede se vacio";
            }
            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCapadatos.Editar(obj, out Mensaje);
            }
            else
            {
                return false;
            }
        }
        public bool Eliminar(int id, out string Mensaje)//emviar un usuario objeto
        {
            return objCapadatos.Eliminar(id, out Mensaje);
        }
    }
}
