using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Demo
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioVenta { get { return Precio * 1.16M; } }
        public DateTime FechaAlta { get { return DateTime.Now; } }


        public void Mostrar(Producto producto) 
        {
            Console.WriteLine($"Código de producto: {producto.CodigoProducto}\n" +
                $"Descripción:{producto.Descripcion}\n" +
                $"Tiene un precio de:{producto.PrecioVenta}\n");
        }
    }
}
