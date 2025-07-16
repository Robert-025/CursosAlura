using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound2.Modelos
{
    internal class MusicasPreferidas
    {
        public MusicasPreferidas(string nome) 
        {
            Nome = nome;
            ListaDeMusicasPreferidas = new List<Musica>();
        }

        public string Nome { get; set; }
        public List<Musica> ListaDeMusicasPreferidas { get; set; }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasPreferidas.Add(musica);

            //Console.WriteLine(ListaDeMusicasPreferidas);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essa são as músicas favoritas: {Nome}\n");
            foreach (var musica in ListaDeMusicasPreferidas)
            {
                Console.WriteLine($"- {musica.Nome},de {musica.Artista}");
            }
        }

        public void GerarArquivoJson()
        {
            // dentro do new{} é como vai ficar a estrutura de cada objeto dentro do json
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                ListaDeMusicasPreferidas
            });

            string nomeArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeArquivo, json);

            Console.WriteLine($"O arquivo json foi criado com sucesso no caminho abaixo: \n{Path.GetFullPath(nomeArquivo)}");
        }
    }
}
