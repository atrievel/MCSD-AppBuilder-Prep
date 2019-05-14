namespace LINQ
{
    internal class Dog
    {
        internal string Name { get; set; }
        internal string Breed { get; set; }

        internal Dog() { }
        internal Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
    }
}