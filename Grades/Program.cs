using Grades.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTxt readTxt = new ReadTxt();
            List<string> allGrades = readTxt.Read();
            var listOfGrade = new List<Grade>();
            foreach(var grade in allGrades)
            {
                var splittedLines = grade.Split(" ");
                listOfGrade.Add(new Grade
                {
                    ID = int.Parse(splittedLines[0]),
                    Midterm = int.Parse(splittedLines[1]),
                    Final = int.Parse(splittedLines[2])
                });
            }
            List<Grade> SortedList = listOfGrade.OrderBy(o => o.ID).ToList();
            using(TextWriter textWriter = new StreamWriter("allgrades.txt"))
            {
                foreach(var grade in SortedList)
                {
                    textWriter.WriteLine(grade);
                }
            }
        }
    }
}
