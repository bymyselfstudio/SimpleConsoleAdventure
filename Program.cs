using System;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager.DragonScore = 0;
            GameManager.HumanScore = 0;

            Dragon dragon = new Dragon();
            Knight knight = new Knight(140);
            Farmer farmer = new Farmer(90);

            farmer.Attack(dragon);
            knight.Attack(dragon);
            dragon.Attack(farmer);
            dragon.Attack(knight);
            
            Console.WriteLine("Health farmer: " + farmer.Health + " | Health knight: " + knight.Health);
            Console.WriteLine("Health dragon: " + dragon.Health);
            Console.WriteLine("HumanScore: " + GameManager.HumanScore + " | DragonScore: " + GameManager.DragonScore);

            Console.ReadKey();
        }
    }
}
