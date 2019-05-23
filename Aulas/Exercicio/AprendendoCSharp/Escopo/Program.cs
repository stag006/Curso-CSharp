using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Escopo");
            Console.ReadLine();

            int idadeArthur = 20;
            bool acompanhado = true;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "Arthur está acompanhado";

                Console.WriteLine(mensagemAdicional);
            }

            else
            {
                mensagemAdicional = "Arthur não está acompanhado";
            }

            if (idadeArthur >= 18 || acompanhado == true)
            {
                Console.WriteLine("Seja bem vindo Arthur, pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
            Console.Read();
        }
    }
}
