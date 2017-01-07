using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsConsole
{
    class Program
    {
        static void Main(string[] args)            
        {           
            int count = 0;
            Console.WriteLine("Welcome to Vowel Counter 2017!");
            Console.WriteLine("Enter text:");
            String txt = Console.ReadLine();
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'a' ||
                    txt[i] == 'e' ||
                    txt[i] == 'i' ||
                    txt[i] == 'o' ||
                    txt[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("The vowel count is " + count);
        }
    }
}
