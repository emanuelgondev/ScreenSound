namespace ScreenSound.Modelos;
using System.Runtime.ConstrainedExecution;

internal class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(String nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Músicas do album {Nome}\n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir ese album inteiro, você precisa de {DuracaoTotal} segundos");
    }
}