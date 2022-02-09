// Дано число. Проверить кратно ли оно 7 и 23

int nmbr = 161;

Multiplicity(nmbr);

void Multiplicity(int nmbr) // Multiplicity of the number method 
{
    if (nmbr == 0)
    
        Console.WriteLine("The number is zero.");             
    
    else
    {
        if (nmbr % 7 == 0 && nmbr % 23 == 0)
        {
            Console.WriteLine($"The {nmbr} is multiple of 7 and 23.");    
        }
        else if (nmbr % 7 == 0)
        {
            Console.WriteLine($"The {nmbr} is multiple of 7."); 
        }
        else if (nmbr % 23 == 0)
        {
            Console.WriteLine($"The {nmbr} is multiple of 23.");   
        }
        else if (nmbr % 7 != 0)
        {
            Console.WriteLine($"The {nmbr} is non-multiple of 7.");
        }      
       
        else if (nmbr % 23 != 0)
        {
            Console.WriteLine($"The {nmbr} is non-multiple of 23.");
        }    
    }
}