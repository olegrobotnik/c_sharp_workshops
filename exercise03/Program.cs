//По заданному номеру дня недели вывести его название
//int [] = {1, 2, 3, 4, 5, 6, 7}
Console.Write("Enter weekday: ");
string weekdayZ = Console.ReadLine();
int weekday = int.Parse(weekdayZ);
if(weekday == 1)
{
    Console.WriteLine("Monday");
}
if(weekday == 2)
{
    Console.WriteLine("Tuesday");
}
if(weekday == 3)
{
    Console.WriteLine("Wednesday");
}
if(weekday == 4)
{
    Console.WriteLine("Thursday");
}    
if(weekday == 5)
{
    Console.WriteLine("Friday");
}
if(weekday == 6)
{
    Console.WriteLine("Saturday");
}    
if(weekday == 7)
{
    Console.WriteLine("Sunday");
}
