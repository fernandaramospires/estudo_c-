using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gabriela = new Cliente();

            gabriela.nome      = "Gabriela";
            gabriela.profissao = "Desenvolvedora c#";
            gabriela.cpf       = "245.256.235-89";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.Saldo   = 500;
            conta.Agencia = 563;
            conta.Numero = 5634527;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();






            Console.WriteLine("Hello World!");
        }
    }
}
