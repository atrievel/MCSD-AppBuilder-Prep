namespace Class.Hierarchy
{
    public interface ILivingOrganism
    {
        float HungerLevel
        {
            get;
            set;
        }

        float ThirstLevel
        {
            get;
            set;
        }

        float SleepLevel
        {
            get;
            set;
        }

        string GetOrganismInformation();
        void Eat(int amount);
        void Drink(int amount);
        void Sleep(int amount);

        float GetWeight();
    }
}