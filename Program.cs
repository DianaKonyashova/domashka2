// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы. // 2 3 4 5 6 

// using System.Reflection;

// int M = 2;
// int N = 6;

// void GetNum(int M, int N)
// {
//     System.Console.WriteLine(M);
//     if (M >= N)
//     {
//         return;
//     }
//     GetNum(M + 1, N);
// }

// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


// int foo(int n, int m)
// {

//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if ((n != 0) && (m == 0))
//     {
//         return foo(n - 1, 1);
//     }
//     else
//     {
//         return foo(n - 1, foo(n, m - 1));
//     }

// }

// int result = foo(3, 2);
// System.Console.WriteLine(result);



// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// int [] array = new int [] {5, 2, 2, 6, 21, 1};

// void ReverseArray (int []array,int num)
// {
//     System.Console.WriteLine(array[num]);
//     if(num==0) 
//     {
//         return;
//     }
//     ReverseArray(array, num - 1);
// } 
// ReverseArray(array, array.Length - 1);