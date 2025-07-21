using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto.Classes
{
    public class Album
    {
        
        private List<Musica> musicas = new List<Musica>();

        public Album(string nomeAlbum)
        {
            Nome = nomeAlbum;
        }

        public string Nome { get; }
        // SUM -> método para realizar soma -- ele está somando a duração para cada m
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicas()
        {
            Console.WriteLine($"Musicas do album {Nome}\n");

            foreach (var musica in musicas)
            {
                Console.WriteLine($"Musica: {musica.Nome}");
            }

            Console.WriteLine($"Esse album possui {DuracaoTotal} segundos.");
        }
    }
}
