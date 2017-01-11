using System;

namespace Compression.Models
{
    [Serializable]
    class Node
    {
        public char Character { get; }
        public int Frequency { get; }
        public Node LeftChild { get; }
        public Node RightChild { get; }

        public Node(char character, int freq, Node left = null, Node right = null)
        {
            Character = character;
            Frequency = freq;
            LeftChild = left;
            RightChild = right;
        }

        public bool HasChildren()
        {
            return LeftChild != null || RightChild != null;
        }

        public override string ToString()
        {
            return $"Char: {Character}, Frequency: {Frequency}, HasChildren: {HasChildren()}";
        }
    }
}
