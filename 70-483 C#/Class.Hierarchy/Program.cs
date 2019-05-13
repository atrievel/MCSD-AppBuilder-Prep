using System;
using System.Collections.Generic;

namespace Class.Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 0;

            List<Cat> cats = new List<Cat>()
            {
                new Cat("Kitty", 4, 13f),
                new Cat("Whiskers", 3, 14f),
                new Cat("Garfield", 4, 100.0f)
            };

            cats.ForEach(cat =>
            {
                cat.HungerLevel = level;
                cat.SleepLevel = level;
                cat.ThirstLevel = level;

                Console.WriteLine(cat.GetOrganismInformation());
                cat.MakeNoise();
                cat.Eat(100);
                cat.Drink(50);
                cat.Sleep(20);

                if(cat.GetWeight() >= 100f)
                {
                    cat.Dispose();
                }

                level++;
            });
        }
    }
}
