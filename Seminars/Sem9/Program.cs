// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа от одного до N.


// void ShowNum (int n)
// {
//     if (n > 0)
//     {
//         ShowNum(n - 1);
//         System.Console.Write(n + " ");
//     }
// }
// ShowNum(5);



// Задание 2. Напишите программу, которая будет принимать на вход число и выводить сумму его цифр.

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return FindSum(num/10)+ num % 10;
//     }
//     else return num;
// }
// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(FindSum(num));\


// Задача 3. Задайте значения M и N. Запишите программу, которая выводит все натуральные числа от M до N.

// void NumsFromTo(int n, int m)
// {
//  if (m != n)
//  {
//     if ( m > n)
//     {
//         NumsFromTo(m - 1, n );
//         System.Console.Write(m);
//         System.Console.WriteLine();
//     }
//     else 
//     {
//         NumsFromTo(n - 1, m );
//         System.Console.Write(n);
//          System.Console.WriteLine();
//     }
//  } 
//  else System.Console.WriteLine(m);
// }

// NumsFromTo(5, 10);

// Задача 4. Напишите программу, которая на вход принимает два числа
//  А и В, и возводит число А в целую степень В

// int Exponentation(int a, in b)
// {
//     if (b >= 1)
//     {
//         return Exponentation(a, b - 1) * a;
//     }
//     else return 1;
// }
// System.Console.WriteLine(Exponentation(3, 5));