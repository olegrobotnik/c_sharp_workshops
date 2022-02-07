//Удалить вторую цифру трёхзначного числа

int rndmNmbr = new Random().Next(100, 1000);
string nmbrStr = rndmNmbr.ToString("G"); //Converting a string to a set of chars
char frstChr = nmbrStr[0];
char scndChr = nmbrStr[1];
char thrdChr = nmbrStr[2];

Console.Write("The number is ");
Console.ForegroundColor = ConsoleColor.Green; //Colored output
Console.WriteLine(nmbrStr);
Console.ResetColor();

Console.Write("The number without a second digit is ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"{frstChr}{thrdChr}");
Console.ResetColor();
