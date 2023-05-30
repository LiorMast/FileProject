using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FileProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"./input.txt");

        }

        public static bool IsNumber(string str)
        {
            Regex regex = new Regex("^[0-9]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(str);
        }
        public static bool IsLetter(string str)
        {
            Regex regex = new Regex("^[a-zA-Z]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(str);
        }
    }
}
