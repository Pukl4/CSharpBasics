namespace Arrays
{
    internal class Program
    {   /*Static means we dont need to create a new object for class program in order to call this function 
        void means function wont return any value 
        static void "Name of the function" ("Data type of the array" "Parameters that passed to a function", "Output" ) */
        static void PrintArray(int[] intArray, string message)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", message, i);
            }
        }
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 23;
            Console.WriteLine("nums 0 : {0}", nums[0]);
            string[] customers = { "Nikita", "Pasha", "Egor" };

            //while using var, data must be the same type
            var employees = new[] { "Nick", "Pavel", "George" };

            //for creating array with random data types
            object[] randomArray = { "Nick", "45", "1.45" };

            //"GetType" for getting data type of specific index
            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            Console.WriteLine("randomArray length : {0}", randomArray.Length);

            for (int l = 0; l < randomArray.Length; l++)
            {
                Console.WriteLine("Array : {0} : Value : {1}",
                    l, randomArray[l]);
            }
            //Multidimensional array, first = rows, second = columns
            string[,] Names = new string[2, 2] { { "Bob", "Smith" }, { "Bobby", "Smite" } };
            Console.WriteLine("MD Value : {0}", Names.GetValue(0, 0));

            for (int j = 0; j < Names.GetLength(0); j++)
            {
                for (int k = 0; k < Names.GetLength(0); k++)
                {
                    Console.WriteLine("{0}", Names[j, k]);
                }
                Console.WriteLine();
            }
            //Using function PrintArray(intArray=random, message="ForEach")
            int[] random = { 1, 2, 3, 4 };
            PrintArray(random, "ForEach");
            Console.WriteLine("-----------------");

            Array.Sort(random);
            Array.Reverse(random);
            Console.WriteLine("1 at index : {0}",
                Array.IndexOf(random, 1));
            random.SetValue(0, 1);
            int[] source = { 1, 2, 3 };
            int[] dest = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(source, startInd, dest, 0, length);
            PrintArray(dest, "Copy");

            //Another way to create array CreateInstance(typeof(data type), length)
            Array another = Array.CreateInstance(typeof(int), 10);
            source.CopyTo(another, 5);
            foreach (int m in another)
            {
                Console.WriteLine("CopyTo : {0}", m);
            }
        }

    }
}
