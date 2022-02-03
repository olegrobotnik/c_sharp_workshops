//Показать четные числа от 1 до N

Console.Write("Enter a random whole number: ");
string numberStr = Console.ReadLine();
int numberN = int.Parse(numberStr);
int n = 1;

while(n <= numberN)
{
    if(n % 2 != 0)
    {
        Console.Write("Odd numbers are: ");
        Console.Write(n + "...");
        n++;
    }
    else    
    {
        n++;          
    } 
}


/*
Console.WriteLine("Enter number N: ");
string numbers = Console.ReadLine();
int number = int.Parse(numbers);
int numberNeg = number * -1;
while (numberNeg <= number)
{
    Console.Write(numberNeg + " ");
    numberNeg++;
}
*/