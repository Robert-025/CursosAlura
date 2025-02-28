using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto.Classes
{
    public class Episodio
    {
        public Episodio(string titulo, int duracao, int numero) 
        {
            Titulo = titulo;
            Duracao = duracao;
            Numero = numero;
        }
        public string Titulo { get; }
        public int Duracao { get; }
        public int Numero { get; }
        public string Resumo => $"O episódio {Numero} se chama {Titulo}, tem {Duracao / 60} minutos e teve participação dos convidados {string.Join(", ", convidados)}";
        public List<string> convidados = new List<string>();

        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }

        public void ListarConvidados(List<string> convidados)
        {
            foreach (var item in convidados)
            {
                Console.Write(item);
            }
        }
    }
}
