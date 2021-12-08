using System;
using System.Text.RegularExpressions;

namespace Occurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello welcome to welcome my first Hello Welcome Console Application";
            string searchItem = "welcome";
            int count = new Regex(searchItem, RegexOptions.Compiled).Matches(str).Count;
            Console.WriteLine("{0} Matches found.", count);
        }
    }
}
