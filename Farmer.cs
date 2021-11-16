using System;

namespace Adventure
{
    class Farmer : ICharacter
    {
        public int Health { get ; set; }

        public Farmer(int startHealth = 100)
        {
            this.Health = startHealth;
        }

        public void Attack(Dragon dragon)
        {
            dragon.Health -= 15;
            GameManager.DragonScore -= 20;
            GameManager.HumanScore += 35;
        }

        public void Damage(int damage)
        {
            Health -= damage;
        }

        public void Action()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            Health += 25;
        }   
    }
}
