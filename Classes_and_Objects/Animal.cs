using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
        class Animal
        {
            public string name;
            public string sound;
            static int numOfAnimals = 0;

            public Animal()
            {
                name = "No Name";
                sound = "No sound";
                
            }

            //If name is provided and sound is not
            public Animal(string name = "No name")
            {
                // Keyword "This" refers to the object's name
                this.name = name;
                this.sound = "No sound";
                numOfAnimals++;
            }

            public Animal(string name = "No name", string sound = "No sound") : this(name)
            {
                this.name = name;
                this.sound = sound;
                numOfAnimals++;
            }

            public void MakeSound()
            {
                Console.WriteLine("{0} says {1}", name, sound);
            }
            
            public static int GetNumAnimals()
            {
                return numOfAnimals;
            }

        }  
}
