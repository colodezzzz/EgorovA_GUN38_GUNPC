using System;

namespace EgorovA_GUN38_GUNPC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");

            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Write("Enter second integer: ");

                if (int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.Write("Enter an operation (&, | or ^): ");

                    if (char.TryParse(Console.ReadLine(), out char op))
                    {
                        bool isValidOperation = true;
                        int result = 0;

                        switch (op)
                        {
                            case '&':
                                result = a & b;
                                break;

                            case '|':
                                result = a | b;
                                break;

                            case '^':
                                result = a ^ b;
                                break;

                            default:
                                isValidOperation = false;
                                Console.WriteLine("Error! You need to enter one of these characters: &, | or ^.");
                                break;
                        }

                        if (isValidOperation)
                        {
                            Console.WriteLine(
                                $"Result of {a} {op} {b}:\n" +
                                $"10: {Convert.ToString(result)}\n" +
                                $"2: {Convert.ToString(result, 2)}\n" +
                                $"16: {Convert.ToString(result, 16)}"
                                );
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! You need enter one character.");
                    }
                }
                else
                {
                    Console.WriteLine("Error! You need enter an integer.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error! You need enter an integer.");
                return;
            }

            Console.ReadKey();
        }
    }
}
