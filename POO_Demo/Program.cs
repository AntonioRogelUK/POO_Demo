using System;
using System.Threading;

namespace POO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamado clase estatica
            //string parametro = "Mensaje enviado desde Main...";
            //MiClaseEstatica.MostrarMensaje(parametro);

            ////Llamado a clase no estatica
            //MiClase objetoClase = new MiClase();
            //Thread.Sleep(1000);
            //MiClase objetoClase2 = new MiClase();

            //Console.WriteLine($"La fecha del objetoClase es: {objetoClase.fecha}");
            //Console.WriteLine("");
            //Console.WriteLine($"La fecha del objetoClase2 es: {objetoClase2.fecha}");


            Producto producto1 = new Producto();

         

            //producto1.CodigoProducto = "001";
            //producto1.Precio = 100.00M;
            //producto1.Mostrar(producto1);

            //Producto producto2 = new Producto();
            //producto2.CodigoProducto = "002";
            //producto2.Descripcion = "Agua embotellada";
            //producto2.Precio = 10.00M;
            //producto2.Mostrar(producto2);

            

            EmpleadoBase empleadoBase = new EmpleadoBase();
            empleadoBase.CodigoEmpleado = "Emp001";
            empleadoBase.Nombre = "Juan Base";
            empleadoBase.SueldoDiario = 500.00M;
            empleadoBase.DiasTrabajados = 10;
            //empleadoBase.MostrarPago();
            ImprimirCalculos(empleadoBase);
            
            Console.WriteLine("");

            EmpleadoComision empleadoComision = new EmpleadoComision();
            empleadoComision.CodigoEmpleado = "Emp002";
            empleadoComision.Nombre = "Pedro Comision";
            empleadoComision.TotalVentas = 34000;
            //empleadoComision.MostrarPago();
            ImprimirCalculos(empleadoComision);

            
        }

        private static void ImprimirCalculos(Empleado empleado) 
        {
            decimal Sueldo = empleado.CalcularPago();
            Console.WriteLine($"El sueldo del empleado {empleado.Nombre} es de {Sueldo}");
        }
    }
}
