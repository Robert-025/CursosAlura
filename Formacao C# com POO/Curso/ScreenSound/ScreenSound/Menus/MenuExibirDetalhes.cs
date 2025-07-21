using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuExibirDetalhes : Menu
    {
        //override -> é usada para estender ou modificar um método  virtual/abstrato, propriedade, indexador ou evento da classe base na classe derivada
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            // base. -> usado para chamar a funcção que esta na classe pai (Menu, nesse caso)
            base.Executar(bandasRegistradas);

            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                // Cria um novo objeto do tipo banda baseado no nome passado
                Banda banda = bandasRegistradas[nomeDaBanda];
                // Exibe os detalhes da banda
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
                Console.WriteLine("\nDiscografia\n");
                foreach (Album album in banda.Albuns)
                {
                    Console.WriteLine($"{album.Nome} -> {album.Media}"); 
                }
                Console.WriteLine("Digite uma tecla para vol    tar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
