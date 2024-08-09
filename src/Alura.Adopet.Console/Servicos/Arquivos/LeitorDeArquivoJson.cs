using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class LeitorDeArquivoJson : ILeitorDeArquivos
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
