using System;
using EgorovA_GUN38_GUNPC.Task6;

namespace EgorovA_GUN38_GUNPC
{
    class Program
    {
        static void Main(string[] args)
        {
            //One one = new One();
            //one.TaskLoop();

            //Two two = new Two();
            //two.TaskLoop();

            //Three three = new Three();
            //three.TaskLoop();

            Three.OwnList l = new Three.OwnList(0);

            l.PrintStraightList();

            l.Add(1);
            l.Add(32);
            l.Add(2);

            l.PrintStraightList();
            l.PrintReversedList();

            Console.ReadKey();
        }
    }
}
