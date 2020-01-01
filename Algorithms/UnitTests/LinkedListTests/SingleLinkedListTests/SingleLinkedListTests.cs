using DataStructures.LinkedLists.SingleLinked;
using NUnit.Framework;

namespace UnitTests.LinkedListTests.SingleLinkedListTests
{
    public class SingleLinkedListTests
    {
        [Test]
        public void AddNodeToEndTest()
        {
            var singleLinkedList = new SingleLinkedList(1);

            singleLinkedList.AddToEnd(2);
            singleLinkedList.AddToEnd(3);
            singleLinkedList.AddToEnd(4);
            singleLinkedList.AddToEnd(5);

            Assert.AreEqual(1, singleLinkedList.Root.Value);
            Assert.AreEqual(2, singleLinkedList.Root.Next.Value);
            Assert.AreEqual(3, singleLinkedList.Root.Next.Next.Value);
            Assert.AreEqual(4, singleLinkedList.Root.Next.Next.Next.Value);
            Assert.AreEqual(5, singleLinkedList.Root.Next.Next.Next.Next.Value);

            Assert.IsNull(singleLinkedList.Root.Next.Next.Next.Next.Next);
        }

        [Test]
        public void AddNodeToStartTest()
        {
            var singleLinkedList = new SingleLinkedList(10);

            singleLinkedList.AddToStart(20);
            singleLinkedList.AddToStart(30);
            singleLinkedList.AddToStart(40);
            singleLinkedList.AddToStart(50);

            Assert.AreEqual(50, singleLinkedList.Root.Value);
            Assert.AreEqual(40, singleLinkedList.Root.Next.Value);
            Assert.AreEqual(30, singleLinkedList.Root.Next.Next.Value);
            Assert.AreEqual(20, singleLinkedList.Root.Next.Next.Next.Value);
            Assert.AreEqual(10, singleLinkedList.Root.Next.Next.Next.Next.Value);

            Assert.IsNull(singleLinkedList.Root.Next.Next.Next.Next.Next);
        }

        [Test]
        public void RemoveNodeAtTest()
        {
            var singleLinkedList = new SingleLinkedList(1);

            singleLinkedList.AddToEnd(2);
            singleLinkedList.AddToEnd(3);
            singleLinkedList.AddToEnd(4);
            singleLinkedList.AddToEnd(5);

            Assert.AreEqual(singleLinkedList.Root.Value, 1);
            singleLinkedList.RemoveNodeAt(0);
            Assert.AreEqual(singleLinkedList.Root.Value, 2);

            singleLinkedList.RemoveNodeAt(1);
            Assert.AreEqual(singleLinkedList.Root.Next.Value, 4);

            singleLinkedList.RemoveNodeAt(0);
            singleLinkedList.RemoveNodeAt(0);
            singleLinkedList.RemoveNodeAt(0);

            Assert.IsNull(singleLinkedList.Root);
        }

        [Test]
        public void GetMiddleNodeTest()
        {
            var singleLinkedList = new SingleLinkedList(1);

            singleLinkedList.AddToEnd(2);
            singleLinkedList.AddToEnd(3);
            singleLinkedList.AddToEnd(4);
            singleLinkedList.AddToEnd(5);

            Assert.AreEqual(3, singleLinkedList.GetMiddleNode().Value);

            singleLinkedList = new SingleLinkedList(1);
            Assert.AreEqual(1, singleLinkedList.GetMiddleNode().Value);

            singleLinkedList = new SingleLinkedList(1);
            singleLinkedList.AddToEnd(2);
            Assert.AreEqual(2, singleLinkedList.GetMiddleNode().Value);

            singleLinkedList = new SingleLinkedList(1);
            singleLinkedList.AddToEnd(2);
            singleLinkedList.AddToEnd(3);
            Assert.AreEqual(2, singleLinkedList.GetMiddleNode().Value);
        }
    }
}
