using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCELL.Datos
{
    class cUsuario
    {
        public int Id;
        public cRol Rol;
        public string Login;
        public string Nombre;
        public string Apellido;
        public int Estado;
        public cUsuario() { }
        public cUsuario(int id, cRol rol, string login, string nombre, string apellido, int estado)
        {
            this.Id = id;
            this.Rol = rol;
            this.Login = login;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Estado = estado;
        }
    }
}
