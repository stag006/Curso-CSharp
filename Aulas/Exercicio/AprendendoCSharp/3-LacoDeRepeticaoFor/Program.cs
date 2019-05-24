using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Estaremos utilizando mais uma variavel "Break"
             * Nesse caso o Break é utilizado para finalizar uma tarela ou seja um LAÇO
             * 
             */
            Console.WriteLine();
            for (int linha = 0; linha <= 10; linha++) // Mais uma vez estamos utilizando a abreveatura da SOMA
            {
                for (int coluna = 0; coluna <= 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            // Melhorando o código estaremos removendo o 'if' e modificando o 'for' interno. Veja a seguir!

            Console.WriteLine();
            for (int linha = 0; linha <= 10; linha++)
            {
                for (int coluna = 0; coluna <=linha; coluna++)
                {
                    Console.WriteLine("*");
                }
            }
            Console.ReadLine();            
        }
    }
}
