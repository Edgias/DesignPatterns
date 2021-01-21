namespace Edgias.DesignPatterns.Strategy
{
    using System;
    public class PNGCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing file: {fileName} using PNG.");
        }
    }
}