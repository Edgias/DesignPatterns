namespace Edgias.DesignPatterns.Memento
{
    using System.Collections.Generic;

    public class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        /// Find index of last item which was added to the list. Search the list using the index and return the item.
        public EditorState Pop()
        {
            int lastIndex = states.Count - 1;
            EditorState lastState = states[lastIndex];
            states.Remove(lastState);

            return lastState;
        }
    }
}