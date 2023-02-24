using System;

namespace Remove_First_and_Last_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove_char("pisiun malenkiy"));
        }
        public static string Remove_char(string s)
        {
            string val = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && i != s.Length - 1)
                {
                    val += s[i];
                }
            }
            return val;
        }
    }
}
