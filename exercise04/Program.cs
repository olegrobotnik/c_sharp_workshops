//Найти максимальное из трех чисел

/*
int numberOne = 1787;
int numberTwo = 7777;
int numberThree = 8787;

int max = numberOne;

if(numberTwo > max) max = numberTwo;
if(numberThree > max) max = numberThree;

Console.WriteLine("The biggest number is " + max);
*/

/*
Console.Write("Enter number one: ");
string numOneStr = Console.ReadLine();
int numberOne = int.Parse(numOneStr);

Console.Write("Enter number two: ");
string numTwoStr = Console.ReadLine();
int numberTwo = int.Parse(numTwoStr);

Console.Write("Enter number two: ");
string numThreeStr = Console.ReadLine();
int numberThree = int.Parse(numThreeStr);

int max = numberOne;

if (numberTwo > max) max = numberTwo;
if (numberThree > max) max = numberThree;

Console.WriteLine("The biggest number is " + max);
*/

int FuncMax(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if( arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; 
}

Console.Write("Enter number one: ");
string numOneStr = Console.ReadLine();
int numberOne = int.Parse(numOneStr);

Console.Write("Enter number two: ");
string numTwoStr = Console.ReadLine();
int numberTwo = int.Parse(numTwoStr);

Console.Write("Enter number two: ");
string numThreeStr = Console.ReadLine();
int numberThree = int.Parse(numThreeStr);

int maxOne = FuncMax(numberOne, numberTwo, numberThree);

Console.WriteLine("The biggest number is " + maxOne);