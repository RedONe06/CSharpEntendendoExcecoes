﻿// using _05_ByteBank;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }
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
                    return;
                }

                _saldo = value;
            }
        }

        private int _agencia;
        private double _saldo = 100;
        
        public ContaCorrente (int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            
            TotalDeContasCriadas++;
            TaxaOperacao = 30/TotalDeContasCriadas;
        }


        public bool Sacar (double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar (double valor)
        {
            _saldo += valor;
        }


        public bool Transferir (double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}