Banda banda = new Banda("Legião Urbana");

Album album1 = new Album("As Quatro Estações");

Musica musica1 = new Musica(banda, "Há Tempos")
{
    Duracao = 225,
    Disponivel = true
};

Musica musica2 = new Musica(banda, "Pais e Filho")
{
    Duracao = 294,
    Disponivel = false
};

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
banda.AdicionarAlbum(album1);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

album1.ExibirMusicasDoAlbum();
banda.ExibirDiscografia();


Console.ReadKey();