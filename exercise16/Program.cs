// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int wkday;

Console.Write("Enter a weekday number from 1 till 7): ");
string value = Console.ReadLine();

bool success = int.TryParse(value, out wkday);
if (success)
{
    if (wkday >= 1 && wkday <= 7)
    {
        if (wkday == 6)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("It's Saturday!");
            Console.ResetColor();
        }
        else if (wkday == 7)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("It's Sunday!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("It is a business day.");
        }
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{value} is not a weekday number!");
        Console.ResetColor();
    }
}
else
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"{value} is not a weekday number!");
    Console.ResetColor();
}






