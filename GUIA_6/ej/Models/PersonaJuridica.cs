using System;
using System.Collections.Generic;
using System.Configuration;
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
            if (VerificarCUIT() == false)
            {
                throw new FormatoCUITNoValidoException();
            }
        }
        protected bool VerificarCUIT(string cuit)
        {
            int[] p = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            bool esValido = this.cuit.Length == 11;
            int ac = 0;
            for(int i = 0;esValido && i < 10; i++)
            {
                esValido &= Char.IsNumber(this.cuit[i]);
                if (esValido)
                {
                    ac += ((int)char.GetNumericValue(this.cuit[i])) * p[i];
                }
                else { return false; }
            }
            int v = 0;
            if (ac % 11 == 0) { v = 0; }
            else if (ac % 11 == 1) { v = 9; }
            else v = 11 - ac % 11;

            return v == ((int)char.GetNumericValue(this.cuit[11])) * p[11];
        }
        public override string Describir()
        {
            return base.Describir() + " " + $"( {this.cuit} )";
        }
    }
}
