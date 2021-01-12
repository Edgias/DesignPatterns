namespace Edgias.DesignPatterns.State
{
    using System;
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line.");
        }
    }
}