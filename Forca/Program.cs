
using Forca.Screens;

namespace Forca;

class Program
{
    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("----------------------");
        Console.WriteLine("     Jogo da Forca    ");
        Console.WriteLine("----------------------");
        Console.WriteLine("Você deseja comerçar a jogar?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        Console.WriteLine("3 - Sair");
        var res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1:
                ComeçarScreen.ComercarJogo();
                break;
            case 2:
                Menu();
                break;
            case 3:
                Environment.Exit(0);
                break;
        }

    }

}