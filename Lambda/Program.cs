﻿namespace Lambda
{
    internal class Program
    {
        delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            //Lambda expression is used to create an anonymous function.
            //Lambda declaration operator =>
            doubleIt dbl = x => x * 2;
            Console.WriteLine($"5 * 2 = {dbl(5)}");

            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };

            // Where used for returning elements matching the condition
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var j in evenList) Console.WriteLine(j);

            var rangeList = numList.Where(x => (x > 2) & (x < 9)).ToList();
            foreach (var q in rangeList) Console.WriteLine(q);

            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }
            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count());

            var nameList = new List<string> { "Doug", "Sally", "Sue" };
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach(var name in sNameList)
            {
                Console.WriteLine(name);
            }

        }
    }
}
