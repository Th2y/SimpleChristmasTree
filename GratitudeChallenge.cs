Console.WriteLine("Bem-vindo ao Desafio de Gratidão Programática!");

List<string> desejos = new List<string>();

Console.WriteLine("Digite pelo que você é grato, apertando ENTER entre cada gratidão. Quando terminar, digite 'fim':");

while (true)
{
    string desejo = Console.ReadLine();

    if (desejo.ToLower() == "fim")
    {
        break;
    }

    desejos.Add(desejo);
}

if (desejos.Count > 0)
{
    Console.WriteLine("\nSou grato por:");

    foreach (string desejo in desejos)
    {
        Console.WriteLine($"- {desejo}");
    }

    Console.WriteLine("\nQue todos os seus desejos continuem se realizando no próximo ano!");
}
else
{
    Console.WriteLine("Eu tenho certeza de que algo bom aconteceu esse ano. Que tal tentar novamente?");
}
