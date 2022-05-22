using System;
using System.Text;

namespace Csharp_Censored_Strings
{
    class Program
    {
        private static void Main(string[] args)
        {
            program();
        }
        public static void program()
        {
            try { 
            Console.WriteLine("Enter Censored String");
            string censored_string = Console.ReadLine();
            Console.WriteLine("Enter the Lost Vowels");
            string lost_vowels = Console.ReadLine();
            censored(censored_string, lost_vowels);
            Console.ReadLine();
            }
            catch (Exception x)
            {
            program();
            }
        }
        public static void censored(string censored_string, string lost_vowels)
        {
            StringBuilder sb_censored_string = new StringBuilder(censored_string);
            int censored_string_length = censored_string.Length;
            int lost_vowels_count = 0;
            for (int it = 0; it < censored_string_length; it++)
            {
                string asterisk = "*";
                if(sb_censored_string[it] == asterisk[0])
                {
                    sb_censored_string[it] = lost_vowels[lost_vowels_count];
                    lost_vowels_count = lost_vowels_count + 1;
                }
            }
            Console.WriteLine(sb_censored_string.ToString());
        }
    }
}