using System;

namespace Adventure
{
    class Knight : ICharacter
    {
        public int Health { get; set; }

        public Knight(int startHealth = 250)
        {
            this.Health = startHealth;
        }

        public void Attack(Dragon dragon)
        {
            dragon.Health -= 60;
            GameManager.DragonScore -= 75;
            GameManager.HumanScore += 100;
        }

        public void Damage(int damage)
        {
            Health -= damage;
        }

        public void Action()
        {
            Console.WriteLine("Save princess");
        }

        public void Heal()
        {
            Health += 25;
        }

    }
}
