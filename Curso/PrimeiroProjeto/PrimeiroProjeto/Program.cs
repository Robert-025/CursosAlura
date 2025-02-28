// Scren sound - Projeto alura  

string msgBoasVindas = "Seja bem vindo(a)!";

//List<string> listaBandas = new List<string>();

//O primeiro tipo do dicionario são as chaves dele e o segundo, nesse caso, é uma lista
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 5});
bandasRegistradas.Add("Metallica", new List<int> {});

void ExibirMgsBoasVindas()
{ 
    Console.WriteLine("--------------------------------------");
    Console.WriteLine(msgBoasVindas);
    Console.WriteLine("--------------------------------------");
};
void ExibirOpcoes()
{
    ExibirMgsBoasVindas();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média de uma banda");
    Console.WriteLine("Digite 0 para sair\n");

    Console.Write("Digite sua opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    //if (opcaoNumerica == 1)
    //{
    //    Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica} - Registrar uma banda");
    //} else if (opcaoNumerica == 2)
    //{
    //    Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica} - Mostrar todas as bandas");
    //} else if (opcaoNumerica == 3)
    //{
    //    Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica} - Avaliar uma banda");
    //} else if (opcaoNumerica == 4)
    //{
    //    Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica} - Exibir média de uma banda");
    //} else if (opcaoNumerica == 0)
    //{
    //    Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica} - Sair");
    //} else {
    //    Console.WriteLine("Digite uma opção válida");
    //};

    switch (opcaoNumerica)
    {
        case 1: RegistrarBandas();
            //Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica}");
            break;

        case 2: ListarBandas();
            //Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica}");
            break;

        case 3: AvaliarBanda();
            //Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica}");
            break;

        case 4: RealizarMedia();
            //Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica}");
            break;

        case 0:
            Console.WriteLine($"\nVocê digitou a opção {opcaoNumerica}");
            break; 

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que voce deseja registrar: ");

    // Le e memoriza o nome digitado pelo usuário
    string nomeBanda = Console.ReadLine()!;
    // Adiciona a variavel nomeBanda na listaBandas
    //listaBandas.Add(nomeBanda);

    // Adiciona a variavel nomeBanda no dicionario bandasRegistradas
    bandasRegistradas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1500);
    Console.Clear();

    ExibirOpcoes();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Listando bandas cadastradas");

    // enquanto i for menor que a quantidade de itens na listaBandas, executa novamente o o loop
    //for (int i = 0; i < listaBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaBandas[i]}");
    //}

    foreach (var band in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoes();
}

void ExibirTituloOpcao(string titulo)
{
    int qtdLetras = titulo.Length;
    string ast = string.Empty.PadLeft(qtdLetras, '*');

    Console.WriteLine(ast);
    Console.WriteLine(titulo);
    Console.WriteLine($"{ast}\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar banda");

    Console.Write("Qual banda voce deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    // Verifica se dentro do dicionario existe um campo igual ao nomeBanda digitado anteriormente
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual nota a banda {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);

        // Adiciona a nota no dicionario na lista da banda digitada, acessando ela diretamente através dos []
        bandasRegistradas[nomeBanda].Add(nota);

        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}!");

        Thread.Sleep(1500);
        Console.Clear();
        ExibirOpcoes();
    }
    else
    {
        Console.WriteLine($"Essa banda não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoes();
    }

}

void RealizarMedia()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo média das bandas");

    Console.Write("Digite o nome da banda que você deseja ver a média: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        int qtdNota = bandasRegistradas[nomeBanda].Count();

        if (qtdNota == 0)
        {
            Console.WriteLine($"\nA banda {nomeBanda} não possui nota cadastrada!");
            Thread.Sleep(1500);
            Console.WriteLine("Digite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoes();
        }
        else
        {
            //int soma = bandasRegistradas[nomeBanda].Sum();
            //float media = soma / qtdNota;
            //Console.WriteLine($"\nA média das notas da banda {nomeBanda} é: {media}");
            List<int> notasBanda = bandasRegistradas[nomeBanda];
            // Average() -> Função que já realiza a média dos valores presente na lista indicada
            Console.WriteLine($"\nA média das notas da banda {nomeBanda} é: {notasBanda.Average()}");
            Thread.Sleep(1500);
            Console.WriteLine("\nDigite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoes();
        }
    }
    else
    {
        Console.WriteLine($"\nEssa banda não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoes();
    }

}

ExibirOpcoes(); 