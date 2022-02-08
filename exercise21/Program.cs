// Программа проверяет пятизначное число на палиндромом.

int InPut(string msg)
{
    Console.Write(msg);
    string num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;    
}

int numOne = InPut("Enter 5-digit number: "); // Обращаемся к методу
// 
bool val1 = numOne % 10 == numOne / 10000; // Ввели лигическую переменную и сразу сравнили
// 
bool val2 = numOne % 100 / 10 == (numOne / 1000) % 10;

if (val1 && val2)
{
    Console.WriteLine("The number is a palindrome.");
} 
else
{
    Console.WriteLine("The naumber is not a palindrome.");
}    
