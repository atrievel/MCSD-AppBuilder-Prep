using System;

namespace Class.Hierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, int legs, float weight) : base(name, legs, weight) { }
        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }
    }
}