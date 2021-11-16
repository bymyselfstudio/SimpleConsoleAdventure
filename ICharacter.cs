namespace Adventure
{
    interface ICharacter
    {
        int Health { get; set; }

        void Attack(Dragon dragon);
        void Damage(int damage);
        void Action();
        void Heal();
    }
}
