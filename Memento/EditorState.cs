namespace Edgias.DesignPatterns.Memento
{
    public class EditorState
    {
        public string Content { get; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}