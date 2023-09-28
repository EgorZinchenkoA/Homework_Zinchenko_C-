//System.Console.WriteLine("input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine($"your number -> {num} ");

//1.Напишите программу, которая на вход принимает число и выдает его квадрат(число, умноженное на само себя)

//System.Console.WriteLine("input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine($"Quad of {num} -> {num*num} ");

//2. напишите программу, которая принимает на вход трехзначное число и на выходе показывает **последнюю** цифру этого числа.

// 456 -> 6   456 % 10 = 45,6
// 782 -> 2
// 918 -> 8

//System.Console.WriteLine("input three-digit number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if(num >= 100 && num < 1000)
//{
//    System.Console.WriteLine($"Last digit of {num} -> {num%10}");
//}
//else
//{
//    System.Console.WriteLine("Your input not three-digit number");
//}

//5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от - N до N
// ...........................................
// System.Console.WriteLine("input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = n*(-1);
// System.Console.WriteLine($"{n} -> \"");
// while (m < n)
// {
//     System.Console.Write($"{m++}, ");
// }
// System.Console.WriteLine($"{n}\"");
//...................................................

//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//Пример: a =25, b = 5 -> да
// System.Console.WriteLine("input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b * b)
// {
//     System.Console.WriteLine($"a = {a}, b = {b} -> да");
// }
// else
// {
//     System.Console.WriteLine($"a = {a}, b = {b} -> нет");
// }