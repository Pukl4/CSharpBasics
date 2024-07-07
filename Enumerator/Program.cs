namespace Enumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm myAnimal = new AnimalFarm();
            myAnimal[0] = new Animal("Wilbur");
            myAnimal[1] = new Animal("Will");
            myAnimal[2] = new Animal("Charlie");
            foreach (Animal i in myAnimal)
            {
                Console.WriteLine(i.Name);
            }
            

        }
    }
}
