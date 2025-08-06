using System;
using System.Collections.Generic;
using System.Security.Permissions;
using EgorovA_GUN38_GUNPC.Task5;

namespace EgorovA_GUN38_GUNPC.Task6
{
    class Task6
    {
        public static bool CanExit()
        {
            Console.Write("\nEnter 'exit' to stop, another text to continue: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Program has finished.");
                return true;
            }

            return false;
        }
    }

    class One
    {
        public void TaskLoop()
        {
            List<string> strings = new List<string>() { "Hello", "I", "Love", "Games" };

            string userInput;
            bool isWorking = true;

            while (isWorking)
            {
                Console.Write("Enter new string: ");
                userInput = Console.ReadLine();

                strings.Add(userInput);

                Console.WriteLine("\nString:");
                foreach (string s in strings)
                {
                    Console.WriteLine(s);
                }

                Console.Write("\nEnter another string: ");
                userInput = Console.ReadLine();

                strings.Insert(strings.Count / 2, userInput);

                isWorking = Task6.CanExit() == false;
            }
        }
    }

    class Two
    {
        public void TaskLoop()
        {
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                { "Volkov", 5 },
                { "Gobozov", 2 },
                { "Ivanova", 4 },
                { "Gudin", 4 },
                { "Popova", 3 },
            };

            string secondName;
            int mark;
            bool isWorking = true;

            while (isWorking)
            {
                Console.Write("Enter a student second name: ");
                secondName = Console.ReadLine();

                Console.Write($"Enter {secondName}'s mark: ");

                if (int.TryParse(Console.ReadLine(), out mark))
                {
                    if (mark >= 2 && mark <= 5)
                    {
                        students.Add(secondName, mark);
                    }
                    else
                    {
                        PrintMarkError();
                    }
                }
                else
                {
                    PrintMarkError();
                }

                Console.Write("Enter a student second name to find his mark: ");
                secondName = Console.ReadLine();

                if (students.TryGetValue(secondName, out mark))
                {
                    Console.WriteLine($"{secondName}'s mark is {mark}.");
                }
                else
                {
                    PrintSecondNameError();
                }

                isWorking = Task6.CanExit() == false;
            }
        }

        private void PrintMarkError()
        {
            DebugMessage.PrintErrorMessage("Incorrect mark! Student will not added!");
        }

        private void PrintSecondNameError()
        {
            DebugMessage.PrintWarningMessage("No one student with this second name.");
        }
    }

    class Three
    {
        class Node
        {
            public int Value;
            public Node Next;
            public Node Prev;
        }

        public void TaskLoop()
        {
            Node node1, node2, node3, node;

            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Enter 3 integeres:");

                node1 = new Node() { Value = int.Parse(Console.ReadLine()), Prev = null };

                node2 = new Node() { Value = int.Parse(Console.ReadLine()), Prev = node1 };
                node1.Next = node2;

                node3 = new Node() { Value = int.Parse(Console.ReadLine()), Prev = node2, Next = null };
                node2.Next = node3;

                Console.WriteLine("\nStraight order:");
                node = node1;

                do
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;
                } while (node != null);

                Console.WriteLine("\nReversed order:");
                node = node3;

                do
                {
                    Console.WriteLine(node.Value);
                    node = node.Prev;
                } while (node != null);

                isWorking = Task6.CanExit() == false;
            }
        }
    }
}
