using DataStructures.LinkedLists.SingleLinked;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleLinkedList = new SingleLinkedList(1);

            
            Console.WriteLine(singleLinkedList.ToString());
            Console.ReadKey();
        }
    }
}
