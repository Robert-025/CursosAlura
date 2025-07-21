using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound2.Modelos;

namespace ScreenSound2.Filtros
{
    internal class LinqOrder
    {
       public static void OrdenarArtistaPorNome(List<Musica> musicas)
       {
            //var artistas = musicas.Select(artistas => artistas.Artista).Distinct().Order().ToList();

            //foreach (var artist in artistas)
            //{
            //    Console.WriteLine($"{artist}");
            //}


            var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine($"Lista de artistas ordenados");

            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine(artista);
            }
        }
    }
}
