using System;
using System.Collections;
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
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IEnumerable < Conta > lista = contas.Where(x => x.Saldo > 500000);
            return lista.Concat(FiltraOutro(contas)).ToHashSet().ToList();
        }
    }
}
