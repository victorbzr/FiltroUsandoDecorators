using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDecorator
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Titular { get; private set; }
        //public DateTime DataDeAbertura { get; private set; }
        public DateOnly DataDeAbertura { get; private set; }
        public Conta(double saldo, string titular, DateOnly dataDeAbertura)
        {
            this.Saldo = saldo;
            this.Titular = titular;
            //this.DataDeAbertura= DateTime.Now;
            this.DataDeAbertura = dataDeAbertura;
        }

        public override string ToString()
        {
            return $"Titular: {Titular}, Saldo: {Saldo}, data de abertura: {DataDeAbertura}";
        }
    }
}
