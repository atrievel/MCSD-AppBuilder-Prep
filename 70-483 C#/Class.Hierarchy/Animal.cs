using System;
using System.Collections;

namespace Class.Hierarchy
{
    public class Animal : ILivingOrganism, IComparable, IDisposable
    {
        private float _hungerLevel;
        private float _thirstLevel;
        private float _sleepLevel;
        private string name;
        private int numberOfLegs = 0;
        private float weight = 0f;

        public float HungerLevel
        {
            get
            {
                return this._hungerLevel;
            }

            set
            {
                this._hungerLevel = value;
            }
        }

        public float ThirstLevel
        {
            get
            {
                return this._thirstLevel;
            }

            set
            {
                this._thirstLevel = value;
            }
        }

        public float SleepLevel
        {
            get
            {
                return this._sleepLevel;
            }

            set
            {
                this._sleepLevel = value;
            }
        }

        public Animal(string name, int legs, float weight)
        {
            this.name = name;
            this.numberOfLegs = legs;
            this.weight = weight;
        }

        public string GetOrganismInformation()
        {
            return $"{this.name} has {this.numberOfLegs} legs and weighs {this.weight} pounds";
        }

        public void Eat(int amount)
        {
            if(this._hungerLevel == 0)
            {
                Console.WriteLine($"{this.name} isn't hungry!");
            }
            else
            {
                this._hungerLevel -= amount;
                this.weight += amount;
            }
        }

        public void Drink(int amount)
        {
            if(this._thirstLevel <= 0)
            {
                Console.WriteLine($"{this.name} isn't thirsty!");
            }
            else
            {
                this._thirstLevel -= amount;
                this.weight += amount/4;
            }
        }

        public void Sleep(int amount)
        {
            if(this._sleepLevel <= 0)
            {
                Console.WriteLine($"{this.name} isn't sleepy!");
            }
            else
            {
                this._sleepLevel -= amount;
            }
        }

        public float GetWeight()
        {
            return this.weight;
        }
        public int CompareTo(object toCompare)
        {
            if (toCompare == null)
            {
                return 1;
            }

            Animal toCompareAsAnimal = toCompare as Animal;

            if (toCompareAsAnimal != null)
            {
                return this.weight.CompareTo(toCompareAsAnimal.weight);
            }
            else
            {
                throw new ArgumentException("toCompare is not of type Animal!");
            }
        }

        public void Dispose()
        {
            Console.WriteLine($"Oh no! {this.name} has died");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing) { }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Noise");
        }
    }

    public class Animals : IEnumerable
    {
        private Animal[] _animals;

        public Animals(Animal[] animals)
        {
            this._animals = new Animal[animals.Length];

            for (int i = 0; i < animals.Length; i++)
            {
                this._animals[i] = animals[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public AnimalEnum GetEnumerator()
        {
            return new AnimalEnum(_animals);
        }
    }

    public class AnimalEnum : IEnumerator
    {
        public Animal[] _animals;
        int position = -1;

        public AnimalEnum(Animal[] animals)
        {
            this._animals = animals;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _animals.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Animal Current
        {
            get
            {
                try
                {
                    return _animals[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}