// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
//     }
//     return array;
// }

// void Convert(int[] array)
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         array [i] = - array[i];
//     }

// }
 

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// } 

// int [] myarray = GenerateArray(4,-9,9);
// PrintArray(myarray);
// Convert(myarray);
// PrintArray(myarray);





// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// } 



// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(system.console.readline())

// bool FindNumber(int[] array, int number)
// {
//     for(int i=0; i<array.lenght; i++)
//     {
//         if (array[i] == number)
//         {
//             return true
//         }
//         return false
//     }
// }





// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1); 
//     }
//     return array;
// }


// void ChangePositiveAndNegative(int[] array)
// {
   
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i]; 
//     }
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }


// int[] myArray = GenerateArray(6, -9, 9);
// PrintArray(myArray);
// ChangePositiveAndNegative(myArray);
// PrintArray(myArray);


// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] arr = {1, 2, 3, 0, 7};
// System.Console.WriteLine(Array.IndexOf(arr, 9));


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// int FindQ(int[] array)

// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int [] myArray = GenerateArray(20, -100, 100);
// PrintArray (myArray);
// System.Console.WriteLine($"количество элементов в заданном диапазоне {FindQ(myArray)} ");





// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21