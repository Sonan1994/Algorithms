using DataStructures.LinkedLists.SingleLinked;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleLinkedList = new SingleLinkedList(1);

            singleLinkedList.AddToStart(2);
            singleLinkedList.AddToStart(3);
            singleLinkedList.AddToStart(4);
            singleLinkedList.AddToStart(5);

            Console.WriteLine(singleLinkedList.ToString());
            Console.ReadKey();
        }
    }
}
