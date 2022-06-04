using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("введите количество элементов списка");
        int n = int.Parse(Console.ReadLine());
        var spisok = new List<int>();
        Console.WriteLine("задайте число");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("заполните список");
        int y = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            spisok.Add(a);
            if (a > b)
            {
                spisok.Insert(i + y, 0);
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
