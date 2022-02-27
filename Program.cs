using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        List<string> listId = new();
        listId.Add("140,36");
        listId.Add("741,396");
        listId.Add("8789,96352");
        listId.Add("7485,4125");
        List<int> TagIds = listId.SelectMany(s=>s.Split(',').Select(int.Parse)).ToList();

        foreach (var item in TagIds)
        {
            Console.WriteLine(item);
        }
    }
}
