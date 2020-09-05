using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Demo
{
    public class EmpleadoBase : Empleado
    {
        public int DiasTrabajados { get; set; }
        public decimal SueldoDiario { get; set; }
        
        public override decimal CalcularPago()
        {
            return DiasTrabajados * SueldoDiario;
        }

        public override void MostrarPago() 
        {
            base.MostrarPago();
            Console.WriteLine($"El sueldo es de {CalcularPago()}");
        }
    }
}
