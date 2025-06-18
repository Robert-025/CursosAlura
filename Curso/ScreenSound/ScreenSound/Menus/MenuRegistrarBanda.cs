using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            // base. -> usado para chamar a funcção que esta na classe pai (Menu, nesse caso)
            base.Executar(bandasRegistradas);
            
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            // Armazena qual o nome da banda que será cadastrado
            string nomeDaBanda = Console.ReadLine()!;
            // Cria um novo objeto do tipo banda com o nome passado na variável
            Banda banda = new Banda(nomeDaBanda);
            // Adiciona a banda no dicionario
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}
