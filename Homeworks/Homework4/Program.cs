// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray( int minValue, int maxValue)
// {
//     int[] array = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.WriteLine("input min: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input max: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(minValue, maxValue));

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponentiation(int a, int b)
// {
//     int result =1;
//     for (int i = 0; i < b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }
// System.Console.WriteLine("Введите число, которое нужно возвести: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите степень: ");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"{a},{b} -> " + Exponentiation(a, b));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sumofnumbersdigits(int n)
// {
//     int result =0;
//     while (n > 0)
//     {;
//         result += n % 10;
//         n = n / 10;
//     }
//     return result;
// }
// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"{n} -> " + Sumofnumbersdigits(n));