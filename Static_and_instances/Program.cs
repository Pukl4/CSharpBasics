namespace Static_and_instances
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static is a modifier that makes a member belong to a type, rather than an "instance" of a type
            //We cant make an instance of MyStaticClass becuse it is static

            // MyStaticClass myStaticClas =new MyStaticClass(); // will not work 
            // Static class cannot have instance members, so anything inside of a static class must also be static
            MyStaticClass.MyStaticMethod();
            Console.WriteLine("______________________________");
            //We dont need to make an instance of MyStaticClass in order to call MyStaticMethod
            MyNonStaticClass myNonStaticClass1 = new MyNonStaticClass();
            MyNonStaticClass myNonStaticClass2 = new MyNonStaticClass();

            Console.WriteLine("Before mutating properties on MyNonStaticClass");
            myNonStaticClass1.MyInstanceMethod();
            myNonStaticClass2.MyInstanceMethod();
            MyNonStaticClass.MyStaticMethod();

            myNonStaticClass1.MyInstanceProperty = "Learning";
            myNonStaticClass2.MyInstanceProperty = "Basics";
            MyNonStaticClass.MyStaticProperty = "Nikita Programmer";


            Console.WriteLine("______________________________");
            Console.WriteLine("After mutating properties on MyNonStaticClass");
            myNonStaticClass1.MyInstanceMethod();
            myNonStaticClass2.MyInstanceMethod();
            MyNonStaticClass.MyStaticMethod();
        }

            static class MyStaticClass
            {
                public static void MyStaticMethod()
                {
                    Console.WriteLine("I am a static method");
                }
            }

    }
    class MyNonStaticClass
    {
        public string MyInstanceProperty { get; set; } = "Nikita";
        public static string MyStaticProperty { get; set; } = "Programmer";
        public static void MyStaticMethod()
        {
            Console.WriteLine($"The static property value is: {MyStaticProperty}");
            //this will not work because MyInstance property is not static
            //Console.WriteLine($"The instance property value is {MyInstanceProperty}");
        }

        public void MyInstanceMethod()
        {
            Console.WriteLine($"The static property value is: {MyStaticProperty}");
            Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
        }
    }
    
}
