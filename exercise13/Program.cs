// Выяснить, кратно ли число заданному, если нет, вывести остаток.


int GetNumber()  // Метод получения случайного числа от 20 до 99
{
    int rndmNmbr = new Random().Next(20, 100);
    return rndmNmbr; 
}

void IsMltpl(int frstNmbr, int scndNmbr)
{
    if (frstNmbr > scndNmbr)     
    {
        int rslt = frstNmbr % scndNmbr;
        if (rslt == 0)
            Console.WriteLine("The first number is multiple of the second number.");
        else 
            Console.WriteLine($"The first number is non-multiple of the second number. The remainder of the division is {rslt}.");  
    } 
    else
    {
        int rslt = scndNmbr % frstNmbr;
        if (rslt == 0)
            Console.WriteLine("The second number is multiple of the first number.");
        else          
            Console.WriteLine($"The second number is non-multiple of the first number. The remainder of the division is {rslt}.");   
    }  
        
}  

int frstNmbr = GetNumber();
Console.WriteLine($"The first random number is {frstNmbr}");

int scndNmbr = GetNumber();
Console.WriteLine($"The second random number is {scndNmbr}");
IsMltpl(frstNmbr, scndNmbr); // Вывод из метода IsMltpl