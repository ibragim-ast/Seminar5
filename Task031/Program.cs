
int[] CreateArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array} ");
    Console.WriteLine();
}

void FindPositiveSum(int [] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                sum += arr[i];
        }
    }

void FindNegativeSum(int [] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
                sum += arr[i];
        }
    }

int[] array = CreateArray(12, -9, 9);
FindPositiveSum(array);
FindNegativeSum(array);
PrintArray(array);

