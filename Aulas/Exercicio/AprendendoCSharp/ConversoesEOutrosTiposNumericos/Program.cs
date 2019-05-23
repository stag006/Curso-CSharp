using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversões e outros tipos numéricos");
            
            double salario = 1270.50;
            int valor = (int)salario; // Isso que você fês é um Casting.

            double valor1 = 0.3;
            double valor2 = 0.5454;
            double total = valor1 + valor2;

            Console.WriteLine(valor);
            Console.WriteLine(salario + 5.45646654);

            Console.WriteLine(valor1 + valor2);
        
        }
    }
}
