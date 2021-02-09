using System;
using System.Collections.Generic;

namespace ConsoleApp.Array.List.Enum
{
  class Program
  {
    
    /// Enum(перечисление)
    enum Days
    {
      Sun = 7,//воскресенье
      Mon,    //понедельник
      Tue,    //вторник
      Wed,    //среда
      Thu,    //четверг
      Fri,    //пятница
      Sat     //суббота
    }

    static void Main(string[] args)
    {
      ///Array(массив)
      int[] array = new int[10];
      array[0] = 1;
      array[1] = 2;
      array[2] = 3;
      array[3] = 4;
      array[4] = 5;

      //Console.WriteLine(array[0].ToString() + ' ' +
      //                  array[1].ToString() + ' ' +
      //                  array[2].ToString() + ' ' +
      //                  array[3].ToString() + ' ' +
      //                  array[4].ToString());
      //Console.ReadKey();

      int[,] array2 = new int[10, 10];
      array2[0, 0] = 2;
      array2[9, 9] = 6;

      //Console.WriteLine(array2[9, 9]);
      //Console.ReadKey();

      int[,,] array3 = new int[10, 10, 10];
      array3[0, 0, 0] = 2;
      array3[9, 9, 9] = 6;

      //Console.WriteLine(array3[9, 9, 9]);
      //Console.ReadKey();

      ///List(список)
      List<int> list = new List<int>();
      list.Add(0);
      list.Add(1);
      list.Add(2);
      list.Add(3);
      list.Add(4);

      //Console.WriteLine(list[0].ToString() + ' ' +
      //                  list[1].ToString() + ' ' +
      //                  list[2].ToString() + ' ' +
      //                  list[3].ToString() + ' ' +
      //                  list[4].ToString());
      //Console.ReadKey();

      ///Enum(перечисление)
      Console.WriteLine(Days.Sun.ToString() + ' ' +
                        Days.Mon.ToString() + ' ' +
                        Days.Tue.ToString() + ' ' +
                        Days.Wed.ToString() + ' ' +
                        Days.Thu.ToString() + ' ' +
                        Days.Fri.ToString() + ' ' +
                        Days.Sat.ToString());
      Console.ReadKey();

    }
  }
}
