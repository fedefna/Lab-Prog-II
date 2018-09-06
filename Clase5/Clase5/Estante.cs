using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        //alta magia, mi constructor publico llama al privado..
        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] getProductos()
        {
            return this.productos;
        }

        public static string mostrarEStante(Estante e)
        {
            string retorno="";
            for (int i=0; i < e.productos.Length; i++)
            {

            }
            return retorno;
        }
    }
}
