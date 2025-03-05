using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Detalhes da banda");
        Console.Write("Digite o Nome da banda que deseja saber mais: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            ExibirTituloDaOpcao(nomeDaBanda);
            Console.WriteLine($"Avaliação: {banda.Media}");
            Console.WriteLine("\nDiscografia: ");
            foreach( Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
                
            }
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
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