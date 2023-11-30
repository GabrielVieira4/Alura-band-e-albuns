class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albums = new List<Album>();
    public string Nome { get; }
    public void AdcionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            System.Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal} Segundos)");
        }
    }

}