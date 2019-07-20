using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente( 867, 867123);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
                       

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            

            ContaCorrente contaDaFernanda = new ContaCorrente(867, 86745820);
            
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
        }
    }
}
