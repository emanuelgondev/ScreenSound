namespace ScreenSound.Modelos;
internal class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Banda(String nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count() == 0)
            {
                return 0;
            }
            else
            {
                return notas.Average(a => a.Nota);
            }
        }
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal} segundos de duração)");
        }
    }
    public void Adicionarnotas(Avaliacao nota)
    {
        notas.Add(nota);

    }

}