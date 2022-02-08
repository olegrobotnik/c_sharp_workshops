// Показать таблицу квадратов чисел от 1 до N

//  Добавить InPut  

int Input(string msg)
{
    Console.Write(msg);
    string nmbrStr = Console.ReadLine();
    int nmbr = int.Parse(nmbrStr);
    return nmbr;
}

int[] InitArry(int nmbr)  //  Метод ввода массива
{
    int[] array = new int[nmbr];
    for (int i = 0; i < nmbr; i++)
    {
        array[i] = (i + 1) * (i + 1);
    }
    return array;
}

void PrintArray(int[] array)   // Метод печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int b = Input("Enter the number N: ");
var array = InitArry(b);

PrintArray(array);