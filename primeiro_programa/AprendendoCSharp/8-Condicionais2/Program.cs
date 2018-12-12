using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8");

            int idadeJoao = 16;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar!");
            }
            else
            {
                 Console.WriteLine("João não possui mais de 18 anos. Não pode entrar");                
            }
            
            Console.ReadLine();

        }
    }
}
