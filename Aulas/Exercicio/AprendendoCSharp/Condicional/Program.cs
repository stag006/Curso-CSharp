using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Testando condicionais");
            // Primeira coisa vamos colocar uma variavel para dar inicio as condicionais.
            int idade = 14;
            int quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                if (quantidadePessoas >=5)
                {
                    Console.WriteLine("Você não tem 18, mas pode entrar, pois está acompanhado");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar");
                }
            }
            Console.ReadLine();

        }
    }
}
