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
            
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);
            Box box3 = box1 + box2;

            Console.WriteLine($"Box 3 : {box3}");
            Console.WriteLine($"Box int : {(int)box3}");
            Box box4 = (Box)4;

            var shopkins = new { Name = "Shopkins", Price = 4.99 };
            Console.WriteLine("{0} costs ${1}", shopkins.Name, shopkins.Price );

            var toyArray = new[]
            {
                new {Name = "Yo-kai Pack", Price = 4.99 },
                new {Name = "Lego", Price = 9.99 }
            };

            foreach (var item in toyArray)
            {
                Console.WriteLine("{0} costs ${1}", item.Name, item.Price);
            }
                
        }
    }
}
