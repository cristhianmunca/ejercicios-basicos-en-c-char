using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dormir = 1.08;
            double sentado = 1.66;
            int cantminu;
            double calorias;

            Console.WriteLine("digite los minutos");
            string cantminut = Console.ReadLine();
            int cantmin = int.Parse(cantminut);

            Console.WriteLine("digite la cantidad de minutos");
            string cantminutos = Console.ReadLine();

            calorias = (cantmin * dormir);
            Console.WriteLine("la cantidad de calorias estando durmiendo es" + calorias);
            Console.ReadLine;
        }
    }
}
