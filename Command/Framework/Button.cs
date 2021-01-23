namespace Edgias.DesignPatterns.Command.Framework
{
    public class Button
    {
        private readonly ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public string Label { get; set; }

        public void Click()
        {
            _command.Execute();
        }
    }
}