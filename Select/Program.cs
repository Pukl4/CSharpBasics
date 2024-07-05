namespace Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oneToTen = new List<int>();
            oneToTen.AddRange(Enumerable.Range(1, 10));

            //Select composes each element of the sequence to a new form
            var squares = oneToTen.Select(x => x * x);
            foreach ( var square in squares) Console.WriteLine(square);

            // Zip is used for applying function to elements of two sequences
            // producing the sequence of the result
            var listOne = new List<int>(new int[] {1, 3, 4});
            var listTwo = new List<int>(new int[] {4, 6, 8});
            var sumList = listOne.Zip(listTwo,(x,y) => x + y).ToList();
            foreach(var item in sumList) Console.WriteLine(item);

            

            
           


        }
    }
}
