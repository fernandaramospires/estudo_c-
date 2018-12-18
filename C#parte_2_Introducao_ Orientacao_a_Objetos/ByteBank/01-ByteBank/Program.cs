using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaFernanda = new ContaCorrente();

            contaDaFernanda.Titular = "Fernanda";
            contaDaFernanda.Agencia = 863;
            contaDaFernanda.Numero  = 863125;
            contaDaFernanda.Saldo   = 100;

            Console.WriteLine(contaDaFernanda.Titular);
            Console.WriteLine("Agencia: " + contaDaFernanda.Agencia);
            Console.WriteLine("Numero: " + contaDaFernanda.Numero);
            Console.WriteLine("Saldo: " + contaDaFernanda.Saldo);

            contaDaFernanda.Saldo +=  + 200;

            Console.WriteLine("Saldo: " + contaDaFernanda.Saldo);

            Console.ReadLine();

        }
    }
}
