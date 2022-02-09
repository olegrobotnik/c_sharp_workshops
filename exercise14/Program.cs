//Найти третью цифру числа или сообщить, что её нет


/* Not working option with array
int[] arry = new int[] { 100, 999, 101, 777, 7777, 77777, 888888, 9999999 };
foreach (int elmnt in arry)
{
    if (elmnt < 100)
    {
        Console.WriteLine($"The number {elmnt} has no third digit!");
        //Console.Write($"{elmnt} ");
    }
foreach (int elmnt in arry)
{

    while (elmnt > 100)
    {
        rslt = elmnt / 10;          
        return;
    }
    rslt = rslt % 10;
    Console.WriteLine($"{rslt} ");

    //rslt = rslt % 10;
    //Console.WriteLine($"Third digit is {rslt}");
    //Console.WriteLine(rslt);


}
*/

/* Not working option with array
int[] arry = { 100, 999, 101, 777, 7777, 77777, 888888, 8888888 };
//int i = 0;
int rslt = 0;

foreach (int elmnt in arry)
{
    if (elmnt < 100)
    {
        Console.WriteLine($"The number {elmnt} has no third digit!");
        //Console.Write($"{elmnt} ");
    }
}

for (int i = 0; i < arry.Length; i++)
{
    while (arry[i] > 99)
    {
        rslt = arry[i] / 10;
        Console.WriteLine($"{rslt} ");
        
    }
    rslt = rslt % 10;
    

}
*/

/* Working completely math option
Console.Write("Enter the number: ");
int nmbr = int.Parse(Console.ReadLine());
int nmbrPos = Math.Abs(nmbr);

if (nmbrPos < 100)
{
    Console.WriteLine("Number is smaller than 3-digit");
    
}
else
{
    while(nmbrPos > 999)
    {
        nmbrPos = nmbrPos / 10;
    }
    Console.WriteLine($"{nmbrPos % 10} is the third digit.");
}

string InPut(string message)
{
    Console.Write(message);
    string numStr = Console.ReadLine();
    //int A = int.Parse(num);
    return numStr;    
}
*/

string num1 = InPut("Enter the first number: ");
//string num2 = InPut("Enter the second number: ");
//string num3 = InPut("Enter the third number: ");

int length = num1.Length;

if (length > 2)
{
    char thrdChr =  num1[2];
    Console.WriteLine($"The third digit of the number is {thrdChr}.");
}
else
{
    Console.WriteLine($"{num1} is not a three-digit number!");
}


