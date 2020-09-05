using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Demo
{
    public class EmpleadoComision : Empleado
    {
        public decimal TotalVentas { get; set; }

        public override decimal CalcularPago()
        {
            return TotalVentas * .5M;
        }

        public override void MostrarPago()
        {
            base.MostrarPago();
            Console.WriteLine($"El sueldo es de {CalcularPago()}");
        }
    }
}
