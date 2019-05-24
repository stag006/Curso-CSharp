using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOpcional_MultiplosDe3
{
    class Program
    {
        // Trabalhando com numeros maior de repetições...
        static void Main(string[] args)
        {
            Console.WriteLine();
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
