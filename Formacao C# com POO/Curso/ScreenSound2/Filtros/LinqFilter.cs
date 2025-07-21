using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound2.Modelos;

namespace ScreenSound2.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarGeneros(List<Musica> musicas)
        {
            // Seleciona todos os generos que forem iguais (=>) ao atributo Genero de musicas. 
            //.Distinct() -> Seleciona os generos achados e faz com que só liste os generos diferentes
            var generosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach (var genero in generosMusicais)
            {
                Console.WriteLine($"{genero}");
            }
        }

        public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
        {
            //procura na lista de musicas o genero igual ao recebido como parametro e seleciona/filtra nos achados o artista por nome. Ele também não deixa repetir o artista. 
            var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine($"Exibindo os artistas do genero {genero}");

            foreach (var artist in artistasPorGenero)
            {
                Console.WriteLine($"{artist}");
            }
        }

        public static void FiltrarMusicaDoArtista(List<Musica> musicas, string nomeArtista)
        {
            // Armazena na musicasArtistas todas as musicas onde o artista for igual ao nomeArtista recebido 
            var musicasArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();

            Console.WriteLine($"Músicas do artista {nomeArtista}");

            foreach(var musica in musicasArtista)
            {
                Console.WriteLine($"\n{musica.Nome}");
            }
        }

        public static void FiltrarTonalidade(List<Musica> musicas, string tonalidade)
        {
            var tonalidadeMusica = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).ToList();

            Console.WriteLine($"Músicas com o tom {tonalidade}\n");

            foreach (var musica in tonalidadeMusica)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
    }
}
