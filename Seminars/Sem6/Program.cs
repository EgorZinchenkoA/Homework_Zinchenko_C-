// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
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
// int[] reversArray(int[] array)
// {
//     int temp;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 -i] = temp;
//     }
//     return array;
// }


// System.Console.WriteLine("input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input min: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input max: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine("->");
// myArray = reversArray(myArray);
// PrintArray(myArray);


// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// string decimalToBinary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 + result;
//         num /= 2;
//     }
//     return result;
// }
// System.Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(decimalToBinary(num));


// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

// bool CheckTriangle(int num1, int num2, int num3)
// {
//     if(num1 +num2 <= num3 || num2 + num3 <= num1 || num1 + num3 <= num2)
//     {
//         System.Console.WriteLine("Такого треугольника не существует");
//         return false;
//     }
//     else
//     {
//         System.Console.WriteLine("Такой треугольник существует");
//         return true;
//     }
// }
// System.Console.WriteLine("input num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input num3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// CheckTriangle(num1, num2, num3);


// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int[] Fibonacci(int n)
// {
//     int[] array = new int[n];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
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
// System.Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintArray(Fibonacci(n));