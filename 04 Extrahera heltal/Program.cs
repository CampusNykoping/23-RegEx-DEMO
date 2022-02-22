using System.Text.RegularExpressions;

Console.Write("Ange text att testa mot: ");
string input = Console.ReadLine();

Regex regex = new Regex(@"\d+");
MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine(match);
}

Console.ReadKey();