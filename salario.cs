using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("digite sus horas tarabajadas");
            string horas = Console.ReadLine();
            int inthoras = int.Parse(horas);
            int b = 40;

            if (inthoras <= b)
            {
               int salsemanal = (inthoras * 16);
                Console.WriteLine( "su salario es de" + "$" +salsemanal);     
            }
            else
            {
                
                int horaextra = (inthoras - 40);
           
                int total = ((b * 16) + (horaextra* 20);
                Console.WriteLine("su sueldo es" + total);

        
            }
            Console.ReadKey();
        }
    }
}
