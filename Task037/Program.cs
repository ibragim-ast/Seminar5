// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] CreateNewArray(int[] array)
{
    int length = array.Length / 2;
        if (length % 2 == 1)
            length += 1;
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        newArray[i] = array[i] * array[array.Length -1 -i];
    }
    
    if (array.Length % 2 == 1)
        newArray[array.Length / 2] = array[array.Length / 2];
    return newArray;
}

int[] array = CreateArray(7, 0, 10);
PrintArray(array);
int[] newArray = CreateNewArray(array);
PrintArray(newArray);

