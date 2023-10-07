//  Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// int FindQuater(int x, int y) 
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return 0;
// }

// System.Console.WriteLine("input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindQuater(x, y));

//.......................................................................
//  Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// void QuadTable(int n)
// {
//     int m = 1;
//     System.Console.Write(n + "->");
//     while (m < n)
//     {
//         System.Console.Write(m * m + ",");
//         m++;
//     }
//     System.Console.WriteLine(m * m);
// }
// System.Console.WriteLine("input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// QuadTable(n);

//  Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

// void coordQuater (int quater)
// {
//     if (quater == 1)
//     {
//         System.Console.WriteLine("x > 0, y > 0");
//     }
//     else if (quater == 2)
//     {
//         System.Console.WriteLine("x < 0, y > 0");
//     }
//     else if (quater == 3)
//     {
//         System.Console.WriteLine("x < 0, y < 0");
//     }
//     else if (quater == 4)
//     {
//         System.Console.WriteLine("x > 0, y < 0");
//     }
//     else
//     {
//         System.Console.WriteLine("ERROR!");
//     }
// }
// System.Console.WriteLine("input quater: ");
// int quater = Convert.ToInt32(Console.ReadLine());

// coordQuater(quater);

//............................................................................
// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

//  double Distance (double xa, double ya, double xb, double yb)
//  {
//     return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
//  }
//  System.Console.WriteLine("input coordinates: ");
//  System.Console.WriteLine("Координата х точки А: ");
//  double xa = Convert.ToDouble(Console.ReadLine());
//  System.Console.WriteLine("Координата y точки А: ");
//  double ya = Convert.ToDouble(Console.ReadLine());
//  System.Console.WriteLine("Координата х точки B: ");
//  double xb = Convert.ToDouble(Console.ReadLine());
//  System.Console.WriteLine("Координата y точки B: ");
//  double yb = Convert.ToDouble(Console.ReadLine());

//  System.Console.WriteLine($"A ({xa},{ya}); B ({xb},{yb}) -> {Math.Round(Distance(xa, ya, xb, yb), 2)}");