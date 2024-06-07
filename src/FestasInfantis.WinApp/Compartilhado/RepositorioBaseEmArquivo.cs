using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.Compartilhado
{
    public abstract class RepositorioBaseEmArquivo<T> where T : EntidadeBase
    {
        protected abstract List<T> ObterRegistros();

        protected int contadorId = 1;

        protected ContextoDados contexto = new ContextoDados();

        public RepositorioBaseEmArquivo(ContextoDados contexto)
        {
           this.contexto = contexto;
        }

        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            ObterRegistros().Add(novoRegistro);

            contexto.Gravar();
        }

        public bool Editar(int id, T novaEntidade)
        {
            T registro = SelecionarPorId(id);

            if (registro == null)
                return false;

            registro.AtualizarRegistro(novaEntidade);

            contexto.Gravar();

            return true;
        }

        public virtual bool Excluir(int id)
        {
            bool conseguiuRemover = ObterRegistros().Remove(SelecionarPorId(id));

            if (!conseguiuRemover)
                return false;

            contexto.Gravar();

            return true;
        }

        public List<T> SelecionarTodos()
        {
            return null ;
        }

        public T SelecionarPorId(int id)
        {
            return ObterRegistros().Find(x => x.Id == id);
        }

        public bool Existe(int id)
        {
            return ObterRegistros().Any(x => x.Id == id);
        }

        public void CadastrarVarios(List<T> registrosAdicionados)
        {
            foreach (T registro in registrosAdicionados)
            {
                registro.Id = contadorId++;
                ObterRegistros().Add(registro);
            }

            contexto.Gravar();
        }

        //protected void SerializarRegistros()
        //{
        //    FileInfo file = new FileInfo(caminho);

        //    file.Directory.Create();

        //    JsonSerializerOptions options = new JsonSerializerOptions()
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve,
        //        WriteIndented = true
        //    };

        //    byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(registros, options);

        //    File.WriteAllBytes(caminho, registrosEmBytes);
        //}

        //protected List<T> DeserializarRegistros()
        //{
        //    FileInfo file = new FileInfo(caminho);

        //    if (!file.Exists)
        //        return new List<T>();

        //    byte[] registrosEmBytes = File.ReadAllBytes(caminho);

        //    JsonSerializerOptions options = new JsonSerializerOptions()
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve
        //    };

        //    List<T> registros = JsonSerializer.Deserialize<List<T>>(registrosEmBytes, options);

        //    return registros;
        //}
    }
}
