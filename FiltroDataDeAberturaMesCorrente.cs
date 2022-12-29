using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDecorator
{
    public class FiltroDataDeAberturaMesCorrente : Filtro
    {
        public FiltroDataDeAberturaMesCorrente() { }
        public FiltroDataDeAberturaMesCorrente(Filtro OutroFiltro) : base(OutroFiltro) { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IEnumerable<Conta> lista = contas.Where(x => x.DataDeAbertura.Month.Equals(DateTime.Now.Month)
            && x.DataDeAbertura.Year.Equals(DateTime.Now.Year));
            return lista.Concat(FiltraOutro(contas)).ToHashSet().ToList();
        }
    }
}
