using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto.Classes
{
    public class Musica
    {
        // Função construtora. - A propriedade recebe o valor passado do argumento (artista) pedida no contrutor
        public Musica(Banda artista, string nomeMusica) 
        { 
            Artista = artista;
            Nome = nomeMusica;
        }

        //Propriedade tem que comecar com letra maiuscula
        //get; set; -> 
        public string Nome {  get; set; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        //Propriedade usando Lambda ( => maneira simples de definir métodos/funcções anonimos)
        //No caso abaixo, a propriedade passa a ser somente leitura, não podendo ser reescrita e o valor dela é definido após a Lambda

        //LAMBDA = (parametro) => expressao
        public string DescricaoResumida => $"A Musica {Nome} pertence ao artista {Artista.Nome}";
        // A expressão abaixo é resumida com o Lambda acima. Se trata somente da leitura
        //{
        //    get
        //    {
        //        return $"A Musica {Nome} pertence ao artista {Artista}";
        //    }
        //}



        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duracao: {Duracao}");
            if (Disponivel == true)
            {
                Console.WriteLine("Disponivel no seu plano.");
            }else            {
                Console.WriteLine("Adquira o plano Plus");
            }
            Console.WriteLine(DescricaoResumida);
        }
    }
}
