namespace Edgias.DesignPatterns.Command
{
    using Edgias.DesignPatterns.Command.Framework;

    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Resize");
        }
    }
}