using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCELL.Datos
{
    class cRol
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public int Estado;
        public cRol() { }
        public cRol(int id, string nombre, string descripcion, int estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }

    }
}
