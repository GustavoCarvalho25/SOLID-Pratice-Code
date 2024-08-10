using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Testes.Servicos
{
    public class LeitorDeArquivoFactoryTest
    {
        [Fact]
        public void QuantoExtensaoForCsvDeveRetornarTipoLeitorDeArquivoCsv()
        {
            // arrange
            string caminhoArquivo = "pets.csv";

            // act
            var leitor = LeitorDeArquivoFactory.CreateLeitorDePets(caminhoArquivo);

            // assert
            Assert.IsType<PetsDoCsv>(leitor);
        }

        [Fact]
        public void QuantoExtensaoForJsonDeveRetornarTipoLeitorDeArquivoJson()
        {
            // arrange
            string caminhoArquivo = "pets.json";

            // act
            var leitor = LeitorDeArquivoFactory.CreateLeitorDePets(caminhoArquivo);

            // assert
            Assert.IsType<PetsDoJson>(leitor);
        }

        [Fact]
        public void QuantoExtensaoNaoSuportadaDeveRetornarNulo()
        {
            // arrange
            string caminhoArquivo = "pets.xsl";

            // act
            var leitor = LeitorDeArquivoFactory.CreateLeitorDePets(caminhoArquivo);

            // assert
            Assert.Null(leitor);
        }
    }
}
