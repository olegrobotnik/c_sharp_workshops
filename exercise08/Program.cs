//Показать четные числа от 1 до N

Console.Write("Enter a random whole number: ");
string numberStr = Console.ReadLine();
int numberN = int.Parse(numberStr);
int n = 1;

Console.Write("Odd numbers are: ");

while(n <= numberN) 
{
    if(n % 2 != 0)
    {
        Console.Write(n + " ");
        n++;
    }
    else    
    {
        n++;          
    } 
}
