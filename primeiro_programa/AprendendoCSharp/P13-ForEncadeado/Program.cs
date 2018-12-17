using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******

            //Escrevendo asteriscos com o break
            for (int contadorLinha =0; contadorLinha <= 10; contadorLinha ++)
            {
                Console.WriteLine();     //simplesmente pula linha;

                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");

                    if (contadorColuna >= contadorLinha)
                        break;
                }
            }

            //Uma forma diferente de fazer o desenho de asteriscos

            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                Console.WriteLine();     //simplesmente pula linha;

                for (int contadorColuna = 0; contadorColuna <= contadorLinha ; contadorColuna++)
                {
                    Console.Write("*");                    
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
