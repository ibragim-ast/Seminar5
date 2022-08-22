// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позициях

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

void FindOddIndexSum(int[] array)
{
    int sum = 0;
    int length = array.Length;

    for (int i = 1; i < length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sum}");
}

int[] array = CreateArray(10, 0, 10);
PrintArray(array);
FindOddIndexSum(array);