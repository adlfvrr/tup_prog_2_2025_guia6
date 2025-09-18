using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    public class Persona : IComparable
    {
        protected string nombre;
        public string Nombre { get { return nombre; } }
        public Persona(string nombre) { this.nombre = nombre; }
        public virtual string Describir()
        {
            return this.Nombre;
        }

        public int CompareTo(object? obj)
        {
            Persona p = obj as Persona;
            if (p != null)
            {
                return this.Nombre.CompareTo(p.Nombre);
            }
            return -1;
        }
    }
}
