
using System;

namespace EgorovA_GUN38_GUNPC
{
    class Task3
    {
        static void Func(string[] args)
        {
            // 1
            for (int n1 = 0, n2 = 1, count = 0, n3 = 0; count < 10; n1 = n2, n2 = n3, count++, n3 = n1 + n2)
            {
                Console.WriteLine(n3);
            }


            // 2
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            // 3
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine();
            }

            // 4
            string password = "qwerty";
            string userEntry;

            do
            {
                userEntry = Console.ReadLine();
            }
            while (userEntry != password);

            Console.ReadKey();
        }
    }
}
