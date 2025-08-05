using System;

namespace EgorovA_GUN38_GUNPC.Task5
{
    class Task5
    {
    }

    class DebugMessage
    {
        private static ConsoleColor DefaultColor = ConsoleColor.White;
        private static ConsoleColor ErrorColor = ConsoleColor.Red;
        private static ConsoleColor WarningColor = ConsoleColor.Yellow;

        public static void PrintErrorMessage(string text)
        {
            Console.ForegroundColor = ErrorColor;
            PrintMessage(text);
        }

        public static void PrintWarningMessage(string text)
        {
            Console.ForegroundColor = WarningColor;
            PrintMessage(text);
        }

        private static void PrintMessage(string text)
        {
            Console.WriteLine(text);
            Console.ForegroundColor = DefaultColor;
        }
    }

    class Unit
    {
        public readonly string Name;
        public float Health => _health;
        public int Damage => _damageInterval.Get;
        public float Armor { get; private set; } = 0.6f;

        private float _health;
        private Interval _damageInterval;

        public Unit() : this("Unknown") { }

        public Unit(string name) : this(name, 0, 5) { }

        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            _damageInterval = new Interval(minDamage, maxDamage);
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

    class Weapon
    {
        public readonly string Name;
        public readonly float Durability;

        private Interval _damageInterval;

        public Weapon() : this("Unknown") { }

        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage)
        {
            
            if (minDamage > maxDamage)
            {
                int temp = minDamage;
                minDamage = maxDamage;
                maxDamage = temp;

                DebugMessage.PrintWarningMessage($"Некорректные входные данные оружия {Name}!");
            }

            if(minDamage < 1)
            {
                minDamage = 1;

                DebugMessage.PrintWarningMessage($"Минимальный урон был приведён к минимальному значению (1)!");
            }

            if (maxDamage <= 1)
            {
                maxDamage = 10;
            }

            _damageInterval = new Interval(minDamage, maxDamage);
        }

        public int GetDamage()
        {
            return (_damageInterval.Min + _damageInterval.Max) / 2;
        }
    }

    struct Interval
    {
        public int Min { get; private set; }
        public int Max { get; private set; }

        public int Get
        {
            get
            {
                Random rnd = new Random();
                return rnd.Next(Min, Max);
            }
        }

        public Interval(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;

                DebugMessage.PrintWarningMessage("Некорректные входные данные!");
            }

            if (minValue < 0)
            {
                minValue = 0;
                DebugMessage.PrintWarningMessage("Некорректные входные данные!");
            }

            if (maxValue < 0)
            {
                maxValue = 0;
                DebugMessage.PrintWarningMessage("Некорректные входные данные!");
            }

            if (minValue == maxValue)
            {
                maxValue += 10;
                DebugMessage.PrintWarningMessage("Некорректные входные данные!");
            }

            Min = minValue;
            Max = maxValue;
        }
    }

    struct Room
    {
        public Unit Unit { get; private set; }
        public Weapon Weapon { get; private set; }

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }

    class Dungeon
    {
        private Room[] _rooms;

        public Dungeon()
        {
            _rooms = new Room[3]
            {
                new Room(
                    new Unit("Monster 1"),
                    new Weapon("Knife")
                ),

                new Room(
                    new Unit("Monster 2"),
                    new Weapon("Sword")
                ),

                new Room(
                    new Unit("Monster 3"),
                    new Weapon("Axe")
                ),
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < _rooms.Length; i++) // поле типа Room[]
            {
                var room = _rooms[i];

                Console.WriteLine("Unit of room: " + room.Unit.Name);
                Console.WriteLine("Weapon of room: " + room.Weapon.Name);
                Console.WriteLine("—-------------------");
            }
        }
    }
}
