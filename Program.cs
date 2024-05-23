using Figgle;

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(FiggleFonts.Big.Render("Personagens aleatorios"));
Console.ResetColor();

Console.WriteLine("\nPressione para continuar...");
Console.ReadKey();
Console.Clear();

Console.WriteLine("");

string[] anime = { "Sagas do Dragon Ball", "Naruto", "Demon Slayer", "Jujutsu" };

string[][] personagem = {
    new string[] { "Goku", "Vegeta", "Broly", "Yancha", "Picolo", "Majin Boo", "Goku Black", "Freeza", "Kuririn", "Gohan" },
    new string[] { "Sasuke", "Naruto", "Madara", "Obito", "Sakura", "Hinata", "Gaara", "Rock Lee", "Hashirama", "Minato", "Kakuzu",
    "Pain", "Jiraya", "Nagato" },
    new string[] { "Tanjiro", "Inosuke", "Zenitsu", "Uzui", "Rengoku", "Tokito", "Shinazugawa", "Shinobu", "Nezuko", "Mitsuri",  },
    new string[] { "Gojo", "Sukuna", "Itadori", "Toji", "Panda", "Mahito", "Todo", "Getou", "Kenjaku", "Inumaki", "Megumi",
    "Nobara", "Meimei" }
};

Console.WriteLine("");

try
{
    Console.Write("\nQuantos personagens das Sagas de Dragon Ball você quer sortear? ");
    int qt1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nQuantos personagens de Naruto você quer sortear? ");
    int qt2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nQuantos personagens de Demon Slayer você quer sortear? ");
    int qt3 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nQuantos personagens você de Jujutsu quer sortear? ");
    int qt4 = Convert.ToInt32(Console.ReadLine());

    if (qt1 < 0 || qt2 < 0 || qt3 < 0 || qt4 < 0)
    {
        throw new ArgumentException();
    }

    Console.WriteLine("");

    Random sorteio = new Random();

    for (int i0 = 1; i0 <= qt1; i0++)
    {
        int sorteioQt1 = sorteio.Next(personagem[0].Length);
        Console.Write($"{anime[0]} =>"); 
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($" {personagem[0][sorteioQt1]}");
        Console.ResetColor();
    }

    Console.WriteLine("");

    for (int i0 = 1; i0 <= qt2; i0++)
    {
        int sorteioQt2 = sorteio.Next(personagem[1].Length);
        Console.Write($"{anime[1]} =>"); 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($" {personagem[1][sorteioQt2]}");
        Console.ResetColor();
    }

    Console.WriteLine("");

    for (int i0 = 1; i0 <= qt3; i0++)
    {
        int sorteioQt3 = sorteio.Next(personagem[2].Length);
        Console.Write($"{anime[2]} =>"); 
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($" {personagem[2][sorteioQt3]}");
        Console.ResetColor();
    }

    Console.WriteLine("");

    for (int i0 = 1; i0 <= qt4; i0++)
    {
        int sorteioQt4 = sorteio.Next(personagem[3].Length);
        Console.Write($"{anime[3]} =>");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($" {personagem[3][sorteioQt4]}");
        Console.ResetColor();
    }
}

catch(FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você digitou algo que não é um número, ou um número decimal.");
    Console.ResetColor();
    return;
}

catch(ArgumentException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("São aceitos apenas números positivos.");
    Console.ResetColor();
    return;
}

catch(OverflowException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você digitou um número muito grande ou muito pequeno.");
    Console.ResetColor();
    return;
}


catch(Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Erro genérico.");
    Console.ResetColor();
    Console.WriteLine($"{ex}");
    return;
}