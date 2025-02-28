using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {   
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de bandas");
        Console.WriteLine("Digite o nome da banda que você deseja registrar");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }

}