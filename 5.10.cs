using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("введите количество элементов списка");
        int n = int.Parse(Console.ReadLine());
        var spisok = new List<int>();
        Console.WriteLine("заполните список");
        int y = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            spisok.Add(a);
            if (a % 2 == 0)
            {
                spisok.Insert(i + y, 2);
                y++;
            }
            if (a % 2 != 0)
            {
                spisok.Insert(i + y, 1);
                y++;
            }
        }

        Console.WriteLine("");
        foreach (var i in spisok)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}
