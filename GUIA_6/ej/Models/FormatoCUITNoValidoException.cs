using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    public class FormatoCUITNoValidoException : ApplicationException
    {
        public FormatoCUITNoValidoException():base("CUIT no válido") { } 
        public FormatoCUITNoValidoException(string message) { }
        public FormatoCUITNoValidoException(string message, Exception inner) { }
    }
}
