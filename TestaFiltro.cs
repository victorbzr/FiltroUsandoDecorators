using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDecorator
{
    public class TestaFiltro
    {
        public static void Main()
        {
            Conta conta = new Conta(99, "Victor", new DateOnly(2022,11,23));
            Conta conta1 = new Conta(98.0, "Andre", new DateOnly(2022,12,23));
            Conta conta2 = new Conta(501000, "Jose", new DateOnly(2022, 12, 23));
            Conta conta3 = new Conta(97, "Janaina", new DateOnly(2022, 09, 20));
            Conta conta4 = new Conta(150, "bruna", new DateOnly(2022, 09, 20));
            HashSet<Conta> contas = new HashSet<Conta>();
            contas.Add(conta);
            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);
            contas.Add(conta4);

            Filtro f1 = new FiltroSaldoMenorQueCemReais();
            Filtro f2 = new FiltroSaldoMaiorQue500MilReais();
            Filtro f3 = new FiltroDataDeAberturaMesCorrente();
            Filtro f4 = new FiltroDataDeAberturaMesCorrente(
                new FiltroSaldoMenorQueCemReais());
            Filtro f5 = new FiltroDataDeAberturaMesCorrente(
                new FiltroSaldoMenorQueCemReais(new FiltroSaldoMaiorQue500MilReais()));

            Console.WriteLine(Filtro.ListaFiltradaToString(f1.Filtra(contas)));
            Console.WriteLine(Filtro.ListaFiltradaToString(f2.Filtra(contas)));
            Console.WriteLine(Filtro.ListaFiltradaToString(f3.Filtra(contas)));
            Console.WriteLine(Filtro.ListaFiltradaToString(f4.Filtra(contas)));
            Console.WriteLine(Filtro.ListaFiltradaToString(f5.Filtra(contas)));
            
        }
    }
}
