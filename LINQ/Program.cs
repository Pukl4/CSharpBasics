
namespace LINQ
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string[] dogs = {"K 9", "Brian Griffin", "Scooby Doo", "Old Yeller",
                             "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie"};

            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog ascending select dog;

            foreach (var i in dogSpaces) 
            {
                Console.WriteLine(i);
            }

            int[] intArray = QueryIntArray();
            foreach (int num in intArray)
            {
                Console.WriteLine(num);
            } 
        }
        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            var gt20 = from num in nums where num > 20 orderby num select num;

            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"Get Type : {gt20.GetType()}");

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;
            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }
            return arrayGT20;
        }
    }
}
