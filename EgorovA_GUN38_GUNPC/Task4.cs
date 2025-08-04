
namespace EgorovA_GUN38_GUNPC.Task4
{
    class Task4
    {
    }

    class Unit
    {
        public string Name { get; private set; }
        public float Health { get; private set; }
        public int Damage { get; private set; } = 5;
        public float Armor { get; private set; } = 0.6f;

        public Unit() : this("Unknown") { }

        public Unit(string name)
        {
            Name = name;
        }

        public float GetReaHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(float damage)
        {
            Health = Health - damage * Armor;

            return Health <= 0f;
        }
    }
}
