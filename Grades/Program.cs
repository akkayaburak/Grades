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
            List<string> allGrades = ReadTxt.Read();
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
            List<Grade> sortedList = listOfGrade.OrderBy(o => o.ID).ToList();
            WriteTxt.Write(sortedList);
        }
    }
}
