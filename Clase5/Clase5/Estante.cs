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

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string retorno="Ubicacion: "+e.ubicacionEstante+". ";
            for (int i=0; i < e.productos.Length; i++)
            {
              float precio = e.productos[i].GetPrecio();
              if (precio > 0)
              {
                retorno=retorno+"Marca: "+ e.productos[i].GetMarca() + ". " + "Codigo de barras: "+ e.productos[i].GetCodigoDeBarra() + ". " + "Precio: "+precio+". ";
              }
            }
            return retorno;
        }

        public static bool operator ==(Estante e, Producto p)
        {
          bool retorno = false;

          if (e is null || p is null)
          {
            retorno = false;
          }
          else
          {
            for (int i = 0; i < e.productos.Length; i++)
            {
          if (!(object.Equals(e.productos[i],null)))
          {
            float precio = e.productos[i].GetPrecio();
            if (e.productos[i].GetCodigoDeBarra() == p.GetCodigoDeBarra())
            {
              retorno = true;
            }
          }
              
            }
          }
          return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
          return !(e == p);
        }

    public static bool operator +(Estante e, Producto p)
    {
      bool retorno = false;
      
        if (e != p)
      {
        for (int i = 0; i < e.productos.Length; i++)
        {
          if (e.productos[i] is null)
          {
            e.productos[i] = p;
            retorno = true;
            break;
          }
        }
      }      
     
      
      return retorno;
    }
    public static Estante operator -(Estante e, Producto p)
    {

      if (e is null || p is null)
      {

      }
      else
      {
        int flag = 0;
        for (int i = 0; i < e.productos.Length; i++)
        {
          if (e.productos[i]==p)
          {
            flag = 1;
          }
          if (flag == 1)
          {
            e.productos[i] = null;
            break;
          }
        }
      }
      return e;
    }
  }
}
