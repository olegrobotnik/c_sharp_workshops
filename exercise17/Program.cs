//По двум заданным числам проверять является ли одно квадратом другого

int InPut(string message)
{
    Console.Write(message);
    string num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;    
}

int numOne = InPut("Enter the first number: ");
int numTwo = InPut("Enter the second number: ");

if(numOne == numTwo * numTwo)
{
  Console.WriteLine($"{numOne} is square of {numTwo}");
}
else if (numTwo == numOne * numOne)
{
    Console.WriteLine($"{numTwo} is square of {numOne}");
}
else
{
    Console.WriteLine("Both numbers are not squares of each other!");
}


