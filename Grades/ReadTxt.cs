using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Grades
{
    public class ReadTxt
    {
        public static List<string> Read()
        {
            List<string> paths = Directory.EnumerateFiles(@"..\..\..\GradesTxt\", "*.txt").ToList();
            if (paths == null)
            {
                return null;
            }
            List<string> list = new List<string>();
            foreach (string filePath in paths)
            {
                string[] lines = File.ReadAllLines(filePath);
                list.AddRange(lines.ToList());
            }
            Console.WriteLine("Files have been read.");
            return list;
        }
    }
}
