using System;
using EgorovA_GUN38_GUNPC.Task5;

namespace EgorovA_GUN38_GUNPC
{
    class Program
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();

            Console.ReadKey();
        }
    }
}
