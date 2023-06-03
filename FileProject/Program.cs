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
            // Read name and grade from file
            string name = GetNameAndGradeFromFile(@"./input.txt", out grade);
            name = Capitalize(name);  // Capitalize the name
            Console.WriteLine($"Name is {name}\nGrade is {grade}"); // Print the name and grade
        }

        // Capitalize the first letter of a string and convert the rest to lowercase
        public static string Capitalize(string str) => $"{str[0].ToString().ToUpper()}{str.Substring(1).ToLower()}";

        // Check if a character is a digit using regular expressions
        public static bool IsDigit(char str)
        {
            Regex regex = new Regex("^[0-9]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(str.ToString());
        }

        // Check if a character is a letter using regular expressions
        public static bool IsLetter(char str)
        {
            Regex regex = new Regex("^[a-zA-Z]+$", RegexOptions.IgnoreCase);
            return regex.IsMatch(str.ToString());
        }

        // Read the name and grade from a file and return the name
        public static string GetNameAndGradeFromFile(string fileName, out int grade) 
        {
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadToEnd();
            string name = "";     // Extract letters to form the name
            string gradestr = ""; // Extract digits to form the grade

            foreach (char line2 in line.Trim())
            {
                if (IsLetter(line2)) name += line2;
                if (IsDigit(line2)) gradestr += line2;
            }

            grade = int.Parse(gradestr);  // Convert the grade from string to integer
            return name;
        }

    }
}
