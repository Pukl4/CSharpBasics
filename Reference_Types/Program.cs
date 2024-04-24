
namespace Reference_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Making new instance
            OurClass our_object = new();
            our_object.ExampleMethod();

            int result = our_object.ExampleFunction();
            Console.WriteLine(result);

            AnotherClass object1 = new (); // new reference
            AnotherClass object2 = new();  // new reference
            AnotherClass object3 = object1; // same reference as object 1

            Console.WriteLine("object1 == object 2:");
            Console.WriteLine(object1 == object2); // false, they are the same type, but different instances
            Console.WriteLine("object3 == object 1:");
            Console.WriteLine(object3 == object1); // true, because object3 is not a new instance or copy,
                                                   // it is just a poingting variable

            //same for collections:
            List<int> Num1 = new List<int> { 1, 2, 3 };
            List<int> Num2 = new List<int> { 1, 2, 3 };
            Console.WriteLine("Num1 == Num2");
            Console.WriteLine(Num1 == Num2);

            void Changevalue(int value)
            {
                value = 42;// this variable only exist inside of this method, it is a copy of number
            }

            int myValue = 1337;
            Console.WriteLine("myValue before ChanngeValue");
            Console.WriteLine(myValue);
            
            Changevalue(myValue);
            Console.WriteLine("myValue after ChanngeValue");
            Console.WriteLine(myValue);

            void ChangeReference(List <string> words)
            {
                words.Add("from");
                words.Add("Dev");
                words.Add("Leader");
            }
            List <string> myWords = new List<string>{"Hello, World"};
            Console.WriteLine("myWords before");
            Console.WriteLine(string.Join(" ", myWords));//Hello,World
            ChangeReference(myWords);
            Console.WriteLine("myWords after");
            Console.WriteLine(string.Join(" ", myWords));//Hello,World from Dev Leader

            /* This is because when we pass a value type to a method
             * we're passing a copy of the value BUT when we pass a 
             * reference type to a method, we're passing a reference*/

        }

        //Defining Class
        public class OurClass
        {
            public void ExampleMethod() 
            {
                Console.WriteLine("Hello from our method");
            }

            public int ExampleFunction() 
            {
                return 42;
            }
        }
        public class AnotherClass
        {

        }
    }
}
