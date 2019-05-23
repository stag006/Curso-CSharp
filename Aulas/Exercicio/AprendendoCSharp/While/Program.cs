using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 9;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador = contador + 10;
            }

            Console.ReadLine();
        }
    }
}
