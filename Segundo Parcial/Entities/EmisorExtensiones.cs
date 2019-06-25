using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class EmisorExtensiones
    {
        public static string Mostrar(this EmisorDeEmails emisor)
        {
            return emisor.ToString() + "Mail: " + emisor.Email;
        }

        public static string Mostrar(this EmisorDeWhatsapp emisor)
        {
            return emisor.ToString() + "Telefono: " + emisor.NumeroTelefono;
        }
    }
}
