using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public static class LeitorDeArquivoFactory
    {
        public static ILeitorDeArquivos<Cliente>? CreateLeitorDeClientes(string caminhoArquivo)
        {
            return Path.GetExtension(caminhoArquivo) switch
            {
                ".csv" => new ClientesDoCSV(caminhoArquivo),
                ".json" => new ClientesDoJson(caminhoArquivo),
                _ => null
            };
        }

        public static ILeitorDeArquivos<Pet>? CreateLeitorDePets(string caminhoArquivo)
        {
            return Path.GetExtension(caminhoArquivo) switch
            {
                ".csv" => new PetsDoCsv(caminhoArquivo),
                ".json" => new PetsDoJson(caminhoArquivo),
                _ => null
            };
        }
    }
}
