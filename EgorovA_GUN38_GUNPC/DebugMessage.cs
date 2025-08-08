using System;

namespace EgorovA_GUN38_GUNPC.DebugMessages
{
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
}
