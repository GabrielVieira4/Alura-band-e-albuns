using System.Reflection.Metadata;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista.Nome}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine(DescricaoResumida);
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista:{Artista.Nome}");
        Console.WriteLine($"Duração:{Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
