using System;
using System.Linq;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList();
            var iterator = list.First;

            //Random r = new Random();
            //var listOfIntegers = Enumerable
            //    .Range(0, 20)
            //    .Select(_ => r.Next(0, 30))
            //    .ToList();

            //for (int i = 0; i < listOfIntegers.Count; i++)
            //{
            //    list.Add(listOfIntegers[i]);
            //}

            list.Add("2");
            list.Add("10");
            list.Add("8");
            list.Remove("2");
            list.DisplayLinkedList();

        }
    }
}
