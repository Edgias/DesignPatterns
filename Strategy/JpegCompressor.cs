namespace Edgias.DesignPatterns.Strategy
{
    using System;
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing file: {fileName} using JPEG.");
        }
    }
}