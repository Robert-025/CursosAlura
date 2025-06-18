using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuMostrarBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas) 
        {
            // base. -> usado para chamar a funcção que esta na classe pai (Menu, nesse caso)
            base.Executar(bandasRegistradas);

            ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
