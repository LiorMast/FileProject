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
            int grade;
            string name = GetNameAndGradeFromFile(@"./input.txt", out grade);
            name = Capitalize(name);
            Console.WriteLine($"Name is {name}\nGrade is {grade}");
        }
        public static string Capitalize(string str) => $"{str[0].ToString().ToUpper()}{str.Substring(1).ToLower()}";
        public static bool IsDigit(char str)
        {
            Regex regex = new Regex("^[0-9]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(str.ToString());
        }
        public static bool IsLetter(char str)
        {
            Regex regex = new Regex("^[a-zA-Z]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(str.ToString());
        }
        public static string GetNameAndGradeFromFile(string fileName, out int grade) 
        {
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadToEnd();
            string name = "";
            string gradestr = "";

            foreach (char line2 in line.Trim())
            {
                if (IsLetter(line2)) name += line2;
                if (IsDigit(line2)) gradestr += line2;
            }

            grade = int.Parse(gradestr);
            return name;
        }

    }
}
