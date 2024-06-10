using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FestasInfantis.WinApp.ModuloDeAlugueisDeTemas
{
    public class Aluguel : EntidadeBase
    {

        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public string PorcentagemDeEntrada { get; set; }
        public string PorcentagemDeDesconto { get; set; }
        public DateTime DataDoPagamento { get; set; }
        public bool StatusAluguel { get; set; }
        public Festa Festa { get; set; }




        public Aluguel(Cliente cliente, Tema tema, string porcentagemDeEntrada, string porcentagemDeDesconto,DateTime dataDoPagamento, 
            bool statusAluguel,Festa festa)
        {
            Cliente = cliente;
            Tema = tema;
            PorcentagemDeEntrada= porcentagemDeEntrada;
            PorcentagemDeDesconto= porcentagemDeDesconto;
            DataDoPagamento= dataDoPagamento;
            StatusAluguel= statusAluguel;
            Festa = festa;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Cliente.Nome))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Cliente.Telefone))
                erros.Add("O campo \"telefone\" é obrigatório");

            if (string.IsNullOrEmpty(Cliente.Cpf))
                erros.Add("O campo \"CPF\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizado = (Aluguel)novoRegistro;

            Cliente = atualizado.Cliente;
            Tema = atualizado.Tema;
            PorcentagemDeEntrada = atualizado.PorcentagemDeEntrada;
            PorcentagemDeDesconto = atualizado.PorcentagemDeDesconto;
            DataDoPagamento = atualizado.DataDoPagamento;
            StatusAluguel = atualizado.StatusAluguel;
            Festa = atualizado.Festa;

        }

        public override string ToString()
        {
            return Cliente.Nome;
        }
    }
}
