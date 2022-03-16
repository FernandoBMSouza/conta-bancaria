using System;
using System.Globalization;

namespace Fernando
{
    class Conta
    {
        private double _saldo;

        public int Numero { get; private set; }
        public string Nome { get; set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public Conta(int numero, string nome, double saldo) : this(numero, nome)
        {
            _saldo = saldo;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        public void Depositar(double deposito)
        {
            _saldo += deposito;
        }

        public void Sacar(double saque)
        {
            _saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: $ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}