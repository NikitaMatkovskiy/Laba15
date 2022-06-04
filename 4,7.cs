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
        int pervoe_chislo = Convert.ToInt32(spisok.Remove(1));
        spisok.RemoveAll(e => (e % 2 == 0) && (pervoe_chislo % 2 == 0));
        Console.WriteLine("");
        foreach (var i in spisok)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}
