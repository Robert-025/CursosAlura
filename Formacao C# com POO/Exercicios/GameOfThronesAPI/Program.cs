using System.Text.Json;
using GameOfThronesAPI.Modelos;

using (HttpClient client = new HttpClient())
{
	try
	{
		string response = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");

        var personagens = JsonSerializer.Deserialize<Personagens>(response);

		personagens.MostrarDados();
    }
	catch (Exception ex)
	{
        Console.WriteLine($"Erro: {ex}");
		throw;
	}
}