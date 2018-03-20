using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList();
            var iterator = list.First;

            while(iterator != null)
            {
                //DoSomeAction(iterator.Data);
                iterator = iterator.Next;
            }
        }
    }
}
