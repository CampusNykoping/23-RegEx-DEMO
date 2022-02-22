using System.Text.RegularExpressions;

Console.WriteLine("Hitta vokaler\n");
Console.Write("Ange text att testa mot: ");
string input = Console.ReadLine();

Regex regex = new Regex("[AEIOUYÅÄÖaeiouyåäö]");
MatchCollection matches = regex.Matches(input);

Console.WriteLine($"Vokaler: {matches.Count}");

Console.ReadKey();