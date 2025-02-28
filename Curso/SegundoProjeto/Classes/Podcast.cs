using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto.Classes
{
    public class Podcast
    {
        public Podcast(string host, string nome) 
        {
            Host = host;
            Nome = nome;
        }
        public string Host { get; }
        public string Nome { get; }
        public List<Episodio> TotalEpisodios = new List<Episodio>();

        public void AdicionarEpisiodio(Episodio episodio)
        {
            TotalEpisodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"O podcast {Nome} é transmitido no {Host}\nEssa é a lista dos episódios:");
            foreach (Episodio episodio in TotalEpisodios)
            {
                Console.WriteLine($"EP: {episodio.Numero}\nTítulo: {episodio.Titulo}\nDuração: {episodio.Duracao}");
                foreach (var convidado in episodio.convidados)
                {
                    Console.WriteLine($"Convidado(a): {convidado}");
                }

                Console.WriteLine(episodio.Resumo);
            }
        }
    }
}
