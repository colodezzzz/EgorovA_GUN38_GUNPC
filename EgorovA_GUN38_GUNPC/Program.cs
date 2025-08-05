using System;

namespace EgorovA_GUN38_GUNPC
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }
    }

    class Unit
    {
        public readonly string Name;
        public float Health => _health;
        public int Damage { get; private set; } = 5;
        public float Armor { get; private set; } = 0.6f;

        private float _health;

        public Unit() : this("Unknown") { }

        public Unit(string name)
        {
            Name = name;
        }

        public float GetReaHealth()
        {
            return _health * (1f + Armor);
        }

        public bool SetDamage(float damage)
        {
            _health = _health - damage * Armor;

            return _health <= 0f;
        }
    }
}
