// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов, значения которых 
// лежат в отрезке [10, 99]

int[] CreateArray123(int length, int min, int max)
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

void PrintNumber10100(int[] array, int min, int max)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < max && array[i] > min)
        num += 1;
    }
    Console.WriteLine($"Количество чисел от 10 до 100 в массиве равно {num}");
}

int[] array = CreateArray123(123, 0, 123);
PrintArray(array);
PrintNumber10100(array, 10, 100);