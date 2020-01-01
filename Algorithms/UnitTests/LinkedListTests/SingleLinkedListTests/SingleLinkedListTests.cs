using DataStructures.LinkedLists.SingleLinked;
using NUnit.Framework;

namespace UnitTests.LinkedListTests.SingleLinkedListTests
{
    public class SingleLinkedListTests
    {
        [Test]
        public void AddNodeToEnd()
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
    }
}
