using System;

namespace Adventure
{
    class Dragon
    {
        public int Health { get; set; }

        public Dragon(int startHealth = 1000)
        {
            this.Health = startHealth;
        }
           

        public void Attack(ICharacter character)
        {
            if (character != null)
            {
                int damage = 0;

                if (character is Farmer)
                {
                    damage = 25;
                    GameManager.DragonScore += 50;
                    GameManager.HumanScore -= 50;
                }
                else if (character is Knight)
                {
                    damage = 50;
                    GameManager.DragonScore += 150;
                    GameManager.HumanScore -= 150;
                }

                character.Damage(damage);
            }
            else
                throw new NotImplementedException();
        }

        public void Action()
        {
            Console.WriteLine("Kidnap princess");
        }

        public void Heal()
        {
            Health += 25;
        }
    }
}
