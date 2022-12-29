using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDecorator
{
    public class FiltroSaldoMaiorQue500MilReais : Filtro
    {
        public FiltroSaldoMaiorQue500MilReais() { }
        public FiltroSaldoMaiorQue500MilReais(Filtro OutroFiltro) : base(OutroFiltro) { }
        public override HashSet<Conta> Filtra(HashSet<Conta> contas)
        {
            return contas.Where(x => x.Saldo > 500000).ToHashSet();
        }
    }
}
