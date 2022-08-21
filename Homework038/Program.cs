
double[] CreateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)} ");
    }
    Console.WriteLine();
}

void DifferenceMinMax(double[] array)
    {
        int length = array.Length;
        double min = array[0];
        double max = array[0];
        double result = 0;
        for (int i = 0; i < length; i++)
        {
            if (min > array[i])
                min = array[i]; 
            if (max < array[i])
                max = array[i];
        }
        result = max - min;
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(result, 2)}");
    }

double[] array = CreateArray(10);
PrintArray(array);
DifferenceMinMax(array);
