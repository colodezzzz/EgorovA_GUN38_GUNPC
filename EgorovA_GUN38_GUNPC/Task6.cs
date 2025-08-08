using System;
using System.Collections.Generic;
using EgorovA_GUN38_GUNPC.DebugMessages;

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

                if (students.TryGetValue(secondName, out _) == false)
                {
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
                }
                else
                {
                    DebugMessage.PrintErrorMessage("Can't add student! Such a student already exists!");
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
            public int Value = 0;
            public Node Next = null;
            public Node Prev = null;
        }

        public class OwnList
        {
            private int _size = 0;
            private Node _firstNode = null;
            private Node _lastNode = null;

            public OwnList()
            {

            }

            public OwnList(int size)
            {
                if (size < 0)
                {
                    DebugMessages.DebugMessage.PrintErrorMessage("Incorrect size! Size must be greater then 0!");
                }

                if (size == 0)
                {
                    return;
                }

                _size = size;
                _firstNode = new Node();
                Node node = _firstNode;

                int i = 0;

                while (i < size-1)
                {
                    node.Next = new Node() { Prev = node };
                    node = node.Next;
                    i++;
                }
            }

            public void Add(int value)
            {
                if (_firstNode == null)
                {
                    _firstNode = new Node() { Value = value};
                    _lastNode = _firstNode;
                    _size = 1;
                    return;
                }

                _lastNode.Next = new Node() { Value = value, Prev = _lastNode };
                _lastNode = _lastNode.Next;
                _size++;
            }

            public int Get(int index)
            {
                Node node = GetNode(index);

                if (node != null)
                {
                    return node.Value;
                }

                PrintIndexError();
                return -1;
            }

            public void Set(int index, int value)
            {
                Node node = GetNode(index);

                if (node != null)
                {
                    node.Value = value;
                }
                else
                {
                    PrintIndexError();
                }
            }

            public void PrintStraightList()
            {
                Node node = _firstNode;

                while (node != null)
                {
                    Console.Write($"{node.Value} ");
                    node = node.Next;
                }

                Console.WriteLine();
            }

            public void PrintReversedList()
            {
                Node node = GetNode(-1);

                while (node != null)
                {
                    Console.Write($"{node.Value} ");
                    node = node.Prev;
                }

                Console.WriteLine();
            }

            private Node GetNode(int index)
            {
                if (IsIndexCorrect(index, out index))
                {
                    Node node = null;
                    int i;

                    if (index >= _size / 2)
                    {
                        i = _size - 1;
                        node = _lastNode;

                        while (i > index)
                        {
                            node = node.Prev;
                            i--;
                        }
                    }
                    else
                    {
                        i = 0;
                        node = _firstNode;

                        while (i < index)
                        {
                            node = node.Next;
                            i++;
                        }
                    }

                    return node;
                }

                return null;
            }

            private void PrintIndexError()
            {
                DebugMessage.PrintErrorMessage("Incorrect index! Index can't be greater than size - 1 or less than -size!");
            }

            private bool IsIndexCorrect(int index, out int correctIndex)
            {
                correctIndex = index;

                if (correctIndex < 0)
                {
                    correctIndex = _size + correctIndex;
                }

                if (_size < 0 || correctIndex > _size - 1)
                {
                    return false;
                }

                return true;
            }
        }

        public void TaskLoop()
        {
            OwnList nodes;

            int size;
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Enter a list size (3-6): ");

                if (int.TryParse(Console.ReadLine(), out size) && size >= 3 && size <= 6)
                {
                    nodes = new OwnList();

                    int i = 0;

                    Console.WriteLine($"Enter an {size} integers:");

                    while (i < size)
                    {
                        if (int.TryParse(Console.ReadLine(), out int value))
                        {
                            nodes.Add(value);
                        }
                        else
                        {
                            nodes.Add(0);
                            DebugMessage.PrintWarningMessage("Input is incorrect. The value is set to default (0).");
                        }

                        i++;
                    }

                    nodes.PrintStraightList();
                    nodes.PrintReversedList();
                }
                else
                {
                    DebugMessage.PrintErrorMessage("Size is incorrect!");
                }

                isWorking = Task6.CanExit() == false;
            }
        }
    }
}
