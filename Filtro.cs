using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDecorator
{
    public abstract class Filtro
    {
        public Filtro? OutroFiltro { get; set; }
        protected Filtro()
        {
            OutroFiltro = null;
        }
        protected Filtro(Filtro filtro)
        {
            OutroFiltro = filtro;
        }
        public abstract IList<Conta> Filtra(IList<Conta> contas);

        public IList<Conta> FiltraOutro(IList<Conta> contas)
        {
            if (OutroFiltro == null)
                return new List<Conta>();
            return OutroFiltro.Filtra(contas);
        }

        public static string ListaFiltradaToString(IList<Conta> lista)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("########################");
            foreach(Conta conta in lista)
            {
                builder.AppendLine($"Titular:{conta.Titular}, Saldo: {conta.Saldo}," +
                    $" Data de abertura: {conta.DataDeAbertura}");
            }
            builder.AppendLine("########################");
            return builder.ToString();
        }
    }
}
