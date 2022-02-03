//Даны два числа. Показать большее и меньшее число

int numberOne = 1399;
int numberTwo = 777;
int min = numberOne;
int max = 0;

if (numberTwo < min) 
{
    min = numberTwo; 
    max = numberOne;
}
else 
{
    max = numberTwo;
} 
Console.WriteLine(min + " is lower than " + max);

