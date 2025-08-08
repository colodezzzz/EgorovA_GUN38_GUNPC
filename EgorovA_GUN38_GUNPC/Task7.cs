using System.Text;
using EgorovA_GUN38_GUNPC.DebugMessages;

namespace EgorovA_GUN38_GUNPC.Task7
{
    class Task7
    {

    }

    class Methods
    {
        // Задание 1
        public static string ConcatenateStrings(string s1, string s2)
        {
            return s1 + s2;
        }

        // Задание 2 - По заданию не ясно, выводить новую строку или возвращать
        public static string GreetUser(string name, int age)
        {
            string result = $"Hello, {name}!\nYou are {age} years old.";
            return result;
        }

        // Задание 3
        public static string GetStringInfo(string s)
        {
            string info = $"Количество символов: {s.Length}\n" +
                $"Строка в верхнем регистре: {s.ToUpper()}\n" +
                $"Строка в нижнем регистре: {s.ToLower()}\n";

            return info;
        }

        // Задание 4
        public static string GetFirstFiveChars(string s)
        {
            if (s.Length < 5)
            {
                DebugMessage.PrintWarningMessage("String has less than 5 chars. Base string return.");
                return s;
            }

            return s.Substring(0, 5);
        }

        // Задание 5
        public static StringBuilder MakeSentence(string[] s)
        {
            StringBuilder builder = new StringBuilder();

            if (s.Length > 0)
            {
                foreach (string str in s)
                {
                    builder.Append(str);
                    builder.Append(" ");
                }

                builder.Remove(builder.Length - 1, 1);
            }

            return builder;
        }

        // Задание 6
        public static string Replace(string text, string findWord, string replaceWord)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(text);
            builder.Replace(findWord, replaceWord);

            return builder.ToString();
        }
    }
}
