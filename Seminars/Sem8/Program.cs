// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns]; 
// }

// void FillArray(int[,] array, int minValue, int maxValue)
// {
    
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i, j] = new Random().Next(minValue, maxValue); 
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j] } ");
//         Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
//     {
//         System.Console.WriteLine("Index of row is out of bound");

//     }
//     else
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
   
// }

// System.Console.WriteLine("input num of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input num ofcolumns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input num of first row: ");
// int row1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input num of second row : ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input minVALUE: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns);
// Print2DArray(myArray);
// FillArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// ChangeRows(myArray, row1, row2);
// Print2DArray(myArray);


// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns]; 
// }

// void FillArray(int[,] array, int minValue, int maxValue)
// {
    
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i, j] = new Random().Next(minValue, maxValue); 
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j] } ");
//         Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
//     {
//         System.Console.WriteLine("Index of row is out of bound");

//     }
//     else
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
   
// }
// void RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1)) 
//     {
//         System.Console.WriteLine("Invalid array!");
//     }
//     else
//     {
//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//             for (int j = i + 1; j < array.GetLength(0); j++)
//             {
//             int temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//             }
//        }
            
        
//     }
// }
// System.Console.WriteLine("input num of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input num ofcolumns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input minVALUE: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns);
// Print2DArray(myArray);
// FillArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// RowsToColumns(myArray);
// Print2DArray(myArray);

// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns]; 
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = new Random().Next(minValue, maxValue); 
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j] } ");
        Console.WriteLine();
    }
    System.Console.WriteLine();
}
int DeleteRowAndColumnMin(int[,] array)
{
    int min = array[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
       
            array[i, minJ] = 0;
    }

      for (int j = 0; j < array.GetLength(0); j++)
    {
       
            array[minI, j] = 0;
    }
    return array;
}

System.Console.WriteLine("input num of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("input num ofcolumns: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("input minVALUE: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns);
FillArray(myArray, minValue, maxValue);
Print2DArray(myArray);

DeleteRowAndColumnMin(myArray);
Print2DArray(myArray);