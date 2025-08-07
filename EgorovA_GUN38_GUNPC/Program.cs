using System;
using EgorovA_GUN38_GUNPC.Task6;

namespace EgorovA_GUN38_GUNPC
{
    class Program
    {
        static void Main(string[] args)
        {
            One one = new One();
            one.TaskLoop();

            Two two = new Two();
            two.TaskLoop();

            Three three = new Three();
            three.TaskLoop();

            Console.ReadKey();
        }
    }
}
