using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigoDeBarra;
        }
        public string GetMarca()
        {
            return this.marca;

        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return $"Marca {p.marca} - Codigo {p.codigoDeBarra} - Precio {p.precio}";
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p, Producto p1)
        {
            if(p is not null && p1 is not null)
            {
                return p.codigoDeBarra == p1.codigoDeBarra && p.marca == p1.marca;
            }
            return false;
        }
        public static bool operator ==(Producto p,string marca)
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p, Producto p1)
        {
            return !(p==p1);
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p==marca);
        }

    }
}
