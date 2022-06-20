using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ClothesLibrary
{
    public class Archive
    {
        private const string OriginalFileName = "C:\\OOP\\lab3\\test.json";
        private const string CompressedFileName = "C:\\OOP\\lab3\\test.gz";
        private const string DecompressedFileName = "C:\\OOP\\lab3\\dec_test.json";

        public void CompressFile()
        {
            using FileStream originalFileStream = File.Open(OriginalFileName, FileMode.Open);
            using FileStream compressedFileStream = File.Create(CompressedFileName);
            using var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress);
            originalFileStream.CopyTo(compressor);
        }

        public void DecompressFile()
        {
            using FileStream compressedFileStream = File.Open(CompressedFileName, FileMode.Open);
            using FileStream outputFileStream = File.Create(DecompressedFileName);
            using var decompressor = new GZipStream(compressedFileStream, CompressionMode.Decompress);
            decompressor.CopyTo(outputFileStream);

        }

    }
}