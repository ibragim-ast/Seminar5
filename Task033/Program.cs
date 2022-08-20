int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FindNumberInArray(int[] array, int x)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i] == x)
        {
            result = i; 
            Console.WriteLine($"Число {x} находится под индексом {result}");
            return;
        }       
        }
    Console.WriteLine($"В массиве нет числа {x}");
}

int[] array = CreateArray(10, -10, 10);
PrintArray(array);
FindNumberInArray(array, -5);