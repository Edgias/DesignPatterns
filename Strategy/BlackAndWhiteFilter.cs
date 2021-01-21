namespace Edgias.DesignPatterns.Strategy
{
    using System;

    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine($"Applying black and white filter on file: {fileName}");
        }
    }
}