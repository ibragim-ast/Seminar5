// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая
// покажет количество четных чисел в массиве

int[] CreateArray100999(int length, int min, int max)
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

void EvenNumbers(int[] array)
{
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
     if (array[i] % 2 == 0)
        count++;   
    }
    Console.WriteLine($"В массиве {count} четных чисел");
}

int[] array = CreateArray100999(10, 100, 1000);
PrintArray(array);
EvenNumbers(array);