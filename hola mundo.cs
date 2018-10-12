using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_hola_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=1;
            int num2 =5;
            int suma;

            Console.WriteLine("ingrese su nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("hola " + nombre);
            Console.ReadKey();

            suma = num1 + num2;
            Console.WriteLine("el resultado de la suma es" + suma);
            Console.ReadKey();
        }
    }
}
