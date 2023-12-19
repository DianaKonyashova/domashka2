// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9 
// using System.Linq;
// using System.Text.RegularExpressions;

// int[,] array = new int[2, 3];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// CreateArray();

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// PrintArray();

// Console.WriteLine("введите строку элемента");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите столбец элемента");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > 2 || b > 3)
// Console.WriteLine("такого элемента нет");
// else
// {
//     System.Console.WriteLine(array[a,b]);
// }


// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива. 
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1

// int[,] array = new int[2, 3];
// int[,] array2 = new int[2, 3];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// CreateArray();

// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// PrintArray(array);

// int[,] FlipArray()
// {
//     int temp = 0;
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             temp = array[0, i];
//             array[0, i] = array[1,i];
//             array[1, i] = temp;
//         }
//     }
//     return array;
// }
// FlipArray();

// void PrintArray2()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] +" ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// PrintArray2();

