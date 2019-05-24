using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando a  Variavel While");
            Console.WriteLine();

            int contador = 1;
            while (contador <=10)
            {
                Console.WriteLine(contador);
                contador ++; //     Que é a mesma coisa do que: contador +=1;
            }
            
            Console.ReadLine();
        }
    }
}
