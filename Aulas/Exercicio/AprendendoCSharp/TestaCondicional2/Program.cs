using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Agora vou estar usando o comando (bool).
            // Portanto a variavel bool só pode guardar dois valores que são: true ou false
            // para fazer o 'OU' é representado por: || ou &&
            

            int idadeArthur = 15;
            int quantidadePessoas = 3;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false; 
            if (idadeArthur >= 18 && acompanhado == true) // O operador que usamos para comparara igualdade é o '==' 
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
            Console.Read();
        }
    }
}
