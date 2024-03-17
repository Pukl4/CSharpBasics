namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logical operators : &&(and) ||(or) !(not)
            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Elementary school");
            }
            if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Middle school");
            }
            if ((age > 13) && (age < 19))
            {
                Console.WriteLine("High school");
            }
            else { Console.WriteLine("College"); }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("Shouldnt work");
            }
            Console.WriteLine("! true=" + (!true));

            // ternary operators are used to assign a
            // value to a variable based on a condition
            // The syntax is:
            // variable = (condition) ? expressionTrue : expressionFalse;

            int x = 10;
            string result = x > 5
                ? "x is greater than 5"
                : "x is less than 5";
            Console.WriteLine(result);

            // The switch statement is used to select one of
            // many code blocks to be executed.
            // The switch expression is used to select one of
            // many code blocks to be executed.

            int dayOfWeek = 4;
            switch (dayOfWeek)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Week Day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            // Switch expression
            string dayOfWeekName = "Haha";
            string res = dayOfWeekName switch
            {
                "Monday" => "First day of the week",
                "Tuesday" => "Second day of the week",
                "Wednesday" => "Third day of the week",
                "Thursday" => "Fourth day of the week",
                "Friday" => "Fifth day of the week",
                "Saturday" => "Sixth day of the week",
                "Sunday" => "Seventh day of the week",
                _ => "Invalid day"
            };
            Console.WriteLine(res);



        }
    }
}