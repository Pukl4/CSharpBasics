namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring an array 
            int[] intArray = new int[5];

            // assigning value to an array
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;
            intArray[4] = 5;

            // indexes [0][1][2][3][4]
            // content [1][2][3][4][5]

            // declaring an array and set the array element values
            int[] decIntArray = [1, 12, 14, 16];
            string[] strArray = ["Monday", "Tueday", "Wednesday"];
            Console.WriteLine(strArray[0] + $" {decIntArray[3]}");

            // Length gets the total number of elements in array
            Console.WriteLine($"The length of the strArray is {strArray.Length}");

            foreach (int i in decIntArray)
            {
                Console.WriteLine(i);            
            }

            foreach (string i in strArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
