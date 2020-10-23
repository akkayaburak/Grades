using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Grades
{
    public class ReadTxt
    {
        public List<string> Read()
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
           
            return list;
        }
    }
}
