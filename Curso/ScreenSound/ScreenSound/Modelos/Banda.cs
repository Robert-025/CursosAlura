namespace ScreenSound.Modelos;

internal class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    // Pega a lista de notas criada e usa o Average() -> Método que faz a média automaticamente
    public double Media 
    { 
        get
        {
            // Se a lista de avaliação não tiver nada (for 0)
            if (notas.Count == 0)
            {
                // Retorna o valor 0
                return 0;
            }
            else
            {
                // Retorna cada nota e faz a média
                return notas.Average(a => a.Nota);
            }
        }
    }
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}