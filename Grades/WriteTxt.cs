using Grades.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grades
{
    class WriteTxt
    {
        public static void Write(List<Grade> sortedList)
        {
            using (TextWriter textWriter = new StreamWriter("../../../../allgrades.txt"))
            {
                foreach (var grade in sortedList)
                {
                    textWriter.Write(grade.ID + " ");
                    textWriter.Write(grade.Midterm + " ");
                    textWriter.Write(grade.Final + " ");
                    textWriter.Write("\n");
                }
                Console.WriteLine("Files have been wrote.");
            }
        }
    }
}
