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


            Console.WriteLine(" ");
            
            
            var numList = new List<int>(new int[] {1,2,3,4,5});

            //Aggregate applies a function over a sequence
            Console.WriteLine("Sum {0} ", numList.Aggregate((a,b) => a + b));

            // Average computes the average of the sequence
            Console.WriteLine("Avg {0}", numList.Average());

            // All returns bool if all elements of the sequence match the condition
            Console.WriteLine("All > 3 : {0}", numList.All(x => x > 3));

            // Any returns bool if any element match the condition
            Console.WriteLine("Any > 3 : {0}", numList.Any(x => x > 3));

            
            var numList2 = new List<int>() { 1, 3, 3, 2, 3 };
            var numList3 = new List<int>() { 3 };
            Console.WriteLine("Distinct : {0}", string.Join(", ", numList2.Distinct()));  
            Console.WriteLine("Except : {0}", string.Join(", ",numList2.Except(numList3)));
            Console.WriteLine("Intersect : {0}", string.Join(", ", numList2.Intersect(numList3)));


            

            
           


        }
    }
}
