// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void FirstHomeExample(int num)
//  {
//      int dec = num / 10;
//      int ed = dec % 10;
//      System.Console.WriteLine($"{num} -> {ed}");
//  }
// System.Console.WriteLine("input threeDigitNumber: ");
// int num = Convert.ToInt32(Console.ReadLine());
// FirstHomeExample(num);

//...................................................
// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 
//  void SecondHomeExample(int num)
//   {
//       if (num >= 100)
//       {
//         while (num > 1000)
//         {
//             num = num / 10;
//         }
//         System.Console.WriteLine($"{num} -> {num % 10}");
//       }
//       else
//       {
//         System.Console.WriteLine($"{num} -> третьей цифры нет");
//       }
//   }
//  System.Console.WriteLine("input threeDigitNumber: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  SecondHomeExample(num);

//.................................................................
// Задача 15: Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//  bool CheckTheDay(int num)
//  {
//      if(num > 5)
//      {
//          return true;
//      }
//      else
//      {
//          return false;
//      }
//  }
//  System.Console.WriteLine("input number: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine($"{num} -> {CheckTheDay(num)}");