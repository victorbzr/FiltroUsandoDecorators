using System;
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
        public override HashSet<Conta> Filtra(HashSet<Conta> contas)
        {
            return contas.Where(x => x.Saldo < 100).ToHashSet();
        }
    }
}
