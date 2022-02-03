//Найти максимальное из трех чисел

int numberOne = 1787;
int numberTwo = 7777;
int numberThree = 8787;

int max = numberOne;

if(numberTwo > max) max = numberTwo;
if(numberThree > max) max = numberThree;

Console.WriteLine("The biggest number is " + max);

