using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WhatsappEcxeption : Exception
    {   
        public WhatsappEcxeption(string mensaje)
            : base(mensaje)
        { }   
    }
}
