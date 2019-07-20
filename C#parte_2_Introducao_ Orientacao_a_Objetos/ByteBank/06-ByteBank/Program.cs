using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome      = "Fernanda";
            cliente.CPF       = "126811425639";
            cliente.Profissao = "Analista de sistema";


            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);





            Console.ReadLine();
        }
    }
}
