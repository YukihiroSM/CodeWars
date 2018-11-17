using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("i  love you, know!"));
        }

        public static string ReverseWords(string str)
        {
            string word = "";
            string res = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else if (str[i] == ' ' || i == (str.Length - 1))
                {
                    char[] arr = word.ToCharArray();
                    Array.Reverse(arr);
                    res += new string(arr);
                    res += " ";
                    word = "";
                }
            }
            char[] arra = word.ToCharArray();
            Array.Reverse(arra);
            res += new string(arra);
            return res;
        }
    }
}
