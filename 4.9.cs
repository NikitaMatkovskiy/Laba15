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

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            spisok.Add(a);
        }
        spisok.RemoveAll(e => (e % 10 == 0));
        Console.WriteLine("");
        foreach (var i in spisok)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}
