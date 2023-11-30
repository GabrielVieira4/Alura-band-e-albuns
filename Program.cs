
Banda CharlieBrownJunior = new Banda("Charlie Brown Junior");

Album AlbumCbjr = new Album("Música Popular Caiçara");

Musica musica1 = new Musica(CharlieBrownJunior, "Céu Azul")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(CharlieBrownJunior, "Pontes indestrutíveis")
{
    Duracao = 313,
    Disponivel = false,
};


Console.Clear();
AlbumCbjr.AdicionarMusica(musica1);
AlbumCbjr.AdicionarMusica(musica2);
CharlieBrownJunior.AdcionarAlbum(AlbumCbjr);
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
CharlieBrownJunior.ExibirDiscografia();

