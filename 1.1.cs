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
        int k = 0;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            spisok.Add(a);
            if (spisok[i] > max) { k = i; max = spisok[i]; }
        }

        spisok.Insert(0, -10);
        spisok.RemoveAt(1);
        spisok.Insert(n - 1, -100);
        spisok.RemoveAt(n);
        spisok.Insert(k + 1, -1);
        spisok.RemoveAt(k);
        spisok.RemoveAll(e => e % 2 != 0);
        int[] arr = spisok.ToArray();
        arr = Array.FindAll(arr, x => x >= 0);
        spisok.Clear();


        Console.WriteLine("");
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(spisok.BinarySearch(5));
        Console.ReadLine();
    }

}
