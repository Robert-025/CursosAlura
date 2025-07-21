using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto.Classes
{
    public class Genero
    {
        private List<Album> albums = new List<Album>();
        public string Nome { get; set; }
        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirAlbunsDoGenero()
        {
            Console.WriteLine($"\nO genero {Nome} possui esses albums");
            foreach(Album album in albums)
            {
                Console.WriteLine($"{album.Nome}");
            }
        }
    }
}
