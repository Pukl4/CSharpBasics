namespace DndHit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining stats for the player
            int constBuff = 5;
            int armorClass = 16;
            int health = 13;

            // Defining variables for each dice roll
            Random dice = new Random();
            int attack = dice.Next(1,21);
            int damage1 = dice.Next(1, 9);
            int damage2 = dice.Next(1, 9);
            int athleticsThrow = dice.Next(1, 21);
            int savingThrow = dice.Next(1, 21);

            // Checking for hit (attack > Armor class) = hit
            if (attack + 2 >= armorClass)
            {
                // Checking for damage and left health
                int leftHealth = health - (damage1 + damage2);
                if (leftHealth <= 0)
                {
                    Console.WriteLine("After the hit, you've lost consciousness");
                }
                // Checking for saving throw
                else if (athleticsThrow >= savingThrow + constBuff) 
                {
                    Console.WriteLine($"The blow has knocked you to the ground, your current health is {leftHealth} and you're skipping your turn");
                }
                else
                {
                    Console.WriteLine($"Your current health is {leftHealth}");
                }
            }
            else { Console.WriteLine("Your opponent missed, now is your chance"); }
        }
    }
}
