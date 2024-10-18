using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringMethods
{
    internal class Program
    {
         // 1. SPLIT()
        //static void Main(string[] args)
        //{

        //    string text = "Biz Code Academynin telebeleriyik";
        //    char[] seperators = new char[] { ' ', ' ', ' ' };
        //    string[] result = Split(text.ToCharArray(), seperators);

        //    foreach (var c in result)
        //    {
        //        Console.WriteLine(c);
        //    }
        //}
        //public static string[] Split(char[] text, char[] seperators)
        //{
        //    string cInput = new string(text);
        //    return cInput.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
        //}




        // 2. REPLACE()
        //static void Main(string[] args)
        //{
        //    string text = "Biz code Academynin telebeleriyik";
        //    char oldChar = 'c';
        //    char newChar = 'C';
        //    string result = Replace(text, oldChar, newChar);
        //    Console.WriteLine(result);  
        //}

        //public static string Replace(string text,char oldChar, char newChar)
        //{
        //    return text.Replace(oldChar, newChar);
        //}




        // 3. LASTINDEXOF()

        public static void Main(string[] args)
        {
            string text = "Bu gun cume gunudur, bu gun hava buludludur";
            char searchChar = 'u';
            int lastIndex = LastIndexOf(text, searchChar);

            if ( lastIndex != -1 )
            {
                Console.WriteLine($"{searchChar}");
            }
            else
            {
                Console.WriteLine($"'{searchChar}' tapilmadi ");
            }

        }

        public static int LastIndexOf(string text, char searchChar)
        {
            if ( string.IsNullOrEmpty( text ))
            {
                return -1;
            }

            for ( int i = 0; i < text.Length - 1; i++ )
            {
                if ( text[i] == searchChar )
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
