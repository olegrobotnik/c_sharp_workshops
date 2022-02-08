// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int InPut(string msg)
{
    Console.Write(msg);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}

void Exec(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("The point is in a quater I.");
    else if (x < 0 && y > 0)
        Console.WriteLine("The point is in a quater II.");
    else if (x < 0 && y < 0)
        Console.WriteLine("The point is in a quater III.");
    else if (x > 0 && y < 0)
        Console.WriteLine("The point is in a quater IV.");  
    else if (x == 0 && y == 0)
        Console.WriteLine("The point is at 0.");  
    else 
        Console.WriteLine("The point is on one of the axes.");
}

int x = InPut("Enter point X coordinate: ");
int y = InPut("Enter point Y coordinate: ");

Exec(x, y);

