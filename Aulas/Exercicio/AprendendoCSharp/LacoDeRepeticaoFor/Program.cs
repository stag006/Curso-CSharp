using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // A variavel (For) ela é um pouco mais direta do que o while deixando o seu código mais limpo.

            Console.WriteLine("Executando a variavel For");

            for (int contador = 1; contador <=10; contador++) // OBS: Estou somando contador++, podém eu poderia estar somando do jeito convencional. contador = contador +1
            {
                Console.WriteLine(contador);
            }
            Console.ReadLine();
        }
    }
}
