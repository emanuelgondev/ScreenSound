using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Detalhes da banda");
        Console.Write("Digite o Nome da banda que deseja saber mais: ");
        string NomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(NomeDaBanda))
        {
            ExibirTituloDaOpcao(NomeDaBanda);
            Banda banda = bandasRegistradas[NomeDaBanda];
            Console.WriteLine("Avaliação: " + banda.Media);
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