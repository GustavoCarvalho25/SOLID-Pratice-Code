using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public abstract class LeitorDeArquivoJson<T> : ILeitorDeArquivos<T>
    {
        private string caminhoDoArquivo;

        public LeitorDeArquivoJson(string caminhoDoArquivo)
        {
            this.caminhoDoArquivo = caminhoDoArquivo;
        }

        public virtual IEnumerable<T> RealizaLeitura()
        {
            using var stream = new FileStream(caminhoDoArquivo, FileMode.Open, FileAccess.Read);
            return JsonSerializer.Deserialize<IEnumerable<T>>(stream) ?? Enumerable.Empty<T>();
        }

        public abstract T CriarDoJson(string linha);
    }
}
