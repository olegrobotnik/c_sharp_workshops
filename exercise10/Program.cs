// Показать вторую цифру трёхзначного числа

// int GetRandomNumber() // Added a function which returns a random number from 100 to 999
// {
//     int randomNumber = new Random().Next(100, 1000);
//     return randomNumber;
// }

/* int randomNumber = new Random().Next(100, 1000); //This is the variant with a string and a char variables
string numberStr = randomNumber.ToString("G");
char two = numberStr[1];

Console.Write("The number is ");
Console.ForegroundColor = ConsoleColor.Green; //Colored output
Console.WriteLine(numberStr);
Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Magenta; //Colored output
//Console.WriteLine($"The second digit is {two}.");

Console.Write("The second digit is ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(two);
Console.ResetColor(); */

int rndmNmbr = new Random().Next(100, 1000); //This is the variant with int variables and division with remainder
int dig1 = rndmNmbr / 10;
int dig2 = dig1 % 10;

Console.Write("The number is ");
Console.ForegroundColor = ConsoleColor.Green; //Colored output
Console.WriteLine(rndmNmbr);
Console.ResetColor();

Console.Write("The second digit is ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(dig2);
Console.ResetColor();