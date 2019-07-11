using Entities;
using EntitiesDAO;
using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Persistencia
{
    public class WhatsappXml : IData<EmisorDeWhatsapp>
    {
        private readonly string path;

        /// <summary>
        /// Asignar valor al path del escritorio + el nombre del archivo.xml
        /// </summary>
        public WhatsappXml()
        {
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\whtsappXML.xml ";
        }

        /// <summary>
        /// agrega al archivo (si no existe lo crea) el objeto serializado.
        /// </summary>
        /// <param name="emisor"></param>
        public void Guardar(Emisor emisor)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Emisor));
                XmlTextWriter wtr = new XmlTextWriter(this.path, Encoding.UTF8);
                serializer.Serialize(wtr, emisor);
                wtr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// recupera el o los objetos serializados y los devuelve en forma de lista.
        /// </summary>
        /// <returns></returns>
        public EmisorDeWhatsapp Leer()
        {
            XmlTextReader rdr = new XmlTextReader(this.path);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(EmisorDeWhatsapp));
                return (EmisorDeWhatsapp)serializer.Deserialize(rdr);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                rdr.Close();
            }
        }
    }
}
