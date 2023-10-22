
// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// int InputInteger(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns]; 
// }

// void FillArray(int[,] array, int minValue, int maxValue)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i, j] = random.Next(minValue, maxValue + 1);
        
    
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
// }

// int rows = InputInteger("ВВедите количество строк: ");
// int columns = InputInteger("Введите количество столбцов: ");
// int min = InputInteger("Введите минимальное значение: ");
// int max = InputInteger("Введите максимальное значение: ");
// int[,] arr= Create2DArray(rows, columns);
// FillArray(arr, min, max);
// Print2DArray(arr);


// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int InputInteger(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns]; 
// }

// void FillArray(int[,] array)
// {
    
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i, j] = i + j; 
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
// }
// int rows = InputInteger("ВВедите количество строк: ");
// int columns = InputInteger("Введите количество столбцов: ");

// int[,] arr= Create2DArray(rows, columns);
// FillArray(arr);
// Print2DArray(arr);

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// НЕ ПОЛУЧИЛСЯ КОД

// int PromtInt(string promt)
// {
//     Console.Write(promt);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// int FillArray(int rows, int columns, int minValue, int maxValue)
// {
//     Random random = new Random();
//     int[,] result = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//         {
//             result[i,j] = random.Next(minValue, maxValue + 1);
//         }
//         return result;    
// }
// void ShowMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j], 3}");
//         Console.WriteLine();
//     }
// }
// void ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(0); j++)
//         {
//             if (i%2 == 0 && j%2 == 0)
//             {
//                 array[i,j] *= array[i,j];
//             }
//         }
//         }
    
// }
// int rows = PromtInt("ВВедите количество строк: ");
// int columns = PromtInt("Введите количество столбцов: ");
// int min = PromtInt("Введите минимальное значение: ");
// int max = PromtInt("Введите максимальное значение: ");
// int[,] array= FillArray(rows, columns, min, max);
// ShowMatrix(array);
// ChangeArray(array);
// ShowMatrix(array);

// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
