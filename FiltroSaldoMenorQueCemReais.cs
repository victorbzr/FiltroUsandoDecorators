using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDecorator
{
    public class FiltroSaldoMenorQueCemReais : Filtro
    {
        public FiltroSaldoMenorQueCemReais() { }
        public FiltroSaldoMenorQueCemReais(Filtro OutroFiltro) : base(OutroFiltro) { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IEnumerable<Conta> lista = contas.Where(x => x.Saldo < 100);
            return lista.Concat(FiltraOutro(contas)).ToHashSet().ToList();
        }
    }
}
