// Напишите программу замены элементов массива: положительные отрицательные, и наоборот
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

void ReplaceNegativePozitive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] *= -1;
        }
}

int[] array = CreateArray(4, -9, 9);
PrintArray(array);
ReplaceNegativePozitive(array);
PrintArray(array);


