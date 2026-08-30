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

            // TwoDimensional array initialization
            // [1] [2]
            // [3] [4]
            int[,] twoDimArray = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(twoDimArray[1, 0]);
            twoDimArray[1, 0] = 5;
            Console.WriteLine(twoDimArray[1, 0]);

            //Jagged arrays is an arrays of arrays, each element in the main array can hold a different number of elements
            //Basic declaration:
            //int[][] jaggedArray;

            //Initialization:
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        }
    }
}
