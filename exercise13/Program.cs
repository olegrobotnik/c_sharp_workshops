//Выяснить, кратно ли число заданному, если нет, вывести остаток.


int GetNumber()
{
    int randomNumber = new Random().Next(20, 100);
    return randomNumber; 
}

int number = GetNumber();
Console.WriteLine($"Random number is {number}");

int secondNumber = GetNumber();
Console.WriteLine($"Second random number is {secondNumber}");
IsMultiple(number, secondNumber);
void IsMultiple(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)     
    {
        int result = firstNumber % secondNumber;
        if (result == 0)
            Console.WriteLine("First number кратно second number.")ж
        else          
            Console.WriteLine("First number НЕкратно second number.")
    }
    else
        int result = secondNumber % firstNumber;
        if (result == 0)
            Console.WriteLine("Second number кратно first number.")ж
        else          
            Console.WriteLine("Second number НЕкратно first number.")
}
