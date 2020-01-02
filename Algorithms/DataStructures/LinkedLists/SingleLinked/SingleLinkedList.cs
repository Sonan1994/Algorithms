using System;

namespace DataStructures.LinkedLists.SingleLinked
{
    public class SingleLinkedList
    {
        #region Fields

        private SingleLinkedListNode _root;

        #endregion

        #region Constructors

        public SingleLinkedList(SingleLinkedListNode root)
        {
            _root = root;
        }

        public SingleLinkedList(int value)
            : this(new SingleLinkedListNode(value))
        {

        }
     
        #endregion

        #region Properties

        public SingleLinkedListNode Root => _root;

        #endregion

        #region Methods

        /// <summary>
        /// Find middle node in single linked list.
        /// Example: 1 -> 2 -> 3 -> 4 return 3
        /// Example: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 return 4
        /// </summary>
        /// <returns></returns>
        public SingleLinkedListNode GetMiddleNode()
        {
            SingleLinkedListNode slowerPointer = _root;
            SingleLinkedListNode fasterPointer = _root;

            while (fasterPointer != null && fasterPointer.Next != null)
            {
                fasterPointer = fasterPointer.Next.Next;
                slowerPointer = slowerPointer.Next;
            }

            return slowerPointer;
        }

        /// <summary>
        /// Adding two list.
        /// Example: (2 -> 4 -> 3) + (5 -> 6 -> 4) = (7 -> 0 -> 8)
        /// </summary>
        /// <param name="firstRoot">Root of first single linked list</param>
        /// <param name="secondRoot">Root of second single linked list</param>
        /// <returns></returns>
        public static SingleLinkedList SumOfTwoLinkedList(SingleLinkedList firstList, SingleLinkedList secondList)
        {
            SingleLinkedListNode firstRoot = firstList.Root;
            SingleLinkedListNode secondRoot = secondList.Root;
            SingleLinkedListNode previousNode = null;

            int step = 0;

            while (firstRoot != null && secondRoot != null)
            {
                int currentValue = step + firstRoot.Value + secondRoot.Value;
                firstRoot.Value = currentValue % 10;
                step = currentValue / 10;

                if (firstRoot.Next == null || secondRoot.Next == null)
                    previousNode = firstRoot;

                firstRoot = firstRoot.Next;
                secondRoot = secondRoot.Next;
            }

            while (firstRoot != null)
            {
                int currentValue = firstRoot.Value + step;
                firstRoot.Value = currentValue % 10;
                step = currentValue / 10;
                previousNode.Next = firstRoot;
                previousNode = firstRoot;
                firstRoot = firstRoot.Next;
            }

            while (secondRoot != null)
            {
                int currentValue = secondRoot.Value + step;
                secondRoot.Value = currentValue % 10;
                step = currentValue / 10;
                previousNode.Next = secondRoot;
                previousNode = secondRoot;
                secondRoot = secondRoot.Next;
            }

            if (step == 1)
                previousNode.Next = new SingleLinkedListNode(step);

            return firstList;
        }


        /// <summary>
        /// Convert 110 to 6 
        /// Convert 111 to 7 etc...
        /// </summary>
        /// <param name="singleLinkedList"></param>
        /// <returns></returns>
        public int BinaryListToInteger()
        {
            SingleLinkedListNode current = _root;
            int result = 0;

            while (current != null)
            {
                result = result << 1 | current.Value;
                current = current.Next;
            }

            return result;
        }

        /// <summary>
        /// Reverse linked list
        /// 1 -> 2 -> 3 -> 4 -> 5  ====> 5 -> 4 -> 3 -> 2 -> 1
        /// </summary>
        /// <param name="value"></param>
        public static SingleLinkedList ReverseLinkedList(SingleLinkedList list)
        {
            var result = ReverseLinkedListIterative(null, list.Root);
            return new SingleLinkedList(result);
        }

        private static SingleLinkedListNode ReverseLinkedListIterative(SingleLinkedListNode previousNode, SingleLinkedListNode currentNode)
        {
            while (currentNode != null)
            {
                SingleLinkedListNode nextNode = currentNode.Next;
                currentNode.Next = previousNode;

                previousNode = currentNode;
                currentNode = nextNode;
            }

            return previousNode;
        }

        private static SingleLinkedListNode ReverseLinkedListRecursive(SingleLinkedListNode previousNode, SingleLinkedListNode currentNode)
        {
            if (currentNode == null)
                return null;

            if (currentNode.Next == null)
            {
                currentNode.Next = previousNode;
                return currentNode;
            }

            SingleLinkedListNode next = currentNode.Next;
            currentNode.Next = previousNode;

            return ReverseLinkedListRecursive(currentNode, next);
        }

        public void AddToEnd(int value)
        {
            SingleLinkedListNode tmpRoot = _root;

            while (tmpRoot.Next != null)
                tmpRoot = tmpRoot.Next;

            tmpRoot.Next = new SingleLinkedListNode(value);
        }

        public void AddToStart(int value)
        {
            var newNode = new SingleLinkedListNode(value);

            newNode.Next = _root;
            _root = newNode;
        }

        public void RemoveAll()
        {
            while (_root != null)
                RemoveNodeAt(0);
        }

        public bool RemoveNodeAt(int index)
        {
            SingleLinkedListNode currentNode = _root;
            SingleLinkedListNode previousNode = null;

            if (index == 0)
            {
                _root = _root.Next;
                return true;
            }
            
            while (index > 0 && currentNode.Next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                index--;
            }
       
            if (index != 0)
                return false;

            previousNode.Next = currentNode.Next;
            return true;
        }

        public override string ToString()
        {
            return GetStringRepresentation(_root);
        }

        private static string GetStringRepresentation(SingleLinkedListNode startNode)
        {
            if (startNode == null)
                return string.Empty;

            string outputResult = string.Empty;

            while (startNode != null)
            {
                outputResult = $"{outputResult}{startNode.Value} -> ";

                if (startNode.Next == null)
                    outputResult = outputResult.Substring(0, outputResult.Length - 3);

                startNode = startNode.Next;
            }

            return outputResult;
        }

        #endregion
    }
}
