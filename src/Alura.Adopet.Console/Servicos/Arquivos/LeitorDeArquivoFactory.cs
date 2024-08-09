using Alura.Adopet.Console.Servicos.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class LeitorDeArquivoFactory
    {
        public static ILeitorDeArquivos? CreatePetFrom(string caminhoDoArquivo)
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
