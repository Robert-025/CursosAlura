// Gerencia um recurso que está dentro das chaves, liberando o recurso quando a chave fecha
using System.Text.Json;
using ScreenSound2.Filtros;
using ScreenSound2.Modelos;

using (HttpClient client = new HttpClient()) 
{
	try
	{
        //Usamos o async porque "não sabemos" qual o tamanho do recurso que essa variavel vai receber.
        //Usamos isso pra garantir que vamos receber todos os recursos
        //O await é usado para fazer a funcao aguardar a tarefa ser concluida para pular para outra parte
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        //Console.WriteLine(response);

        //Transforma o JSON em um objeto que pode ser manipulado na linguagem. Chamamos de desserialização.
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

        //LinqFilter.FiltrarGeneros(musicas);
        //LinqOrder.OrdenarArtistaPorNome(musicas);
        //LinqFilter.FiltrarArtistaPorGenero(musicas, "hip hop");
        //LinqFilter.FiltrarMusicaDoArtista(musicas, "Eminem");


        //var musicasPreferidasRobert = new MusicasPreferidas("Robert");
        //musicasPreferidasRobert.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasRobert.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasRobert.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasRobert.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasRobert.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasRobert.ExibirMusicasFavoritas();

        //var musicasPreferidasCarlos = new MusicasPreferidas("Carlos");
        //musicasPreferidasCarlos.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasCarlos.AdicionarMusicasFavoritas(musicas[77]);
        //musicasPreferidasCarlos.AdicionarMusicasFavoritas(musicas[88]);
        //musicasPreferidasCarlos.AdicionarMusicasFavoritas(musicas[23]);
        //musicasPreferidasCarlos.AdicionarMusicasFavoritas(musicas[123]);

        //musicasPreferidasCarlos.ExibirMusicasFavoritas();

        //musicasPreferidasCarlos.GerarArquivoJson();

        LinqFilter.FiltrarTonalidade(musicas, "Bb");
    }
    catch (Exception ex)
	{
        Console.WriteLine($"Erro: {ex}");
		throw;
	}

}