using Edgias.DesignPatterns.Command.Framework;

namespace Edgias.DesignPatterns.Command
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Black and White.");
        }
    }
}