using Entities;
using EntitiesDAO;
using System;
using System.IO;

namespace Persistencia
{
    public class WhatsappTexto: IData<string>
    {
        private readonly string path;

        /// <summary>
        /// Asignar valor al path del escritorio + el nombre del archivo.txt
        /// </summary>
        public WhatsappTexto()
        {
            this.path= Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\whtsappTexto.txt ";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emisor"></param>
        public void Guardar(Emisor emisor)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.path);
                sw.WriteLine(emisor);
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// retorna un string con el contenido
        /// </summary>
        /// <returns></returns>
        public string Leer()
        {
            try
            {
                StreamReader rdr = new StreamReader(this.path);
                rdr.Close();
                return rdr.ReadToEnd();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
