// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива
// a b c => “abcdef”
// d e f 

// char[,] matrix = new char[2, 3] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
// string str = " ";

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//             str += matrix[i,j];
//     }
// }
// System.Console.WriteLine(str);

// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. // “aBcD1ef!-” => “abcd1ef!-”

// string str1 = "aBcD1ef!-";
// string str2 = str1.ToLower(); 
// System.Console.WriteLine(str2);

// // Задайте произвольную строку. Выясните,
// // является ли она палиндромом.

// System.Console.WriteLine("введите строку");
// string str = Console.ReadLine();

// int n = str.Length / 2;
// bool palindrome = false;
// for (int i = 0; i < n; i++)
// {
//     if (str[i] != str[str.Length - 1 - i])
//     {
//         palindrome = false;
//         break;
//     }
//     else
//     {
//         palindrome = true;
//     }
// }
// if (palindrome == true)
// {
//     System.Console.WriteLine("yes");
// }
// else
// {
//     System.Console.WriteLine("no");
// }
