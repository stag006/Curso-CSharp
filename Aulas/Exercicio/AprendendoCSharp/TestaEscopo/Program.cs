using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais - Escopo");

            int idade = 15;
            int quantidadePessoas = 1;
            bool acompanhado;
            //bool acompanhado = true;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else
	        {
                acompanhado = false;
            }

            if (idade >=18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }

            Console.ReadLine();
        }  
    }
}
