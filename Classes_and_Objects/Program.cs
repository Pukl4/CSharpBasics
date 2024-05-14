namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat's name is {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Derek";
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of animals : {0}", Animal.NumOfAnimals);
        }

        
    }
}
