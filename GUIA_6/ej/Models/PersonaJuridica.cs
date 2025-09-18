using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    public class PersonaJuridica : Persona
    {
        string cuit;
        public PersonaJuridica(string nombre, string cuit) : base(nombre)
        {
            this.cuit = cuit;
        }
        public override string Describir()
        {
            return base.Describir() + " " + $"( {this.cuit} )";
        }
    }
}
