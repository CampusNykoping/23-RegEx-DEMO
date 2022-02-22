using System.Text.RegularExpressions;

Console.Write("Ange tid att testa: ");
string input = Console.ReadLine();

Regex regex = new Regex(@"^(?<hour>[0-2][0-9]):(?<min>[0-5][0-9]):(?<sec>[0-5][0-9])?$");

while (input != "END")
{
    Match match = regex.Match(input);
    if (match.Success)
    {
        if (IsValidTime(match))
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
    else
    {
        Console.WriteLine("invalid");
    }

    Console.Write("Ange tid att testa: ");
    input = Console.ReadLine();
}




bool IsValidTime(Match clock)
{
    int hours = int.Parse(clock.Groups["hour"].Value);
    int minutes = int.Parse(clock.Groups["min"].Value);
    int seconds = int.Parse(clock.Groups["sec"].Value);

    if (hours >= 0 && hours <= 23)
        if (minutes >= 0 && minutes <= 59)
            if (seconds >= 0 && seconds <= 59)
                return true;

    return false;
}

Console.ReadKey();