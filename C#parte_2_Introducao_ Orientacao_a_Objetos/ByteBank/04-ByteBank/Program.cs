using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.Titular = "Bruno";
            Console.WriteLine("Antes do saque, o saldo é de R$ " + contaDoBruno.Saldo);

            bool resultado = contaDoBruno.Sacar(50);
            Console.WriteLine(resultado);

            Console.WriteLine("Depois do saque, o saldo é de R$" + contaDoBruno.Saldo);


            Console.ReadLine();
        }
    }
}
