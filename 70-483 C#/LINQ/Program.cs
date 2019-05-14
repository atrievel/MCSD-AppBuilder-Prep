using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DogQueryGenerator queries = new DogQueryGenerator();

            Console.WriteLine("SELECT DOG NAMES");
            Console.WriteLine("----------------");
            queries.ProjectDogName()
                .ForEach(d => Console.WriteLine(d));

            Console.WriteLine("\nJOIN DOGS AND BREEDS");
            Console.WriteLine("--------------------");
            queries.JoinDogsAndBreeds()
                .ToList()
                .ForEach(d => Console.WriteLine($"{d.DogName} is a {d.DogBreed} with BreedId of {d.DogBreedId}"));

            Console.WriteLine("\nTAKE BREEDS");
            Console.WriteLine("------------");
            queries.TakeBreeds(2)
                .ForEach(b => Console.WriteLine(b.BreedName));

            Console.WriteLine("\nSKIP BREEDS");
            Console.WriteLine("------------");
            queries.SkipBreeds(2)
                .ForEach(b => Console.WriteLine(b.BreedName));

            Console.WriteLine("\nAGGREGATE AVERAGE DOG NAME LENGTH");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(queries.AggregateAverageNameLengths());
        }
    }
}
