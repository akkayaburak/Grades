using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.Model
{
    public class Grade
    {
        public int ID { get; set; }
        public int Midterm { get; set; }
        public int Final { get; set; }

        public Grade()
        {
        }

    }
}
