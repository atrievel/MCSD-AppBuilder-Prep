using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class DogQueryGenerator
    {
        private List<Dog> dogs;
        private List<Breed> breeds;
        internal DogQueryGenerator()
        {
            this.dogs = new List<Dog>()
            {
                new Dog()
                {
                    Name = "Laika the Space Dog",
                    Breed = "East Siberian Laika"
                },
                new Dog("Rin Tin Tin", "German Shepard"),
                new Dog("Cujo", "Saint Bernard"),
                new Dog("Balto", "Siberian Husky"),
                new Dog()
                {
                    Name = "Old Yeller",
                    Breed = "Labrador Retriever"
                }
            };

            this.breeds = new List<Breed>()
            {
                new Breed()
                {
                    BreedId = 1,
                    BreedName = "East Siberian Laika"
                },
                new Breed()
                {
                    BreedId = 2,
                    BreedName = "German Shepard"
                },
                new Breed()
                {
                    BreedId = 5,
                    BreedName = "Labrador Retriever"
                }
            };
        }

        internal List<string> ProjectDogName()
        {
            return this.dogs
                .OrderBy(d => d.Name)
                .Select(d => d.Name)
                .ToList();
        }

        internal IEnumerable<dynamic> JoinDogsAndBreeds()
        {
            return this.dogs
                .Join(this.breeds,
                    d => d.Breed,
                    b => b.BreedName,
                    (d, b) => new
                        {
                            DogName = d.Name,
                            DogBreed = b.BreedName,
                            DogBreedId = b.BreedId
                        });
        }

        internal List<Breed> TakeBreeds(int take)
        {
            return this.breeds
                .Take(take)
                .ToList();
        }

        internal List<Breed> SkipBreeds(int skip)
        {
            return this.breeds
                .Skip(skip)
                .ToList();
        }

        internal decimal AggregateAverageNameLengths()
        {
            return this.dogs
                    .Aggregate(
                        0,
                        (result, d) => result + d.Name.Length,
                        result => (decimal)result / this.dogs.Count
                    );
        }
    }
}