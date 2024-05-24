using System;
using System.Collections.Generic;
using System.Linq;

public class userData
{
    public string Name { get; set; }
    public int Level { get; set; }

    public userData(string name, int level)
    {
        Name = name;
        Level = level;
    }
}

class Program
{
    static void Main()
    {
        List<userData> list = new List<userData>();
        list.Add(new userData("GTA 5", 10));
        list.Add(new userData("Genshin Impact", 60));
        list.Add(new userData("Counter Strike 2", 15));
        list.Add(new userData("LOL", 125));

        // a
        var selectedData = list.Select(u => new { u.Name, u.Level });
        foreach (var item in selectedData)
        {
            Console.WriteLine("Name: " + item.Name + " | Level: " + item.Level);
        }
        // b
        var sortedList = list.OrderByDescending(u => u.Level);
        Console.WriteLine("\nDanh sach userData sau khi sap xep theo thu tu giam dan cua Level: ");
        foreach (var item in sortedList)
        {
            Console.WriteLine("Name: " + item.Name + " | Level: " + item.Level);
        }
    }
}
