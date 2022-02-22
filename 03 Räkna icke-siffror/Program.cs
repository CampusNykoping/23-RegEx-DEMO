using System.Text.RegularExpressions;

Console.Write("Ange text att testa mot: ");
string input = Console.ReadLine();

//Regex regex = new Regex("[\\D]");
Regex regex = new Regex(@"[\D]");
MatchCollection matches = regex.Matches(input);

Console.WriteLine($"Icke-siffror: {matches.Count}");

Console.ReadKey();