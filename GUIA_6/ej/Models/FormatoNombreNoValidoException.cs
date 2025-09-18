using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models
{
    public class FormatoNombreNoValidoException : ApplicationException
    {
        public FormatoNombreNoValidoException()
        { }
        public FormatoNombreNoValidoException(string message)
        { }
        public FormatoNombreNoValidoException(string message, Exception inner)
        { }
        
    }
}
