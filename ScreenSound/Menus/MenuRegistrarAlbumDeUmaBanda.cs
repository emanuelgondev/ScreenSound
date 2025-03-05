using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarAlbumDeUmaBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.WriteLine("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual é nome do album que você gostaria de registrar para a banda {nomeDaBanda}: ");
            string tituloAlbum = Console.ReadLine()!;
            Album album = new Album(tituloAlbum);
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"\nO Album {tituloAlbum} foi registrado com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
            // condição para validar se um almbum já foi cadastrado
        }
        
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}