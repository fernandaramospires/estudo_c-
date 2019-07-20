﻿namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;

        public static int TotalDeContasCriadas { get; private set; }
        
       
        private int _agencia;



        public int Agencia
        {
            get { return _agencia; }
            set
            {
                if(value <= 0)
                { return;
                }

                _agencia = value;
            }
        }
        public int Numero;
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;      //para imediatamente de executar o método
                }

                _saldo = value;

            }
        }       
        
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero  = numero;

            TotalDeContasCriadas++;
            
        }

        public bool Sacar(double valor)
        {

            if (_saldo < valor)
            {
                return false;
            }
            else
            {

                _saldo -= valor;
                return true;
            }

        }

        public void Depositar(double valor)
        {
            _saldo += valor;

        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
        
    }
}






