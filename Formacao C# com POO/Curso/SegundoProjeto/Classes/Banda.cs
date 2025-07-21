using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto.Classes
{
    public class Banda
    {
        public Banda(string nomeBanda)
        {
            Nome = nomeBanda;   
        }
        private List<Album> albums = new List<Album>();  
        public string Nome { get; }
        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"\nDiscografia da banda {Nome}");
            foreach (Album album in albums)
            {
                Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}
