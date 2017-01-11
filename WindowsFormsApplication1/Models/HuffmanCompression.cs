using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Compression.Models
{
    class HuffmanCompression : ICompression
    {
        public CompressedFile Compress(Stream fileStream)
        {
            string toCompress = new StreamReader(fileStream).ReadToEnd();
            Node rootNode = BuildTree(GetSortedCharFrequency(toCompress));
            Dictionary<char, BitArray> codeMap = new Dictionary<char, BitArray>();
            BuildCodeMap(codeMap, rootNode, "");
            
            return new CompressedFile(rootNode, EncodeString(toCompress, codeMap));
        }

        public string Decompress(CompressedFile compressed)
        {
            StringBuilder sb = new StringBuilder();
            Node currNode = compressed.Root;

            foreach (byte b in compressed.Bytes)
            {
                for (int j = 0; j < 8; j++)
                {
                    currNode = (b & (1 << j)) != 0 ? currNode.LeftChild : currNode.RightChild;
                    if (currNode.HasChildren()) continue;

                    sb.Append(currNode.Character);
                    currNode = compressed.Root;
                }
            }

            return sb.ToString();
        }

        private static IEnumerable<KeyValuePair<char, int>> GetSortedCharFrequency(string s)
        {
            IDictionary<char, int> freqMap = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (freqMap.ContainsKey(c))
                    freqMap[c]++;
                else
                    freqMap.Add(c, 1);
            }

            return from entry in freqMap orderby entry.Value descending select entry;
        }

        private static Node BuildTree(IEnumerable<KeyValuePair<char, int>> freqMap)
        {
            Queue<Node> queue = MapToNodeQueue(freqMap);

            while (queue.Count > 1)
            {
                Node node1 = queue.Dequeue();
                Node node2 = queue.Dequeue();
                Node newNode = new Node('\0', node1.Frequency + node2.Frequency, node1, node2);
                queue.Enqueue(newNode);
            }

            return queue.Dequeue();
        }

        private static Queue<Node> MapToNodeQueue(IEnumerable<KeyValuePair<char, int>> map)
        {
            Queue<Node> queue = new Queue<Node>();
            foreach (KeyValuePair<char, int> pair in map)
            {
                queue.Enqueue(new Node(pair.Key, pair.Value));
            }
            return queue;
        }

        private static void BuildCodeMap(IDictionary<char, BitArray> map, Node node, string code)
        {
            if (node == null) return;

            if (node.HasChildren())
            {
                BuildCodeMap(map, node.LeftChild, code + "0");
                BuildCodeMap(map, node.RightChild, code + "1");
            }
            else
            {
                BitArray bits = new BitArray(code.Length);
                for (int i = 0; i < code.Length; i++)
                {
                    bits[i] = code[i] == '1';
                }
                map.Add(node.Character, bits);
            }
        }

        private static byte[] EncodeString(string s, IDictionary<char, BitArray> codeMap)
        {
            
            BitArray bits = new BitArray(0);

            bits = s.Aggregate(bits, (current, c) => AppendBits(current, codeMap[c]));

            byte[] bytes = new byte[(bits.Length - 1) / 8 + 1];
            int i = 0, pos = 0;
            foreach (bool bit in bits)
            {
                if (bit) bytes[i] = (byte)(bytes[i] | (1 << pos));
                pos++;

                if (pos < 8) continue;
                pos = 0;
                i++;
            }
            return bytes;
        }

        private static BitArray AppendBits(BitArray current, BitArray after)
        {
            var bools = new bool[current.Count + after.Count];
            current.CopyTo(bools, 0);
            after.CopyTo(bools, current.Count);
            return new BitArray(bools);
        }
    }
}
