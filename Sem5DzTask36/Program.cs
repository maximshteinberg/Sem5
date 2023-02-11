// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int sum(int [] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (i%2==1)
       {
            result = result + arr[i];
       }
       
    }
    return result;
}

int[] a = GenerateArray(6,-5,5);
PrintArray(a);
System.Console.WriteLine($"{sum(a)}");