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
