using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void getEachCharCount(string[] inputString) 
        {
            string outputString = string.Join("",inputString);
            var newString = outputString.GroupBy(x => x).Select(x => new { Char = x.Key, Count = x.Count() });
            foreach (var c in newString)
            {
                Console.WriteLine("{0} : {1}",c.Char,c.Count);
            }
            Console.ReadLine();
        }

        public static void reverseWordOfString(string inputString)
        {
            string[] splitStringArr = inputString.Split(' ');
            Array.Reverse(splitStringArr);
            string outputString = string.Join(" ", splitStringArr);
            Console.WriteLine(outputString);
            Console.ReadLine();
        }

        public static void reverseWordOfStringWithoutSplitAndReverse(string inputString)
        {
            StringBuilder outputString = new StringBuilder();
            List<char> words = new List<char>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsWhiteSpace(inputString[i]) == true || i == inputString.Length)
                {
                    string str = string.Empty;
                    foreach (var word in words)
                    {
                        str += words;
                    }
                    outputString.Insert(0, str);
                    outputString.Insert(0, ' ');
                    words = new List<char>();
                }
                else
                {
                    words.Add(inputString[i]);
                }
            }
            string newStr = string.Empty;
            foreach (var word in words)
            {
                newStr += word;
            }
            outputString.Insert(0, newStr);
            string output = outputString.ToString();
            Console.WriteLine(output);
            Console.ReadLine();
        }

        public static void RemoveDuplicates(string[] inputString)
        {
            HashSet<string> hashsetString = new HashSet<string>(inputString);
            string[] result = new string[hashsetString.Count];
            hashsetString.CopyTo(result);
            string outputString = string.Join(" ", result);
            Console.WriteLine(outputString);
            Console.ReadLine();
        }
    }
}
