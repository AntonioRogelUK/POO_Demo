using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Demo
{
    public class MiClase
    {
        private string miVariable;
        public DateTime fecha;

        public MiClase()
        {
            miVariable = "Asignando valor por defecto";
            fecha = DateTime.Now;
        }

        public void MostrarMensaje(string mensaje) 
        {
            Console.Write("Mensaje desde MiClase");
            Console.Write(mensaje);

            Console.Write("miVariable");
            Console.Write(miVariable);
        }
    }
}
