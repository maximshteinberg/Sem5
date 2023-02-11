// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] GenerateArray(int size, int Leftrange, int RightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(Leftrange, RightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int MaxZn(int[] a)
{
    int max = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }

    }
    return max;
}

int MinZn(int[] a)
{
    int min = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < min)
        {
            min = a[i];
        }

    }
    return min;
}

int[] arr = GenerateArray(4, 0, 10);
PrintArray(arr);
System.Console.WriteLine($"Максимальное число в массиве: {MaxZn(arr)}");
System.Console.WriteLine($"Минимальное число в массиве: {MinZn(arr)}");
int dif = MaxZn(arr)-MinZn(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным числом: {dif}");
