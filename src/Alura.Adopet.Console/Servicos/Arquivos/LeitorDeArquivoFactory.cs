using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class LeitorDeArquivoFactory
    {
        public static ILeitorDeArquivos<Pet>? CreatePetFrom(string caminhoDoArquivo)
        {
            var extensao = Path.GetExtension(caminhoDoArquivo);
            switch (extensao)
            {
                case ".json":
                    return new LeitorDeArquivoJson(caminhoDoArquivo);
                case ".csv":
                    return new LeitorDeArquivoCSV(caminhoDoArquivo);
                default:
                    return null;
            }
        }
    }
}
