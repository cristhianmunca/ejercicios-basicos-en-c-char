using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orie
{
    class Program
    {
        static void Main(string[] args)
        {
            articulo leche = new articulo("lacteos 001", "galon de leche", 2, 2.50);

            //aplicar descuento
            leche.setDescuento(0.15);

            //obtener precio ajustado
            double precio_leche = leche.getTotalajustado();

            Console.WriteLine(leche.getDescripcion() + "\n " + precio_leche);

            articulo jugo = new articulo("jugo de mora 002", "caja de jugo de mora", 3, 3.20);
            leche.setDescuento(0.20);
            double precio_jugo = jugo.getTotalajustado();
            Console.WriteLine(jugo.getDescripcion() + "\n" + precio_jugo);
            Console.ReadKey();
        }
    }
}
