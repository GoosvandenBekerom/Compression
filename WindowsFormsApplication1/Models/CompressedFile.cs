using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace Compression.Models
{
    [Serializable]
    class CompressedFile
    {
        public Node Root { get; }
        public byte[] Bytes { get; }

        public CompressedFile(Node root, byte[] bytes)
        {
            Root = root;
            Bytes = bytes;
        }

        public override string ToString()
        {
            return $"Compressed Bitcount: {Bytes.Length*8}";
        }

        public bool Save(string filePath)
        {
            Stream fs = new FileStream(filePath, FileMode.Create);
            //BinaryWriter bw = new BinaryWriter(fs);

            try
            {
                // TODO: Save Root Node
                fs.WriteAsync(Bytes, 0, Bytes.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                //bw.Close();
                //bw.Dispose();
                fs.Close();
                fs.Dispose();
            }
            return true;
        }

        public static CompressedFile From(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
