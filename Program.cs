int height;

do
{
    Console.Write("Digite a altura que você deseja que a sua árvore tenha (entre 3 e 10): ");
    if (int.TryParse(Console.ReadLine(), out height) && height >= 3 && height <= 10)
    {
        break;
    }
    else
    {
        Console.WriteLine("Por favor, digite um número válido entre 3 e 10.");
    }
} while (true);

DrawChristmasTree(height);

static void DrawSpaces(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(" ");
    }
}

static void DrawBalls(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write("o");
    }
}

static void DrawChristmasTree(int height)
{
    DrawSpaces(height - 1);
    Console.WriteLine("*");

    for (int i = 1; i < height; i++)
    {
        DrawSpaces(height - i - 1);
        DrawBalls(2 * i + 1);
        Console.WriteLine();
    }

    DrawSpaces(height - 1);
    Console.WriteLine("|");
}
