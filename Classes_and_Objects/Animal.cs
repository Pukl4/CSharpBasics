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
            protected string sound;
            protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();
            public void SetAnimalIDInfo(int idNum, string owner)
            {
                animalIDInfo.IDNum = idNum;
                animalIDInfo.Owner = owner;
            }

            public void GetAnimalIDInfo()
            {
                Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
            }

            public virtual void MakeSound()
            {
                Console.WriteLine($"{name} says {sound}");
            }

            public Animal() : this("No name", "No sound") { }
            
            public Animal(string name) : this(name, "No sound") { }

            public Animal(string name, string sound)
            {
                Name = name;
                Sound = sound;
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (value.Any(char.IsDigit))
                    {
                        name = "No Name";

                    }
                    name = value;
                }
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

            public class AnimalHealth
            {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
            }
        }  
}
