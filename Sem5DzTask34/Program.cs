// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int leftrange, int rightrange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftrange, rightrange + 1);
    }
    return array;
}

int num(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count = count + 1;
        }
    }

    return count;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int [] myarray = GenerateArray(4, 100, 999);
PrintArray(myarray);
System.Console.WriteLine($"Количество четных чисел равно: {num(myarray)}");