namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"
            };

            grover.Sound = "Bark";
            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");
            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wf",
                Sound2 = "Brk"
            };
            spot.MakeSound();

        }

        
    }
}
