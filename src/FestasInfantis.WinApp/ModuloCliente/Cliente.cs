using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
       

        public Cliente(string nome,  string cpf,string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;         
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"CPF\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente atualizado = (Cliente)novoRegistro;

            Nome = atualizado.Nome;
            Cpf = atualizado.Cpf;
            Telefone = atualizado.Telefone;         
           
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}
