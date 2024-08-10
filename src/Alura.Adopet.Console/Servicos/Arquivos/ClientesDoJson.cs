using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class ClientesDoJson : LeitorDeArquivoJson<Cliente>
    {
        public ClientesDoJson(string caminhoDoArquivo) : base(caminhoDoArquivo)
        {
        }

        public override Cliente CriarDoJson(string linha)
        {         
            return JsonSerializer.Deserialize<Cliente>(linha);
        }
    }
}
