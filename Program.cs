// Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// int[] array = new int[4];

// CreateArray();
// System.Console.WriteLine(FindCount());

// int[] CreateArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         System.Console.Write(array[i] + " ");
//     }
//     return array;
// }


// FindCount();
// int FindCount()
// {
//     int count =0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 ==0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


//  Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)


// System.Console.WriteLine("введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];

// void CreateArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 20);
//         Console.Write(array[i] + " ");
//     }
// }

// void FlipArray()
// {
//     int temp = 0;
//     int n = array.Length;
//     int k = n / 2;
//     for (int i = 0; i < k; i++)
//     {
//         temp = array[i];
//         array[i] = array[n - 1];
//         array[n - 1] = temp;
//         n--;
//     }
// }

// CreateArray();
// FlipArray();
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write($" {array[i]}");
// }


// Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная. // сумма? стринг в инт? функция?


// for (int i = 0; ; i++)
// {
//     Console.WriteLine("Введите число");
//     string stop = Console.ReadLine();

//     if (stop == "q")
//     {
//         break;
//     }
//     int num = Convert.ToInt32(stop);
//     int sum = 0;
//     int copyNum = num;

//     while (copyNum > 0)
//     {
//         sum = sum + copyNum % 10;
//         copyNum = copyNum / 10;
//     }

//     if (sum % 2 == 0)
//     {
//         break;
//     }
// }