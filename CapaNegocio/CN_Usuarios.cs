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
                string clave = "test123";
                obj.clave = CN_Recursos.GetSHA256(clave);

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
        public bool Eliminar(Usuario id, out string Mensaje)
        {
            return objCapadatos.Eliminar(id, out Mensaje);
        }
    }
}
