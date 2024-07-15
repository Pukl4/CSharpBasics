using System.Collections;

namespace BasicLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new[]
            {
                new Animal{Name = "Heidi", Height = .8, Weight = 18, AnimalID = 1},
                new Animal{Name = "Bulk", Height = 4, Weight = 130, AnimalID = 2},
                new Animal{Name = "Congo", Height = 3.8, Weight = 90, AnimalID = 3},
            };

            var famAnimalEnum = animals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach (var animal in smAnimals)
            {
                Console.WriteLine("{0} weighs {1} lbs", animal.Name, animal.Weight);
            }

            ArrayList animalList = new ArrayList()
            {
                new Animal{Name = "German SHepard", Height = 25, Weight = 77},
                new Animal{Name = "Chihuahua", Height = 7, Weight = 4.4},
                new Animal{Name = "Bernard", Height = 30, Weight = 200},
            }; 

            var animalListEnum = animalList.OfType<Animal>();

            var bigDogs = from dog in animalListEnum
                          where (dog.Weight > 70) &&
                          (dog.Height > 25)
                          orderby dog.Name
                          select dog;
            foreach (var animal in bigDogs)
            {
                Console.WriteLine("{0} weighs {1} lbs", animal.Name, animal.Weight);
            }

            Owner[] owners = new[]
            {
                new Owner{Name = "Doug Parks", OwnerID = 1},
                new Owner{Name = "Sally Smith", OwnerID = 2},
                new Owner{Name = "Paul Brooks", OwnerID = 3},
            };

            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height,
                             };

            Array arrNameHeight = nameHeight.ToArray();

            var innerjoin = 
                from animal in animals
                join owner in owners on animal.AnimalID
                equals owner.OwnerID
                select new { OwnerName = owner.Name, AnimalName = animal.Name };

            var groupJoin =
                from owner in owners
                orderby owner.OwnerID
                join animal in animals on owner.OwnerID
                equals animal.AnimalID into ownerGroup
                select new
                {
                    Owner = owner.Name,

                    Animals = from owner2 in ownerGroup
                              orderby owner2.Name
                              select owner2
                };

            int totalAnimals = 0;

            foreach (var i in innerjoin)
            {
                Console.WriteLine("{0} owns {1}", i.OwnerName, i.AnimalName);
            }

            Console.WriteLine();

            foreach (var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach (var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine("* {0}", animal.Name);
                }
            }
        } 
    }
}
