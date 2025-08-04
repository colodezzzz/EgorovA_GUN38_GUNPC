using System;

namespace EgorovA_GUN38_GUNPC
{
    class Task2
    {
        static void Func(string[] args)
        {
            // Задача А
            // Задание 1
            int[] mas1 = new int[8];
            mas1[0] = 0;
            mas1[1] = 1;

            for (int i = 2; i < mas1.Length; i++)
            {
                mas1[i] = mas1[i - 1] + mas1[i - 2];
            }

            // Задание 2
            string[] mas2 = new string[] {
                "January", "February",
                "March", "April", "May",
                "June", "July", "August",
                "September", "October", "November",
                "December"
            };

            // Задание 3
            int[,] mas3 = new int[3, 3];

            for (int i = 0; i < mas3.GetLength(0); i++)
            {
                for (int j = 0; j < mas3.GetLength(1); j++)
                {
                    mas3[i, j] = 1;

                    for (int k = 0; k <= i; k++)
                    {
                        mas3[i, j] *= (j + 2);
                    }
                }
            }

            // Задание 4
            double[][] mas4 = new double[3][];

            mas4[0] = new double[5];
            mas4[1] = new double[] { Math.E, Math.PI };
            mas4[2] = new double[4];

            for (int i = 0; i < mas4[0].Length; i++)
            {
                mas4[0][i] = i + 1;
            }

            for (int i = 0; i < mas4[2].Length; i++)
            {
                mas4[2][i] = Math.Log10(Math.Pow(10, i));
            }

            // Задача Б
            // Задание 5
            Array.Copy(mas1, mas2, 3);

            // Задание 6
            Array.Resize(ref mas1, mas1.Length * 2);

            Console.ReadKey();
        }
    }
}
