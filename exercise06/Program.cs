//Выяснить является ли число чётным

int number = new Random().Next(999);

if(number % 2 != 0)
{
    Console.WriteLine("The number " + number + " is odd.");
}
else
{
    Console.WriteLine("The number " + number + " is even.");
}



