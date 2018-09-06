using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto()
        {
            this.codigoDeBarra = "";
            this.marca = "";
            this.precio = 0;
        }

        public string getcodigoDeBarra()
        {
            return this.codigoDeBarra;
        }

        public void setCodigoDeBarra(string codigo)
        {
            this.codigoDeBarra = codigo;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public float getPrecio()
        {
            return this.precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }

        public void mostrarProducto(Producto prod)
        {
            Console.WriteLine("Codigo de barra: "+this.codigoDeBarra+". Marca: "+this.marca+". Precio: "+this.precio);
        }

        public static explicit operator string(Producto p)
        {
            return p.getcodigoDeBarra();
        }

        public static bool operator == (Producto p1, Producto p2)
        {
            bool retorno=false;

            if(p1 is null || p2 is null)
            {
                retorno = false;
            }   else if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
                {
                    retorno= true;
                }
            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1==p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;

            if (p is null || marca is null)
            {
                retorno = false;
            }
            else if (p.marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
