using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LaçoDeRepetiçaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando a variavel For");

            for (int multiplicador = 1; multiplicador <=10; multiplicador++)
            {
                for (int contador = 0; contador <=10; contador=contador+10)
                {
                    Console.WriteLine(multiplicador + " * " + contador + " = " +  multiplicador);
                    Console.WriteLine();

                }
                Console.WriteLine();

            }
            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
