namespace Edgias.DesignPatterns.Essentials
{
    using System;

    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hi, my name is {Name}");
        }
    }
}