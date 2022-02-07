//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int GetRandomNumber ()
{
     int randomNumber = new Random().Next(10, 100);
     return randomNumber;
}

int number = GetRandomNumber();
Console.WriteLine($"Generated number is {number}");

int firstDigit = number / 10;
int lastDigit = number % 10;

if (firstDigit > lastDigit) 
    Console.WriteLine($"The biggest digit is {firstDigit}");    
else 
    Console.WriteLine($"The biggest digit is {lastDigit}");

