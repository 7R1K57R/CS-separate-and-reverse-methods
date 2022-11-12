using System;

namespace methods
{
    class Program
    {
        static string[] SeparSent(string splitable)
        {
            char ch = ' ';
            int CountOfWord = 1;
            foreach (char c in splitable)
            {
                if (c == ch)
                {
                    CountOfWord++;
                }
            }
            string[] splited = new string[CountOfWord];
            int i = 0;
            string temp = " ";
            for (int j = 0; j < splitable.Length; j++)
            {
                if (j == splitable.Length - 1)
                {
                    temp += splitable[j];
                }
                else
                {
                    if (splitable[j] != ch)
                    {
                        temp += splitable[j];
                        continue;
                    }
                }
                splited[i] = temp;
                temp = " ";
                i++;
            }
            foreach (var word in splited)
            {
                Console.WriteLine(word);
            }
            return splited;
        }
        static string RevWordInSent(string[] reversable)
        {
            
            string[] reversed = new string[reversable.Length];
            int r = 0;
            for (int i = reversable.Length-1; i >= 0; i--)
            {
                reversed[r] += reversable[i];
                r++;
            }
            string result;
            result = string.Concat(reversed);
            return result;
        }
        static string RevWordInSent(string reversable)
        {  
            string[] reversed = new string[reversable.Length];
            int r = 0;
            for (int i = reversable.Length - 1; i >= 0; i--)
            {
                reversed[r] += reversable[i];
                r++;
            }
            string result;
            result = string.Concat(reversed);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RevWordInSent(SeparSent(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
