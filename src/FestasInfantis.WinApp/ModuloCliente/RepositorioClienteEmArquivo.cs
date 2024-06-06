using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioBaseEmArquivo<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Cliente> ObterRegistros()
        {
            return contexto.Clientes;
        }

        //public override bool Excluir(int id)
        //{
        //  Cliente cliente = SelecionarPorId(id);

        //    List<>
            
        //    return base.Excluir(id);
        //}

    }
}

