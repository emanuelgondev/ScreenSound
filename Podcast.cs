class Podcast
{
 
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Host { get; }
    public int TotalEpisodios => episodios.Count();
    public string Nome { get; }

    public List<Episodio> episodios = new List<Episodio>();

    public void AdicionarEpisodio(Episodio ep)
    {
        episodios.Add(ep);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"O podcast {Nome} do host {Host}");

        foreach (var episodio in episodios.OrderBy(o => o.Ordem))
        {
            Console.WriteLine($"\nEpisodio #{episodio.Ordem}");
            Console.WriteLine(episodio.Resumo);
        }
    }

}