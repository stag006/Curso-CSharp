using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testa Caracteres");

            // Esta variavel só vai uma letra e lembra que se usa sempre as '_';

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            Console.WriteLine("Digite o seu nome:");
            Console.Read();

            Console.WriteLine("Digite a sua idade:");
            Console.Read();

            Console.ReadLine();
        }
    }
}
