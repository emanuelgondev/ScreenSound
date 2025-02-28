using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarAlbumDeUmaBanda : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine("Digite o nome da banda: ");
        string NomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(NomeDaBanda))
        {
            Console.Write($"Qual é nome do album que você gostaria de registrar para a banda {NomeDaBanda}: ");
            string nomeAlbum = Console.ReadLine()!;
            Album album = new Album(nomeAlbum);
            Banda banda = new Banda(NomeDaBanda);
            banda.AdicionarAlbum(album);
            Console.WriteLine($"\nO Album {nomeAlbum} foi registrado com sucesso para a banda {NomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA banda {NomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}