using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
        class Animal
        {   //When we set name and sound as private they can only be accessed through get and set
            private string name;
            private string sound;
            public static int numOfAnimals = 0;
            public const string SHELTER = "Nick's Home for Animals";

            //readonly value cannot be changed
            public readonly int idNum;

            public Animal() : this("No name", "No sound") { }
            
            public Animal(string name) : this(name, "No sound") { }

            public Animal(string name, string sound)
            {
                SetName(name);
                Sound = sound;

                NumOfAnimals = 1;
                Random rnd = new Random(); 
                idNum= rnd.Next(1, 2147483640);
            }
            
            
            public void MakeSound()
            {
                Console.WriteLine("{0} says {1}", name, sound);
            }
            
            public static int GetNumAnimals()
            {
                return numOfAnimals;
            }

            public void SetName(string name)
            {
                if (!name.Any(char.IsDigit)) 
                {
                    this.name = name;
                }
                else
                {
                    this.name = "No name";
                    Console.WriteLine("Name can't contain numbers");
                }
            }
            public string GetName()
            {
                return name;
            }

            public string Sound
            {
                get { return sound; }
                set 
                {
                    if(value.Length > 10)
                    {
                        sound = "No sound";
                        Console.WriteLine("Sound is too long");
                    }
                    else
                    {
                        sound = value;   
                    }
                }
            }

            public string Owner { get; set; } = "No Owner";
            
            public static int NumOfAnimals
            {
                get { return numOfAnimals; }
                set { numOfAnimals += value; }
            }
        }  
}
