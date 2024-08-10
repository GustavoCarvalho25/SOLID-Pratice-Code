using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class LeitorDeArquivoJson : ILeitorDeArquivos<Pet>
    {
        private string caminhoDoArquivo;

        public LeitorDeArquivoJson(string caminhoDoArquivo)
        {
            this.caminhoDoArquivo = caminhoDoArquivo;
        }

        public IEnumerable<Pet> RealizaLeitura()
        {
            using var stream = new FileStream(caminhoDoArquivo, FileMode.Open, FileAccess.Read);
            return JsonSerializer.Deserialize<IEnumerable<Pet>>(stream) ?? Enumerable.Empty<Pet>();
        }
    }
}
