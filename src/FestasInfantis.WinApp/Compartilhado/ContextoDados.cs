using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class ContextoDados
    {
        public List<Cliente> Clientes { get; set; }
        public List<Tema> Temas { get; set; }
        public List<ItensDoTema> ItensDoTema { get; set; }

        public List<AlugueisDoTema> AlugueisDoTemas { get; set; }

        private string caminho = $"C:\\temp\\FestasInfantis\\dados.json";

        public ContextoDados()
        {
            Clientes = new List<Cliente>();

            Temas = new List<Tema>();

            ItensDoTema = new List<ItensDoTema>();
           
            AlugueisDoTemas = new List<AlugueisDoTema>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null) return;

            Clientes = ctx.Clientes;

            Temas = ctx.Temas;

            ItensDoTema = ctx.ItensDoTema;

            AlugueisDoTemas = ctx.AlugueisDoTemas;
        }
    }
}
