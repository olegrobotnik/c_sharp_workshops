
//Показать числа от -N до N

Console.Write("Enter random positive number: ");
string numberStr = Console.ReadLine();
int numberInt = int.Parse(numberStr);
int numberPos = Math.Abs(numberInt);
int numberNeg = numberPos * -1;
while(numberNeg <= numberPos)
{
    Console.Write(numberNeg + " ");
    numberNeg++;
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