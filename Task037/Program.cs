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
    int count = array.Length / 2;
        if (count % 2 != 0)
            count = count + 1;
    int startNumber = 0;
    int endNumber = array.Length -1;
    int length = count;
    int[] newArray = new int[length];

    for (int i = 0; i < count; i++)
    {
        int result = array[startNumber] + array[endNumber];
        newArray[i] = result;
        startNumber++;
        endNumber--;
    }
    return newArray;
}

int[] array = CreateArray(7, 0, 10);
PrintArray(array);
int[] newArray = CreateNewArray(array);
PrintArray(newArray);

