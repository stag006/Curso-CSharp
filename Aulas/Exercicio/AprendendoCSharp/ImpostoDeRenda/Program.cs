using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este programa tem o assunto sobre o imposto de Renda; 
            // Estaremos forçando o assunto que aprendemos na aula passada

            Console.WriteLine("Imposto de Renda");

            /*  • De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
                • De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
                • De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.*/

            double salario = 3800.0;
            bool teste = true;

            if (salario >= 1900 && <= 2800.0 ==true)
            {
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ 142");
            }

            else if (salario >= 2800.0 && <= 3751.0 == false)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }
            else if (salario >= 3751.0 && <= 4664.0 == true)
            { 
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Voê pode deduzir até R$ 363");

            }
        }
    }
}
