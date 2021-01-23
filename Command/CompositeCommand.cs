using System.Collections.Generic;
using Edgias.DesignPatterns.Command.Framework;

namespace Edgias.DesignPatterns.Command
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach(ICommand command in _commands)
            {
                command.Execute();
            }
        }
    }
}