using System;

namespace EtlEjemplo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ImpVe imp = new ImpVe();

            imp.ImpVeMetodo();

            Console.WriteLine();
            Console.WriteLine("Proceso terminado. Presiona una tecla para salir.");
            Console.ReadKey();
        }
    }
}