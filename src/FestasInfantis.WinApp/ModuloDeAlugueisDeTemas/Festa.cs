using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FestasInfantis.WinApp.ModuloDeAlugueisDeTemas
{
    public class Festa: EntidadeBase
    {
        public DateTime DataDaFesta { get; set; }
        public DateTime HorarioDeInicio { get; set; }
        public DateTime HorarioDeTermino { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }



        public Festa(DateTime dataDaFesta, DateTime horarioDeInicio, DateTime horarioDeTermino, string cidade, string rua,
            string bairro, string estado, string numero)
        {
            DataDaFesta = dataDaFesta;
            HorarioDeInicio = horarioDeInicio;
            HorarioDeTermino = horarioDeTermino;
            Cidade = cidade;
            Rua = rua;  
            Bairro = bairro;    
            Estado = estado;    
            Numero = numero;    
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Cidade.Trim()))
                erros.Add("O campo \"cidade\" é obrigatório");

            if (string.IsNullOrEmpty(Rua.Trim()))
                erros.Add("O campo \"rua\" é obrigatório");

            if (string.IsNullOrEmpty(Bairro.Trim()))
                erros.Add("O campo \"bairro\" é obrigatório");

            if (string.IsNullOrEmpty(Estado.Trim()))
                erros.Add("O campo \"estado\" é obrigatório");
            if (string.IsNullOrEmpty(Numero.Trim()))
                erros.Add("O campo \"número\" é obrigatório");






            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Festa atualizado = (Festa)novoRegistro;

            DataDaFesta = atualizado.DataDaFesta;
            HorarioDeInicio = atualizado.HorarioDeInicio;
            HorarioDeTermino = atualizado.HorarioDeTermino;
            Cidade = atualizado.Cidade;
            Rua = atualizado.Rua;
            Bairro = atualizado.Bairro;
            Estado = atualizado.Estado;
            Numero = atualizado.Numero;

        }

        public override string ToString()
        {
            return null;
        }
    }
}
