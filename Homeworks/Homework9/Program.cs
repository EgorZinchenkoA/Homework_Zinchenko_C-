// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int NumberFromTo(int n, int m)
// {
//   if (n == m) 
//   {
//     return n;
//   }  
//   else 
//   Console.Write($"{NumberFromTo(n, m + 1)}, ");
//   return m;
// }
// Console.WriteLine(NumberFromTo(5, 1));
//..................................................................................
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int SumBetweenTwoElements(int a, in b)
// {
//     if (a == b)
//     {
//         return a;
//     }
//     else 
//     {
//        return SumBetweenTwoElements(a + 1, b) + a;
//     }
// }
// System.Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumBetweenTwoElements(a, b));
//..................................................................................
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AkkermanFunction(int m, int n)
// {
//   if (m == 0) 
//   {
//     return n + 1;
//   }
//   else
//   if (m > 0 && n == 0)
//   {
//   return AkkermanFunction(m - 1, 1);
//   }
//   else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }
// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(AkkermanFunction(n, m));