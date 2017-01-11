using System.Collections;
using System.IO;

namespace Compression.Models
{
    interface ICompression
    {
        CompressedFile Compress(Stream fileStream);
        string Decompress(CompressedFile compressed);
    }
}
