﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloDaOpcao("Avaliar album");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                // Cria um novo objeto do tipo banda baseado no nome passado na variável
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                // Se dentro dos albums da banda tiver algum ( Any() ) objeto que tenho o nome do album igual ao digitado 
                if (banda.Albuns.Any(a => a.Nome == tituloAlbum))
                {
                    // Define o objeto album atraves da procura pelo nome digitado usando o metodo First()
                    Album album = banda.Albuns.First(a => a.Nome == tituloAlbum);
                    Console.Write($"Qual a nota que o album {tituloAlbum} merece: ");
                    // Armazena a nota dada, transformando o que foi recebido já no tipo avaliação
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);                    
                    // Adiciona a nota a essa banda
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nO album {tituloAlbum} não foi encontrado!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();

                }
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
