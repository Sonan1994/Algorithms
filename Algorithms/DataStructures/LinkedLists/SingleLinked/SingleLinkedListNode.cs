namespace DataStructures.LinkedLists.SingleLinked
{
    /// <summary>
    ///  Class which represent node of Single Linked List
    /// </summary>
    public class SingleLinkedListNode
    {
        private int _value;
        private SingleLinkedListNode _next;

        public SingleLinkedListNode(int value)
        {
            _value = value;
            _next = null;
        }

        /// <summary>
        /// Integer value of node
        /// </summary>
        public int Value
        {
            get => _value;
            set => _value = value;
        }


        /// <summary>
        /// Reference to Next node in Single Linked List
        /// </summary>
        public SingleLinkedListNode Next
        {
            get => _next;
            set => _next = value;
        }
    }
}
