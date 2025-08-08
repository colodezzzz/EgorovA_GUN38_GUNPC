using System;
using EgorovA_GUN38_GUNPC.Task7;

namespace EgorovA_GUN38_GUNPC
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine(Methods.ConcatenateStrings("Hello", " World"));

            // 2
            Console.WriteLine(Methods.GreetUser("Oleg", 22));

            // 3
            Console.WriteLine(Methods.GetStringInfo("Hello World"));

            // 4
            Console.WriteLine(Methods.GetFirstFiveChars("Hello World"));

            // 5
            Console.WriteLine(Methods.MakeSentence(new string[] { "Hello", " World" }));

            // 6
            Console.WriteLine(Methods.Replace("Hello World", "Hell", "Heaven"));

            Console.ReadKey();
        }
    }
}
