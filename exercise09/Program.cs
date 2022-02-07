//Показать последнюю цифру трёхзначного числа

int GetLastDigit(int number)
{
    return number % 10;    
}

int GetIntegerFromConsole(int min, int max)
{
    int result = 0;
    bool isError = true;
    while (isError);
    {
        Console.Write($"Enter a whole number from {min} to {max}"); //$ используется для фигурных скобок, чтобы можно было вывести переменные
        string input = Console.ReadLine();
        //result = int.Parse(input);
        //if(int.TryParse(input, out result)) isError = result < min || result > max;
        result = int.Parse(input);
        isError = result < min || result > max;
    }
    return result;
}

int number = GetIntegerFromConsole(100, 999);
int lastDigit = GetLastDigit(number);
Console.WriteLine(lastDigit);

