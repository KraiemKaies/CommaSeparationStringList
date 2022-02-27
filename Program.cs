using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        List<string> listId = new();

        List<int> listId1 = new();
        List<int> listId2 = new();

        listId.Add("140,36");
        listId.Add("741,396");
        listId.Add("8789,96352");
        listId.Add("7485,4125");

        List<int> ListIdInt = listId.SelectMany(s=>s.Split(',').Select(int.Parse)).ToList();

        for (int i = 0; i < ListIdInt.Count; i++)
        {
            if (i % 2 == 0) listId1.Add(ListIdInt[i]);
            if (i % 2 == 1) listId2.Add(ListIdInt[i]);
        }

        foreach (string i in listId) Console.WriteLine("Total List :" + i);
        foreach (int i in listId1) Console.WriteLine("List 1 :" + i);
        foreach (int i in listId2) Console.WriteLine("List 2 :" + i);
    }
}
