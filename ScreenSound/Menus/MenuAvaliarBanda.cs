using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas){
    //digite qual banda deseja avaliar
    // se a banda exitir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal
    base.Executar(bandasRegistradas);
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o Nome da banda que deseja avaliar: ");
    string NomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(NomeDaBanda))
    {
        Banda banda = bandasRegistradas[NomeDaBanda];
        Console.Write($"Qual a nota que a banda {NomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.Adicionarnotas(new Avaliacao(nota));
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {NomeDaBanda}");
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