using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloDeAlugueisDeTemas
{
    public class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contexto.AlugueisDeTemas;
        }
    }
}
