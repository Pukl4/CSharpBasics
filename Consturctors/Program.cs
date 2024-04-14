using System.Security.Cryptography.X509Certificates;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructors are used to initialize a class

            
            
        }
        //This class still has a cinstractor even though we cant see it
        class ImplicitConstructor 
        {
        }

        //This is a parameterless constructor
        class ExplicitConstructor
        {
            public ExplicitConstructor()
            {
                Console.WriteLine("ExplicitConstructor constructor called");
            }
        }

        //This class has a constructor that takes in a value 
        class ConstructorWithParameter
        {
            public ConstructorWithParameter(string message)
            {
                Console.WriteLine(message);
            }
        }

        //This is a class with multiple constructors "chained" together by using :this()
        class MultipleConstructors
        {
            public MultipleConstructors()
                :this("This is a default message")
            {
            }
            public MultipleConstructors(string message)
            {
                Console.WriteLine(message);
            }
        }

        //Generally, we use constructors to initialize the class
        class CollectionOfWords
        {
            private List<string> _strings;

            public CollectionOfWords()
            {
                _strings = new List<string>();
            }
            public void Add(string word)
            {
                _strings.Add(word);
            }
            public void Print()
            {
                foreach (var word in _strings)
                {
                    Console.WriteLine(word);
                }
            }
        }
        

        class CollectionOfWords2
        {
            private List<string> _strings;

            public CollectionOfWords2(List <string> words)
            {
                _strings=new List<string>();

                foreach (var word in words)
                {
                    _strings.Add(word);
                }
            }

            public void Print()
            {
                foreach (var word in _strings)
                {
                    Console.WriteLine(word);
                }
            }
        }


        //We can have static constructors which will run the first time the type is used
        class StaticConstructor
        {
            static StaticConstructor()
            {
                Console.WriteLine("StaticConstructor constructor called");
            }
        }

        //We can also have private constructors to prevent certain access patterns for our class

        class OurClassWithAHiddenConstructor
        {
            public OurClassWithAHiddenConstructor(int value)
                :this()
            {
                Console.WriteLine(
                    $"This is the public constructor and" +
                    $"we received value {value}");
            }

            private OurClassWithAHiddenConstructor()
            {
                Console.WriteLine(
                    "Nobody can call this constructor" +
                    "directly from the outside");
            }
        }

    }
}
