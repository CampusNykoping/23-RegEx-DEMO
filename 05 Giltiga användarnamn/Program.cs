using System.Text.RegularExpressions;

Console.Write("Ange text att testa mot: ");
string input = Console.ReadLine();

Regex regex = new Regex(@"^[\w\d-]{3,16}$");        // "_" ingår i \w

while (input != "END")
{
    MatchCollection matches = regex.Matches(input);
    if (matches.Count > 0)
    {
        Console.WriteLine("valid");
    }
    else
    {
        Console.WriteLine("invalid");
    }

    Console.Write("Ange text att testa mot: ");
    input = Console.ReadLine();
}


Console.ReadKey();