using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Demo
{
    public abstract class Empleado : IEmpleado
    {
        public string CodigoEmpleado { get; set; }
        public string Nombre { get; set; }

        public abstract decimal CalcularPago();

        public void Mensaje()
        {
            Console.WriteLine("");
        }

        public void Mensaje2()
        {
            Console.WriteLine("");
        }

        public virtual void MostrarPago() 
        {
            Console.WriteLine($"Nombre empleado: {Nombre} {CodigoEmpleado}");
        }
    }
}
