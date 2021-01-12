namespace Edgias.DesignPatterns.State
{
    using System;
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle.");
        }
    }
}