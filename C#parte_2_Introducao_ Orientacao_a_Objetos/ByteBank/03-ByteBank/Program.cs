using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaFernanda = new ContaCorrente();
            contaDaFernanda.Titular = "Fernanda";
            contaDaFernanda.Agencia = 863;
            contaDaFernanda.Numero  = 863452;


            ContaCorrente contaDaFernandaPires = new ContaCorrente();
            contaDaFernanda.Titular = "Fernanda";
            contaDaFernanda.Agencia = 863;
            contaDaFernanda.Numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: "+ (contaDaFernanda == contaDaFernandaPires)); // retorna false , pois são referências diferentes

            int idade = 26;
            int idadeMaisUmaVez = 26;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));  // retorna true

            contaDaFernanda = contaDaFernandaPires; 

            Console.WriteLine(contaDaFernanda == contaDaFernandaPires); // retorna true, as duas variáveis apontam para o mesmo objeto.

            contaDaFernanda.Saldo = 300;

            Console.WriteLine(contaDaFernanda.Saldo);
            Console.WriteLine(contaDaFernandaPires.Saldo); // ambos retornam 300, pois ambas variáveis apontam para o mesmo objeto.

            
            Console.ReadLine();
        }
    }
}
