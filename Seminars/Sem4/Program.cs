// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// int DigitCount(int num)
// {
//     int count = 0;
//     for (int i = 1; Math.Abs(num) > 0; i++)
//     {
//         num /= 10;
//         count = i;
//     }
//     return count;
// }
// System.Console.WriteLine("input n: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));

//..................................................................................
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
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

// System.Console.WriteLine("input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input min: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input max: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, minValue, maxValue));

//.......................................................................

// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

// int GetSumNumbers(int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// System.Console.WriteLine("input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetSumNumbers(a));



// Найдите факториал от 1 до А
// int FindFactorial(int a)
// {
//     int fact = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         fact *= i;
//     }
//     return fact;
// }
// System.Console.WriteLine("input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindFactorial(a));
