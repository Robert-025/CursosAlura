using SegundoProjeto.Classes;

Banda banda1 = new Banda("Frank Ocean");

Album albumFrank = new Album("Blond");

// Uma forma de passar os parâmentros da classe Musica. O que vem no parênteses é porque é exigido no método contrutor da classe
Musica musica1 = new Musica(banda1, "Nikes")
{
    Duracao = 136,
    Disponivel = true,
};

Musica musica2 = new Musica(banda1, "Ivy")
{
    Duracao = 249,
    Disponivel = false,
};

// Outra forma de passar os parâmentros da classe Musica. O que vem no parênteses é porque é exigido no método contrutor da classe
//Musica musica2 = new Musica(banda1, "Ivy");
//musica2.Duracao = 249;
//musica2.Disponivel = false;

Genero genero1 = new Genero();
genero1.Nome = "R&B";


Podcast podcast1 = new Podcast("Youtube", "PodPah");

Episodio episodio1 = new Episodio("To com o Ney", 1000, 1);

episodio1.AdicionarConvidados("Neymar");
episodio1.AdicionarConvidados("Bruna Marquezine");

podcast1.AdicionarEpisiodio(episodio1);

podcast1.ExibirDetalhes();

albumFrank.AdicionarMusica(musica1);
albumFrank.AdicionarMusica(musica2);

genero1.AdicionarAlbum(albumFrank);
genero1.ExibirAlbunsDoGenero();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

banda1.AdicionarAlbum(albumFrank);
banda1.ExibirDiscografia();