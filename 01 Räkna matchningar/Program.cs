using System.Text.RegularExpressions;

Console.Write("Ange sökmönster: ");
string pattern = Console.ReadLine();

Console.Write("Ange text att testa mot: ");
string input = Console.ReadLine();

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

Console.WriteLine("Antal träffar: {0}", matches.Count);


Console.ReadKey();