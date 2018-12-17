using System;

namespace _10_calculapoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - calcula poupança");
            
            double valorInvestido = 1000;
            int contadorMes = 1;

            //0.36% = 0.0036

            while (contadorMes  <=  12)
            {

                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após {0} meses você terá R$" + valorInvestido, contadorMes);
                contadorMes++;

            }
            Console.ReadLine();


        }
    }
}
