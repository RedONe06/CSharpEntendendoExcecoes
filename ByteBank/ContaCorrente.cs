using System;

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
            private set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            private set
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
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento de agencia deve ser > 0 ", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento de numero deve ser > 0 ", nameof(numero));
            }
            
            TotalDeContasCriadas++;
            //TaxaOperacao = 30/TotalDeContasCriadas;
        }


        public void Sacar (double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException($"Saldo insuficiente para saque no valor de {valor}");
            }
            _saldo -= valor;
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
