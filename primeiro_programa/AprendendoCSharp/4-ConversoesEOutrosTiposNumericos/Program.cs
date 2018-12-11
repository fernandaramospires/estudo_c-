using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario; //casting              

            int idade = 26;                     //int é um tipo de variavel de 32 bits.
            Console.WriteLine(idade);

            long idade_2 = 130000000000000000; // long é um tipo de variavel de 64 bits
            Console.WriteLine(idade_2);
            
            short quantidadeProdutos = 150;   //short é um tipo de variavel de 16 
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;  //colocar o f para indicar que é um float, sem o f. Reconhece como double. 
            Console.WriteLine(altura);











            Console.WriteLine(salarioEmInteiro);









            Console.ReadLine();

        }
    }
}
