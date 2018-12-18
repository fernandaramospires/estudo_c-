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

            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(resultadoSaque);

            Console.WriteLine("Depois do saque, o saldo é de R$" + contaDoBruno.Saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.Saldo);

            ContaCorrente contaDaFernanda = new ContaCorrente();
            contaDaFernanda.Titular = "Fernanda";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo do Fernanda: " + contaDaFernanda.Saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaFernanda);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo do Fernanda: " + contaDaFernanda.Saldo);

            Console.WriteLine("Resultado transferência:" + resultadoTransferencia);



            Console.ReadLine();
        }
    }
}
